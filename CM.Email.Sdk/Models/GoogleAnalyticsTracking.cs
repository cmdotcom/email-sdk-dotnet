using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Email.Sdk.Models
{
    public class GoogleAnalyticsTracking
    {
        /// <summary>
        /// The source to put in the utm_source tag
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// The medium to put in the utm_medium tag
        /// </summary>
        public string Medium { get; set; }

        /// <summary>
        /// The campaign to put in the utm_campaign tag
        /// </summary>
        public string Campaign { get; set; }
    }
}
