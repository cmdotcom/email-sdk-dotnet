using System;

namespace CM.Email.Sdk.Models
{
    public class Mailing
    {
        /// <summary>
        /// The ID of the mailing
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The accountID of the mailing
        /// </summary>
        public Guid AccountID { get; set; }

        /// <summary>
        /// The campaignID that the mailing belongs to
        /// </summary>
        public Guid CampaignID { get; set; }

        /// <summary>
        /// The name of the mailing
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The from name to use in your mailing. Leave null if you want to use the email address only
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// The ID of the from address you want to send with. Make sure this address is verified first
        /// </summary>
        public Guid? FromAddressID { get; set; }

        /// <summary>
        /// The ID of the from address you want to set as reply to. Make sure this address is verified first
        /// </summary>
        public Guid? ReplyToAddressID { get; set; }

        /// <summary>
        /// The subject of your mailing. The subject can include merge fields as well, for example: Hi {{ Recipient.FirstName }}, see this awesome mail!
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The state of the mailing
        /// </summary>
        public MailingState MailingState { get; set; }

        /// <summary>
        /// The type of the mailing
        /// </summary>
        public MailingType MailingType { get; set; }

        /// <summary>
        /// The template that will be used to send the campaign with
        /// </summary>
        public Template Template { get; set; }

        /// <summary>
        /// When the mailing was created
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// When the mailing was last modified
        /// </summary>
        public DateTime ModifiedOnUtc { get; set; }

        /// <summary>
        /// When the mailing was deleted
        /// </summary>
        public DateTime? DeletedOnUtc { get; set; }
    }
}
