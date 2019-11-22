namespace CM.Email.Models
{
    public class FromDomainDnsEntry
    {
        /// <summary>
        /// The host of the DNS entry
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The type of the DNS entry
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The value of the DNS entry
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Whether this entry has been entered correctly or not. Please note that the verify method should be called first
        /// </summary>
        public bool IsValid { get; set; }
    }
}
