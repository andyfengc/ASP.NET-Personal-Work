using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPasswordUserControl
{
    public partial class LoginPasswordUserControl : UserControl
    {
        public string UserName
        {
            get { return txtUserName.Text; }
            private set { }
        }

        public string Password { get { return txtPassword.Text; } private set { } }

        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }
    }
}
