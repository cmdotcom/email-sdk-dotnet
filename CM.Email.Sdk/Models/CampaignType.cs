namespace CM.Email.Models
{
    public enum CampaignType
    {
        /// <summary>A normal newsletter campaign</summary>
        Newsletter = 1,

        /// <summary>A test for a newsletter campaign (Only supported in the EmailCampaigns app and not for creating or updating campaigns)</summary>
        TestNewsletter = 2,

        /// <summary>A Triggered campaign for sending transaction mail with the same editor and statistic features</summary>
        Triggered = 3,

        /// <summary>A test for a Triggered campaign (Only supported in the EmailCampaigns app and not for creating or updating campaigns)</summary>
        TestTriggered = 4,

        /// <summary>A AB test campaign for first testing 2-6 test campaigns and then proceeding to send the best performing test campaign to the remaining recipients</summary>
        ABTestNewsletter = 5
    }
}
