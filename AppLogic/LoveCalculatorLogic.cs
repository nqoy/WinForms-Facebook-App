namespace AppLogic
{
    using System.Collections.Generic;

    public static class LoveCalculatorLogic
    {
        private const float k_MatchThreshold = 80f;
        private const float k_MatchPercentAddition = 100 / 6f;

        public static bool IsLovePercentSufficient(float i_LovePercent)
        {
            return i_LovePercent >= k_MatchThreshold;
        }

        public static float CompareCommonInterest(List<string> i_UserFeature, List<List<string>> i_FakeUserProperties)
        {
            float matchPercentResult = 0;

            for(int i = 0; i < i_UserFeature.Count; i++)
            {
                matchPercentResult += i_FakeUserProperties[i].Contains(i_UserFeature[i]) ? k_MatchPercentAddition : 0;
            }

            return matchPercentResult;
        }

        public static string GetDatingMail(string i_FakeUserName)
        {
            return $"{i_FakeUserName.Replace(" ", string.Empty)}@yahoo.com";
        }
    }
}
