using System;
using System.Text;

namespace TCPServer
{
    public class SPN_encryption
    {
        private string txtMetin, bin_MetinText, anahtar, bin_Anahtar, s_Boxes = "", sifrelenmisText;



        public SPN_encryption(string anahtar)
        {
            this.anahtar = anahtar;
            this.bin_Anahtar = this.stringToBinary(this.anahtar);
        }
        public SPN_encryption(string metin_Text, string anahtar)
        {
            this.anahtar = anahtar;
            this.bin_Anahtar = this.stringToBinary(this.anahtar);
            this.txtMetin = metin_Text;
            this.bin_MetinText = this.stringToBinary(this.txtMetin);
        }



        //Convert string to binary
        private string stringToBinary(string data)
        {
            string binary = "";
            for (int i = 0; i < data.Length; i++)
            {
                binary += Convert.ToString(data[i], 2).PadLeft(8, '0');
            }

            return binary;
        }

        // Convert binary to string
        public string binaryToString(string enctxt)
        {
            // use your encoding here
            Encoding enc = System.Text.Encoding.ASCII;

            string binaryString = enctxt.Replace(" ", "");

            var bytes = new byte[binaryString.Length / 8];

            var ilen = (int)(binaryString.Length / 8);

            for (var i = 0; i < ilen; i++)
            {
                bytes[i] = Convert.ToByte(binaryString.Substring(i * 8, 8), 2);
            }

            string str = enc.GetString(bytes);

            return str;

        }




        private string xor(string text, string key)
        {
            string bin_xor = "";
            int xor = 0;
            for (int i = 0; i < 16; i++)
            {
                xor = Convert.ToInt32(text[i]) ^ Convert.ToInt32(key[i]);
                bin_xor += xor.ToString();
            }
            return bin_xor;
        }



        private string substitution(string data)
        {
            string p_Data = "";
            p_Data += data[2]; p_Data += data[8]; p_Data += data[12]; p_Data += data[5];
            p_Data += data[9]; p_Data += data[0]; p_Data += data[14]; p_Data += data[4];
            p_Data += data[11]; p_Data += data[1]; p_Data += data[15]; p_Data += data[6];
            p_Data += data[3]; p_Data += data[10]; p_Data += data[7]; p_Data += data[13];


            return p_Data;
        }

        private string r_Substitution(string data)
        {
            string rp_Data = "";
            rp_Data += data[5]; rp_Data += data[9]; rp_Data += data[0]; rp_Data += data[12];
            rp_Data += data[7]; rp_Data += data[3]; rp_Data += data[11]; rp_Data += data[14];
            rp_Data += data[1]; rp_Data += data[4]; rp_Data += data[13]; rp_Data += data[8];
            rp_Data += data[2]; rp_Data += data[15]; rp_Data += data[6]; rp_Data += data[10];




            return rp_Data;

        }



        public string encrypt()
        {

            string xor = "";
            string data = this.bin_MetinText;

            for (int i = 0; i < this.bin_MetinText.Length; i += 16)
            {
                data = this.bin_MetinText.Substring(i, 16);

                for (int j = 0; j < 64; j += 16)
                {
                    xor = this.xor(data, this.bin_Anahtar.Substring(j, 16));

                    if (j < 32)
                    {
                        s_Boxes = this.substitution(xor);
                    }
                    else
                    {
                        s_Boxes = xor;
                    }

                    data = s_Boxes;

                }
                this.sifrelenmisText += data;
            }

            return this.sifrelenmisText;
        }

        public string decrypt(string data)
        {

            string xor = "";
            string metin_Text = "";
            string sifrelenmis_Text = data;

            for (int i = 0; i < sifrelenmis_Text.Length; i += 16)
            {
                data = sifrelenmis_Text.Substring(i, 16);

                for (int j = 48; j >= 0; j -= 16)
                {
                    xor = this.xor(data, this.bin_Anahtar.Substring(j, 16));

                    if (j == 48 || j == 0)
                    {
                        s_Boxes = xor;
                    }
                    else
                    {
                        s_Boxes = this.r_Substitution(xor);
                    }

                    data = s_Boxes;

                }

                metin_Text += data;
            }

            return this.binaryToString(metin_Text);
        }



    }
}
