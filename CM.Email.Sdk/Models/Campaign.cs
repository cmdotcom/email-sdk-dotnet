using System;

namespace CM.Email.Sdk.Models
{
    public class Campaign
    {
        /// <summary>
        /// The ID of the campaign
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The accountID of the campaign
        /// </summary>
        public Guid AccountID { get; set; }

        /// <summary>
        /// The name of the campaign
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the campaign
        /// </summary>
        public CampaignType CampaignType { get; set; }

        /// <summary>
        /// The state of the campaign
        /// </summary>
        public CampaignState CampaignState { get; set; }

        /// <summary>
        /// The ID of the address list you want to send to
        /// </summary>
        public Guid? ToAddressListID { get; set; }

        /// <summary>
        /// The datetime to schedule this campaign. This datetime is currently in the dutch timezone. Leave null if you want to send a campaign right away
        /// </summary>
        public DateTime? ScheduledOn { get; set; }

        /// <summary>
        /// The test percentage multiplier to use for your AB test newletter. This should be at least 0.10 (10%) or higher. Leave null if you want to send a newsletter or triggered campaign
        /// </summary>
        public decimal? TestPercentage { get; set; }

        /// <summary>
        /// The test duration to use for your AB test newsletter, this sould be at least 240 minutes (4 hours). Leave null if you want to send a newsletter or triggered campaign
        /// </summary>
        public int? TestDurationMinutes { get; set; }

        /// <summary>
        /// The type of the AB test metric. Leave null if you want to send a newsletter or triggered campaign
        /// </summary>
        public TestMetricType? TestMetricType { get; set; }

        /// <summary>
        /// The datetime to calculate the winning mailing and send it. This value is calculated automatically. This datetime is currently in the dutch timezone
        /// </summary>
        public DateTime? SendToRemainingOn { get; set; }

        /// <summary>
        /// The ID of the best performing mailing based on the TestDuration and TestMetricType. This value will be filled when the campaign has the PickedUpByFinisher state
        /// </summary>
        public Guid? WinningVariationID { get; set; }

        /// <summary>
        /// The total recipients of your campaign. This one will automatically be filled when you create the campaign based on your address list.
        /// </summary>
        public int TotalRecipients { get; set; }

        /// <summary>
        /// CampaignTags added to the campaign
        /// </summary>
        public CampaignTag[] CampaignTags { get; set; }

        /// <summary>
        /// When the campaign was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// When the campaign was last modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// When the campaign was deleted
        /// </summary>
        public DateTime? DeletedOn { get; set; }
    }
}
