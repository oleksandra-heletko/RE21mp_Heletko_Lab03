using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heletko_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            string c = "";
            if (string.IsNullOrEmpty(keyEncTextBox.Text))
            {
                cDecTextBox.Text = pEncTextBox.Text;
                return;
            }
            c = MyCipher(pEncTextBox, keyEncTextBox, cEncTextBox); //Шифрування
            cDecTextBox.Text = cEncTextBox.Text;
            keyDecTextBox.Text = keyEncTextBox.Text;
            MyCipher(cDecTextBox, keyDecTextBox, pDecTextBox, c); //Дешифрування
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pEncTextBox.Text = "";
            keyEncTextBox.Text = "";
            cEncTextBox.Text = "";
            pDecTextBox.Text = "";
            keyDecTextBox.Text = "";
            cDecTextBox.Text = "";
        }

        void MyShowToolTip(TextBox tBox, byte[] array)
        {
            string bin = "";
            for (int i = 0; i < array.Length; i++) bin += Convert.ToString(array[i], 2);
            encToolTip.SetToolTip(tBox, bin);
        }

        byte[] MyXOR(byte[] txtArray, byte[] kArray)
        {
            int txtLength = txtArray.Length;
            int kLength = kArray.Length;
            byte[] cArray = new byte[txtLength];
            for (int i = 0; i < txtLength; i++)
            {
                byte p = txtArray[i];
                byte k = kArray[i % kLength]; // MOD
                byte c = (byte)(p ^ k); //XOR
                cArray[i] = c;
            }
            return cArray;
        }

        string MyCipher(TextBox tBoxText, TextBox tBoxKey, TextBox tBoxCipher, string c = "")
        {
            string txt = tBoxText.Text;
            byte[] txtArray;
            if (c == "") txtArray = Encoding.Unicode.GetBytes(txt);
            else txtArray = Encoding.Unicode.GetBytes(c);
            MyShowToolTip(tBoxText, txtArray); //Створити підказку
            string k = tBoxKey.Text;
            byte[] kArray = Encoding.Unicode.GetBytes(k);
            MyShowToolTip(tBoxKey, kArray); //Створити підказку
            byte[] cArray = MyXOR(txtArray, kArray);
            c = Encoding.Unicode.GetString(cArray);
            tBoxCipher.Text = c;
            MyShowToolTip(tBoxCipher, cArray); //Створити підказку
            return c;
        }
    }
}
