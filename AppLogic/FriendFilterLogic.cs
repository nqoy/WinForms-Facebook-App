namespace AppLogic
{
    using System.Collections.Generic;
    using System.Linq;

    public static class FriendFilterLogic
    {
        private static readonly Dictionary<string, List<string>> sr_FeatureFilterDictionary = new Dictionary<string, List<string>>();

        public static void EditFilterToFilterDict(bool i_Checked, string i_GroupBoxName, string i_Feature)
        {
            List<string> filteredFeaturesList = null;

            if (i_Checked)
            {
                if (sr_FeatureFilterDictionary.ContainsKey(i_GroupBoxName))
                {
                    filteredFeaturesList = sr_FeatureFilterDictionary[i_GroupBoxName];
                    if (!filteredFeaturesList.Contains(i_Feature))
                    {
                        filteredFeaturesList.Add(i_Feature);
                    }
                }
                else
                {
                    filteredFeaturesList = new List<string>{i_Feature};
                    sr_FeatureFilterDictionary.Add(i_GroupBoxName, filteredFeaturesList);
                }
            }
            else
            {
                filteredFeaturesList = sr_FeatureFilterDictionary[i_GroupBoxName];
                filteredFeaturesList.Remove(i_Feature);
                if (filteredFeaturesList.Count == 0)
                {
                    sr_FeatureFilterDictionary.Remove(i_GroupBoxName);
                }
            }
        }

        public static bool CheckSpecificFriendFeatures(FakeUser i_Friend)
        {
            bool isFilterOfFriendOK = true;

            foreach (KeyValuePair<string, List<string>> element in sr_FeatureFilterDictionary)
            {
                dynamic propertyValue = i_Friend.GetType().GetProperty(element.Key).GetValue(i_Friend, null);

                if (element.Value.Count == 1)
                {
                    isFilterOfFriendOK = element.Value.Any(value => propertyValue.Contains(value));
                }
                else
                {
                    isFilterOfFriendOK = element.Value.All(value => propertyValue.Contains(value));
                }

                if (!isFilterOfFriendOK)
                {
                    break;
                }
            }

            return isFilterOfFriendOK;
        }

        public static string GetFriendMail(string i_FakeUserName)
        {
            return $"{i_FakeUserName.Replace(" ", string.Empty)}@gmail.com";
        }
    }
}
