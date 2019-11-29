using System;
using System.Collections.Generic;

namespace CM.Email.Sdk.Models
{
    public class MailingStatistics
    {
        /// <summary>
        /// The ID of the mailing
        /// </summary>
        public Guid MailingID { get; set; }

        /// <summary>
        /// Total number of recipients
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Statistiscs per state, see statistic object definition
        /// </summary>
        public List<MailingStatistic> Statistics { get; set; }
    }
}
