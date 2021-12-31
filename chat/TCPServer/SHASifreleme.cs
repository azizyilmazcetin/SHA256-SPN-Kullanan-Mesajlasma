using System;
using System.Text;
using System.Security.Cryptography;

namespace TCPServer
{
    class SHA_encryption
    {
        private string txtMetin;

        public SHA_encryption(string txtMetin)
        {
            this.txtMetin = txtMetin;
        }


        public string sifrele()
        {
            SHA256Managed sha256 = new SHA256Managed();
            Byte[] b_Text = Encoding.ASCII.GetBytes(this.txtMetin);
            b_Text = sha256.ComputeHash(b_Text);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in b_Text)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();

        }



    }
}
