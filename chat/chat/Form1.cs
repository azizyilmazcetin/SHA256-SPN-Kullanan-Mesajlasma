using System;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SimpleTcp;


namespace chat
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void form1_Load(object sender, EventArgs e)
        {
            client=new(txtIP.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;

        }
        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server: connected.{Environment.NewLine}";
            });
            
           
        }
        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $" Server disconnected.{Environment.NewLine}";
            });
            
            
        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $" Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
           

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(client.IsConnected)
            {
                if(!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(txtMessage.Text);
                    txtInfo.Text+=$"Me:{txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMetin.Text == "") { MessageBox.Show("Metin bo� olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text == "") { MessageBox.Show("Anahtar bo� olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text.Length != 8) { MessageBox.Show("Anahtar 8 karakterden olu�mal�d�r.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                if (SPNCheckbox.Checked == true)
                {
                    SPN_encryption spn = new SPN_encryption(txtAnahtar.Text);
                    txtSifrelenmis.Text = spn.decrypt(txtMetin.Text);
                }
                else if (SHACheckbox.Checked == true) { MessageBox.Show("SHA �ifrelemesi ��z�lemez"); }
                else if (SPNCheckbox.Checked == false && SHACheckbox.Checked == false) { MessageBox.Show("�ifreleme T�r� Se�iniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMetin.Text = TurkceKarakterDegisimi(txtMetin.Text);
            if (txtMetin.Text == "") { MessageBox.Show("Metin bo� olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text == "") { MessageBox.Show("Anahtar bo� olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text.Length != 8) { MessageBox.Show("Anahtar 8 karakterden olu�mal�d�r.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                if (SPNCheckbox.Checked == true)
                {
                    if (txtMetin.Text.Length % 2 == 1) { txtMetin.Text += " "; }
                    else
                    {

                        SPN_encryption spn = new SPN_encryption(txtMetin.Text, txtAnahtar.Text);
                        txtSifrelenmis.Text = spn.encrypt();
                    }
                }
                else if (SHACheckbox.Checked == true)
                {
                    SHA_encryption sha = new SHA_encryption(txtMetin.Text);
                    txtSifrelenmis.Text = sha.sifrele();
                }
                else if (SPNCheckbox.Checked == false && SHACheckbox.Checked == false) { MessageBox.Show("�ifreleme T�r� Se�iniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }
        private string TurkceKarakterDegisimi(string text)
        {
            text = text.Replace("�", "C");
            text = text.Replace("�", "c");
            text = text.Replace("�", "G");
            text = text.Replace("�", "g");
            text = text.Replace("�", "I");
            text = text.Replace("�", "i");
            text = text.Replace("�", "O");
            text = text.Replace("�", "o");
            text = text.Replace("�", "S");
            text = text.Replace("�", "s");
            text = text.Replace("�", "U");
            text = text.Replace("�", "u");


            return text;
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            txtMetin.Text = TurkceKarakterDegisimi(txtMetin.Text);
            if (txtMetin.Text == "") { MessageBox.Show("Metin bo� olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text == "") { MessageBox.Show("Anahtar bo� olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text.Length != 8) { MessageBox.Show("Anahtar 8 karakterden olu�mal�d�r.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                if (SPNCheckbox.Checked == true)
                {
                    if (txtMetin.Text.Length % 2 == 1) { txtMetin.Text += " "; }
                    else
                    {

                        SPN_encryption spn = new SPN_encryption(txtMetin.Text, txtAnahtar.Text);
                        txtSifrelenmis.Text = spn.encrypt();
                    }
                }
                else if (SHACheckbox.Checked == true)
                {
                    SHA_encryption sha = new SHA_encryption(txtMetin.Text);
                    txtSifrelenmis.Text = sha.sifrele();
                }
                else if (SPNCheckbox.Checked == false && SHACheckbox.Checked == false) { MessageBox.Show("�ifreleme T�r� Se�iniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            if (txtMetin.Text == "") { MessageBox.Show("Metin bo� olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text == "") { MessageBox.Show("Anahtar bo� olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text.Length != 8) { MessageBox.Show("Anahtar 8 karakterden olu�mal�d�r.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                if (SPNCheckbox.Checked == true)
                {
                    SPN_encryption spn = new SPN_encryption(txtAnahtar.Text);
                    txtSifrelenmis.Text = spn.decrypt(txtMetin.Text);
                }
                else if (SHACheckbox.Checked == true) { MessageBox.Show("SHA �ifrelemesi ��z�lemez"); }
                else if (SPNCheckbox.Checked == false && SHACheckbox.Checked == false) { MessageBox.Show("�ifreleme T�r� Se�iniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }


        private void SHACheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SHACheckbox.Checked == true)
            {
                SPNCheckbox.Checked = false;
            }
        }

        private void SPNCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            if (SPNCheckbox.Checked == true)
            {
                SHACheckbox.Checked = false;
            }
        }

        private void SPNCheckbox_CheckedChanged_1(object sender, EventArgs e)
        {

            if (SPNCheckbox.Checked == true)
            {
                SHACheckbox.Checked = false;
            }
        }

        private void SHACheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SHACheckbox.Checked == true)
            {
                SPNCheckbox.Checked = false;
            }
        }
    }
}