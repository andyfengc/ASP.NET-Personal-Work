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

namespace Baseball
{
    public partial class BaseballManagerForm : Form
    {
        public BaseballManagerForm()
        {
            InitializeComponent();
        }

        private void BaseballManagerForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            using (var db = new BaseballEntities())
            {
                // windows form controls need extra step for binding to data source, console do not need this step
                // when windows form controls are binding to datasource, they need a way to load data into memory but default entity framework loading cannot do that
                // DbContext.Dbset.Load() + DbContext.Dbset.Local.ToBindingList() will do that

                //// way1: linq, 
                //db.Players.Load();
                //var players = from player in db.Players.Local.ToBindingList()
                //              orderby player.LastName
                //              orderby player.FirstName
                //              select player;
                ////db.Players.Local.to
                //playerBindingSource.DataSource = players;

                //// way2.1: lambodz, professor's solution
                //db.Players.OrderBy(player => player.LastName)
                //    .ThenBy(player => player.FirstName).Load();
                //playerBindingSource.DataSource = db.Players.Local;

                //way2.2: lambodz
                db.Players.Load();
                var players = db.Players.Local.ToBindingList()
                    .OrderBy(player => player.LastName)
                    .ThenBy(player => player.FirstName)
                    .Select(player => player);
                playerBindingSource.DataSource = players;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string lastName = txtLastname.Text;
            LoadDataByLastName(lastName);
        }

        private void LoadDataByLastName(string lastName)
        {
            using (var db = new BaseballEntities())
            {
                db.Players.Load();
                var players = db.Players.Local.ToBindingList().Where(player => player.LastName.ToUpper().Contains(lastName.ToUpper())).Select(player => player);
                playerBindingSource.DataSource = players;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLastname.Text = "";
            LoadAllData();
        }
    }
}
