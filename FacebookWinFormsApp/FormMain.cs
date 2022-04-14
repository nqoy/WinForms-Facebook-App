namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using AppLogic;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public partial class FormMain : Form
    {
        private static readonly AppSettings sr_AppSettings;
        private static LoginResult s_LoginResult;

        static FormMain()
        {
            sr_AppSettings = AppSettings.LoadFromXmlFile();
            UserFriendsDictionary = FakeUser.LoadFriends();
        }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 15;
            RememberMe_Checkbox.Checked = sr_AppSettings.IsRememberMeChecked;
            Category_comboBox.Items.AddRange(Enum.GetNames(typeof(eUserElements)));
            Profile_picture.Image = Image.FromFile(AppLogic.FilePath.GetResourcePath("Barny.png"));
            if (sr_AppSettings.IsRememberMeChecked && !string.IsNullOrEmpty(sr_AppSettings.LastLoginAccessToken))
            {
                s_LoginResult = FacebookService.Connect(sr_AppSettings.LastLoginAccessToken);
                fetchUserDetails();
                openOrCloseButtons(true);
            }
            else
            {
                openOrCloseButtons(false);
            }
        }

        private enum eUserElements
        {
            LikedPages = 1,
            Videos,
            Music,
            Albums,
            Events,
            Groups,
        }
        public static User LoggedInUser {get; set;}
        public static Dictionary<int, FakeUser> UserFriendsDictionary { get; set; }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sr_AppSettings.IsRememberMeChecked = RememberMe_Checkbox.Checked;
            sr_AppSettings.LastLoginAccessToken = sr_AppSettings.IsRememberMeChecked ? s_LoginResult.AccessToken : null;
            sr_AppSettings.SaveToXmlFile();
        }

        private void fetchUserData<T>(FacebookObjectCollection<T> i_Source)
        {
            foreach (T data in i_Source)
            {
                if (data.GetType().GetProperty("Name").GetValue(data, null) != null)
                {
                    Category_listBox.Items.Add(data);
                }
            }
        }

        private void loadFeatureImage(string i_PictureURL)
        {
            if (!string.IsNullOrEmpty(i_PictureURL))
            {
                Category_picture.LoadAsync(i_PictureURL);
            }
            else
            {
                Category_picture.Image = Category_picture.ErrorImage;
            }
        }

        private void openOrCloseButtons(bool i_Value)
        {
            Login_btn.Enabled = !i_Value;
            Logout_bth.Enabled = i_Value;
            ShowPosts_btn.Enabled = i_Value;
            FriendFilter_btn.Enabled = i_Value;
            Category_comboBox.Enabled = i_Value;
            LoveCalculator_btn.Enabled = i_Value;
            RememberMe_Checkbox.Enabled = i_Value;
        }

        private void displayFieldFeaturesOnListBox()
        {
            string categoryName = Category_comboBox.SelectedItem.ToString();
            eUserElements fieldToDisplay = (eUserElements)Enum.Parse(typeof(eUserElements), categoryName);

            Category_picture.Image = null;
            Category_listBox.Items.Clear();
            Category_listBox.DisplayMember = "Name";
            switch (fieldToDisplay)
            {
                case eUserElements.LikedPages:
                    fetchUserData<Page>(LoggedInUser.LikedPages);
                    break;
                case eUserElements.Videos:
                    fetchUserData<Video>(LoggedInUser.Videos);
                    break;
                case eUserElements.Music:
                    fetchUserData<Page>(FacebookService.GetCollection<Page>("music"));
                    break;
                case eUserElements.Albums:
                    fetchUserData<Album>(LoggedInUser.Albums);
                    break;
                case eUserElements.Events:
                    fetchUserData<Event>(LoggedInUser.Events);
                    break;
                case eUserElements.Groups:
                    fetchUserData<Group>(LoggedInUser.Groups);
                    break;
                default:
                    break;
            }

            checkIfListBoxIsEmpty(categoryName);
        }

        private void checkIfListBoxIsEmpty(string i_CategoryName)
        {
            if (Category_listBox.Items.Count == 0)
            {
                Category_picture.Image = null;
                MessageBox.Show($"No {i_CategoryName} to retrieve :(");
            }
        }

        private void displaySelectedCoverPhoto()
        {
            string categoryName = Category_comboBox.SelectedItem.ToString();
            eUserElements fieldToDisplay = (eUserElements)Enum.Parse(typeof(eUserElements), categoryName);

            switch (fieldToDisplay)
            {
                case eUserElements.LikedPages:
                    displayPagePhoto();
                    break;
                case eUserElements.Videos:
                    displayVideoCoverPhoto();
                    break;
                case eUserElements.Music:
                    displayPagePhoto();
                    break;
                case eUserElements.Albums:
                    displayAlbumsCoverPhoto();
                    break;
                case eUserElements.Events:
                    displayEventCoverPhoto();
                    break;
                case eUserElements.Groups:
                    displayGroupCoverPhoto();
                    break;
                default:
                    break;
            }
        }

        private void clearMainFormComponents()
        {
            LoggedInUser = null;
            Posts_listBox.Items.Clear();
            Profile_picture.Image = null;
            Category_picture.Image = null;
            Friends_listBox.Items.Clear();
            UserFriendsDictionary.Clear();
            Category_listBox.Items.Clear();
            FriendProfile_picture.Image = null;
            RememberMe_Checkbox.Checked = false;
            UserLocation_label.Text = string.Empty;
            UserFullName_label.Text = string.Empty;
            UserBirthDate_label.Text = string.Empty;
            Profile_picture.Image = Image.FromFile(AppLogic.FilePath.GetResourcePath("Barny.png"));
        }

        private void showFriendProfileImage()
        {
            FriendProfile_picture.Image = Image.FromFile(FakeUser.GetFakeUserImage(Friends_listBox.SelectedItem.ToString()));
        }

        private void facebookUserInitialize()
        {
            if (!string.IsNullOrEmpty(s_LoginResult.AccessToken))
            {
                fetchUserDetails();
                openOrCloseButtons(true);
            }
        }

        private void displayAlbumsCoverPhoto()
        {
            Album selectedAlbum = Category_listBox.SelectedItem as Album;

            loadFeatureImage(selectedAlbum.PictureAlbumURL);
        }

        private void displayVideoCoverPhoto()
        {
            Video video = Category_listBox.SelectedItem as Video;

            loadFeatureImage(video.PictureURL);
        }

        private void displayEventCoverPhoto()
        {
            Event selectedEvent = Category_listBox.SelectedItem as Event;

            loadFeatureImage(selectedEvent.Cover.SourceURL);
        }

        private void displayGroupCoverPhoto()
        {
            Group selectedGroup = Category_listBox.SelectedItem as Group;

            loadFeatureImage(selectedGroup.PictureNormalURL);
        }

        private void facebookAccesRequest()
        {
            Clipboard.SetText("design.patterns20cc");
            s_LoginResult = FacebookService.Login(
                "673056113883125",
                "email",
                "public_profile",
                "pages_read_engagement",
                "pages_manage_posts",
                "publish_to_groups",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");
        }

        private void displayFakeUserNames()
        {
            foreach (KeyValuePair<int, FakeUser> element in UserFriendsDictionary)
            {
                Friends_listBox.Items.Add(element.Value.Name);
            }
        }

        private void fetchUserDetails()
        {
            LoggedInUser = s_LoginResult.LoggedInUser;
            UserFullName_label.Text = LoggedInUser.Name;
            UserBirthDate_label.Text = LoggedInUser.Birthday;
            UserLocation_label.Text = LoggedInUser.Location.Name;
            Profile_picture.LoadAsync(LoggedInUser.PictureNormalURL);
            displayFakeUserNames();
        }

        private void showUserComments()
        {
            Post selectedPost = LoggedInUser.Posts[Posts_listBox.SelectedIndex + 1];

            Comments_ListBox.DisplayMember = "Message";
            try
            {
                Comments_ListBox.DataSource = selectedPost.Comments;
            }
            catch
            {
                Comments_ListBox.Items.Clear();
            }
        }

        private void displayPagePhoto()
        {
            Page selectedPage = Category_listBox.SelectedItem as Page;

            loadFeatureImage(selectedPage.PictureNormalURL);
        }

        private void showUserPosts()
        {
            Posts_listBox.Items.Clear();

            foreach (Post post in LoggedInUser.Posts)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    Posts_listBox.Items.Add(post.Message);
                }
            }
        }

        private void LoveCalculator_btn_Click(object sender, EventArgs e)
        {
            FormLoveCalculator LoveCalculatorForm = new FormLoveCalculator();

            LoveCalculatorForm.ShowDialog();
        }

        private void FriendFilter_btn_Click(object sender, EventArgs e)
        {
            FormFriendFilter FriendFilterForm = new FormFriendFilter();

            FriendFilterForm.ShowDialog();
        }

        private void showPosts_btn_Click(object sender, EventArgs e)
        {
            showUserPosts();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            clearMainFormComponents();
            openOrCloseButtons(false);
            FacebookService.LogoutWithUI();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            facebookAccesRequest();
            facebookUserInitialize();
        }

        private void Category_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayFieldFeaturesOnListBox();
        }

        private void Category_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedCoverPhoto();
        }

        private void Friends_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showFriendProfileImage();
        }

        private void posts_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showUserComments();
        }
    }
}