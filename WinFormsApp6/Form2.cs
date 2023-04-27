
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

	/// <summary>
	/// Summary for MyForm2
	/// </summary>
	public partial class Form2 : Form
	{
		public
			char checkStep = 'F';
		char Getstep()
		{
			return checkStep;
		}
		String GetPass()
		{
			return textBox3.Text;
		}

		public Form2(string code, string name, string pass)
		{
			InitializeComponent();
			String Ver = code;
			String u = name;
			String a = pass;
			label3.Text = Ver;
			label5.Text = u;
			label6.Text = a;
			//
			//TODO: Add the constructor code here
			//
		}
		public Form2(string code)
		{
			InitializeComponent();
			String Ver = code;
			label3.Text = Ver;
			button1.Text = "VERIFY";
		}


		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label6;



		private void label2_Click(System.Object sender, System.EventArgs e)
		{
		}
		private void textBox2_TextChanged(System.Object sender, System.EventArgs e)
		{
		}
		private void button1_Click(System.Object sender, System.EventArgs e)
		{
			if (button1.Text == "Verify")
			{
				if (textBox1.Text != "")
				{
					if (label1.Text == "Verification Code")
					{
						if (textBox1.Text == label3.Text)
						{
							label1.Text = "Enter Password";
							label2.Show();
							label2.Text = "Renter Password";
							textBox2.Show();
							label4.Hide();
							textBox3.Show();
							textBox1.Text = "";
							textBox1.Hide();
							textBox3.Show();
							button1.Text = "Enter";
						}
						else
						{
							label4.Text = "Verification Invalid";
							label4.Show();
						}

					}

				}
			}
			else
			{
				if (label1.Text == "Enter Password")
				{
					if (textBox2.Text != "")
					{
						if (textBox3.Text == textBox2.Text)
						{
							if (textBox3.Text != label5.Text)
							{
								if (textBox3.Text != label6.Text)
								{
									label4.Hide();
									this.Close();
								}
								else
								{
									label4.Show();
									label4.Text = "This password is an old password ";
								}
							}
							else
							{
								label4.Text = "Password cannot be the same as the Username";
								label4.Show();
							}
						}
						else
						{
							label4.Text = "Passwords do not match";
							label4.Show();
						}
					}
				}

			}
			if (button1.Text == "VERIFY")
			{
				if (textBox1.Text != "")
				{
					if (label3.Text == textBox1.Text)
					{
						checkStep = 'T';
						this.Close();
					}
					else
					{
						label4.Text = "Verification is incorrect";
						label4.Show();
					}
				}

			}

		}
		private void MyForm2_Load(System.Object sender, System.EventArgs e)
		{
			label3.Hide();
			label2.Hide();
			textBox2.Hide();
			textBox3.Hide();
			label4.Hide();
			label5.Hide();
			label6.Hide();
		}
		private void textBox1_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!Char.IsNumber(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
		private void MyForm2_Activated(System.Object sender, System.EventArgs e)
		{
			this.Focus();
		}
	};
}
