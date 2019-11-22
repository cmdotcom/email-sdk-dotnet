namespace CM.Email.Models
{
    public class WebhookSettings
    {
        /// <summary>
        /// True if you want to receive sent events
        /// </summary>
        public bool Sent { get; set; }

        /// <summary>
        /// True if you want to receive unsubscribe events
        /// </summary>
        public bool Unsubscribe { get; set; }

        /// <summary>
        /// True if you want to receive delivered events
        /// </summary>
        public bool Delivered { get; set; }

        /// <summary>
        /// True if you want to receive complaint events
        /// </summary>
        public bool Complaint { get; set; }

        /// <summary>
        /// True if you want to receive bounced events
        /// </summary>
        public bool Bounced { get; set; }

        /// <summary>
        /// True if you want to receive blacklisted events
        /// </summary>
        public bool Blacklisted { get; set; }

        /// <summary>
        /// True if you want to receive opened events
        /// </summary>
        public bool Opened { get; set; }

        /// <summary>
        /// True if you want to receive viewed in browser events
        /// </summary>
        public bool ViewedInBrowser { get; set; }

        /// <summary>
        /// True if you want to receive clicked events
        /// </summary>
        public bool Clicked { get; set; }

        /// <summary>
        /// True if you want to receive permanent bounced events
        /// </summary>
        public bool PermanentBounced { get; set; }
    }
}
