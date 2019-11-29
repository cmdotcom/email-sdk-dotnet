using System;

namespace CM.Email.Sdk.Models
{
    public class FromDomain
    {
        /// <summary>
        /// The ID of the from domain
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The accountID of the from domain
        /// </summary>
        public Guid AccountID { get; set; }

        /// <summary>
        /// The domain, for example myawesomecompany.com
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Whether the domain is verified and can be used in from addresses. This is true when all DNS entries are created correctly and have been verified
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Dns entries for this domain, see dns entry object definition
        /// </summary>
        public FromDomainDnsEntry[] DnsEntries { get; set; }

        /// <summary>
        /// When the from domain was created
        /// </summary>
        public DateTime Createdon { get; set; }

        /// <summary>
        /// When the from domain was modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// When the from domain was deleted
        /// </summary>
        public DateTime? DeletedOn { get; set; }
    }
}
