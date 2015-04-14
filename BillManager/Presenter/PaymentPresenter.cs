using BillManager.Entitiy;
using BillManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager.Presenter
{
    class PaymentPresenter
    {
        private IPaymentView view;

        public PaymentPresenter(IPaymentView view)
        {
            this.view = view;
            this.view.loadCurrentUserInfoHandler += LoadCurrentUser;
            this.view.loadPayeeHandler += LoadPayee;
            this.view.retrievePaymentHandler += RetrievePayment;
        }

        private void LoadCurrentUser(object sender, EventArgs e)
        {
            // get logged user id
            string accessId = this.view.AccessId;
            // load user info
            using (var db = new AMSEntities())
            {
                var result = from client in db.Clients
                             where client.AccessID == accessId
                             select client.Firstname + " " + client.Lastname;
                this.view.LoggedUserName = result.FirstOrDefault();
            }
        }

        // load payment details under a selected payee
        private void RetrievePayment(object sender, EventArgs e)
        {
            // get selected payee
            string payeeId = this.view.SelectedPayeeId;
            //Payee payee = this.view.SelectedPayee;
            
            // load payment details
            List<PaymentDetail> payments = new List<PaymentDetail>();
            using (var db = new AMSEntities())
            {
                var result = from payee in db.Payees
                             from payment in db.Payments
                             where payee.Payments.Contains(payment)
                             && payment.PayeeID == payeeId
                             && payment.ClientID == this.view.AccessId
                             select new PaymentDetail { PayeeName = payee.Name, AccountNumber = payment.AccountNumber, Amount = (double)payment.Amount, BillingDate = payment.BillingDate, PaymentDate = payment.PaymentDate };
                foreach (var item in result)
                {
                    payments.Add(item);
                }
            }
            this.view.PaymentDetails = payments;
        }

        private void LoadPayee(object sender, EventArgs e)
        {
            List<Payee> payees = new List<Payee>();
            using (var db = new AMSEntities())
            {
                // get current logged user information
                string accessId = view.AccessId;

                var result = from payee in db.Payees
                             from payment in db.Payments
                             where payee.Payments.Contains(payment)
                             && payment.ClientID == accessId
                             select payee;
                foreach (var item in result.Distinct())
                {
                    payees.Add(item);
                }
                this.view.Payees = payees;
            }
        }
    }
}
