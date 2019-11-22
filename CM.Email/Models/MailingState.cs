namespace CM.Email.Models
{
    public enum MailingState
    {
        /// <summary>The mailing is saved</summary>
        Saved = 1,

        /// <summary>The mailing is set to send, but is not yet sent. (In this state you can still edit your mailing. Triggered mailings can be updated at any time)</summary>
        ReadyForSending = 2,

        /// <summary>The mailing is currently being processed to be sent (At this point you can't edit your mailing anymore</summary>
        PickedUpByProcessor = 3,

        /// <summary>The mailing is (being) sent</summary>
        Processed = 4,

        /// <summary>The campaign has been stopped because the bouncerate or complaintrate exceeded their limits</summary>
        Stopped = 5,

        /// <summary>The campaign has stopped sending because the wallet has insufficient funds</summary>
        OutOfCredits = 6
    }
}
