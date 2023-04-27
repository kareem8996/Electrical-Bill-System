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
    public partial class Two_Step : Form
    {
        public Two_Step()
        {
            InitializeComponent();
        }
        string Code;
        char verified='F';
        public Two_Step(string code)
        {
            Code = code;
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {
            if (Verification_textBox.Text == Code) verified = 'T'; else MessageBox.Show("Wrong Verification Code");
        }
        public char getStep()
        {
            return verified;
        }
        private void Two_Step_Load(object sender, EventArgs e)
        {

        }
    }
}
