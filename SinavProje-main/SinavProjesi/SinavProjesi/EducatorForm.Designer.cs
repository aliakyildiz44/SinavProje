
namespace SinavProjesi
{
    partial class EducatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducatorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEducator = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewDeleteQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.updateQuestions_UC1 = new SinavProjesi.Educator_UC.UpdateQuestions_UC();
            this.addNewQuestions_UC1 = new SinavProjesi.Educator_UC.AddNewQuestions_UC();
            this.viewAndDelete_UC1 = new SinavProjesi.Educator_UC.ViewAndDelete_UC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.btnUpdateQuestions);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.btnAddNewQuestion);
            this.panel1.Controls.Add(this.btnViewDeleteQuestions);
            this.panel1.Controls.Add(this.lblEducator);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // lblEducator
            // 
            this.lblEducator.AutoSize = true;
            this.lblEducator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducator.Location = new System.Drawing.Point(59, 229);
            this.lblEducator.Name = "lblEducator";
            this.lblEducator.Size = new System.Drawing.Size(169, 40);
            this.lblEducator.TabIndex = 1;
            this.lblEducator.Text = "Educator";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.viewAndDelete_UC1);
            this.panel2.Controls.Add(this.updateQuestions_UC1);
            this.panel2.Controls.Add(this.addNewQuestions_UC1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 768);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.LimeGreen;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(12, 715);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 46);
            this.btnExit.TabIndex = 7;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.Location = new System.Drawing.Point(11, 582);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(263, 45);
            this.guna2Button5.TabIndex = 6;
            this.guna2Button5.Text = "Log Out";
            // 
            // btnUpdateQuestions
            // 
            this.btnUpdateQuestions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateQuestions.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateQuestions.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateQuestions.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuestions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateQuestions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateQuestions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateQuestions.FillColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateQuestions.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuestions.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateQuestions.Image")));
            this.btnUpdateQuestions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateQuestions.Location = new System.Drawing.Point(11, 372);
            this.btnUpdateQuestions.Name = "btnUpdateQuestions";
            this.btnUpdateQuestions.Size = new System.Drawing.Size(263, 45);
            this.btnUpdateQuestions.TabIndex = 3;
            this.btnUpdateQuestions.Text = "Update Question";
            this.btnUpdateQuestions.Click += new System.EventHandler(this.btnUpdateQuestions_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button4.Location = new System.Drawing.Point(11, 511);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(263, 45);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "All Student Result";
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewQuestion.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewQuestion.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewQuestion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewQuestion.Image")));
            this.btnAddNewQuestion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewQuestion.Location = new System.Drawing.Point(11, 305);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(263, 45);
            this.btnAddNewQuestion.TabIndex = 2;
            this.btnAddNewQuestion.Text = "Add New Question";
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // btnViewDeleteQuestions
            // 
            this.btnViewDeleteQuestions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewDeleteQuestions.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDeleteQuestions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDeleteQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDeleteQuestions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDeleteQuestions.FillColor = System.Drawing.Color.LimeGreen;
            this.btnViewDeleteQuestions.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeleteQuestions.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDeleteQuestions.Image")));
            this.btnViewDeleteQuestions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewDeleteQuestions.Location = new System.Drawing.Point(12, 442);
            this.btnViewDeleteQuestions.Name = "btnViewDeleteQuestions";
            this.btnViewDeleteQuestions.Size = new System.Drawing.Size(263, 47);
            this.btnViewDeleteQuestions.TabIndex = 4;
            this.btnViewDeleteQuestions.Text = "View and Delete Questions";
            this.btnViewDeleteQuestions.Click += new System.EventHandler(this.btnViewDeleteQuestions_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // updateQuestions_UC1
            // 
            this.updateQuestions_UC1.BackColor = System.Drawing.Color.White;
            this.updateQuestions_UC1.Location = new System.Drawing.Point(-1, 0);
            this.updateQuestions_UC1.Name = "updateQuestions_UC1";
            this.updateQuestions_UC1.Size = new System.Drawing.Size(1095, 768);
            this.updateQuestions_UC1.TabIndex = 2;
            // 
            // addNewQuestions_UC1
            // 
            this.addNewQuestions_UC1.BackColor = System.Drawing.Color.White;
            this.addNewQuestions_UC1.ForeColor = System.Drawing.Color.Black;
            this.addNewQuestions_UC1.Location = new System.Drawing.Point(-2, 0);
            this.addNewQuestions_UC1.Name = "addNewQuestions_UC1";
            this.addNewQuestions_UC1.Size = new System.Drawing.Size(1093, 768);
            this.addNewQuestions_UC1.TabIndex = 1;
            this.addNewQuestions_UC1.Load += new System.EventHandler(this.addNewQuestions_UC1_Load);
            // 
            // viewAndDelete_UC1
            // 
            this.viewAndDelete_UC1.BackColor = System.Drawing.Color.White;
            this.viewAndDelete_UC1.Location = new System.Drawing.Point(-1, 0);
            this.viewAndDelete_UC1.Name = "viewAndDelete_UC1";
            this.viewAndDelete_UC1.Size = new System.Drawing.Size(1095, 768);
            this.viewAndDelete_UC1.TabIndex = 3;
            // 
            // EducatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EducatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.EducatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnUpdateQuestions;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnAddNewQuestion;
        private Guna.UI2.WinForms.Guna2Button btnViewDeleteQuestions;
        private System.Windows.Forms.Label lblEducator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Educator_UC.AddNewQuestions_UC addNewQuestions_UC1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Educator_UC.UpdateQuestions_UC updateQuestions_UC1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Educator_UC.ViewAndDelete_UC viewAndDelete_UC1;
    }
}