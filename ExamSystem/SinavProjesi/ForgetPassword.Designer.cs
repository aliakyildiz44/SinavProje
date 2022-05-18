namespace SinavProjesi
{
    partial class ForgetPassword
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
            this.SendButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailForgotTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Animated = true;
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.BorderRadius = 10;
            this.SendButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(320, 303);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(160, 66);
            this.SendButton.TabIndex = 11;
            this.SendButton.Text = "Send";
            this.SendButton.UseTransparentBackground = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please enter your e-mail address";
            // 
            // emailForgotTxt
            // 
            this.emailForgotTxt.Animated = true;
            this.emailForgotTxt.BorderColor = System.Drawing.Color.White;
            this.emailForgotTxt.BorderRadius = 15;
            this.emailForgotTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailForgotTxt.DefaultText = "";
            this.emailForgotTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailForgotTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailForgotTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailForgotTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailForgotTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.emailForgotTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailForgotTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailForgotTxt.ForeColor = System.Drawing.Color.White;
            this.emailForgotTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailForgotTxt.Location = new System.Drawing.Point(212, 192);
            this.emailForgotTxt.Name = "emailForgotTxt";
            this.emailForgotTxt.PasswordChar = '\0';
            this.emailForgotTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.emailForgotTxt.PlaceholderText = "E-mail";
            this.emailForgotTxt.SelectedText = "";
            this.emailForgotTxt.Size = new System.Drawing.Size(376, 60);
            this.emailForgotTxt.TabIndex = 9;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(738, 17);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailForgotTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button SendButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox emailForgotTxt;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}