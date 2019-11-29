using System;

namespace CM.Email.Sdk.Models
{
    public class FromAddress
    {
        /// <summary>
        /// The ID of the from address
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The accountID of the from address
        /// </summary>
        public Guid AccountID { get; set; }

        /// <summary>
        /// The default from name that will be used in the campaign. This can still be overwritten when sending a campaign
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The address to send from
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// When the address was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// When the address was last modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// When the address was deleted
        /// </summary>
        public DateTime? DeletedOn { get; set; }
    }
}
