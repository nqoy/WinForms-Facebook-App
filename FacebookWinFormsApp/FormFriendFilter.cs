namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using AppLogic;

    public partial class FormFriendFilter : Form
    {
        public FormFriendFilter()
        {
            InitializeComponent();
            displayFakeUserNames();
            FriendsCount_label.Text = Friends_listBox.Items.Count.ToString();
            Logo_picture.Image = Image.FromFile(FilePath.GetResourcePath("Play_Logo.png"));
            Anna_picebox.Image = Image.FromFile(FilePath.GetResourcePath("Anna.gif"));
        }

        private void displayContactInfo()
        {
            const string header = "It seems you found yourself a new Friend";
            string message = string.Format(
                "Here is this person's Email{0}{1}{0}Have fun!",
                Environment.NewLine,
                FriendFilterLogic.GetFriendMail(Friends_listBox.SelectedItem.ToString()));

            MessageBox.Show(message, header);
        }

        private void displyFilteredFriend()
        {
            Friends_listBox.Items.Clear();
            foreach (KeyValuePair<int, FakeUser> element in FormMain.UserFriendsDictionary)
            {
                if (FriendFilterLogic.CheckSpecificFriendFeatures(element.Value))
                {
                    Friends_listBox.Items.Add(element.Value.Name);
                }
            }

            FriendsCount_label.Text = Friends_listBox.Items.Count.ToString();
        }

        private void displayFakeUserNames()
        {
            foreach (KeyValuePair<int, FakeUser> element in FormMain.UserFriendsDictionary)
            {
                Friends_listBox.Items.Add(element.Value.Name);
            }
        }

        private void showSelectedFriendImage()
        {
            FriendProfle_picbox.Image = Image.FromFile(FakeUser.GetFakeUserImage(Friends_listBox.SelectedItem.ToString()));
        }

        private void Contact_btn_Click(object sender, EventArgs e)
        {
            displayContactInfo();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            FriendProfle_picbox.Image = null;
            FriendFilterLogic.EditFilterToFilterDict(checkBox.Checked, checkBox.Parent.Text, checkBox.Text);
            displyFilteredFriend();
        }

        private void Friends_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Friends_listBox.SelectedItems.ToString()))
            {
                showSelectedFriendImage();
            }
        }
    }
}
