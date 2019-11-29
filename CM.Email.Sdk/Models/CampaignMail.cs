using System;

namespace CM.Email.Sdk.Models
{
    public class CampaignMail
    {
        /// <summary>
        /// The ID of the send mail
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The account guid
        /// </summary>
        public Guid AccountID { get; set; }

        /// <summary>
        /// The campaign guid you want to send the email for
        /// </summary>
        public Guid CampaignID { get; set; }

        /// <summary>
        /// The email address you want to send the email to
        /// </summary>
        public string ToAddress { get; set; }

        /// <summary>
        /// The name of the person to send your mail to
        /// </summary>
        public string ToName { get; set; }

        /// <summary>
        /// The custom values you want to use inside you triggered campaign
        /// </summary>
        public CustomValue[] CustomValues { get; set; }
    }
}
