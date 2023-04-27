using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle.DataAccess.Client;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            char step2, notification;
            if (siticoneToggleSwitch1.Checked) step2 = 'T'; else step2 = 'F';
            if (siticoneToggleSwitch2.Checked) notification = 'T'; else notification = 'F';
            Account_Settings account_Settings = new Account_Settings(siticoneTextBox1.Text, siticoneTextBox2.Text, siticoneTextBox3.Text, siticoneTextBox4.Text, siticoneTextBox5.Text, siticoneTextBox6.Text,notification,step2);
            //Account_Settings account_Settings = new Account_Settings(10);
            this.Hide();
            account_Settings.ShowDialog();
            this.Show();
            if (account_Settings.save_key())
            {
                //OracleCommand c = new OracleCommand();
                //c.Connection = conn;
                //c.CommandText = $"update Customer set FIRSTNAME='{account_Settings.GetFirstName()}',LASTNAME='{account_Settings.GetLastName()}',USERNAME='{account_Settings.GetUsername()}',USERPASSWORD='{account_Settings.GetPass()}',EMAIL='{account_Settings.GetEmail()}'";
                //c.CommandType = CommandType.Text;
                //int r = c.ExecuteNonQuery();
                //if (r != -1)
                //{
                //    MessageBox.Show("Changes Saved");
                //}
            }
            
        }

        private void siticoneTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //OracleConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            //string ordb = "Data source=orcl;User Id=scott;Password = tiger; ";
            //OracleConnection conn=new OracleConnection(ordb);
        }

        private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
