using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager.Presenter
{
    class LoginPresenter
    {
        private LoginForm view;
        public LoginPresenter(LoginForm view)
        {
            this.view = view;
            this.view.LoginHandler += DoLogin;
        }

        private void DoLogin(object sender, EventArgs e)
        {
            string cardNumber = view.CardNumber;
            string password = view.Password;
            if (this.CheckLogin(cardNumber, password))
            {
                // login successfully
                view.DisplayPaymentHistory();
            }
            else
            {
                // try again!
                view.DisplayTryAgain();
            }
        }

        private bool CheckLogin(string cardNumber, string password)
        {
            using (var db = new AMSEntities())
            {
                var result = from login in db.Logins
                             where login.AccessID == cardNumber
                             && login.Password == password
                             select login;
                if (result.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


    }
}
