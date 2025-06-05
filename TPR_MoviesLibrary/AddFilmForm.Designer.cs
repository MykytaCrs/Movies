namespace TPR_MoviesLibrary
{
    partial class AddFilmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilmForm));
            btn_submitAdd = new Button();
            btn_close = new Button();
            gb_info = new GroupBox();
            txt_description = new TextBox();
            txt_genres = new TextBox();
            txt_director = new TextBox();
            txt_country = new TextBox();
            txt_year = new TextBox();
            txt_name = new TextBox();
            lbl_activity = new Label();
            lbl_livingPlace = new Label();
            lbl_height = new Label();
            lbl_birthplace = new Label();
            lbl_name = new Label();
            lbl_birthdate = new Label();
            pb_photo = new PictureBox();
            gb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_photo).BeginInit();
            SuspendLayout();
            // 
            // btn_submitAdd
            // 
            btn_submitAdd.BackColor = Color.Black;
            btn_submitAdd.DialogResult = DialogResult.OK;
            btn_submitAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_submitAdd.ForeColor = Color.White;
            btn_submitAdd.Location = new Point(43, 320);
            btn_submitAdd.Name = "btn_submitAdd";
            btn_submitAdd.Size = new Size(246, 64);
            btn_submitAdd.TabIndex = 18;
            btn_submitAdd.Text = "SUBMIT";
            btn_submitAdd.UseVisualStyleBackColor = false;
            btn_submitAdd.Click += btn_submitAdd_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Black;
            btn_close.DialogResult = DialogResult.Cancel;
            btn_close.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(43, 400);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(246, 64);
            btn_close.TabIndex = 17;
            btn_close.Text = "CLOSE";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // gb_info
            // 
            gb_info.Controls.Add(txt_description);
            gb_info.Controls.Add(txt_genres);
            gb_info.Controls.Add(txt_director);
            gb_info.Controls.Add(txt_country);
            gb_info.Controls.Add(txt_year);
            gb_info.Controls.Add(txt_name);
            gb_info.Controls.Add(lbl_activity);
            gb_info.Controls.Add(lbl_livingPlace);
            gb_info.Controls.Add(lbl_height);
            gb_info.Controls.Add(lbl_birthplace);
            gb_info.Controls.Add(lbl_name);
            gb_info.Controls.Add(lbl_birthdate);
            gb_info.ForeColor = Color.Black;
            gb_info.Location = new Point(343, 12);
            gb_info.Name = "gb_info";
            gb_info.Size = new Size(667, 452);
            gb_info.TabIndex = 16;
            gb_info.TabStop = false;
            gb_info.Text = "Info";
            // 
            // txt_description
            // 
            txt_description.ForeColor = Color.Black;
            txt_description.Location = new Point(349, 258);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(246, 168);
            txt_description.TabIndex = 20;
            // 
            // txt_genres
            // 
            txt_genres.ForeColor = Color.Black;
            txt_genres.Location = new Point(349, 213);
            txt_genres.Name = "txt_genres";
            txt_genres.Size = new Size(246, 27);
            txt_genres.TabIndex = 19;
            // 
            // txt_director
            // 
            txt_director.ForeColor = Color.Black;
            txt_director.Location = new Point(349, 172);
            txt_director.Name = "txt_director";
            txt_director.Size = new Size(246, 27);
            txt_director.TabIndex = 18;
            // 
            // txt_country
            // 
            txt_country.ForeColor = Color.Black;
            txt_country.Location = new Point(349, 132);
            txt_country.Name = "txt_country";
            txt_country.Size = new Size(246, 27);
            txt_country.TabIndex = 17;
            // 
            // txt_year
            // 
            txt_year.ForeColor = Color.Black;
            txt_year.Location = new Point(349, 92);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(246, 27);
            txt_year.TabIndex = 16;
            // 
            // txt_name
            // 
            txt_name.ForeColor = Color.Black;
            txt_name.Location = new Point(349, 52);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(246, 27);
            txt_name.TabIndex = 15;
            // 
            // lbl_activity
            // 
            lbl_activity.AutoSize = true;
            lbl_activity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_activity.ForeColor = Color.Black;
            lbl_activity.Location = new Point(35, 254);
            lbl_activity.Name = "lbl_activity";
            lbl_activity.Size = new Size(116, 28);
            lbl_activity.TabIndex = 9;
            lbl_activity.Text = "Description:";
            // 
            // lbl_livingPlace
            // 
            lbl_livingPlace.AutoSize = true;
            lbl_livingPlace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_livingPlace.ForeColor = Color.Black;
            lbl_livingPlace.Location = new Point(35, 172);
            lbl_livingPlace.Name = "lbl_livingPlace";
            lbl_livingPlace.Size = new Size(87, 28);
            lbl_livingPlace.TabIndex = 8;
            lbl_livingPlace.Text = "Director:";
            // 
            // lbl_height
            // 
            lbl_height.AutoSize = true;
            lbl_height.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_height.ForeColor = Color.Black;
            lbl_height.Location = new Point(35, 213);
            lbl_height.Name = "lbl_height";
            lbl_height.Size = new Size(76, 28);
            lbl_height.TabIndex = 5;
            lbl_height.Text = "Genres:";
            // 
            // lbl_birthplace
            // 
            lbl_birthplace.AutoSize = true;
            lbl_birthplace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_birthplace.ForeColor = Color.Black;
            lbl_birthplace.Location = new Point(35, 132);
            lbl_birthplace.Name = "lbl_birthplace";
            lbl_birthplace.Size = new Size(86, 28);
            lbl_birthplace.TabIndex = 3;
            lbl_birthplace.Text = "Country:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.Black;
            lbl_name.Location = new Point(35, 52);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(68, 28);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name:";
            // 
            // lbl_birthdate
            // 
            lbl_birthdate.AutoSize = true;
            lbl_birthdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_birthdate.ForeColor = Color.Black;
            lbl_birthdate.Location = new Point(35, 92);
            lbl_birthdate.Name = "lbl_birthdate";
            lbl_birthdate.Size = new Size(52, 28);
            lbl_birthdate.TabIndex = 2;
            lbl_birthdate.Text = "Year:";
            // 
            // pb_photo
            // 
            pb_photo.InitialImage = null;
            pb_photo.Location = new Point(32, 12);
            pb_photo.Name = "pb_photo";
            pb_photo.Size = new Size(267, 280);
            pb_photo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_photo.TabIndex = 15;
            pb_photo.TabStop = false;
            // 
            // AddFilmForm
            // 
            AcceptButton = btn_submitAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1030, 495);
            Controls.Add(btn_submitAdd);
            Controls.Add(btn_close);
            Controls.Add(gb_info);
            Controls.Add(pb_photo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1048, 542);
            MinimumSize = new Size(1048, 542);
            Name = "AddFilmForm";
            Text = "AddFilm";
            gb_info.ResumeLayout(false);
            gb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_photo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_submitAdd;
        private Button btn_close;
        private GroupBox gb_info;
        private TextBox txt_description;
        private TextBox txt_genres;
        private TextBox txt_director;
        private TextBox txt_country;
        private TextBox txt_year;
        private TextBox txt_name;
        private Label lbl_activity;
        private Label lbl_livingPlace;
        private Label lbl_height;
        private Label lbl_birthplace;
        private Label lbl_name;
        private Label lbl_birthdate;
        private PictureBox pb_photo;
    }
}