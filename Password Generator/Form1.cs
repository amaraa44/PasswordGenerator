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

        private String upperCaseChars = "ABCDEFGHIJKLMOPQRSTUVWXYZ";
        private String lowerCaseChars = "abcdefghijklmopqrstuvwxyz";
        private String specialChars = "<>#&@{},;.:-_*!%/=()$[]|\"\\";

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

            String characters = "";

            if (lowerCase_CB.Checked)
            {
                characters += lowerCaseChars;
            }
            if (upperCase_CB.Checked)
            {
                characters += upperCaseChars;
            }
            if (specialChars_CB.Checked)
            {
                characters += specialChars;
            }

            if (characters.Length >= 1)
            {
                for (int i = 0; i < pwLenght_NmbUD.Value; i++)
                {
                    password += characters[r.Next(0,characters.Length)];
                }
            }
            else
            {
                MessageBox.Show("Please select at least one of the checkbox.");
            }


            return password;
        }

        private void copy_Btn_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(pw_TextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
