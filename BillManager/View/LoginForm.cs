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
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginPresenter presenter = new LoginPresenter(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginHandler(sender, e);
        }

        public string CardNumber
        {
            get { return loginControl.accessCard; }
        }

        public string Password
        {
            get { return loginControl.Password; }
        }

        public event EventHandler LoginHandler;


        public void DisplayTryAgain()
        {
            MessageBox.Show("Login is incorrect, try again! ");
        }

        public void DisplayLoginFail()
        {
            MessageBox.Show("Sorry, login failed! ");
        }

        public void DisplayPaymentHistory()
        {
            this.Hide();
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.AccessId = CardNumber;
            paymentForm.Show();
        }
    }
}
