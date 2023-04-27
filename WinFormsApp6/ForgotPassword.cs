using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        string Code;
        string ID;
        bool Password_Changed = false;
        public bool getPassword_Changed()
        {
            return Password_Changed;
        }
        public ForgotPassword(string id,string code)
        {
            InitializeComponent();
            Code= code;
            ID = id;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (Code_Password_label.Text == "Code:")
            {
                if (Code_Password_textBox.Text == Code)
                {
                    Code_Password_label.Text = "New Password";
                    Code_Password_textBox.Text = "";
                    Reenter_Password_label.Show();
                    Reenter_Password_textBox.Show();

                }
            }
            else
            {
                string Username = Account_Settings.getCustomerFromDataBase(ID, "Username", "Customer");
                if (Code_Password_textBox.Text != "")
                {
                    if(Code_Password_textBox.Text == Reenter_Password_textBox.Text)
                    {
                        if (Code_Password_textBox.Text != Username)
                        {
                            MessageBox.Show("Password changed succesfully");
                            Password_Changed= true;
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Password cannot be the same as Username");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords dont match");
                    }
                }
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Check your Email for the code");
            Reenter_Password_label.Hide();
            Reenter_Password_textBox.Hide();
        }
    }
}
