namespace TCPServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstClientIP = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifrelenmis = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnCoz = new System.Windows.Forms.Button();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(340, 398);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(81, 66);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(333, 297);
            this.txtInfo.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(82, 369);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(333, 23);
            this.txtMessage.TabIndex = 4;
            // 
            // Messages
            // 
            this.Messages.AutoSize = true;
            this.Messages.Location = new System.Drawing.Point(12, 348);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(67, 15);
            this.Messages.TabIndex = 5;
            this.Messages.Text = "Messages : ";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(237, 398);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstClientIP
            // 
            this.lstClientIP.FormattingEnabled = true;
            this.lstClientIP.ItemHeight = 15;
            this.lstClientIP.Location = new System.Drawing.Point(420, 66);
            this.lstClientIP.Name = "lstClientIP";
            this.lstClientIP.Size = new System.Drawing.Size(257, 49);
            this.lstClientIP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Client IP";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(479, 141);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(198, 114);
            this.txtMetin.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Metin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifrelenmiş Metin";
            // 
            // txtSifrelenmis
            // 
            this.txtSifrelenmis.Location = new System.Drawing.Point(479, 307);
            this.txtSifrelenmis.Multiline = true;
            this.txtSifrelenmis.Name = "txtSifrelenmis";
            this.txtSifrelenmis.Size = new System.Drawing.Size(198, 114);
            this.txtSifrelenmis.TabIndex = 12;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(702, 255);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(82, 39);
            this.btnSifrele.TabIndex = 13;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click_1);
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(702, 307);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(82, 39);
            this.btnCoz.TabIndex = 14;
            this.btnCoz.Text = "Çöz";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click_1);
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(755, 37);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(103, 23);
            this.txtAnahtar.TabIndex = 15;
            this.txtAnahtar.Text = "security";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Anahtar";
            // 
            // SPNCheckbox
            // 
            this.SPNCheckbox.AutoSize = true;
            this.SPNCheckbox.Location = new System.Drawing.Point(702, 167);
            this.SPNCheckbox.Name = "SPNCheckbox";
            this.SPNCheckbox.Size = new System.Drawing.Size(48, 19);
            this.SPNCheckbox.TabIndex = 17;
            this.SPNCheckbox.Text = "SPN";
            this.SPNCheckbox.UseVisualStyleBackColor = true;
            this.SPNCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SHACheckbox
            // 
            this.SHACheckbox.AutoSize = true;
            this.SHACheckbox.Location = new System.Drawing.Point(702, 210);
            this.SHACheckbox.Name = "SHACheckbox";
            this.SHACheckbox.Size = new System.Drawing.Size(67, 19);
            this.SHACheckbox.TabIndex = 18;
            this.SHACheckbox.Text = "SHA256";
            this.SHACheckbox.UseVisualStyleBackColor = true;
            this.SHACheckbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 536);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstClientIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private Button btnStart;
        private TextBox txtInfo;
        private TextBox txtMessage;
        private Label Messages;
        private Button btnSend;
        private ListBox lstClientIP;
        private Label label2;
        private TextBox txtMetin;
        private Label label3;
        private Label label4;
        private TextBox txtSifrelenmis;
        private Button btnSifrele;
        private Button btnCoz;
        private TextBox txtAnahtar;
        private Label label5;
        private CheckBox SPNCheckbox;
        private CheckBox SHACheckbox;
    }
}