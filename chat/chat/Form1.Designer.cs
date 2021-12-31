namespace chat
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.btnCoz = new System.Windows.Forms.Button();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.txtSifrelenmis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.SPNCheckbox = new System.Windows.Forms.CheckBox();
            this.SHACheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(82, 37);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(333, 23);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(312, 348);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(82, 66);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(333, 218);
            this.txtInfo.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(82, 303);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(333, 23);
            this.txtMessage.TabIndex = 4;
            // 
            // Messages
            // 
            this.Messages.AutoSize = true;
            this.Messages.Location = new System.Drawing.Point(12, 306);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(67, 15);
            this.Messages.TabIndex = 5;
            this.Messages.Text = "Messages : ";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(217, 348);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Anahtar";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(756, 32);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(103, 23);
            this.txtAnahtar.TabIndex = 24;
            this.txtAnahtar.Text = "security";
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(669, 241);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(82, 39);
            this.btnCoz.TabIndex = 23;
            this.btnCoz.Text = "Çöz";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(669, 178);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(82, 39);
            this.btnSifrele.TabIndex = 22;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSifrelenmis
            // 
            this.txtSifrelenmis.Location = new System.Drawing.Point(453, 250);
            this.txtSifrelenmis.Multiline = true;
            this.txtSifrelenmis.Name = "txtSifrelenmis";
            this.txtSifrelenmis.Size = new System.Drawing.Size(198, 114);
            this.txtSifrelenmis.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Şifrelenmiş Metin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Metin";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(453, 66);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(198, 114);
            this.txtMetin.TabIndex = 18;
            // 
            // SPNCheckbox
            // 
            this.SPNCheckbox.AutoSize = true;
            this.SPNCheckbox.Location = new System.Drawing.Point(669, 97);
            this.SPNCheckbox.Name = "SPNCheckbox";
            this.SPNCheckbox.Size = new System.Drawing.Size(48, 19);
            this.SPNCheckbox.TabIndex = 26;
            this.SPNCheckbox.Text = "SPN";
            this.SPNCheckbox.UseVisualStyleBackColor = true;
            this.SPNCheckbox.CheckedChanged += new System.EventHandler(this.SPNCheckbox_CheckedChanged_1);
            // 
            // SHACheckbox
            // 
            this.SHACheckbox.AutoSize = true;
            this.SHACheckbox.Location = new System.Drawing.Point(669, 132);
            this.SHACheckbox.Name = "SHACheckbox";
            this.SHACheckbox.Size = new System.Drawing.Size(67, 19);
            this.SHACheckbox.TabIndex = 27;
            this.SHACheckbox.Text = "SHA256";
            this.SHACheckbox.UseVisualStyleBackColor = true;
            this.SHACheckbox.CheckedChanged += new System.EventHandler(this.SHACheckbox_CheckedChanged_1);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 492);
            this.Controls.Add(this.SHACheckbox);
            this.Controls.Add(this.SPNCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.btnCoz);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtSifrelenmis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "TCP/IP Client";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private Button btnConnect;
        private TextBox txtInfo;
        private TextBox txtMessage;
        private Label Messages;
        private Button btnSend;
        private Label label5;
        private TextBox txtAnahtar;
        private Button btnCoz;
        private Button btnSifrele;
        private TextBox txtSifrelenmis;
        private Label label4;
        private Label label3;
        private TextBox txtMetin;
        private CheckBox SPNCheckbox;
        private CheckBox SHACheckbox;
    }
}