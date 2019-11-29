namespace CM.Email.Sdk.Models
{
    public class CampaignClickStatistic
    {
        /// <summary>
        /// The url of the link
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// The number of unique recipients that clicked this link
        /// </summary>
        public int NumberOfClicks { get; set; }
    }
}
