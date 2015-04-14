using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BookManager
{
    public partial class BookManagerForm : Form
    {
        private const string Q1_Header = "Titles and authors, sorted by title:";
        private const string Q2_Header = "Titles and authors, sorted by title and authors last name, then first name";
        private const string Q3_Header = "Authors grouped by title, sorted by title:";

        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            LoadQ1Result();
            LoadQ2Result();
            LoadQ3Result();
        }

        // Get a list of all the titles and the authors who wrote them. Sort the results by title.
        private void LoadQ1Result()
        {
            using (var db = new BooksEntities())
            {
                // pure linq solution 1, test in LinqPad
                //var results = 
                //        from title in Titles 
                //        join authorIsbn in AuthorISBNs 
                //        on title.ISBN equals authorIsbn.ISBN 
                //        join author in Authors 
                //        on authorIsbn.AuthorID equals author.AuthorID
                //        orderby title.Title
                //        select new {title.Title, title.ISBN, author.FirstName, author.LastName};
                //        results.Dump();

                // pure linq solution 2, test in LinqPad
                //var results =
                //from title in Titles
                //from authorIsbn in AuthorISBNs
                //from author in Authors
                //where title.ISBN == authorIsbn.ISBN
                //&& author.AuthorID == authorIsbn.AuthorID
                //orderby title.Title
                //select new { title.Title, title.ISBN, author.FirstName, author.LastName };
                //results.Dump();

                // buggy, do not consider join
                //var titlesAndAuthorsSortedByTitle = from title in db.Titles
                //                                    from author in db.Authors
                //                                    orderby title.Title1
                //                                    select new { title.Title1, title.ISBN, FullName = author.FirstName + " " + author.LastName };

                // linq to entity
                var titlesAndAuthorsSortedByTitle = from title in db.Titles
                                                    from author in db.Authors
                                                    where title.Authors.Contains(author)
                                                    orderby title.Title1
                                                    select new { title.Title1, title.ISBN, FullName = author.FirstName + " " + author.LastName };

                txtQ1.AppendText(Q1_Header);
                foreach (var item in titlesAndAuthorsSortedByTitle)
                {
                    txtQ1.AppendText(string.Format("\r\n\t{0,-50} {1,-15} {2,-15}", item.Title1, item.ISBN, item.FullName));
                }
            }
        }

        // Get a list of all the titles and the authors who wrote them. 
        // Sort the results by title. For each title sort the authors
        // alphabetically by last name, then first name
        private void LoadQ2Result()
        {
            using (var db = new BooksEntities())
            {
                var titlsAndAuthorsSortedByTitle = from title in db.Titles
                                                   from author in db.Authors
                                                   where title.Authors.Contains(author)
                                                   orderby title.Title1, author.LastName, author.FirstName
                                                   select new { title.Title1, title.ISBN, FullName = author.LastName + ", " + author.FirstName };
                txtQ2.AppendText(Q2_Header);
                foreach (var item in titlsAndAuthorsSortedByTitle)
                {
                    txtQ2.AppendText(string.Format("\r\n\t{0,-50} {1,-15} {2,-15} ", item.Title1, item.ISBN, item.FullName));
                }
            }

        }

        // Get a list of all the authors grouped by title, sorted by title; 
        // for a given title sort the author names alphabetically by last name 
        // then first name
        private void LoadQ3Result()
        {
            using (var db = new BooksEntities())
            {
                // retrieve results
                var result = from title in db.Titles
                             orderby title.Title1
                             select new
                             {
                                 title.Title1,
                                 FullName = from author in db.Authors
                                            where title.Authors.Contains(author)
                                            orderby author.LastName, author.LastName
                                            select author.LastName + ", " + author.FirstName
                             };
                // add result 
                txtQ3.AppendText(Q3_Header);
                foreach (var item in result)
                {
                    txtQ3.AppendText("\r\n\t" + item.Title1);
                    foreach (var name in item.FullName)
                    {
                        txtQ3.AppendText("\r\n\t\t" + name);
                    }
                }
            }

        }



    }
}
