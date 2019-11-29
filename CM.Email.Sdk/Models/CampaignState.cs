namespace CM.Email.Models
{
    /// <summary>
    /// The states a campaign can be in when created in EmailCampaigns
    /// </summary>
    public enum CampaignState
    {
        /// <summary>The campaign is saved</summary>
        Saved = 1,

        /// <summary>The campaign is set to send, but is not yet sent. (In this state you can still edit your campaign, but make sure you set it to ReadyForSending again when your finished. Triggered Campaigns can be updated at any time)</summary>
        ReadyForSending = 2,

        /// <summary>The campaign is currently being processed to be sent (At this point you can't edit your campaign anymore</summary>
        PickedUpByProcessor = 3,

        /// <summary>The campaign is (being) sent</summary>
        Processed = 4,

        /// <summary>The campaign has been stopped because the bouncerate or complaintrate exceeded their limits</summary>
        Stopped = 5,

        /// <summary>The campaign has stopped sending because the wallet has insufficient funds</summary>
        OutOfCredits = 6,           

        /// <summary>When your AB test campaign is sent and the results are coming in</summary>
        ABTestInProgress = 7,

        /// <summary>When you AB test campaign has it's results and starts sending the winning test campaign</summary>
        PickedUpByFinisher = 8
    }
}
