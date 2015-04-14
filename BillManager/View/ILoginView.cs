using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager.View
{
    public interface ILoginView
    {
        
        string CardNumber { get; }
        string Password { get; }
        void DisplayTryAgain();
        void DisplayLoginFail();
        void DisplayPaymentHistory();
        event EventHandler LoginHandler;
    }
}
