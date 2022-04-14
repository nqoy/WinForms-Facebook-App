namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using AppLogic;

    internal partial class FormLoveCalculator : Form
    {
        public FormLoveCalculator()
        {
            InitializeComponent();
            loadFakeUserNames();
            UserLoveProfile_picture.LoadAsync(FormMain.LoggedInUser.PictureNormalURL);
            Love_LOGO.Image = Image.FromFile(FilePath.GetResourcePath("Love_LOGO.png"));
            BackgroundImage = Image.FromFile(FilePath.GetResourcePath("Valentine-Design.jpg"));
        }

        private static void showMatchMessage(float i_LovePercent, FakeUser i_FakeUser)
        {
            string header = $"You have only {i_LovePercent}% common interests";
            string message = "Don't be upset, There are plenty of fish in the sea";

            if (LoveCalculatorLogic.IsLovePercentSufficient(i_LovePercent))
            {
                header = $"You have {i_LovePercent}% common interests!!!";
                message = $"Here is this person's Email, good luck!!{Environment.NewLine}{LoveCalculatorLogic.GetDatingMail(i_FakeUser.Name)}";
            }

            MessageBox.Show(message, header);
        }

        private List<string> extractChosenFeatures(List<GroupBox> i_GroupBoxes)
        {
            List<string> chosenFeatures = new List<string>();

            foreach (GroupBox groupBox in i_GroupBoxes)
            {
                RadioButton radioButtonRef = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);

                if (radioButtonRef != null)
                {
                    chosenFeatures.Add(radioButtonRef.Text);
                }
            }

            return chosenFeatures;
        }

        private void showHeartGif(float i_LovePercent)
        {
            bool isMatch = LoveCalculatorLogic.IsLovePercentSufficient(i_LovePercent);
            string heartGif = isMatch ? "HeartTwark.gif" : "HeartBreak.gif";

            Heart_picture.Image = Image.FromFile(FilePath.GetResourcePath(heartGif));
        }

        private void showSelectedFriendImage()
        {
            FriendLoveProfile_picture.Image = Image.FromFile(FakeUser.GetFakeUserImage(FriendsLove_listBox.SelectedItem.ToString()));
        }

        private void calculateLovePercent()
        {
            float lovePercent = 0;
            FakeUser fakeUser = FormMain.UserFriendsDictionary[FriendsLove_listBox.SelectedIndex];
            List<GroupBox> groupBoxes = new List<GroupBox>()
                                            {
                                                Movies_groupBox,
                                                Book_groupBox,
                                                Holiday_groupBox,
                                                Music_groupBox,
                                                Season_groupBox,
                                                Sport_groupBox,
                                            };
            List<List<string>> fakeUserProperties = new List<List<string>>()
                                                {
                                                    fakeUser.Movies,
                                                    fakeUser.Books,
                                                    fakeUser.Holiday,
                                                    fakeUser.Musics,
                                                    fakeUser.Seasons,
                                                    fakeUser.Sports,
                                                };
            List<string> userFeatures = extractChosenFeatures(groupBoxes);

            if (userFeatures.Count == groupBoxes.Count)
            {
                lovePercent = LoveCalculatorLogic.CompareCommonInterest(userFeatures, fakeUserProperties);
                showHeartGif(lovePercent);
                showMatchMessage(lovePercent, fakeUser);
            }
            else
            {
                MessageBox.Show("Please choose a favorite in each category");
            }
        }

        private void loadFakeUserNames()
        {
            foreach (KeyValuePair<int, FakeUser> element in FormMain.UserFriendsDictionary)
            {
                FriendsLove_listBox.Items.Add(element.Value.Name);
            }
        }

        private void Calculator_btn_Click(object sender, EventArgs e)
        {
            calculateLovePercent();
        }

        private void FriendsLove_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedFriendImage();
            Calculator_btn.Enabled = true;
        }
    }
}