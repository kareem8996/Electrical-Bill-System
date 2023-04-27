namespace WinFormsApp6
{
	public partial class Camera_winform : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code


		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent()
		{
			//System.ComponentModel.ComponentResourceManager resources = (new System.ComponentModel.ComponentResourceManager(Camera_winform.typeid));
			this.pictureBox1 = (new System.Windows.Forms.PictureBox());
			this.Username_label = (new System.Windows.Forms.Label());
			this.Capture_button = (new Siticone.Desktop.UI.WinForms.SiticoneButton());
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(106, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(490, 349);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Username_label
			// 
			this.Username_label.AutoSize = true;
			this.Username_label.Location = new System.Drawing.Point(634, 17);
			this.Username_label.Name = "Username_label";
			this.Username_label.Size = new System.Drawing.Size(12, 17);
			this.Username_label.TabIndex = 3;
			this.Username_label.Text = " ";
			// 
			// Capture_button
			// 
			this.Capture_button.BackColor = System.Drawing.SystemColors.Control;
			this.Capture_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Capture_button.BorderRadius = 15;
			this.Capture_button.BorderThickness = 2;
			this.Capture_button.CheckedState.Parent = this.Capture_button;
			this.Capture_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Capture_button.CustomImages.Parent = this.Capture_button;
			this.Capture_button.FillColor = System.Drawing.Color.Transparent;
			this.Capture_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Capture_button.ForeColor = System.Drawing.Color.Black;
			//this.Capture_button.HoveredState.Parent = this.Capture_button;
			this.Capture_button.Location = new System.Drawing.Point(289, 392);
			this.Capture_button.Name = "Capture_button";
			this.Capture_button.PressedColor = System.Drawing.Color.WhiteSmoke;
			this.Capture_button.PressedDepth = 50;
			this.Capture_button.ShadowDecoration.Parent = this.Capture_button;
			this.Capture_button.Size = new System.Drawing.Size(102, 40);
			this.Capture_button.TabIndex = 89;
			this.Capture_button.Text = "Capture";
			this.Capture_button.Click += new System.EventHandler(this.Capture_button_Click);
			// 
			// Camera_winform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7, 16);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 471);
			this.Controls.Add(this.Capture_button);
			this.Controls.Add(this.Username_label);
			this.Controls.Add(this.pictureBox1);
			//this.Icon = (cli.safe_cast<System.Drawing.Icon>(resources.GetObject("$this.Icon")));
			this.Name = "Camera_winform";
			this.Text = "Camera_winform";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camera_winform_FormClosing);
			this.Load += new System.EventHandler(this.Camera_winform_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}