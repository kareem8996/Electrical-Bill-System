#pragma once

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
	using System;
	using System.ComponentModel;
	using System.Collections;
	using System.Windows.Forms;
	using System.Data;
	using System.Drawing;

	/// <summary>
	/// Summary for Camera_winform
	/// </summary>
	public partial class Camera_winform : System.Windows.Forms.Form
	{

		private Siticone.Desktop.UI.WinForms.SiticoneButton Capture_button;
		public
			Camera MyCamera = new Camera();
		public Camera_winform(string username)
		{
			InitializeComponent();
			String uname = username;
			Username_label.Text = uname;
			MyCamera.OnFrameArrived += new FrameArrivedEventHandler(this.MyCamera_OnFrameArrived);
			MyCamera.Start(0);
			Username_label.Hide();
			//
			//TODO: Add the constructor code here
			//
		}
		void MyCamera_OnFrameArrived(Object source, FrameArrivedEventArgs e)
		{
			Image img = e.GetFrame();
			pictureBox1.Image = img;
		}


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>

		private System.Windows.Forms.PictureBox pictureBox1;



		private System.Windows.Forms.Label Username_label;

		private void Camera_winform_Load(System.Object sender, System.EventArgs e)
		{
		}
		private void Capture_button_Click(System.Object sender, System.EventArgs e)
		{
			if (Capture_button.Text == "Capture")
			{
				MyCamera.Stop();
				string username = Username_label.Text;
				string wow = "C:\\Users\\karee\\Desktop\\PICs\\" + username + ".jpg";
				String str3 = wow;
				pictureBox1.Image.Save(str3, ImageFormat.Jpeg);
				Capture_button.Text = "Retake";
			}
			else
			{
				MyCamera.Start(0);
				Capture_button.Text = "Capture";
			}
		}
		private void Save_button_Click(System.Object sender, System.EventArgs e)
		{

		}
		private void Camera_winform_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			MyCamera.Stop();
		}
	};
}
