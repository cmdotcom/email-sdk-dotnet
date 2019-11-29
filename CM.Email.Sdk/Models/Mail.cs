using System;

namespace CM.Email.Sdk.Models
{
    public class Mail
    {
        /// <summary>
        /// The ID of the mail
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The accountID of the mail
        /// </summary>
        public Guid AccountID { get; set; }

        /// <summary>
        /// The ID of the from address you want to send with. Make sure this address is created as a sender first
        /// </summary>
        public Guid FromAddressID { get; set; }

        /// <summary>
        /// The from name to use in your mail. Leave null if you want to use the email address only
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// The ID of the address you want the recipient to reply to when he click the reply button. Make sure this address is created as a sender first. Leave null to use the from address as the reply to
        /// </summary>
        public Guid? ReplyToAddressID { get; set; }

        /// <summary>
        /// The address to send your mail to
        /// </summary>
        public string ToAddress { get; set; }

        /// <summary>
        /// The name of the person to send your mail to
        /// </summary>
        public string ToName { get; set; }

        /// <summary>
        /// The Ccs for this mail. An array of email addresses needs to be passed. See the email address object definition. Keep in mind that every cc will count as an additional mail. When you have a cc it's impossible to know wheter the recipient or the person in the cc opened or clicked the mail
        /// </summary>
        public MailAddress[] Ccs { get; set; }

        /// <summary>
        /// The Bccs for this mail. An array of email addresses needs to be passed. See the email address object definition. Keep in mind that every bcc will count as an additional mail. When you have a bcc it's impossible to know wheter the recipient or the person in the bcc opened or clicked the mail
        /// </summary>
        public MailAddress[] Bccs { get; set; }

        /// <summary>
        /// The subject of your mail
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The html body of the template. This is the body that recipients with a normal e-mail client will get
        /// </summary>
        public string HtmlBody { get; set; }

        /// <summary>
        /// The text body of the template. This is the body that recipients will get when their e-mail client doesn't support HTML
        /// </summary>
        public string TextBody { get; set; }

        /// <summary>
        /// The attachments for this mail. Attachments will not be returned in the response when sending a mail. See the attachment object definition
        /// </summary>
        public Attachment[] Attachments { get; set; }

        /// <summary>
        /// Your own reference. We will use this reference also in the status updates we will send to you when you have a webhook configured
        /// </summary>
        public string CustomerReference { get; set; }

        /// <summary>
        /// When the mail was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// When the mail was last modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }
    }
}
