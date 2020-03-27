using System;

namespace CM.Email.Sdk.Models
{
    public class CampaignStatisticDetail
    {
        /// <summary>
        /// The email address of the recipient
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// DateTime the mail was sent on
        /// </summary>
        public DateTime? SentOnUtc { get; set; }

        /// <summary>
        /// DateTime the mail was delivered on
        /// </summary>
        public DateTime? DeliveredOnUtc { get; set; }

        /// <summary>
        /// DateTime the user opened the mail
        /// </summary>
        public DateTime? OpenedOnUtc { get; set; }

        /// <summary>
        /// DateTime the mail has bounced on
        /// </summary>
        public DateTime? BouncedOnUtc { get; set; }

        /// <summary>
        /// DateTime the user complained on
        /// </summary>
        public DateTime? ComplainedOnUtc { get; set; }

        /// <summary>
        /// DateTime the user unsubscirbed on
        /// </summary>
        public DateTime? UnsubscribedOnUtc { get; set; }

        /// <summary>
        /// DateTime it was blacklisted on. This means this recipient has caused a permanent bounce before, or unsubscribed and we haven't send to it with this campaign
        /// </summary>
        public DateTime? BlacklistedOnUtc { get; set; }

        /// <summary>
        /// How many links a user has clicked
        /// </summary>
        public int NumberOfClicks { get; set; }
    }
}
