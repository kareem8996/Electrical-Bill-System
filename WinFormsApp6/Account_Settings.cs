namespace WinFormsApp6
{
	using System;
	using System.ComponentModel;
	using System.Collections;
	using System.Windows.Forms;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Net;
	using System.Net.Mail;
	using System.Windows.Forms;
	using AForge;
	using AForge.Video;
	using AForge.Video.DirectShow;
	using DarrenLee.Media;
	using System.IO;
	using System.Drawing.Imaging;
	using System.Drawing.Drawing2D;
	//using Oracle.DataAccess.Client;
	using System.Collections.Generic;
	partial class Account_Settings : System.Windows.Forms.Form
	{
		FilterInfoCollection filterInfoCollection;
		VideoCaptureDevice videoCaptureDevice;
		private System.Windows.Forms.TextBox Lastname_Textbox;
		private System.Windows.Forms.TextBox Username_Textbox;

		private System.Windows.Forms.GroupBox AccountGbox;
		private System.Windows.Forms.Label Last_Name_label;

		private System.Windows.Forms.Label Phone;



		private System.Windows.Forms.Label Username;



		//OracleConnection conn;


		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;




		private System.Windows.Forms.TextBox Phone_Textbox;




		private System.Windows.Forms.GroupBox NotificationGbox;
		private System.Windows.Forms.Label Email_label;


		private System.Windows.Forms.GroupBox SecurityGbox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;


		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox Email_Textbox;
		private System.Windows.Forms.TextBox Password_Textbox;



		private System.Windows.Forms.Button Save_button;


		private System.Windows.Forms.PictureBox pictureBox2;



		private System.Windows.Forms.TextBox step2_code_Textbox;









		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label Hello_label;
		private System.Windows.Forms.Button Account_button;
		private System.Windows.Forms.Button Notification_button;


		private System.Windows.Forms.Button Security_button;
		private System.Windows.Forms.Button Logout_button;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Current_Tab_label;














		int timer1_counter = 0;
		int timer1_counter2 = 0;
		int timer2_counter = 0;
		int timer2_counter2 = 0;
		static String Code;
		char who = 's';
		private System.Windows.Forms.PictureBox Last_Name_picturebox;
		private System.Windows.Forms.PictureBox Last_Name_pictureBox2;
		private System.Windows.Forms.PictureBox Username_picturebox2;
		private System.Windows.Forms.PictureBox Username_picturebox;
		private System.Windows.Forms.PictureBox Phone_picturebox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox Password_pictureBox;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox VCODE_pictureBox;




		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox Email_picturebox;


		private System.Windows.Forms.PictureBox Phone_picturebox;





		List<PictureBox> pics = new List<PictureBox>();

		List<Label> labels = new List<Label>();

		String old_username;
		String old_phone;
		String old_email;
		String old_name;
		String RandomCode;
		private System.Windows.Forms.Label Username_error_label;
		private System.Windows.Forms.Label Last_name_error_label;
		private System.Windows.Forms.Label Phone_error_label;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label Reenter;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label Password_label_error;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label Reenter_error_label;
		private System.Windows.Forms.Timer timer3;
		String old_pass;

		bool changed = false;

		char s_key = '0';
		List<String> EMAILS = new List<String>();
		List<String> PHONES = new List<String>();
		private System.Windows.Forms.Label email_error_label;
		private System.Windows.Forms.Label email_error_label2;
		private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch email_switch;
		private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Email_checkBox;
		private Siticone.Desktop.UI.WinForms.SiticoneButton Send_code_button;
		private System.Windows.Forms.Label step2_code_label;
		private System.Windows.Forms.Label step2_error_label;
		private Siticone.Desktop.UI.WinForms.SiticoneButton Browse_button;
		private Siticone.Desktop.UI.WinForms.SiticoneButton No_pic_button;
		private Siticone.Desktop.UI.WinForms.SiticoneButton New_pic_button;
		private Siticone.Desktop.UI.WinForms.SiticoneButton Delete_button;

		#region Windows Form Designer generated code
		void Show_Account()
		{

		}
		public int curr_loc;
		public Account_Settings(string first, string last, string user, string password, string email, string phone, char send_email, char step2)
		{
			InitializeComponent();
			First_Name_textbox.Text = first;
			Lastname_Textbox.Text = last;
			Username_Textbox.Text = user;
			Password_Textbox.Text = password;
			Email_Textbox.Text = email;
			Phone_Textbox.Text = phone;
			if (send_email == 'T')
			{
				Email_checkBox.Checked = true;
			}
			else
			{
				Email_checkBox.Checked = false;
			}
			if (step2 == 'T')
			{
				email_switch.Checked = true;
			}
			else
			{
				email_switch.Checked = false;
			}

		}
		//	public Account_Settings(int id){
		//	InitializeComponent();
		//	OracleCommand c = new OracleCommand();
		//	c.Connection=conn;
		//	c.CommandText = $"select FIRSTNAME,LASTNAME,USERNAME,USERPASSWORD,EMAIL from Customer where id='{id}';";
		//	c.CommandType = CommandType.Text;
		//	OracleDataReader dr = c.ExecuteReader();
		//          while (dr.Read())
		//          {
		//		First_Name_textbox.Text = dr[0].ToString();
		//		Lastname_Textbox.Text = dr[1].ToString();
		//		Username_Textbox.Text = dr[2].ToString();
		//		Password_Textbox.Text = dr[3].ToString();
		//		Email_Textbox.Text = dr[4].ToString();
		//          }
		//	dr.Close();
		//	//who = 'd';
		//	//First_Name_textbox.Text = 
		//	//Last_Name_textbox.Text = 
		//	//Hello_label.Text = 
		//	//Username_Textbox.Text = ;
		//	//Email_Textbox.Text = ;
		//	//Phone_Textbox.Text = ;
		//	//Password_Textbox.Text = ;
		//	//if (send_email == 'T')
		//	//{
		//	//	Email_checkBox.Checked = true;
		//	//}
		//	//else
		//	//{
		//	//	Email_checkBox.Checked = false;
		//	//}
		//	//if (step2 == 'T')
		//	//{
		//	//	email_switch.Checked = true;
		//	//}
		//	//else
		//	//{
		//	//	email_switch.Checked = false;
		//	//}

		//	//string wow = "PICs\\Doctors\\" + username + ".jpg";
		//	//String  str3 = new String(wow);
		//	//if (System.IO.File.Exists(str3))
		//	//{
		//	//	pictureBox1.ImageLocation = str3;
		//	//	pictureBox2.ImageLocation = str3;
		//	//}
		//	//else
		//	//{
		//	//	pictureBox1.ImageLocation = "PICs\\guest.jpg";
		//	//	pictureBox2.ImageLocation = "PICs\\guest.jpg";
		//	//}
		//	//GraphicsPath  gp = new GraphicsPath();
		//	//gp.AddEllipse(pictureBox2.DisplayRectangle);
		//	//pictureBox2.Region = new System.Drawing.Region(gp);
		//	AccountGbox.Show();
		//	NotificationGbox.Hide();
		//	SecurityGbox.Hide();
		//	Send_code_button.Hide();
		//	email_error_label.Hide();
		//	step2_code_label.Hide();
		//	step2_code_Textbox.Hide();
		//	pictureBox5.Hide();
		//	Send_code_button.Hide();
		//	VCODE_pictureBox.Hide();
		//	email_error_label.Hide();
		//	//panel3.Show();
		//	//Password_Textbox.Text = p;
		//	//
		//	//TODO: Add the constructor code here
		//	//
		//}
		Account_Settings()
		{
			InitializeComponent();

			//
			//TODO: Add the constructor code here
			//
		}
		public void Account_Settings_Load(System.Object sender, System.EventArgs e)
		{
			//string ordb = "Data source=orcl;User Id=scott;Password = tiger; ";
			// conn=new OracleConnection(ordb);
			//conn.Open();
			Hello_label.Text = First_Name_textbox.Text + " " + Lastname_Textbox.Text;
			First_Name_error_label.Hide();
			videoCaptureDevice = new VideoCaptureDevice();
			curr_loc = Password_Textbox.Location.Y;
			Show_Account();
			changed = false;
			old_username = Username_Textbox.Text;
			old_phone = Phone_Textbox.Text;
			old_email = Email_Textbox.Text;
			old_name = Lastname_Textbox.Text;
			old_pass = Password_Textbox.Text;


			labels.Add(label9);
			labels.Add(Last_Name_label);
			labels.Add(Phone);
			labels.Add(Username);
			labels.Add(Email_label);
			labels.Add(step2_code_label);
			labels.Add(Reenter);

			pics.Add(Password_pictureBox);
			pics.Add(Last_Name_picturebox);
			pics.Add(Phone_picturebox);
			pics.Add(Username_picturebox);
			pics.Add(Email_picturebox);
			pics.Add(VCODE_pictureBox);
			pics.Add(pictureBox8);

			Reenter.Hide();
			pictureBox7.Hide();
			pictureBox8.Hide();
			textBox1.Hide();
			textBox1.Hide();
			Username_error_label.Hide();
			Last_name_error_label.Hide();
			Password_label_error.Hide();
			Reenter_error_label.Hide();
			Phone_error_label.Hide();
			email_error_label.Hide();
		}
		private void textBox3_TextChanged(System.Object sender, System.EventArgs e)
		{
		}
		List<String> UNAMES = new List<String>();
		char genders;
		void Blue(PictureBox p, Label l)
		{
			l.ForeColor = Color.FromArgb(0, 102, 204);
			p.BackColor = Color.FromArgb(0, 102, 204);
		}
		void Green(PictureBox p, Label l)
		{
			l.ForeColor = Color.FromArgb(0, 255, 0);
			p.BackColor = Color.FromArgb(0, 255, 0);
		}
		void Red(PictureBox p, Label l)
		{
			l.ForeColor = Color.FromArgb(255, 0, 0);
			p.BackColor = Color.FromArgb(255, 0, 0);
		}
		void Blacken(PictureBox p, Label l)
		{
			l.ForeColor = Color.FromArgb(0, 0, 0);
			p.BackColor = Color.FromArgb(0, 0, 0);
		}
		void Bluen(PictureBox p, Label l)
		{

			for (int i = 0; i < labels.Count; i++)
			{
				if (labels[i].ForeColor != Color.FromArgb(0, 255, 0))
					Blacken(pics[i], labels[i]);
			}
			Blue(p, l);
		}

		private void Phone_Textbox_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
		private void tableLayoutPanel1_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
		{
		}
		private void Browse_button_Click(System.Object sender, System.EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			string filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
			String str3 = filter;
			dialog.Filter = str3;
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				//MyCamera.Stop();
				pictureBox1.ImageLocation = dialog.FileName;
				pictureBox2.ImageLocation = dialog.FileName;
				changed = true;
			}

		}
		Form2 c;
		char Logoutkey = '0';
		bool Delete_choice = false;
		//	void MarshalString(String s, string& os)
		//	{
		//		using namespace Runtime.InteropServices;
		//const char* chars =
		//	(const char*)(Marshal.StringToHGlobalAnsi(s)).ToPointer();
		//os = chars;
		//		Marshal.FreeHGlobal(IntPtr((void*) chars));
		//	}
		void save()
		{
			string username = Username_Textbox.Text;
			if (who == 'd')
			{
				string old_uname = old_username;
				old_uname = "PICs\\Doctors\\" + old_uname + ".jpg";
				String old_u = old_uname;
				System.IO.File.Delete(old_u);
				string wow = "PICs\\Doctors\\" + username + ".jpg";
				String str3 = wow;
				if (pictureBox1.ImageLocation != "PICs\\guest.jpg")
				{
					if (System.IO.File.Exists(str3))
					{
						System.IO.File.Delete(str3);
						pictureBox1.Image.Save(str3, ImageFormat.Jpeg);
					}
					else
						pictureBox1.Image.Save(str3, ImageFormat.Jpeg);
				}
				else
				{
					System.IO.File.Delete(str3);
				}
			}
			else if (who == 'p')
			{
				string old_uname = old_username;

				old_uname = "PICs\\patients\\" + old_uname + ".jpg";
				String old_u = old_uname;
				System.IO.File.Delete(old_u);
				string wow = "PICs\\Patients\\" + username + ".jpg";
				String str3 = wow;
				if (pictureBox1.ImageLocation != "PICs\\guest.jpg")
				{
					if (System.IO.File.Exists(str3))
					{
						System.IO.File.Delete(str3);
						pictureBox1.Image.Save(str3, ImageFormat.Jpeg);
					}
					else
						pictureBox1.Image.Save(str3, ImageFormat.Jpeg);
				}
				else
				{
					System.IO.File.Delete(str3);

				}
			}
		}

		public String GetPass()
		{
			return Password_Textbox.Text;
		}
		public String GetLastName()
		{
			return Lastname_Textbox.Text;
		}
		public String GetFirstName()
		{
			return Lastname_Textbox.Text;
		}
		public String GetUsername()
		{
			return Username_Textbox.Text;
		}
		public String GetEmail()
		{
			return Email_Textbox.Text;
		}
		public String GetPhone()
		{
			return Phone_Textbox.Text;
		}
		public bool change_occured()
		{
			if (changed == false)
				return false;
			else
				return true;
		}
		public char Getsend_email()
		{
			if (Email_checkBox.Checked)
				return 'T';
			else
				return 'F';
		}
		char STEP2;
		public char Getstep2()
		{
			if (!email_switch.Checked)
				return 'F';
			else
			{

				if (Step_two == false) return 'F';
				else return 'T';
			}
		}
		public bool logout()
		{
			if (Logoutkey == 'b' || Logoutkey == 'n')
				return true;
			else
				return false;
		}
		public bool save_key()
		{
			if (Logoutkey == 'b' || Logoutkey == 'o')
				return true;
			else
				return false;
		}
		public bool Delete_key()
		{
			if (Delete_choice)
				return true;
			else
				return false;

		}
		public bool phone_or_name_changed()
		{
			if (Phone.ForeColor == Color.FromArgb(0, 255, 0) || Last_Name_label.ForeColor == Color.FromArgb(0, 255, 0))
				return true;
			else
				return false;
		}
		private void Security_button_Click(System.Object sender, System.EventArgs e)
		{
			SecurityGbox.Show();
			AccountGbox.Hide();
			NotificationGbox.Hide();
			Current_Tab_label.Text = "Security";
		}
		private void Account_button_Click(System.Object sender, System.EventArgs e)
		{
			AccountGbox.Show();
			NotificationGbox.Hide();
			SecurityGbox.Hide();
			Current_Tab_label.Text = "Account";


		}
		private void Notification_button_Click(System.Object sender, System.EventArgs e)
		{
			NotificationGbox.Show();
			AccountGbox.Hide();
			SecurityGbox.Hide();
			Current_Tab_label.Text = "Notification";


		}
		private void No_pic_button_Click(System.Object sender, System.EventArgs e)
		{
			pictureBox1.ImageLocation = "C:\\Users\\karee\\Desktop\\PICs\\guest.jpg";
			pictureBox2.ImageLocation = "C:\\Users\\karee\\Desktop\\PICs\\guest.jpg";
			changed = true;

		}
		private void Save_button_Click(System.Object sender, System.EventArgs e)
		{
			save();
			Logoutkey = 'o';
			s_key = '1';
		}
		private void New_pic_button_Click(System.Object sender, System.EventArgs e)
		{
			bool check_errors = false;
			for (int i = 0; i < labels.Count; i++)
			{
				if (labels[i].ForeColor == Color.FromArgb(255, 0, 0))
				{
					check_errors = true;
					break;
				}
			}
			if (!check_errors)
			{
				string username = Username_Textbox.Text;
				string temp = "C:\\Users\\karee\\Desktop\\PICs\\" + username + ".jpg";
				String temp_loc = temp;
				System.IO.File.Delete(temp_loc);
				Camera_winform cm = new Camera_winform(username);
				cm.ShowDialog();
				if (who == 'd')
				{
					string org = "C:\\Users\\karee\\Desktop\\PICs\\Doctors\\" + username + ".jpg";
					String org_loc = temp;
					if (System.IO.File.Exists(temp_loc))
					{
						changed = true;
						pictureBox1.ImageLocation = temp_loc;
						pictureBox2.ImageLocation = temp_loc;
					}
					else if (System.IO.File.Exists(org_loc))
					{
						pictureBox1.ImageLocation = org_loc;
						pictureBox2.ImageLocation = org_loc;

					}
				}
				else if (who == 'p')
				{
					string org = "C:\\Users\\karee\\Desktop\\PICs\\Patients\\" + username + ".jpg";
					String org_loc = temp;
					if (System.IO.File.Exists(temp_loc))
					{
						changed = true;
						pictureBox1.ImageLocation = temp_loc;
						pictureBox2.ImageLocation = temp_loc;
					}
					else if (System.IO.File.Exists(org_loc))
					{
						pictureBox1.ImageLocation = org_loc;
						pictureBox2.ImageLocation = org_loc;

					}
				}
			}
			else
			{
				System.Windows.Forms.DialogResult Quit_result = MessageBox.Show("You cannot save while having errors,please fix them first", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void Account_Settings_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			this.ActiveControl = Last_Name_label;
			string username = Username_Textbox.Text;
			string temp = "C:\\Users\\karee\\Desktop\\PICs\\" + username + ".jpg";
			String temp_loc = temp;
			if (Delete_choice == false)
			{
				bool check_errors = false;
				for (int i = 0; i < labels.Count; i++)
				{
					if (labels[i].ForeColor == Color.FromArgb(255, 0, 0))
					{
						check_errors = true;
						break;
					}
				}
				if (System.IO.File.Exists(temp_loc))
					System.IO.File.Delete(temp_loc);
				if (!check_errors || Logoutkey == 'b')
				{
					if (Logoutkey == '0' && s_key == '0' && changed)
					{
						System.Windows.Forms.DialogResult Quit_result = MessageBox.Show("Do you want to save Current changes?", "Quit?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
						if (Quit_result == System.Windows.Forms.DialogResult.Yes)
						{
							//Save_button.PerformClick();
							save();

							Logoutkey = 'o';
						}
						else if (Quit_result == System.Windows.Forms.DialogResult.Cancel)
						{
							e.Cancel = true;
						}
					}
				}
				else
				{
					System.Windows.Forms.DialogResult Quit_result = MessageBox.Show("You still have errors, do you want to exit without saving?", "Errors", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
					if (Quit_result == System.Windows.Forms.DialogResult.No)
					{
						//Save_button.PerformClick()
						e.Cancel = true;

					}
				}
			}

			else
			{
				System.Windows.Forms.DialogResult Delete_result;
				if (who == 'd')
					Delete_result = MessageBox.Show("Are you sure you want to delete all your data including diseases and its symptoms ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				else
					Delete_result = MessageBox.Show("Are you sure you want to delete all your data including Diagnosis History?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (Delete_result == System.Windows.Forms.DialogResult.No)
				{
					e.Cancel = true;
					Delete_choice = false;
				}
				else
				{
					string randCode;
					string from, pass, MessageBody;
					Random rd = new Random();
					randCode = rd.Next(1000000, 10000000).ToString();
					MailMessage message = new MailMessage();
					from = "selfdiagnosissupp@gmail.com";
					pass = "eomootfkfmpefvut";
					MessageBody = "We  are very sorry that you are deleting your account.\n Remember that deleting your account means that you are deleting all your info and all diseases created by you will be deleted\n Here is the verification code to confirm the delete process " + randCode + " .";
					String From = from;
					String MB = MessageBody;
					String To;
					String Pass = pass;
					message.From = new MailAddress(From);
					message.Body = MB;
					message.Subject = "Account Delete :(";

					To = Email_Textbox.Text;
					SmtpClient smtp = new SmtpClient("smtp.gmail.com");
					smtp.EnableSsl = true;
					message.To.Add(To);
					smtp.Port = 587;
					smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
					smtp.Credentials = new NetworkCredential(From, Pass);
					try
					{
						smtp.Send(message);
						message.To.Clear();
					}
					catch (Exception ex)
					{

					}
					c = new Form2(randCode);
					c.ShowDialog();
					this.Show();
					if (System.IO.File.Exists(temp_loc))
						System.IO.File.Delete(temp_loc);

					//Deleting all Doctor's pictures(Temp,old username, new username)
					if (who == 'd')
					{
						string old_uname = old_username;
						old_uname = "C:\\Users\\karee\\Desktop\\PICs\\Doctors\\" + old_uname + ".jpg";
						String old_u = old_uname;
						System.IO.File.Delete(old_u);
						string wow = "C:\\Users\\karee\\Desktop\\PICs\\Doctors\\" + username + ".jpg";
						String str3 = new String(wow);
						if (pictureBox1.ImageLocation != "C:\\Users\\karee\\Desktop\\PICs\\guest.jpg")
						{
							if (System.IO.File.Exists(str3))
							{
								System.IO.File.Delete(str3);
							}
						}
						else
						{
							System.IO.File.Delete(str3);
						}
					}
					//Deleting all patient's pictures(Temp,old username, new username)
					else if (who == 'p')
					{
						string old_uname = old_username;

						old_uname = "C:\\Users\\karee\\Desktop\\PICs\\Patients\\" + old_uname + ".jpg";
						String old_u = new String(old_uname);
						System.IO.File.Delete(old_u);
						string wow = "C:\\Users\\karee\\Desktop\\PICs\\Patients\\" + username + ".jpg";
						String str3 = new String(wow);
						if (pictureBox1.ImageLocation != "C:\\Users\\karee\\Desktop\\PICs\\guest.jpg")
						{
							if (System.IO.File.Exists(str3))
							{
								System.IO.File.Delete(str3);
							}
						}
						else
						{
							System.IO.File.Delete(str3);

						}
					}
				}


			}
		}

		private void Logout_button_Click(System.Object sender, System.EventArgs e)
		{
			bool check_errors = false;
			for (int i = 0; i < labels.Count; i++)
			{
				if (labels[i].ForeColor == Color.FromArgb(255, 0, 0))
				{
					check_errors = true;
					break;
				}
			}
			if (!check_errors)
			{
				if (s_key != '1' && changed)
				{
					System.Windows.Forms.DialogResult Logout_result = MessageBox.Show("Are you sure you want to Logout & save Current changes?", "Logout?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					if (Logout_result == System.Windows.Forms.DialogResult.Yes)
					{
						//Save_button.PerformClick();
						save();
						Logoutkey = 'b';
						this.Close();
					}
					else if (Logout_result == System.Windows.Forms.DialogResult.No)
					{
						Logoutkey = 'n';
						this.Close();
					}
				}
				else
				{
					System.Windows.Forms.DialogResult Logout_result = MessageBox.Show("Are you sure you want to Logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (Logout_result == System.Windows.Forms.DialogResult.Yes)
					{
						//Save_button.PerformClick();
						Logoutkey = 'b';
						this.Close();
					}
				}
			}
			else
			{

				System.Windows.Forms.DialogResult Quit_result = MessageBox.Show("You still have errors, do you want to logout without saving?", "Errors", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (Quit_result == System.Windows.Forms.DialogResult.Yes)
				{
					Logoutkey = 'b';
					this.Close();
				}

			}

		}
		int counter = 0;
		private void step2_CheckBox_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			counter++;
			if (email_switch.Checked == true)
			{
				Send_code_button.Show();
				changed = true;
				VCODE_pictureBox.Show();
				pictureBox5.Show();
				pictureBox5.BringToFront();
				step2_code_Textbox.Show();
				step2_code_Textbox.BringToFront();
				step2_code_label.Show();
				step2_code_label.BringToFront();
				Send_code_button.Text = "Send";
				Send_code_button.PerformClick();
				Send_code_button.Text = "Enter";
			}
			else
			{
				step2_code_label.Hide();
				step2_code_Textbox.Hide();
				Send_code_button.Hide();
				Blacken(VCODE_pictureBox, step2_code_label);
				step2_error_label.Hide();
				step2_code_Textbox.Text = "";
				Step_two = false;
				pictureBox5.Hide();
				VCODE_pictureBox.Hide();
				step2_code_Textbox.Hide();
			}
		}
		private void step2_phone_Textbox_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
		private void Account_button_MouseHover(System.Object sender, System.EventArgs e)
		{
			Account_button.BackColor = Color.FromArgb(255, 255, 255);
			Account_button.ForeColor = Color.FromArgb(0, 0, 0);
			Account_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\Avatar_black.GIF");
			Account_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		private void Account_button_MouseLeave(System.Object sender, System.EventArgs e)
		{
			Account_button.BackColor = Color.FromArgb(0, 102, 204);
			Account_button.ForeColor = Color.FromArgb(255, 255, 255);
			Account_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\Avatar_white.GIF");
			Account_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		private void Security_button_MouseHover(System.Object sender, System.EventArgs e)
		{
			Security_button.BackColor = Color.FromArgb(255, 255, 255);
			Security_button.ForeColor = Color.FromArgb(0, 0, 0);
			Security_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\Security_black.GIF");
			Security_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		private void Security_button_MouseLeave(System.Object sender, System.EventArgs e)
		{
			Security_button.BackColor = Color.FromArgb(0, 102, 204);
			Security_button.ForeColor = Color.FromArgb(255, 255, 255);
			Security_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\Security_white.GIF");
			Security_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		private void Notification_button_MouseHover(System.Object sender, System.EventArgs e)
		{
			Notification_button.BackColor = Color.FromArgb(255, 255, 255);
			Notification_button.ForeColor = Color.FromArgb(0, 0, 0);
			Notification_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\Notification_black.GIF");
			Notification_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		private void Notification_button_MouseLeave(System.Object sender, System.EventArgs e)
		{
			Notification_button.BackColor = Color.FromArgb(0, 102, 204);
			Notification_button.ForeColor = Color.FromArgb(255, 255, 255);
			Notification_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\Notification_white.GIF");
			Notification_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		private void Save_button_MouseHover(System.Object sender, System.EventArgs e)
		{
			Save_button.BackColor = Color.FromArgb(255, 255, 255);
			Save_button.ForeColor = Color.FromArgb(0, 0, 0);
			Save_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\bookmark_black.GIF");
			Save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

		}
		private void Save_button_MouseLeave(System.Object sender, System.EventArgs e)
		{
			Save_button.BackColor = Color.FromArgb(0, 102, 204);
			Save_button.ForeColor = Color.FromArgb(255, 255, 255);
			Save_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\bookmark_white.GIF");
			Save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

		}
		private void Logout_button_MouseHover(System.Object sender, System.EventArgs e)
		{
			Logout_button.BackColor = Color.FromArgb(255, 255, 255);
			Logout_button.ForeColor = Color.FromArgb(0, 0, 0);
			Logout_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\exit_sign_black.GIF");
			Logout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		private void Logout_button_MouseLeave(System.Object sender, System.EventArgs e)
		{
			Logout_button.BackColor = Color.FromArgb(0, 102, 204);
			Logout_button.ForeColor = Color.FromArgb(255, 255, 255);
			Logout_button.Image = System.Drawing.Image.FromFile("C:\\Users\\karee\\Desktop\\PICs\\sys\\exit_sign_white.GIF");
			Logout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		bool Step_two = false;
		private void Send_code_button_Click(System.Object sender, System.EventArgs e)
		{
			if (Send_code_button.Text == "Send" && counter != 1)
			{
				step2_error_label.Text = "An e-mail has been sent to your email";
				step2_error_label.ForeColor = Color.FromArgb(255, 0, 0);
				step2_error_label.Show();
				Random rd = new Random();
				RandomCode = rd.Next(1000000, 10000000).ToString();
				string from, pass, MessageBody;
				string random_c = RandomCode;
				MailMessage message = new MailMessage();
				from = "selfdiagnosissupp@gmail.com";
				pass = "eomootfkfmpefvut";
				MessageBody = "Your 2 Step Verification Code is " + random_c + " .";
				String From = from;
				String MB = MessageBody;
				String To;
				String Pass = pass;
				message.From = new MailAddress(From);
				message.Body = MB;
				message.Subject = "2 Step Verification Code";
				To = Email_Textbox.Text;
				SmtpClient smtp = new SmtpClient("smtp.gmail.com");
				smtp.EnableSsl = true;
				message.To.Add(To);
				smtp.Port = 587;
				smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtp.Credentials = new NetworkCredential(From, Pass);
				try
				{
					smtp.SendMailAsync(message);
					message.To.Clear();
				}
				catch (Exception ex)
				{

				}
			}
			else
			{
				if (RandomCode == step2_code_Textbox.Text)
				{
					System.Windows.Forms.MessageBox.Show("2-Step Verification has been activated", "2-Step", MessageBoxButtons.OK, MessageBoxIcon.Information);
					step2_error_label.Hide();
					Blacken(VCODE_pictureBox, step2_code_label);
					step2_error_label.Hide();
					step2_code_label.Hide();
					step2_code_Textbox.Hide();
					VCODE_pictureBox.Hide();
					pictureBox5.Hide();
					Send_code_button.Hide();
					Step_two = true;
				}
				else
				{
					if (counter != 1)
					{
						step2_error_label.Text = "Invalid Code";
						step2_error_label.Show();
						Red(VCODE_pictureBox, step2_code_label);
						Step_two = false;
					}
				}
			}

		}
		private void pictureBox3_Click(System.Object sender, System.EventArgs e)
		{
		}
		private void Fullname_Textbox_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Bluen(First_Name_pictureBox, First_Name_label);
		}
		private void Username_Textbox_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Bluen(Username_picturebox, Username);
		}
		private void label4_Click(System.Object sender, System.EventArgs e)
		{

		}
		private void Username_Textbox_TextChanged(System.Object sender, System.EventArgs e)
		{
			changed = true;
			string UNAME = Username_Textbox.Text;
		}
		private void Phone_Textbox_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Bluen(Phone_picturebox, Phone);
		}
		private void Fullname_Textbox_TextChanged(System.Object sender, System.EventArgs e)
		{
			changed = true;
		}
		private void Phone_Textbox_TextChanged(System.Object sender, System.EventArgs e)
		{
			changed = true;

		}
		private void Password_Textbox_TextChanged(System.Object sender, System.EventArgs e)
		{
			timer1_counter2 = 0;
			changed = true;
			if (old_pass != Password_Textbox.Text && old_pass != null)
			{
				Bluen(Password_pictureBox, label9);
			}
			else
			{
				if (old_pass == Password_Textbox.Text)
				{
					Blacken(Password_pictureBox, label9);
					timer1.Stop();
					return;
				}
			}
			if (label9.ForeColor == Color.FromArgb(0, 102, 204) && old_pass != null)
			{
				Password_label_error.Text = "";
				string old_p = old_pass;
				string new_p = Password_Textbox.Text;
				string curr_uname = Username_Textbox.Text;
				if (old_p != new_p)
				{
					string org2 = "";
					for (int i = 0; i < curr_uname.Length; i++)
					{
						org2 += Char.ToLower(curr_uname[i]);
					}
					string org1 = "";
					for (int i = 0; i < new_p.Length; i++)
					{
						org1 += Char.ToLower(new_p[i]);
					}
					if (org1 != org2)
					{
						timer1.Start();
						Password_label_error.Hide();
						Green(Password_pictureBox, label9);
						textBox1.Focus();

					}
					else
					{
						timer1.Stop();
						Password_label_error.Text = "Password cannot be the same as Username";
						Password_label_error.Show();
						Red(Password_pictureBox, label9);
					}
				}
			}

		}
		private void step2_email_Textbox_TextChanged(System.Object sender, System.EventArgs e)
		{
			changed = true;

		}
		private void step2_code_Textbox_TextChanged(System.Object sender, System.EventArgs e)
		{
			changed = true;
		}

		private void Email_Textbox_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (Email_Textbox.Text != old_email)
			{
				changed = true;
			}
		}
		private void Email_checkBox_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			changed = true;
		}
		private void Username_Textbox_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			string new_uname = Username_Textbox.Text;
			string old_uname = old_username;
			bool test_name = false;
			Username_error_label.Text = "";

			if (new_uname != old_uname)
			{
				if (new_uname.Length >= 3)
				{
					for (int i = 0; i < new_uname.Length; i++)
					{
						char c = new_uname[i];
						if (!Char.IsLetterOrDigit(c))
						{

							/*label2.Text = "username cannot have symbols";
							label2.Show();*/
							Username_error_label.Text += "Username cannot have symbols\n";
							Username_error_label.Show();
							test_name = false;
							Red(Username_picturebox, Username);
							e.Cancel = true;
							break;
						}
						test_name = true;
						Blacken(Username_picturebox, Username);
						e.Cancel = false;
					}

				}
				else
				{
					Username_error_label.Text += "Username should be 3 characters or more\n";
					Username_error_label.Show();
					Red(Username_picturebox, Username);
					e.Cancel = true;
				}
				if (test_name)
				{
					for (int i = 0; i < UNAMES.Count; i++)
					{
						string u = UNAMES[i];
						string org2 = "";
						for (int j = 0; j < u.Length; j++)
						{
							if (Char.IsLetter(u[j]))
								org2 += Char.ToLower(u[j]);
							else
							{
								org2 += u[j];
							}
						}
						string org = "";
						for (int j = 0; j < new_uname.Length; j++)
						{
							if (Char.IsLetter(new_uname[j]))
								org += Char.ToLower(new_uname[j]);
							else
							{
								org += new_uname[j];
							}
						}

						if (org == org2)
						{
							Username_error_label.Text = "This Username is already taken\n";
							Username_error_label.Show();

							Red(Username_picturebox, Username);
							e.Cancel = true;
							break;
						}
						else
						{
							Green(Username_picturebox, Username);
							Username_error_label.Hide();
							e.Cancel = false;
						}

					}

				}
			}
			else
			{
				Blacken(Username_picturebox, Username);
			}
		}
		private void AccountGbox_Enter(System.Object sender, System.EventArgs e)
		{
		}
		private void Name_pictureBox2_Click(System.Object sender, System.EventArgs e)
		{
		}
		private void Password_Textbox_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Bluen(Password_pictureBox, label9);
			if (Reenter.Visible)
				this.ActiveControl = label9;
		}
		private void step2_phone_Textbox_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
		}
		private void Email_Textbox_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Bluen(Email_picturebox, Email_label);
		}
		private void step2_code_Textbox_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
		}
		private void Fullname_Textbox_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			string old_fullname = old_name;
			string new_fullname = Lastname_Textbox.Text;
			bool check_name = false;
			if (old_fullname != new_fullname)
			{
				if (new_fullname.Length >= 3)
				{
					for (int i = 0; i < new_fullname.Length; i++)
					{
						if (!Char.IsLetterOrDigit(new_fullname[i]) && new_fullname[i] != ' ')
						{
							check_name = true;
							break;
						}
					}

					Hello_label.Text = "Hello " + First_Name_textbox.Text + " " + Lastname_Textbox.Text;
					if (check_name)
					{
						Last_name_error_label.Text = "Full Name should not contain special characters";
						Last_name_error_label.Show();
						Red(Last_Name_picturebox, Last_Name_label);
						e.Cancel = true;
					}
					else
					{
						Green(Last_Name_picturebox, Last_Name_label);
						Last_name_error_label.Hide();
						e.Cancel = false;
					}
				}

				else
				{
					Last_name_error_label.Text = "Full Name should be more than three characters";
					Last_name_error_label.Show();
					Red(Last_Name_picturebox, Last_Name_label);
					e.Cancel = true;
				}
			}
			else
			{
				Blacken(Last_Name_picturebox, Last_Name_label);
				Hello_label.Text = "Hello " + First_Name_textbox.Text + " " + Lastname_Textbox.Text;

			}
		}
		private void Firstname_Textbox_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			string old_fullname = old_name;
			string new_fullname = First_Name_textbox.Text;
			bool check_name = false;
			if (old_fullname != new_fullname)
			{
				if (new_fullname.Length >= 3)
				{
					for (int i = 0; i < new_fullname.Length; i++)
					{
						if (!Char.IsLetterOrDigit(new_fullname[i]) && new_fullname[i] != ' ')
						{
							check_name = true;
							break;
						}
					}

					Hello_label.Text = "Hello " + First_Name_textbox.Text + " " + Lastname_Textbox.Text;
					if (check_name)
					{
						Last_name_error_label.Text = "Full Name should not contain special characters";
						Last_name_error_label.Show();
						Red(First_Name_pictureBox, First_Name_label);
						e.Cancel = true;
					}
					else
					{
						Green(First_Name_pictureBox, First_Name_label);
						First_Name_error_label.Hide();
						e.Cancel = false;
					}
				}

				else
				{
					First_Name_label.Text = "Full Name should be more than three characters";
					First_Name_error_label.Show();
					Red(First_Name_pictureBox, First_Name_label);
					e.Cancel = true;
				}
			}
			else
			{
				Blacken(First_Name_pictureBox, First_Name_label);
				Hello_label.Text = "Hello " + First_Name_textbox.Text + " " + Lastname_Textbox.Text;

			}
		}
		private void Phone_Textbox_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			string old_p = old_phone;
			string new_p = Phone_Textbox.Text;
			double mphone = System.Convert.ToDouble(Phone_Textbox.Text);
			double cphone = mphone;
			bool vphone = true;
			int lengthCount = 1;
			if (old_p != new_p)
			{
				for (; cphone > 0.9; cphone /= 10, lengthCount++) ;//Here we count the entered numbers
				if (lengthCount != 11)
				{
					vphone = false;
					Phone_error_label.Text = "Phone numbers are 11 numbers";
					Phone_error_label.Show();

				}
				int[] check = new int[11]; ;
				for (int i = lengthCount - 1; i >= 0; i--)
				{
					check[i] = (int)mphone % 10;
					mphone /= 10;
				}
				if (check[2] != 1 && check[2] != 2 && check[2] != 0 && check[2] != 5)
				{
					Phone_error_label.Text = "Invalid phone number";
					Phone_error_label.Show();
					vphone = false;
				}
				if (vphone)
				{
					Blacken(Phone_picturebox, Phone);
					e.Cancel = false;
					bool check_phone = false;
					for (int i = 0; i < PHONES.Count; i++)
					{
						if (Phone_Textbox.Text == PHONES[i])
						{
							Red(Phone_picturebox, Phone);
							e.Cancel = true;
							Phone_error_label.Text = "This phone number is already taken\n";
							Phone_error_label.Show();
							check_phone = true;
							break;
						}
					}
					if (!check_phone)
					{
						Phone_error_label.Hide();
						Green(Phone_picturebox, Phone);

					}
				}
				else
				{
					Red(Phone_picturebox, Phone);
					e.Cancel = true;
				}
			}
			else
			{
				Blacken(Phone_picturebox, Phone);
				Phone_error_label.Hide();
			}
		}

		private void Password_Textbox_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (label9.ForeColor == Color.Red)
			{
				e.Cancel = true;
			}
			else
			{
				if (old_pass == Password_Textbox.Text)
				{
					Blacken(Password_pictureBox, label9);
				}
				e.Cancel = false;
			}
		}
		private void timer1_Tick(System.Object sender, System.EventArgs e)
		{
			if (timer1_counter2 == 120)
			{
				if (curr_loc != Password_Textbox.Location.Y + 70)
				{
					if (timer1_counter == 70)
					{
						timer1_counter = 0;
						timer1.Stop();
					}
					timer1_counter += 10;
					Password_Textbox.Location = new System.Drawing.Point(Password_Textbox.Location.X, Password_Textbox.Location.Y - 15);
					Password_label_error.Location = new System.Drawing.Point(Password_label_error.Location.X, Password_label_error.Location.Y - 15);
					Password_pictureBox.Location = new System.Drawing.Point(Password_pictureBox.Location.X, Password_pictureBox.Location.Y - 15);
					pictureBox3.Location = new System.Drawing.Point(pictureBox3.Location.X, pictureBox3.Location.Y - 15);
					label9.Location = new System.Drawing.Point(label9.Location.X, label9.Location.Y - 15);
					Reenter.Show();
					pictureBox7.Show();
					pictureBox8.Show();
					textBox1.Show();
					Blacken(pictureBox8, Reenter);
					textBox1.Focus();
				}
			}
			else
				timer1_counter2 += 5;

		}
		private void timer2_Tick(System.Object sender, System.EventArgs e)
		{
			if (timer2_counter2 == 120)
			{
				if (curr_loc != Password_Textbox.Location.Y)
				{
					if (timer2_counter == 70)
					{
						timer2_counter2 = 0;
						timer2_counter = 0;
						timer2.Stop();
						Reenter.Hide();
						pictureBox7.Hide();
						pictureBox8.Hide();
						textBox1.Hide();
						textBox1.Text = "";
						Green(Password_pictureBox, label9);
						Blacken(pictureBox8, Reenter);
						Reenter_error_label.Hide();
					}
					timer2_counter += 10;
					Password_Textbox.Location = new System.Drawing.Point(Password_Textbox.Location.X, Password_Textbox.Location.Y + 15);
					Password_label_error.Location = new System.Drawing.Point(Password_label_error.Location.X, Password_label_error.Location.Y + 15);
					Password_pictureBox.Location = new System.Drawing.Point(Password_pictureBox.Location.X, Password_pictureBox.Location.Y + 15);
					pictureBox3.Location = new System.Drawing.Point(pictureBox3.Location.X, pictureBox3.Location.Y + 15);
					label9.Location = new System.Drawing.Point(label9.Location.X, label9.Location.Y + 15);


				}
			}
			else
				timer2_counter2 += 5;
		}
		private void textBox1_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (textBox1.Text == Password_Textbox.Text)
			{
				Green(pictureBox8, Reenter);
				this.ActiveControl = Reenter;
				timer2.Start();
			}

		}
		private void timer3_Tick(System.Object sender, System.EventArgs e)
		{
		}
		private void textBox1_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (textBox1.Text == "")
			{
				Red(pictureBox8, Reenter);
				Reenter_error_label.Text = "Passwords do not match";
				Reenter_error_label.Show();
				e.Cancel = true;
			}
			if (Reenter.ForeColor == Color.FromArgb(255, 0, 0))
			{
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
			}
		}
		private void Email_Textbox_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			string new_email = Email_Textbox.Text;
			string s_old_email = old_email;
			bool test_email = false;
			email_error_label.Text = "";
			string[] domains = { "gmail.com", "outlook.com", "yahoo.com", "hotmail.com", "icloud.com", "cis.asu.edu.eg" };
			int at_index = new_email.IndexOf("@");
			if (new_email != s_old_email)
			{
				string email_username = new_email.Substring(0, at_index);
				for (int i = 0; i < at_index; i++)
				{
					if (email_username[i] != '.' && !Char.IsLetterOrDigit(email_username[i]))
					{
						test_email = false;
						test_email = false;
						if (Email_label.Visible)
						{
							Red(Email_picturebox, Email_label);
							email_error_label.Text = "Invalid email\n";
							email_error_label.Show();
						}
						else
						{
							email_error_label2.Text = "Invalid email\n";
							email_error_label2.Show();
						}
						e.Cancel = true;
						break;
					}
					else
					{
						test_email = true;
						if (Email_label.Visible)
						{
							Blacken(Email_picturebox, Email_label);

						}
						else
							e.Cancel = false;
					}
				}
				if (test_email)
				{
					for (int i = 0; i < 6; i++)
					{
						if (new_email.IndexOf(domains[i], at_index) == -1)
						{
							test_email = false;
							if (Email_label.Visible)
							{
								Red(Email_picturebox, Email_label);
								email_error_label.Text = "Invalid email\n";
								email_error_label.Show();
							}
							else
							{
								email_error_label2.Text = "Invalid email\n";
								email_error_label2.Show();
							}
							e.Cancel = true;
						}
						else
						{
							test_email = true;
							if (Email_label.Visible)
							{
								Blacken(Email_picturebox, Email_label);

							}
							else
								e.Cancel = false;
							break;
						}
					}
				}
				string org = "";
				for (int j = 0; j < new_email.Length; j++)
				{
					if (Char.IsLetter(new_email[j]))
						org += Char.ToLower(new_email[j]);
					else
					{
						org += new_email[j];
					}
				}
				if (test_email)
				{
					for (int i = 0; i < EMAILS.Count; i++)
					{
						string u = EMAILS[i];
						string org2 = "";
						for (int j = 0; j < u.Length; j++)
						{
							if (Char.IsLetter(u[j]))
								org2 += Char.ToLower(u[j]);
							else
							{
								org2 += u[j];
							}
						}
						if (org == org2)
						{
							if (Email_label.Visible)
							{
								Red(Email_picturebox, Email_label);
								email_error_label.Text = "This E-mail is already taken\n";
								email_error_label.Show();
							}
							else
							{
								email_error_label2.Text = "This E-mail is already taken\n";
								email_error_label2.Show();
							}
							e.Cancel = true;
							break;
						}
						else
						{
							if (Email_label.Visible)
							{
								Green(Email_picturebox, Email_label);
								email_error_label.Hide();
							}
							else
							{
								email_error_label2.Hide();
							}
							e.Cancel = false;
							Email_Textbox.Text = org;
						}

					}

				}
			}
			else
			{
				if (Email_label.Visible)
				{
					Blacken(Email_picturebox, Email_label);

				}
				else
					changed = false;
			}
		}

		private void SecurityGbox_Enter(System.Object sender, System.EventArgs e)
		{
		}
		private void Vemail_pictureBox_Click(System.Object sender, System.EventArgs e)
		{
		}
		private void siticoneNumericUpDown1_ValueChanged(System.Object sender, System.EventArgs e)
		{
		}
		private void Delete_button_Click(System.Object sender, System.EventArgs e)
		{
			Delete_choice = true;
			this.Close();
		}
		private void step2_code_Textbox_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && this.Visible)
			{
				Send_code_button.PerformClick();
			}
		}
		private void NotificationGbox_Enter(System.Object sender, System.EventArgs e)
		{
		}

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>

		#endregion

		private Button button1;

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
		
		//public static void Notification(string id, string PaymentType,string PaymentAmount,string PaymentDueDate)
  //      {
  //          string email = getCustomerFromDataBase(id, "EMAIL", "Customer");
  //          string NationalID = getCustomerFromDataBase(id, "NationalID", "Customer");
  //          string Name = getCustomerFromDataBase(id, "FirstName", "Customer")+" "+getCustomerFromDataBase(id, "LastName", "Customer");
		//	string from, pass, MessageBody;
  //          MailMessage message = new MailMessage();
  //          from = "selfdiagnosissupp@gmail.com";
  //          pass = "eomootfkfmpefvut";
  //          MessageBody = $"This is the receipt for your latest Bill Payment:\nName: '{Name}'\nNational ID: '{NationalID}'\nPayment Due Date: '{PaymentDueDate}'\nPayment Type: '{PaymentType}'\nAmount Paid: '{PaymentAmount}'\nThank you for using our System ";
  //          String From = new String(from);
  //          String MB = new String(MessageBody);
  //          String To;
  //          String Pass = new String(pass);
  //          message.From = new MailAddress(From);
  //          message.Body = MB;
  //          message.Subject = "Bill Payment.";
  //          To = email;
  //          SmtpClient smtp = new SmtpClient("smtp.gmail.com");
  //          smtp.EnableSsl = true;
  //          message.To.Add(To);
  //          smtp.Port = 587;
  //          smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
  //          smtp.Credentials = new NetworkCredential(From, Pass);
  //          try
  //          {
  //              smtp.SendMailAsync(message);
  //              message.To.Clear();
  //          }
  //          catch (Exception ex)
  //          {
  //          }

  //      }


        //public static bool Forget_Password(string id)
        //      {
        //	bool Password_Changed = false;
        //	string email=getCustomerFromDataBase( id,  "EMAIL","Customer");
        //          string from, pass, MessageBody;
        //          Random rd = new Random();
        //          string randCode = rd.Next(1000000, 10000000).ToString();
        //          MailMessage message = new MailMessage();
        //          from = "selfdiagnosissupp@gmail.com";
        //          pass = "eomootfkfmpefvut";
        //          MessageBody = "Your Password Change Code is " + randCode + " .";
        //          String From = new String(from);
        //          String MB = new String(MessageBody);
        //          String To;
        //          String Pass = new String(pass);
        //          message.From = new MailAddress(From);
        //          message.Body = MB;
        //          message.Subject = "Change Password";
        //          To = email;
        //          SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        //          smtp.EnableSsl = true;
        //          message.To.Add(To);
        //          smtp.Port = 587;
        //          smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //          smtp.Credentials = new NetworkCredential(From, Pass);
        //	try
        //	{
        //		smtp.SendMailAsync(message);
        //		message.To.Clear();
        //	}
        //	catch (Exception ex)
        //	{
        //	}
        //	ForgotPassword fp = new ForgotPassword(id, randCode);
        //	fp.ShowDialog();
        //	return fp.getPassword_Changed();
        //          }


        //public static bool TwoStep(string id)
        //{
        //	string email=getCustomerFromDataBase( id,  "EMAIL","Customer");
        //	string from, pass, MessageBody;
        //	Random rd = new Random();
        //	string randCode = rd.Next(1000000, 10000000).ToString();
        //	MailMessage message = new MailMessage();
        //	from = "selfdiagnosissupp@gmail.com";
        //	pass = "eomootfkfmpefvut";
        //	MessageBody = "Your 2 Step Verification Code is " + randCode + " .";
        //	String From = new String(from);
        //	String MB = new String(MessageBody);
        //	String To;
        //	String Pass = new String(pass);
        //	message.From = new MailAddress(From);
        //	message.Body = MB;
        //	message.Subject = "2 Step Verification";
        //	To =email;
        //	SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        //	smtp.EnableSsl = true;
        //	message.To.Add(To);
        //	smtp.Port = 587;
        //	smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //	smtp.Credentials = new NetworkCredential(From, Pass);
        //	try
        //	{
        //		smtp.SendMailAsync(message);
        //		message.To.Clear();
        //	}
        //	catch (Exception ex)
        //	{

        //	}
        //	Two_Step sc = new Two_Step(randCode);
        //	sc.ShowDialog();
        //	Login_Form.Show();
        //	return sc.getStep() == 'T';
        //}
        //public static string getCustomerFromDataBase(string id, string columnName, string tableName)
        //{
        //	OracleCommand c = new OracleCommand();
        //	c.Connection = conn;
        //	c.CommandText = $"select '{columnName}' from'{tableName}' where CustomerID= '{id}';";
        //	c.CommandType = CommandType.Text;
        //	OracleDataReader dr = c.ExecuteReader();
        //	if (dr.Read())
        //	{
        //		return dr[0].ToString();
        //	}
        //	return "";
        //}
    }
}