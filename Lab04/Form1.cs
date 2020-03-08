using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void initialMessageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || (e.KeyChar > 72 && e.KeyChar < 97) || e.KeyChar > 104) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private Dictionary<char, string> dictionary = new Dictionary<char, string>
        {
            {'A', "00" },
            {'B', "01" },
            {'C', "100" },
            {'D', "101" },
            {'E', "110" },
            {'F', "1110" },
            {'G', "11110" },
            {'H', "11111" }
        };

        private void encodeMessageButton_Click(object sender, EventArgs e)
        {
            encodedMessageTextBox.Clear();
            string initialMessage = initialMessageTextBox.Text;
            StringBuilder encodedMessage = new StringBuilder(initialMessage.Length * 2);

            foreach(char symbol in initialMessage)
            {
                encodedMessage.Append(dictionary[Char.ToUpper(symbol)]);
            }

            encodedMessageTextBox.Text = encodedMessage.ToString();
        }

        private void decodeMessageButton_Click(object sender, EventArgs e)
        {
            decodedMessageTextBox.Clear();
            StringBuilder encodedMessage = new StringBuilder(encodedMessageTextBox.Text);
            StringBuilder decodedMessage = new StringBuilder();

            StringBuilder partOfMessage = new StringBuilder();
            while (encodedMessage.Length != 0)
            {
                partOfMessage.Append(encodedMessage[0]);
                encodedMessage.Remove(0, 1);
                if (dictionary.ContainsValue(partOfMessage.ToString()))
                {
                    decodedMessage.Append(dictionary.FirstOrDefault(x => x.Value == partOfMessage.ToString()).Key);
                    partOfMessage.Clear();
                }
            }

            decodedMessageTextBox.Text = decodedMessage.ToString();
        }
    }
}
