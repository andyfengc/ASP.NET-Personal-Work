using BillManager.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager.View
{
    public interface IPaymentView
    {
        string LoggedUserName { get; set; }
        string AccessId { get; set; }
        string SelectedPayeeId { get; }
        Payee SelectedPayee { get; }
        List<PaymentDetail> PaymentDetails { set; }
        List<Payee> Payees { set; }

        event EventHandler loadCurrentUserInfoHandler;
        event EventHandler loadPayeeHandler;
        event EventHandler retrievePaymentHandler;
    }
}
