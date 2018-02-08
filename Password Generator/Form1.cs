using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String[] characters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                                        "a", "b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        private String[] specialCharacters = { "<", ">", "#", "&", "@", "{", "}", "ä", "[", "]", "$", "ß", "\\", "|", "€",
                                                "÷", "§", "~", "'", "ˇ", "\"", "^", "+", "!", "%", "˛", "/", "=", "(", ")", "¸","*","_",
                                                "-","?"};
        private void gen_Button_Click(object sender, EventArgs e)
        {
            

            if (pwLenght_NmbUD.Value <= 4)
            {
                MessageBox.Show("Please increase the lenght of password.\n" +
                    "The minimum lenght is 5.");
            }else if (pwLenght_NmbUD.Value >= 33)
            {
                MessageBox.Show("Please decrease the lenght of password.\n" +
                    "The maximum lenght is 32.");
            }
            else
            {
                pw_TextBox.Text = genPassword();
            }

        }

        private String genPassword()
        {
            String password = "";
            Random r = new Random();

            for (int i = 0; i < pwLenght_NmbUD.Value; i++)
            {
                int rnd = r.Next(0, 2 + 1);
                if (rnd == 0)
                {
                    password += r.Next(0, 10);
                }
                else if (rnd == 1)
                {
                    int rnd1 = r.Next(0, characters.Length);
                    password += characters.GetValue(rnd1);
                }
                else if (rnd == 2)
                {
                    int rnd1 = r.Next(0, specialCharacters.Length);
                    password += specialCharacters.GetValue(rnd1);
                }
            }

            return password;
        }

        private void copy_Btn_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(pw_TextBox.Text);
        }
    }
}
