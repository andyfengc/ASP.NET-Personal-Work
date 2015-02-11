using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    // my application can handle multiple subscribers and publishers
    public partial class MainForm : Form
    {
        private SubscribeForm subscribeForm;
        private PublishForm publishForm;

        // declare delegate
        private delegate void PublishMessageHandler(string msg);

        // define delegate objects
        private PublishMessageHandler emailDelegate = null;
        private PublishMessageHandler mobileDelegate = null;
        private List<SubscribeForm> subscriptionList = new List<SubscribeForm>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void subscribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subscribeForm = new SubscribeForm(this);
            subscribeForm.Show();
            Console.WriteLine(sender);
        }

        private void publishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publishForm = new PublishForm(this);
            publishForm.Show();
        }

        // publish message
        public void Publish(string message)
        {
            // publish
            if (emailDelegate != null)
                emailDelegate.Invoke(message);
            if (mobileDelegate != null)
                mobileDelegate.Invoke(message);
            //// add publish log
            //foreach (SubscribeForm s in subscriptionList)
            //    this.AddLog("Send to " + s.Display());
        }

        public void RegisterEmail(SubscribeForm subscribeForm)
        {
            emailDelegate += subscribeForm.SendEmail;

        }

        public void UnRegisterEmail(SubscribeForm subscribeForm)
        {
            emailDelegate -= subscribeForm.SendEmail;

        }
        public void RegisterMobile(SubscribeForm subscribeForm)
        {
            mobileDelegate += subscribeForm.SendMobile;
        }

        public void UnRegisterMobile(SubscribeForm subscribeForm)
        {
            mobileDelegate -= subscribeForm.SendMobile;
        }

        public void AddLog(string log)
        {
            lstLog.Items.Add(log);
        }
        public void UpdateSubscriptionList()
        {
            lstSubscription.Items.Clear();
            foreach (SubscribeForm s in subscriptionList)
                lstSubscription.Items.Add(s.Display());
        }

        public void AddSubscriptionItem(SubscribeForm subscribeForm)
        {
            subscriptionList.Add(subscribeForm);
        }

        public void RemoveSubscriptionItem(SubscribeForm subscribeForm)
        {
            subscriptionList.Remove(subscribeForm);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Chen Feng \nStudent ID: 300720952\nV1.0", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
