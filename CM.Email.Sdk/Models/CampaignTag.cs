using System;

namespace CM.Email.Sdk.Models
{
    public class CampaignTag
    {
        /// <summary>
        /// The ID of the campaign tag
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The accountID of the campaign tag
        /// </summary>
        public Guid AccountID { get; set; }

        /// <summary>
        /// The name of the tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// When the tag was created
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// When the tag was modified
        /// </summary>
        public DateTime ModifiedOnUtc { get; set; }

        /// <summary>
        /// When the tag was deleted
        /// </summary>
        public DateTime? DeletedOnUtc { get; set; }
    }
}
