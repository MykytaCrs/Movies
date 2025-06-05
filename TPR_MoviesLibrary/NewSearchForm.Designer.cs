namespace TPR_MoviesLibrary
{
    partial class NewSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSearchForm));
            groupBox1 = new GroupBox();
            txt_description = new TextBox();
            btn_find = new Button();
            txt_genres = new TextBox();
            lbl_name = new Label();
            txt_director = new TextBox();
            lbl_birthdate = new Label();
            txt_country = new TextBox();
            lbl_birthplace = new Label();
            txt_year = new TextBox();
            lbl_height = new Label();
            txt_name = new TextBox();
            lbl_livingPlace = new Label();
            lbl_activity = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(btn_find);
            groupBox1.Controls.Add(txt_genres);
            groupBox1.Controls.Add(lbl_name);
            groupBox1.Controls.Add(txt_director);
            groupBox1.Controls.Add(lbl_birthdate);
            groupBox1.Controls.Add(txt_country);
            groupBox1.Controls.Add(lbl_birthplace);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(lbl_height);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(lbl_livingPlace);
            groupBox1.Controls.Add(lbl_activity);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(-1, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(834, 408);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // txt_description
            // 
            txt_description.ForeColor = Color.Black;
            txt_description.Location = new Point(376, 229);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(246, 168);
            txt_description.TabIndex = 69;
            // 
            // btn_find
            // 
            btn_find.BackColor = Color.Black;
            btn_find.DialogResult = DialogResult.OK;
            btn_find.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_find.ForeColor = Color.White;
            btn_find.Location = new Point(669, 355);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(143, 42);
            btn_find.TabIndex = 79;
            btn_find.Text = "Find";
            btn_find.UseVisualStyleBackColor = false;
            btn_find.Click += btn_find_Click;
            // 
            // txt_genres
            // 
            txt_genres.ForeColor = Color.Black;
            txt_genres.Location = new Point(376, 184);
            txt_genres.Name = "txt_genres";
            txt_genres.Size = new Size(246, 27);
            txt_genres.TabIndex = 68;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.Black;
            lbl_name.Location = new Point(62, 23);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(68, 28);
            lbl_name.TabIndex = 58;
            lbl_name.Text = "Name:";
            // 
            // txt_director
            // 
            txt_director.ForeColor = Color.Black;
            txt_director.Location = new Point(376, 143);
            txt_director.Name = "txt_director";
            txt_director.Size = new Size(246, 27);
            txt_director.TabIndex = 67;
            // 
            // lbl_birthdate
            // 
            lbl_birthdate.AutoSize = true;
            lbl_birthdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_birthdate.ForeColor = Color.Black;
            lbl_birthdate.Location = new Point(62, 63);
            lbl_birthdate.Name = "lbl_birthdate";
            lbl_birthdate.Size = new Size(52, 28);
            lbl_birthdate.TabIndex = 59;
            lbl_birthdate.Text = "Year:";
            // 
            // txt_country
            // 
            txt_country.ForeColor = Color.Black;
            txt_country.Location = new Point(376, 103);
            txt_country.Name = "txt_country";
            txt_country.Size = new Size(246, 27);
            txt_country.TabIndex = 66;
            // 
            // lbl_birthplace
            // 
            lbl_birthplace.AutoSize = true;
            lbl_birthplace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_birthplace.ForeColor = Color.Black;
            lbl_birthplace.Location = new Point(62, 103);
            lbl_birthplace.Name = "lbl_birthplace";
            lbl_birthplace.Size = new Size(86, 28);
            lbl_birthplace.TabIndex = 60;
            lbl_birthplace.Text = "Country:";
            // 
            // txt_year
            // 
            txt_year.ForeColor = Color.Black;
            txt_year.Location = new Point(376, 63);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(246, 27);
            txt_year.TabIndex = 65;
            // 
            // lbl_height
            // 
            lbl_height.AutoSize = true;
            lbl_height.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_height.ForeColor = Color.Black;
            lbl_height.Location = new Point(62, 184);
            lbl_height.Name = "lbl_height";
            lbl_height.Size = new Size(76, 28);
            lbl_height.TabIndex = 61;
            lbl_height.Text = "Genres:";
            // 
            // txt_name
            // 
            txt_name.ForeColor = Color.Black;
            txt_name.Location = new Point(376, 23);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(246, 27);
            txt_name.TabIndex = 64;
            // 
            // lbl_livingPlace
            // 
            lbl_livingPlace.AutoSize = true;
            lbl_livingPlace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_livingPlace.ForeColor = Color.Black;
            lbl_livingPlace.Location = new Point(62, 143);
            lbl_livingPlace.Name = "lbl_livingPlace";
            lbl_livingPlace.Size = new Size(87, 28);
            lbl_livingPlace.TabIndex = 62;
            lbl_livingPlace.Text = "Director:";
            // 
            // lbl_activity
            // 
            lbl_activity.AutoSize = true;
            lbl_activity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_activity.ForeColor = Color.Black;
            lbl_activity.Location = new Point(62, 225);
            lbl_activity.Name = "lbl_activity";
            lbl_activity.Size = new Size(116, 28);
            lbl_activity.TabIndex = 63;
            lbl_activity.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-1, 7);
            label1.Name = "label1";
            label1.Size = new Size(247, 32);
            label1.TabIndex = 56;
            label1.Text = "Create search pattern:";
            // 
            // NewSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 465);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(855, 512);
            MinimumSize = new Size(855, 512);
            Name = "NewSearchForm";
            Text = "NewSearch";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_find;
        private Label label1;
        private TextBox txt_description;
        private TextBox txt_genres;
        private Label lbl_name;
        private TextBox txt_director;
        private Label lbl_birthdate;
        private TextBox txt_country;
        private Label lbl_birthplace;
        private TextBox txt_year;
        private Label lbl_height;
        private TextBox txt_name;
        private Label lbl_livingPlace;
        private Label lbl_activity;
    }
}