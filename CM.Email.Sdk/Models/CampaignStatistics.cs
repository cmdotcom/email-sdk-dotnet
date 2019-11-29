using System;
using System.Collections.Generic;

namespace CM.Email.Sdk.Models
{
    public class CampaignStatistics
    {
        /// <summary>
        /// The ID of the campaign
        /// </summary>
        public Guid CampaignID { get; set; }

        /// <summary>
        /// Total number of recipients
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Statistiscs per state, see statistic object definition
        /// </summary>
        public List<CampaignStatistic> Statistics { get; set; }
    }
}
