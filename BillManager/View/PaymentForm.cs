using BillManager.Entitiy;
using BillManager.Presenter;
using BillManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillManager
{
    public partial class PaymentForm : Form, IPaymentView
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            PaymentPresenter presenter = new PaymentPresenter(this);
            loadCurrentUserInfoHandler(sender, e);
            loadPayeeHandler(sender, e);
        }



        public string SelectedPayeeId
        {
            get { return cbPayee.SelectedValue.ToString(); }
        }

        public List<PaymentDetail> PaymentDetails
        {
            set
            {

                gvPaymentDetail.DataSource = value;
            }
        }

        public event EventHandler loadPayeeHandler;

        public event EventHandler retrievePaymentHandler;


        public Payee SelectedPayee
        {
            get { return cbPayee.SelectedItem as Payee; }
        }

        public List<Payee> Payees
        {
            set
            {
                cbPayee.DataSource = value;
                cbPayee.DisplayMember = "Name";
                cbPayee.ValueMember = "PayeeID";
            }
        }

        private string accessId;
        public string AccessId
        {
            get
            {
                return this.accessId;
            }
            set
            {
                this.accessId = value;
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            this.retrievePaymentHandler(sender, e);
        }

        private string loggedUserName;
        public string LoggedUserName
        {
            get
            {
                return lblLoggedUser.Text;
            }
            set
            {
                lblLoggedUser.Text = value;
            }
        }


        public event EventHandler loadCurrentUserInfoHandler;

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
