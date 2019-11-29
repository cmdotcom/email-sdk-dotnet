namespace CM.Email.Sdk.Models
{
    public class MailingStatistic
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
        /// Statistiscs per state, see statistic object definition
        /// </summary>
        public int NumberOfItems { get; set; }
    }
}
