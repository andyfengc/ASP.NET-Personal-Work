using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Delegate
{
    public partial class SubscribeForm : Form
    {
        private MainForm server;
        private string email;
        private bool enableEmail;
        private string mobile;
        private bool enableMobile;

        public SubscribeForm(MainForm server)
        {
            InitializeComponent();
            this.server = server;
            this.btnUnsubscribe.Enabled = false;
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                // get email address
                email = txtEmail.Text;
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match emailMatch = emailRegex.Match(email);
                if (!emailMatch.Success)
                {
                    throw new EmailFormatException();
                }
                // get email enabled option
                enableEmail = chkEmail.Checked;

                // get mobile phone number
                mobile = txtMobile.Text;
                Regex mobileRegex = new Regex(@"^(647|416|905)\d{7}$");
                Match mobileMatch = mobileRegex.Match(mobile);
                if (!mobileMatch.Success)
                {
                    throw new MobileFormatException();
                }
                // get mobile enabled option
                enableMobile = chkMobile.Checked;

                // register event handler
                server.RegisterEmail(this);
                server.RegisterMobile(this);
                // update button
                btnSubscribe.Enabled = false;
                btnUnsubscribe.Enabled = true;
                // update server
                server.AddLog("+ Email: " + email + " Mobile " + mobile);
                server.AddSubscriptionItem(this);
                server.UpdateSubscriptionList();
            }
            catch (EmailFormatException ex)
            {
                MessageBox.Show("Please re-enter email address. (e.g. username@hostname.com)");
            }
            catch (MobileFormatException ex)
            {
                MessageBox.Show("Please re-enter mobile phone number. (e.g. 6471111111 or 4161111111)");
            }
        }

        public void SendEmail(string msg)
        {
            if (enableEmail)
                server.AddLog("Message has been sent to " + email);
            //todo: call gmail api through smtp to send a real message;
        }

        public void SendMobile(string msg)
        {
            if (enableMobile)
                server.AddLog("Message has been sent to " + mobile);
            // todo: call mobile company api to send a real message;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            // get email address
            email = txtEmail.Text;
            // get mobile phone number
            mobile = txtMobile.Text;
            // unregister event handler
            server.UnRegisterEmail(this);
            server.UnRegisterMobile(this);
            // update button
            btnSubscribe.Enabled = true;
            btnUnsubscribe.Enabled = false;
            server.AddLog("- Email: " + email + " Mobile: " + mobile);
            server.RemoveSubscriptionItem(this);
            server.UpdateSubscriptionList();
        }

        public string Display()
        {
            return email + (enableEmail ? " (yes)" : " (no)") + "     " + mobile + (enableMobile ? " (yes)" : " (no)");
        }

        class EmailFormatException : Exception
        {
            public EmailFormatException() : base() { }
            public EmailFormatException(string msg)
                : base(msg)
            {
            }
        }

        class MobileFormatException : Exception
        {
            public MobileFormatException() : base() { }
            public MobileFormatException(string msg) : base(msg) { }
        }
    }
}

