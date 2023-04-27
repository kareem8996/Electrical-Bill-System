namespace WinFormsApp6
{
    partial class ForgotPassword
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Code_Password_textBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Code_Password_label = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Reenter_Password_label = new System.Windows.Forms.Label();
            this.Reenter_Password_textBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            // 
            // Code_Password_textBox
            // 
            this.Code_Password_textBox.DefaultText = "";
            this.Code_Password_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Code_Password_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Code_Password_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Code_Password_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Code_Password_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Code_Password_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Code_Password_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Code_Password_textBox.Location = new System.Drawing.Point(154, 93);
            this.Code_Password_textBox.Name = "Code_Password_textBox";
            this.Code_Password_textBox.PasswordChar = '\0';
            this.Code_Password_textBox.PlaceholderText = "";
            this.Code_Password_textBox.SelectedText = "";
            this.Code_Password_textBox.Size = new System.Drawing.Size(250, 39);
            this.Code_Password_textBox.TabIndex = 1;
            // 
            // Code_Password_label
            // 
            this.Code_Password_label.AutoSize = true;
            this.Code_Password_label.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Code_Password_label.Location = new System.Drawing.Point(154, 59);
            this.Code_Password_label.Name = "Code_Password_label";
            this.Code_Password_label.Size = new System.Drawing.Size(58, 25);
            this.Code_Password_label.TabIndex = 0;
            this.Code_Password_label.Text = "Code:";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(231, 254);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(89, 39);
            this.siticoneButton1.TabIndex = 2;
            this.siticoneButton1.Text = "Verify";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // Reenter_Password_label
            // 
            this.Reenter_Password_label.AutoSize = true;
            this.Reenter_Password_label.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reenter_Password_label.Location = new System.Drawing.Point(154, 147);
            this.Reenter_Password_label.Name = "Reenter_Password_label";
            this.Reenter_Password_label.Size = new System.Drawing.Size(155, 25);
            this.Reenter_Password_label.TabIndex = 0;
            this.Reenter_Password_label.Text = "Reenter Password:";
            // 
            // Reenter_Password_textBox
            // 
            this.Reenter_Password_textBox.DefaultText = "";
            this.Reenter_Password_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Reenter_Password_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Reenter_Password_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Reenter_Password_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Reenter_Password_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Reenter_Password_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reenter_Password_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Reenter_Password_textBox.Location = new System.Drawing.Point(154, 181);
            this.Reenter_Password_textBox.Name = "Reenter_Password_textBox";
            this.Reenter_Password_textBox.PasswordChar = '\0';
            this.Reenter_Password_textBox.PlaceholderText = "";
            this.Reenter_Password_textBox.SelectedText = "";
            this.Reenter_Password_textBox.Size = new System.Drawing.Size(250, 39);
            this.Reenter_Password_textBox.TabIndex = 1;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 403);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.Reenter_Password_textBox);
            this.Controls.Add(this.Reenter_Password_label);
            this.Controls.Add(this.Code_Password_textBox);
            this.Controls.Add(this.Code_Password_label);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Code_Password_textBox;
        private Label Code_Password_label;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Label Reenter_Password_label;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Reenter_Password_textBox;
    }
}