using System;

namespace CM.Email.Sdk.Models
{
    public class Unsubscription
    {
        /// <summary>
        /// The ID of the unsubscription
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The accountID of the unsubscription
        /// </summary>
        public Guid? AccountID { get; set; }

        /// <summary>
        /// The email address that unsubscribed
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The unsubscription type
        /// </summary>
        public UnsubscriptionType UnsubscriptionType { get; set; }

        /// <summary>
        /// When the address was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// When the address was last modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }
    }
}
