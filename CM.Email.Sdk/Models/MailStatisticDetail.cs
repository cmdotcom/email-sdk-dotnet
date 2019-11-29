using System;

namespace CM.Email.Models
{
    public class MailStatisticDetail
    {
        /// <summary>
        /// The email address of the recipient
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The subject of the mail
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// When the mail was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// DateTime the mail was sent on
        /// </summary>
        public DateTime? SentOn { get; set; }

        /// <summary>
        /// DateTime the mail was delivered on
        /// </summary>
        public DateTime? DeliveredOn { get; set; }

        /// <summary>
        /// DateTime the user opened the mail
        /// </summary>
        public DateTime? OpenedOn { get; set; }

        /// <summary>
        /// DateTime the mail has bounced on
        /// </summary>
        public DateTime? BouncedOn { get; set; }

        /// <summary>
        /// DateTime the user complained on
        /// </summary>
        public DateTime? ComplainedOn { get; set; }

        /// <summary>
        /// DateTime the user unsubscirbed on
        /// </summary>
        public DateTime? UnsubscribedOn { get; set; }

        /// <summary>
        /// DateTime it was blacklisted on. This means this recipient has caused a permanent bounce before, or unsubscribed and we haven't send to it with this mailing
        /// </summary>
        public DateTime? BlacklistedOn { get; set; }

        /// <summary>
        /// How many links a user has clicked
        /// </summary>
        public int NumberOfClicks { get; set; }
    }
}
