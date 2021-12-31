using System;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SimpleTcp;

namespace TCPServer
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            txtInfo.Text += $"Starting...{Environment.NewLine}";
            btnStart.Enabled = true;
            btnSend.Enabled = true;
        }

        private void form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }
        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
            lstClientIP.Items.Add(e.IpPort);
            });
            
        }
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                lstClientIP.Items.Remove(e.IpPort);
            });
           
        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort}:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}"; ;
            });
            

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text) && lstClientIP.SelectedItem != null)
                {
                    server.Send(lstClientIP.SelectedItem.ToString(), txtMessage.Text);
                    txtInfo.Text += $"Server:{txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = String.Empty;


                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SPNCheckbox.Checked == true)
            {
                SHACheckbox.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (SHACheckbox.Checked == true)
            {
                SPNCheckbox.Checked = false;
            }
        }
        private string TurkceKarakterDegisimi(string text)
        {
            text = text.Replace("Ç", "C");
            text = text.Replace("ç", "c");
            text = text.Replace("Ð", "G");
            text = text.Replace("ð", "g");
            text = text.Replace("Ý", "I");
            text = text.Replace("ý", "i");
            text = text.Replace("Ö", "O");
            text = text.Replace("ö", "o");
            text = text.Replace("Þ", "S");
            text = text.Replace("þ", "s");
            text = text.Replace("Ü", "U");
            text = text.Replace("ü", "u");


            return text;
        }

        private void btnSifrele_Click_1(object sender, EventArgs e)
        {
            txtMetin.Text = TurkceKarakterDegisimi(txtMetin.Text);
            if (txtMetin.Text == "") { MessageBox.Show("Metin boþ olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text == "") { MessageBox.Show("Anahtar boþ olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text.Length != 8) { MessageBox.Show("Anahtar 8 karakterden oluþmalýdýr.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
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
                else if (SPNCheckbox.Checked == false && SHACheckbox.Checked == false) { MessageBox.Show("Þifreleme Türü Seçiniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

        private void btnCoz_Click_1(object sender, EventArgs e)
        {
            if (txtMetin.Text == "") { MessageBox.Show("Metin boþ olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text == "") { MessageBox.Show("Anahtar boþ olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtAnahtar.Text.Length != 8) { MessageBox.Show("Anahtar 8 karakterden oluþmalýdýr.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                if (SPNCheckbox.Checked == true)
                {
                    SPN_encryption spn = new SPN_encryption(txtAnahtar.Text);
                    txtSifrelenmis.Text = spn.decrypt(txtMetin.Text);
                }
                else if (SHACheckbox.Checked == true) { MessageBox.Show("SHA Þifrelemesi Çözülemez"); }
                else if (SPNCheckbox.Checked == false && SHACheckbox.Checked == false) { MessageBox.Show("Þifreleme Türü Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }
    }
}