﻿
namespace SinavProjesi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.studentButton = new Guna.UI2.WinForms.Guna2Button();
            this.hidePasswordPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.showPasswordPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.KaydirmaPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.LoginPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.SignUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.SignUpPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nameSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.signUp2Button = new Guna.UI2.WinForms.Guna2Button();
            this.userNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConfirmPasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordRegisterTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailRegisterTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ForgotTextBox = new System.Windows.Forms.Label();
            this.RememberTextBox = new System.Windows.Forms.Label();
            this.passwordLoginTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.RememberSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.emailLoginTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.userCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasswordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordPicture)).BeginInit();
            this.KaydirmaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.LoginPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.LoginPanel.Controls.Add(this.userCombo);
            this.LoginPanel.Controls.Add(this.studentButton);
            this.LoginPanel.Controls.Add(this.hidePasswordPicture);
            this.LoginPanel.Controls.Add(this.showPasswordPicture);
            this.LoginPanel.Controls.Add(this.KaydirmaPanel);
            this.LoginPanel.Controls.Add(this.ForgotTextBox);
            this.LoginPanel.Controls.Add(this.RememberTextBox);
            this.LoginPanel.Controls.Add(this.passwordLoginTxt);
            this.LoginPanel.Controls.Add(this.RememberSwitch);
            this.LoginPanel.Controls.Add(this.emailLoginTxt);
            this.LoginPanel.Controls.Add(this.guna2PictureBox1);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(555, 906);
            this.LoginPanel.TabIndex = 3;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // studentButton
            // 
            this.studentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentButton.ForeColor = System.Drawing.Color.White;
            this.studentButton.Location = new System.Drawing.Point(184, 697);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(165, 46);
            this.studentButton.TabIndex = 12;
            this.studentButton.Text = "Login Student";
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // hidePasswordPicture
            // 
            this.hidePasswordPicture.Image = ((System.Drawing.Image)(resources.GetObject("hidePasswordPicture.Image")));
            this.hidePasswordPicture.ImageRotate = 0F;
            this.hidePasswordPicture.Location = new System.Drawing.Point(492, 511);
            this.hidePasswordPicture.Name = "hidePasswordPicture";
            this.hidePasswordPicture.Size = new System.Drawing.Size(42, 60);
            this.hidePasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePasswordPicture.TabIndex = 11;
            this.hidePasswordPicture.TabStop = false;
            this.hidePasswordPicture.Click += new System.EventHandler(this.hidePasswordPicture_Click);
            // 
            // showPasswordPicture
            // 
            this.showPasswordPicture.Image = ((System.Drawing.Image)(resources.GetObject("showPasswordPicture.Image")));
            this.showPasswordPicture.ImageRotate = 0F;
            this.showPasswordPicture.Location = new System.Drawing.Point(492, 459);
            this.showPasswordPicture.Name = "showPasswordPicture";
            this.showPasswordPicture.Size = new System.Drawing.Size(42, 60);
            this.showPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPasswordPicture.TabIndex = 10;
            this.showPasswordPicture.TabStop = false;
            this.showPasswordPicture.Click += new System.EventHandler(this.showPasswordPicture_Click);
            // 
            // KaydirmaPanel
            // 
            this.KaydirmaPanel.Controls.Add(this.LoginPicture);
            this.KaydirmaPanel.Controls.Add(this.LoginButton);
            this.KaydirmaPanel.Controls.Add(this.SignUpButton);
            this.KaydirmaPanel.Controls.Add(this.SignUpPanel);
            this.KaydirmaPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KaydirmaPanel.Location = new System.Drawing.Point(0, 771);
            this.KaydirmaPanel.Name = "KaydirmaPanel";
            this.KaydirmaPanel.Size = new System.Drawing.Size(555, 135);
            this.KaydirmaPanel.TabIndex = 9;
            // 
            // LoginPicture
            // 
            this.LoginPicture.Image = ((System.Drawing.Image)(resources.GetObject("LoginPicture.Image")));
            this.LoginPicture.ImageRotate = 0F;
            this.LoginPicture.Location = new System.Drawing.Point(173, 3);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(218, 127);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPicture.TabIndex = 15;
            this.LoginPicture.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderRadius = 10;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(6, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(161, 66);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseTransparentBackground = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Animated = true;
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignUpButton.BorderRadius = 10;
            this.SignUpButton.BorderThickness = 3;
            this.SignUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUpButton.FillColor = System.Drawing.Color.Empty;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(397, 53);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(161, 66);
            this.SignUpButton.TabIndex = 8;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseTransparentBackground = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.White;
            this.SignUpPanel.Controls.Add(this.guna2ComboBox1);
            this.SignUpPanel.Controls.Add(this.nameSurname);
            this.SignUpPanel.Controls.Add(this.nameTxt);
            this.SignUpPanel.Controls.Add(this.signUp2Button);
            this.SignUpPanel.Controls.Add(this.userNameTxt);
            this.SignUpPanel.Controls.Add(this.ConfirmPasswordTxt);
            this.SignUpPanel.Controls.Add(this.passwordRegisterTxt);
            this.SignUpPanel.Controls.Add(this.emailRegisterTxt);
            this.SignUpPanel.ForeColor = System.Drawing.Color.White;
            this.SignUpPanel.Location = new System.Drawing.Point(3, 142);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(555, 752);
            this.SignUpPanel.TabIndex = 12;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 15;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.White;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Student",
            "Educator"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(99, 547);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(376, 36);
            this.guna2ComboBox1.TabIndex = 11;
            // 
            // nameSurname
            // 
            this.nameSurname.Animated = true;
            this.nameSurname.BorderColor = System.Drawing.Color.White;
            this.nameSurname.BorderRadius = 15;
            this.nameSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameSurname.DefaultText = "";
            this.nameSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameSurname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.nameSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameSurname.ForeColor = System.Drawing.Color.White;
            this.nameSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameSurname.Location = new System.Drawing.Point(99, 190);
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.PasswordChar = '\0';
            this.nameSurname.PlaceholderForeColor = System.Drawing.Color.White;
            this.nameSurname.PlaceholderText = "Surname";
            this.nameSurname.SelectedText = "";
            this.nameSurname.Size = new System.Drawing.Size(376, 60);
            this.nameSurname.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Animated = true;
            this.nameTxt.BorderColor = System.Drawing.Color.White;
            this.nameTxt.BorderRadius = 15;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTxt.ForeColor = System.Drawing.Color.White;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.Location = new System.Drawing.Point(96, 103);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.nameTxt.PlaceholderText = "Name";
            this.nameTxt.SelectedText = "";
            this.nameTxt.Size = new System.Drawing.Size(376, 60);
            this.nameTxt.TabIndex = 1;
            // 
            // signUp2Button
            // 
            this.signUp2Button.Animated = true;
            this.signUp2Button.BackColor = System.Drawing.Color.Transparent;
            this.signUp2Button.BorderRadius = 10;
            this.signUp2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUp2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUp2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUp2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUp2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.signUp2Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signUp2Button.ForeColor = System.Drawing.Color.White;
            this.signUp2Button.Location = new System.Drawing.Point(181, 640);
            this.signUp2Button.Name = "signUp2Button";
            this.signUp2Button.Size = new System.Drawing.Size(161, 66);
            this.signUp2Button.TabIndex = 8;
            this.signUp2Button.Text = "Sign Up";
            this.signUp2Button.UseTransparentBackground = true;
            this.signUp2Button.Click += new System.EventHandler(this.signUp2Button_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.Animated = true;
            this.userNameTxt.BorderColor = System.Drawing.Color.White;
            this.userNameTxt.BorderRadius = 15;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.DefaultText = "";
            this.userNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.userNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userNameTxt.ForeColor = System.Drawing.Color.White;
            this.userNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxt.Location = new System.Drawing.Point(96, 16);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.PasswordChar = '\0';
            this.userNameTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.userNameTxt.PlaceholderText = "User Name";
            this.userNameTxt.SelectedText = "";
            this.userNameTxt.Size = new System.Drawing.Size(376, 60);
            this.userNameTxt.TabIndex = 0;
            // 
            // ConfirmPasswordTxt
            // 
            this.ConfirmPasswordTxt.Animated = true;
            this.ConfirmPasswordTxt.BorderColor = System.Drawing.Color.White;
            this.ConfirmPasswordTxt.BorderRadius = 15;
            this.ConfirmPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPasswordTxt.DefaultText = "";
            this.ConfirmPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPasswordTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.ConfirmPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmPasswordTxt.ForeColor = System.Drawing.Color.White;
            this.ConfirmPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPasswordTxt.Location = new System.Drawing.Point(96, 453);
            this.ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            this.ConfirmPasswordTxt.PasswordChar = '*';
            this.ConfirmPasswordTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.ConfirmPasswordTxt.PlaceholderText = "Confirm Password";
            this.ConfirmPasswordTxt.SelectedText = "";
            this.ConfirmPasswordTxt.Size = new System.Drawing.Size(376, 60);
            this.ConfirmPasswordTxt.TabIndex = 5;
            // 
            // passwordRegisterTxt
            // 
            this.passwordRegisterTxt.Animated = true;
            this.passwordRegisterTxt.BorderColor = System.Drawing.Color.White;
            this.passwordRegisterTxt.BorderRadius = 15;
            this.passwordRegisterTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordRegisterTxt.DefaultText = "";
            this.passwordRegisterTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordRegisterTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordRegisterTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordRegisterTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordRegisterTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.passwordRegisterTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordRegisterTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordRegisterTxt.ForeColor = System.Drawing.Color.White;
            this.passwordRegisterTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordRegisterTxt.Location = new System.Drawing.Point(96, 365);
            this.passwordRegisterTxt.Name = "passwordRegisterTxt";
            this.passwordRegisterTxt.PasswordChar = '*';
            this.passwordRegisterTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordRegisterTxt.PlaceholderText = "Password";
            this.passwordRegisterTxt.SelectedText = "";
            this.passwordRegisterTxt.Size = new System.Drawing.Size(376, 60);
            this.passwordRegisterTxt.TabIndex = 4;
            // 
            // emailRegisterTxt
            // 
            this.emailRegisterTxt.Animated = true;
            this.emailRegisterTxt.BorderColor = System.Drawing.Color.White;
            this.emailRegisterTxt.BorderRadius = 15;
            this.emailRegisterTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailRegisterTxt.DefaultText = "";
            this.emailRegisterTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailRegisterTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailRegisterTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailRegisterTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailRegisterTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.emailRegisterTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailRegisterTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailRegisterTxt.ForeColor = System.Drawing.Color.White;
            this.emailRegisterTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailRegisterTxt.Location = new System.Drawing.Point(99, 278);
            this.emailRegisterTxt.Name = "emailRegisterTxt";
            this.emailRegisterTxt.PasswordChar = '\0';
            this.emailRegisterTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.emailRegisterTxt.PlaceholderText = "E-mail";
            this.emailRegisterTxt.SelectedText = "";
            this.emailRegisterTxt.Size = new System.Drawing.Size(376, 60);
            this.emailRegisterTxt.TabIndex = 3;
            // 
            // ForgotTextBox
            // 
            this.ForgotTextBox.AutoSize = true;
            this.ForgotTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotTextBox.ForeColor = System.Drawing.Color.White;
            this.ForgotTextBox.Location = new System.Drawing.Point(336, 564);
            this.ForgotTextBox.Name = "ForgotTextBox";
            this.ForgotTextBox.Size = new System.Drawing.Size(126, 21);
            this.ForgotTextBox.TabIndex = 6;
            this.ForgotTextBox.Text = "Forgot Password";
            this.ForgotTextBox.Click += new System.EventHandler(this.ForgotTextBox_Click);
            // 
            // RememberTextBox
            // 
            this.RememberTextBox.AutoSize = true;
            this.RememberTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberTextBox.ForeColor = System.Drawing.Color.White;
            this.RememberTextBox.Location = new System.Drawing.Point(191, 564);
            this.RememberTextBox.Name = "RememberTextBox";
            this.RememberTextBox.Size = new System.Drawing.Size(113, 21);
            this.RememberTextBox.TabIndex = 5;
            this.RememberTextBox.Text = "Remember Me";
            // 
            // passwordLoginTxt
            // 
            this.passwordLoginTxt.Animated = true;
            this.passwordLoginTxt.BorderColor = System.Drawing.Color.White;
            this.passwordLoginTxt.BorderRadius = 15;
            this.passwordLoginTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLoginTxt.DefaultText = "";
            this.passwordLoginTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordLoginTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordLoginTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordLoginTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordLoginTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.passwordLoginTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordLoginTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordLoginTxt.ForeColor = System.Drawing.Color.White;
            this.passwordLoginTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordLoginTxt.Location = new System.Drawing.Point(96, 459);
            this.passwordLoginTxt.Name = "passwordLoginTxt";
            this.passwordLoginTxt.PasswordChar = '*';
            this.passwordLoginTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordLoginTxt.PlaceholderText = "Password";
            this.passwordLoginTxt.SelectedText = "";
            this.passwordLoginTxt.Size = new System.Drawing.Size(376, 60);
            this.passwordLoginTxt.TabIndex = 1;
            // 
            // RememberSwitch
            // 
            this.RememberSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RememberSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RememberSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RememberSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RememberSwitch.Location = new System.Drawing.Point(96, 556);
            this.RememberSwitch.Name = "RememberSwitch";
            this.RememberSwitch.Size = new System.Drawing.Size(80, 36);
            this.RememberSwitch.TabIndex = 3;
            this.RememberSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RememberSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RememberSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RememberSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // emailLoginTxt
            // 
            this.emailLoginTxt.Animated = true;
            this.emailLoginTxt.BorderColor = System.Drawing.Color.White;
            this.emailLoginTxt.BorderRadius = 15;
            this.emailLoginTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailLoginTxt.DefaultText = "";
            this.emailLoginTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailLoginTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailLoginTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailLoginTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailLoginTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.emailLoginTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailLoginTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailLoginTxt.ForeColor = System.Drawing.Color.White;
            this.emailLoginTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailLoginTxt.Location = new System.Drawing.Point(96, 355);
            this.emailLoginTxt.Name = "emailLoginTxt";
            this.emailLoginTxt.PasswordChar = '\0';
            this.emailLoginTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.emailLoginTxt.PlaceholderText = "E-mail";
            this.emailLoginTxt.SelectedText = "";
            this.emailLoginTxt.Size = new System.Drawing.Size(376, 60);
            this.emailLoginTxt.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::SinavProjesi.Properties.Resources.pen2_unscreen;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(125, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(309, 173);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(549, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(929, 906);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(830, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(881, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::SinavProjesi.Properties.Resources.background;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(3, 0);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(926, 906);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 1;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::SinavProjesi.Properties.Resources.background;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(3, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(926, 906);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.Red;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.SignUpPanel;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // userCombo
            // 
            this.userCombo.BackColor = System.Drawing.Color.Transparent;
            this.userCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.userCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.userCombo.ItemHeight = 30;
            this.userCombo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.userCombo.Location = new System.Drawing.Point(214, 257);
            this.userCombo.Name = "userCombo";
            this.userCombo.Size = new System.Drawing.Size(177, 36);
            this.userCombo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1478, 906);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasswordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordPicture)).EndInit();
            this.KaydirmaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            this.SignUpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2TextBox emailLoginTxt;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RememberSwitch;
        private Guna.UI2.WinForms.Guna2TextBox passwordLoginTxt;
        private System.Windows.Forms.Label ForgotTextBox;
        private System.Windows.Forms.Label RememberTextBox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2Button SignUpButton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel KaydirmaPanel;
        private Guna.UI2.WinForms.Guna2Panel SignUpPanel;
        private Guna.UI2.WinForms.Guna2Button signUp2Button;
        private Guna.UI2.WinForms.Guna2TextBox userNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordRegisterTxt;
        private Guna.UI2.WinForms.Guna2TextBox emailRegisterTxt;
        private Guna.UI2.WinForms.Guna2PictureBox LoginPicture;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox nameSurname;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2PictureBox showPasswordPicture;
        private Guna.UI2.WinForms.Guna2PictureBox hidePasswordPicture;
        private Guna.UI2.WinForms.Guna2Button studentButton;
        private Guna.UI2.WinForms.Guna2ComboBox userCombo;
    }
}

