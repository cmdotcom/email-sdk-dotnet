using System;

namespace CM.Email.Sdk.Models
{
    public class Webhook
    {
        /// <summary>
        /// The accountID of the webhook
        /// </summary>
        public Guid AccountID { get; set; }

        /// <summary>
        /// The url of your API where the status updates will be send to
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The settings for the status update types you want to receive on your API. See object definition webhook settings
        /// </summary>
        public WebhookSettings Settings { get; set; }

        /// <summary>
        /// When the webhook was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// When the webhook was last modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// When the webhook was deleted
        /// </summary>
        public DateTime? DeletedOn { get; set; }
    }
}
