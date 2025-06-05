namespace TPR_MoviesLibrary
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            Authorization = new TabPage();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btn_login = new Button();
            txt_password = new TextBox();
            label3 = new Label();
            txt_empl_id = new TextBox();
            label1 = new Label();
            AdminPage = new TabPage();
            cb_searchType = new ComboBox();
            txt_currUser = new Label();
            btn_AddFilm = new Button();
            btn_LoadInfo = new Button();
            dgv_movies = new DataGridView();
            lbl_username = new Label();
            ModeraorPage = new TabPage();
            lbl_verd = new Label();
            cb_verdicts = new ComboBox();
            btn_apply = new Button();
            btn_showReports = new Button();
            dgv_moderator = new DataGridView();
            lbl_username2 = new Label();
            tabControl1.SuspendLayout();
            Authorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            AdminPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_movies).BeginInit();
            ModeraorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_moderator).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Authorization);
            tabControl1.Controls.Add(AdminPage);
            tabControl1.Controls.Add(ModeraorPage);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1164, 647);
            tabControl1.TabIndex = 0;
            // 
            // Authorization
            // 
            Authorization.BackColor = Color.LightGray;
            Authorization.Controls.Add(pictureBox1);
            Authorization.Controls.Add(label4);
            Authorization.Controls.Add(btn_login);
            Authorization.Controls.Add(txt_password);
            Authorization.Controls.Add(label3);
            Authorization.Controls.Add(txt_empl_id);
            Authorization.Controls.Add(label1);
            Authorization.Location = new Point(4, 29);
            Authorization.Name = "Authorization";
            Authorization.Padding = new Padding(3);
            Authorization.Size = new Size(1156, 614);
            Authorization.TabIndex = 0;
            Authorization.Text = "Authorization";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(539, 517);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(823, 101);
            label4.Name = "label4";
            label4.Size = new Size(178, 46);
            label4.TabIndex = 12;
            label4.Text = "WELCOME";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Black;
            btn_login.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(800, 412);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(220, 59);
            btn_login.TabIndex = 11;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = Color.Black;
            txt_password.Location = new Point(744, 318);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(328, 36);
            txt_password.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(744, 275);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 9;
            label3.Text = "Password:";
            // 
            // txt_empl_id
            // 
            txt_empl_id.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_empl_id.ForeColor = Color.Black;
            txt_empl_id.Location = new Point(744, 225);
            txt_empl_id.Name = "txt_empl_id";
            txt_empl_id.Size = new Size(328, 36);
            txt_empl_id.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(744, 179);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 7;
            label1.Text = "Employee ID:";
            // 
            // AdminPage
            // 
            AdminPage.Controls.Add(cb_searchType);
            AdminPage.Controls.Add(txt_currUser);
            AdminPage.Controls.Add(btn_AddFilm);
            AdminPage.Controls.Add(btn_LoadInfo);
            AdminPage.Controls.Add(dgv_movies);
            AdminPage.Controls.Add(lbl_username);
            AdminPage.Location = new Point(4, 29);
            AdminPage.Name = "AdminPage";
            AdminPage.Padding = new Padding(3);
            AdminPage.Size = new Size(1156, 614);
            AdminPage.TabIndex = 1;
            AdminPage.Text = "Admin Page";
            AdminPage.UseVisualStyleBackColor = true;
            // 
            // cb_searchType
            // 
            cb_searchType.FormattingEnabled = true;
            cb_searchType.Items.AddRange(new object[] { "All", "New..." });
            cb_searchType.Location = new Point(967, 51);
            cb_searchType.Name = "cb_searchType";
            cb_searchType.Size = new Size(151, 28);
            cb_searchType.TabIndex = 26;
            // 
            // txt_currUser
            // 
            txt_currUser.AutoSize = true;
            txt_currUser.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_currUser.ForeColor = Color.Navy;
            txt_currUser.Location = new Point(66, 2);
            txt_currUser.Name = "txt_currUser";
            txt_currUser.Size = new Size(0, 30);
            txt_currUser.TabIndex = 25;
            // 
            // btn_AddFilm
            // 
            btn_AddFilm.BackColor = Color.Black;
            btn_AddFilm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddFilm.ForeColor = Color.White;
            btn_AddFilm.Location = new Point(946, 525);
            btn_AddFilm.Name = "btn_AddFilm";
            btn_AddFilm.Size = new Size(191, 58);
            btn_AddFilm.TabIndex = 19;
            btn_AddFilm.Text = "Add Film";
            btn_AddFilm.UseVisualStyleBackColor = false;
            btn_AddFilm.Click += btn_AddFilm_Click;
            // 
            // btn_LoadInfo
            // 
            btn_LoadInfo.BackColor = Color.Black;
            btn_LoadInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LoadInfo.ForeColor = Color.White;
            btn_LoadInfo.Location = new Point(965, 96);
            btn_LoadInfo.Name = "btn_LoadInfo";
            btn_LoadInfo.Size = new Size(153, 68);
            btn_LoadInfo.TabIndex = 15;
            btn_LoadInfo.Text = "Show";
            btn_LoadInfo.UseVisualStyleBackColor = false;
            btn_LoadInfo.Click += btn_LoadInfo_Click;
            // 
            // dgv_movies
            // 
            dgv_movies.AllowUserToAddRows = false;
            dgv_movies.AllowUserToDeleteRows = false;
            dgv_movies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_movies.Location = new Point(3, 51);
            dgv_movies.Name = "dgv_movies";
            dgv_movies.ReadOnly = true;
            dgv_movies.RowHeadersWidth = 51;
            dgv_movies.RowTemplate.Height = 29;
            dgv_movies.Size = new Size(922, 561);
            dgv_movies.TabIndex = 14;
            dgv_movies.CellDoubleClick += dgv_movies_CellDoubleClick;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.Black;
            lbl_username.Location = new Point(6, 2);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(68, 30);
            lbl_username.TabIndex = 13;
            lbl_username.Text = "User: ";
            // 
            // ModeraorPage
            // 
            ModeraorPage.Controls.Add(lbl_verd);
            ModeraorPage.Controls.Add(cb_verdicts);
            ModeraorPage.Controls.Add(btn_apply);
            ModeraorPage.Controls.Add(btn_showReports);
            ModeraorPage.Controls.Add(dgv_moderator);
            ModeraorPage.Controls.Add(lbl_username2);
            ModeraorPage.Location = new Point(4, 29);
            ModeraorPage.Name = "ModeraorPage";
            ModeraorPage.Size = new Size(1156, 614);
            ModeraorPage.TabIndex = 2;
            ModeraorPage.Text = "Moderator Page";
            ModeraorPage.UseVisualStyleBackColor = true;
            // 
            // lbl_verd
            // 
            lbl_verd.AutoSize = true;
            lbl_verd.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_verd.Location = new Point(1003, 422);
            lbl_verd.Name = "lbl_verd";
            lbl_verd.Size = new Size(83, 24);
            lbl_verd.TabIndex = 20;
            lbl_verd.Text = "Verdicts:";
            // 
            // cb_verdicts
            // 
            cb_verdicts.FormattingEnabled = true;
            cb_verdicts.Location = new Point(972, 462);
            cb_verdicts.Name = "cb_verdicts";
            cb_verdicts.Size = new Size(151, 28);
            cb_verdicts.TabIndex = 19;
            // 
            // btn_apply
            // 
            btn_apply.BackColor = Color.Black;
            btn_apply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_apply.ForeColor = Color.White;
            btn_apply.Location = new Point(970, 513);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(153, 68);
            btn_apply.TabIndex = 18;
            btn_apply.Text = "Apply";
            btn_apply.UseVisualStyleBackColor = false;
            btn_apply.Click += btn_apply_Click;
            // 
            // btn_showReports
            // 
            btn_showReports.BackColor = Color.Black;
            btn_showReports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_showReports.ForeColor = Color.White;
            btn_showReports.Location = new Point(965, 62);
            btn_showReports.Name = "btn_showReports";
            btn_showReports.Size = new Size(153, 68);
            btn_showReports.TabIndex = 17;
            btn_showReports.Text = "Load";
            btn_showReports.UseVisualStyleBackColor = false;
            btn_showReports.Click += btn_showReports_Click;
            // 
            // dgv_moderator
            // 
            dgv_moderator.AllowUserToAddRows = false;
            dgv_moderator.AllowUserToDeleteRows = false;
            dgv_moderator.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_moderator.Location = new Point(3, 51);
            dgv_moderator.Name = "dgv_moderator";
            dgv_moderator.ReadOnly = true;
            dgv_moderator.RowHeadersWidth = 51;
            dgv_moderator.RowTemplate.Height = 29;
            dgv_moderator.Size = new Size(922, 561);
            dgv_moderator.TabIndex = 16;
            dgv_moderator.CellDoubleClick += dgv_moderator_CellDoubleClick;
            // 
            // lbl_username2
            // 
            lbl_username2.AutoSize = true;
            lbl_username2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username2.ForeColor = Color.Black;
            lbl_username2.Location = new Point(6, 2);
            lbl_username2.Name = "lbl_username2";
            lbl_username2.Size = new Size(68, 30);
            lbl_username2.TabIndex = 15;
            lbl_username2.Text = "User: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1165, 648);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1183, 695);
            MinimumSize = new Size(1183, 695);
            Name = "MainForm";
            Text = "AbsoluteCinema";
            tabControl1.ResumeLayout(false);
            Authorization.ResumeLayout(false);
            Authorization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            AdminPage.ResumeLayout(false);
            AdminPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_movies).EndInit();
            ModeraorPage.ResumeLayout(false);
            ModeraorPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_moderator).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Authorization;
        private TabPage AdminPage;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btn_login;
        private TextBox txt_password;
        private Label label3;
        private TextBox txt_empl_id;
        private Label label1;
        private Label txt_currUser;
        private Button btn_AddFilm;
        private Button btn_LoadInfo;
        public DataGridView dgv_movies;
        private Label lbl_username;
        private TabPage ModeraorPage;
        private Label lbl_verd;
        private ComboBox cb_verdicts;
        private Button btn_apply;
        private Button btn_showReports;
        public DataGridView dgv_moderator;
        private Label lbl_username2;
        private ComboBox cb_searchType;
    }
}