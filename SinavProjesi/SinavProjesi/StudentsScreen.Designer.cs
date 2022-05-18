namespace SinavProjesi
{
    partial class StudentsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsScreen));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnResult = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExam = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pctUser = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(155, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(904, 441);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(600, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(600, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Silver;
            this.LeftPanel.Controls.Add(this.btnResult);
            this.LeftPanel.Controls.Add(this.btnExam);
            this.LeftPanel.Controls.Add(this.btnAccount);
            this.LeftPanel.Controls.Add(this.pnlLine);
            this.LeftPanel.Controls.Add(this.lblUserName);
            this.LeftPanel.Controls.Add(this.pctUser);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(155, 504);
            this.LeftPanel.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.BorderRadius = 20;
            this.btnResult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResult.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResult.FillColor = System.Drawing.Color.Teal;
            this.btnResult.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(10, 300);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(126, 45);
            this.btnResult.TabIndex = 11;
            this.btnResult.Text = "My Results";
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnExam
            // 
            this.btnExam.BorderRadius = 20;
            this.btnExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExam.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExam.FillColor = System.Drawing.Color.Teal;
            this.btnExam.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExam.ForeColor = System.Drawing.Color.White;
            this.btnExam.Location = new System.Drawing.Point(10, 223);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(126, 45);
            this.btnExam.TabIndex = 10;
            this.btnExam.Text = "Exams";
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BorderRadius = 20;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.Teal;
            this.btnAccount.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(10, 148);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(126, 45);
            this.btnAccount.TabIndex = 9;
            this.btnAccount.Text = "Account";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.White;
            this.pnlLine.Location = new System.Drawing.Point(10, 63);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(180, 1);
            this.pnlLine.TabIndex = 8;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(37, 16);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 17);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User Name";
            // 
            // pctUser
            // 
            this.pctUser.BackColor = System.Drawing.Color.Transparent;
            this.pctUser.Image = ((System.Drawing.Image)(resources.GetObject("pctUser.Image")));
            this.pctUser.Location = new System.Drawing.Point(7, 8);
            this.pctUser.Margin = new System.Windows.Forms.Padding(2);
            this.pctUser.Name = "pctUser";
            this.pctUser.Size = new System.Drawing.Size(30, 32);
            this.pctUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUser.TabIndex = 7;
            this.pctUser.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Silver;
            this.TopPanel.Controls.Add(this.guna2ControlBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(155, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(904, 63);
            this.TopPanel.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(874, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 19);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "If you want to shine like the sun, first burn like the sun";
            // 
            // StudentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 504);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsScreen";
            this.Text = "StudentsScreen";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        public Guna.UI2.WinForms.Guna2GradientPanel LeftPanel;
        public Guna.UI2.WinForms.Guna2GradientButton btnExam;
        public Guna.UI2.WinForms.Guna2GradientButton btnAccount;
        private System.Windows.Forms.Panel pnlLine;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pctUser;
        private System.Windows.Forms.Panel TopPanel;
        public Guna.UI2.WinForms.Guna2GradientButton btnResult;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label3;
    }
}