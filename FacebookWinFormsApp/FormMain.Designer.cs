namespace BasicFacebookFeatures
{
    public partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Login_btn = new System.Windows.Forms.Button();
            this.Logout_bth = new System.Windows.Forms.Button();
            this.Category_label = new System.Windows.Forms.Label();
            this.Friends_label = new System.Windows.Forms.Label();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.Comments_ListBox = new System.Windows.Forms.ListBox();
            this.Posts_listBox = new System.Windows.Forms.ListBox();
            this.Friends_listBox = new System.Windows.Forms.ListBox();
            this.Category_listBox = new System.Windows.Forms.ListBox();
            this.UserLocation_label = new System.Windows.Forms.Label();
            this.UserBirthDate_label = new System.Windows.Forms.Label();
            this.UserFullName_label = new System.Windows.Forms.Label();
            this.Location_label = new System.Windows.Forms.Label();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.FullName_label = new System.Windows.Forms.Label();
            this.FriendFilter_btn = new System.Windows.Forms.Button();
            this.LoveCalculator_btn = new System.Windows.Forms.Button();
            this.FriendProfile_picture = new System.Windows.Forms.PictureBox();
            this.Category_picture = new System.Windows.Forms.PictureBox();
            this.Profile_picture = new System.Windows.Forms.PictureBox();
            this.RememberMe_Checkbox = new System.Windows.Forms.CheckBox();
            this.ShowPosts_btn = new System.Windows.Forms.Button();
            this.Comments_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FriendProfile_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(588, 15);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(110, 70);
            this.Login_btn.TabIndex = 36;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Logout_bth
            // 
            this.Logout_bth.Enabled = false;
            this.Logout_bth.Location = new System.Drawing.Point(701, 15);
            this.Logout_bth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logout_bth.Name = "Logout_bth";
            this.Logout_bth.Size = new System.Drawing.Size(110, 70);
            this.Logout_bth.TabIndex = 52;
            this.Logout_bth.Text = "Logout";
            this.Logout_bth.UseVisualStyleBackColor = true;
            this.Logout_bth.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.Location = new System.Drawing.Point(15, 572);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(73, 20);
            this.Category_label.TabIndex = 81;
            this.Category_label.Text = "Category";
            // 
            // Friends_label
            // 
            this.Friends_label.AutoSize = true;
            this.Friends_label.Location = new System.Drawing.Point(584, 225);
            this.Friends_label.Name = "Friends_label";
            this.Friends_label.Size = new System.Drawing.Size(62, 20);
            this.Friends_label.TabIndex = 79;
            this.Friends_label.Text = "Friends";
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.FormattingEnabled = true;
            this.Category_comboBox.Location = new System.Drawing.Point(18, 598);
            this.Category_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(159, 28);
            this.Category_comboBox.TabIndex = 73;
            this.Category_comboBox.SelectedIndexChanged += new System.EventHandler(this.Category_comboBox_SelectedIndexChanged);
            // 
            // Comments_ListBox
            // 
            this.Comments_ListBox.FormattingEnabled = true;
            this.Comments_ListBox.ItemHeight = 20;
            this.Comments_ListBox.Location = new System.Drawing.Point(16, 471);
            this.Comments_ListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Comments_ListBox.Name = "Comments_ListBox";
            this.Comments_ListBox.Size = new System.Drawing.Size(550, 84);
            this.Comments_ListBox.TabIndex = 72;
            // 
            // Posts_listBox
            // 
            this.Posts_listBox.FormattingEnabled = true;
            this.Posts_listBox.ItemHeight = 20;
            this.Posts_listBox.Location = new System.Drawing.Point(14, 308);
            this.Posts_listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Posts_listBox.Name = "Posts_listBox";
            this.Posts_listBox.Size = new System.Drawing.Size(552, 124);
            this.Posts_listBox.TabIndex = 68;
            this.Posts_listBox.SelectedIndexChanged += new System.EventHandler(this.posts_ListBox_SelectedIndexChanged);
            // 
            // Friends_listBox
            // 
            this.Friends_listBox.FormattingEnabled = true;
            this.Friends_listBox.ItemHeight = 20;
            this.Friends_listBox.Location = new System.Drawing.Point(588, 415);
            this.Friends_listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Friends_listBox.Name = "Friends_listBox";
            this.Friends_listBox.Size = new System.Drawing.Size(223, 464);
            this.Friends_listBox.TabIndex = 65;
            this.Friends_listBox.SelectedIndexChanged += new System.EventHandler(this.Friends_listBox_SelectedIndexChanged);
            // 
            // Category_listBox
            // 
            this.Category_listBox.FormattingEnabled = true;
            this.Category_listBox.ItemHeight = 20;
            this.Category_listBox.Location = new System.Drawing.Point(184, 598);
            this.Category_listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Category_listBox.Name = "Category_listBox";
            this.Category_listBox.Size = new System.Drawing.Size(202, 184);
            this.Category_listBox.TabIndex = 64;
            this.Category_listBox.SelectedIndexChanged += new System.EventHandler(this.Category_listBox_SelectedIndexChanged);
            // 
            // UserLocation_label
            // 
            this.UserLocation_label.AutoSize = true;
            this.UserLocation_label.Location = new System.Drawing.Point(434, 174);
            this.UserLocation_label.Name = "UserLocation_label";
            this.UserLocation_label.Size = new System.Drawing.Size(51, 20);
            this.UserLocation_label.TabIndex = 61;
            this.UserLocation_label.Text = "label3";
            // 
            // UserBirthDate_label
            // 
            this.UserBirthDate_label.AutoSize = true;
            this.UserBirthDate_label.Location = new System.Drawing.Point(434, 122);
            this.UserBirthDate_label.Name = "UserBirthDate_label";
            this.UserBirthDate_label.Size = new System.Drawing.Size(51, 20);
            this.UserBirthDate_label.TabIndex = 60;
            this.UserBirthDate_label.Text = "label2";
            // 
            // UserFullName_label
            // 
            this.UserFullName_label.AutoSize = true;
            this.UserFullName_label.Location = new System.Drawing.Point(434, 71);
            this.UserFullName_label.Name = "UserFullName_label";
            this.UserFullName_label.Size = new System.Drawing.Size(51, 20);
            this.UserFullName_label.TabIndex = 59;
            this.UserFullName_label.Text = "label1";
            // 
            // Location_label
            // 
            this.Location_label.AutoSize = true;
            this.Location_label.Location = new System.Drawing.Point(291, 169);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(78, 20);
            this.Location_label.TabIndex = 56;
            this.Location_label.Text = "Location: ";
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Location = new System.Drawing.Point(291, 120);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(85, 20);
            this.BirthDate_label.TabIndex = 55;
            this.BirthDate_label.Text = "Birth Date:";
            // 
            // FullName_label
            // 
            this.FullName_label.AutoSize = true;
            this.FullName_label.Location = new System.Drawing.Point(291, 71);
            this.FullName_label.Name = "FullName_label";
            this.FullName_label.Size = new System.Drawing.Size(84, 20);
            this.FullName_label.TabIndex = 54;
            this.FullName_label.Text = "Full Name:";
            // 
            // FriendFilter_btn
            // 
            this.FriendFilter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FriendFilter_btn.Enabled = false;
            this.FriendFilter_btn.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FriendFilter_btn.Location = new System.Drawing.Point(312, 808);
            this.FriendFilter_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FriendFilter_btn.Name = "FriendFilter_btn";
            this.FriendFilter_btn.Size = new System.Drawing.Size(223, 72);
            this.FriendFilter_btn.TabIndex = 83;
            this.FriendFilter_btn.Text = "Friend filter";
            this.FriendFilter_btn.UseVisualStyleBackColor = true;
            this.FriendFilter_btn.Click += new System.EventHandler(this.FriendFilter_btn_Click);
            // 
            // LoveCalculator_btn
            // 
            this.LoveCalculator_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoveCalculator_btn.Enabled = false;
            this.LoveCalculator_btn.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoveCalculator_btn.Location = new System.Drawing.Point(16, 808);
            this.LoveCalculator_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoveCalculator_btn.Name = "LoveCalculator_btn";
            this.LoveCalculator_btn.Size = new System.Drawing.Size(223, 72);
            this.LoveCalculator_btn.TabIndex = 82;
            this.LoveCalculator_btn.Text = "Find Love";
            this.LoveCalculator_btn.UseVisualStyleBackColor = true;
            this.LoveCalculator_btn.Click += new System.EventHandler(this.LoveCalculator_btn_Click);
            // 
            // FriendProfile_picture
            // 
            this.FriendProfile_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriendProfile_picture.Location = new System.Drawing.Point(587, 249);
            this.FriendProfile_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FriendProfile_picture.Name = "FriendProfile_picture";
            this.FriendProfile_picture.Size = new System.Drawing.Size(224, 167);
            this.FriendProfile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FriendProfile_picture.TabIndex = 80;
            this.FriendProfile_picture.TabStop = false;
            // 
            // Category_picture
            // 
            this.Category_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Category_picture.Location = new System.Drawing.Point(398, 598);
            this.Category_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Category_picture.Name = "Category_picture";
            this.Category_picture.Size = new System.Drawing.Size(167, 184);
            this.Category_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Category_picture.TabIndex = 66;
            this.Category_picture.TabStop = false;
            // 
            // Profile_picture
            // 
            this.Profile_picture.Location = new System.Drawing.Point(18, 15);
            this.Profile_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Profile_picture.Name = "Profile_picture";
            this.Profile_picture.Size = new System.Drawing.Size(250, 222);
            this.Profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile_picture.TabIndex = 53;
            this.Profile_picture.TabStop = false;
            // 
            // RememberMe_Checkbox
            // 
            this.RememberMe_Checkbox.AutoSize = true;
            this.RememberMe_Checkbox.Location = new System.Drawing.Point(671, 94);
            this.RememberMe_Checkbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RememberMe_Checkbox.Name = "RememberMe_Checkbox";
            this.RememberMe_Checkbox.Size = new System.Drawing.Size(140, 24);
            this.RememberMe_Checkbox.TabIndex = 89;
            this.RememberMe_Checkbox.Text = "Remember Me";
            this.RememberMe_Checkbox.UseVisualStyleBackColor = true;
            // 
            // ShowPosts_btn
            // 
            this.ShowPosts_btn.Location = new System.Drawing.Point(16, 271);
            this.ShowPosts_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPosts_btn.Name = "ShowPosts_btn";
            this.ShowPosts_btn.Size = new System.Drawing.Size(129, 29);
            this.ShowPosts_btn.TabIndex = 90;
            this.ShowPosts_btn.Text = "Show Posts";
            this.ShowPosts_btn.UseVisualStyleBackColor = true;
            this.ShowPosts_btn.Click += new System.EventHandler(this.showPosts_btn_Click);
            // 
            // Comments_label
            // 
            this.Comments_label.AutoSize = true;
            this.Comments_label.Location = new System.Drawing.Point(12, 449);
            this.Comments_label.Name = "Comments_label";
            this.Comments_label.Size = new System.Drawing.Size(86, 20);
            this.Comments_label.TabIndex = 91;
            this.Comments_label.Text = "Comments";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(838, 906);
            this.Controls.Add(this.Comments_label);
            this.Controls.Add(this.ShowPosts_btn);
            this.Controls.Add(this.RememberMe_Checkbox);
            this.Controls.Add(this.FriendFilter_btn);
            this.Controls.Add(this.LoveCalculator_btn);
            this.Controls.Add(this.Category_label);
            this.Controls.Add(this.FriendProfile_picture);
            this.Controls.Add(this.Friends_label);
            this.Controls.Add(this.Category_comboBox);
            this.Controls.Add(this.Comments_ListBox);
            this.Controls.Add(this.Posts_listBox);
            this.Controls.Add(this.Category_picture);
            this.Controls.Add(this.Friends_listBox);
            this.Controls.Add(this.Category_listBox);
            this.Controls.Add(this.UserLocation_label);
            this.Controls.Add(this.UserBirthDate_label);
            this.Controls.Add(this.UserFullName_label);
            this.Controls.Add(this.Location_label);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.FullName_label);
            this.Controls.Add(this.Profile_picture);
            this.Controls.Add(this.Logout_bth);
            this.Controls.Add(this.Login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.FriendProfile_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button Login_btn;
		private System.Windows.Forms.Button Logout_bth;
        private System.Windows.Forms.Button FriendFilter_btn;
        private System.Windows.Forms.Button LoveCalculator_btn;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.PictureBox FriendProfile_picture;
        private System.Windows.Forms.Label Friends_label;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.ListBox Comments_ListBox;
        private System.Windows.Forms.ListBox Posts_listBox;
        private System.Windows.Forms.PictureBox Category_picture;
        private System.Windows.Forms.ListBox Friends_listBox;
        private System.Windows.Forms.ListBox Category_listBox;
        private System.Windows.Forms.Label UserLocation_label;
        private System.Windows.Forms.Label UserBirthDate_label;
        private System.Windows.Forms.Label UserFullName_label;
        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.Label FullName_label;
        private System.Windows.Forms.PictureBox Profile_picture;
        private System.Windows.Forms.CheckBox RememberMe_Checkbox;
        private System.Windows.Forms.Button ShowPosts_btn;
        private System.Windows.Forms.Label Comments_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}