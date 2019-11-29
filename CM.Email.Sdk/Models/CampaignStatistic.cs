namespace CM.Email.Sdk.Models
{
    public class CampaignStatistic
    {
        /// <summary>
        /// The ID of status
        /// </summary>
        public int StatusID { get; set; }

        /// <summary>
        /// The name of the status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Number of items with this status
        /// </summary>
        public int NumberOfItems { get; set; }
    }
}
