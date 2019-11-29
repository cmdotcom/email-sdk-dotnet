namespace CM.Email.Sdk.Models
{
    public enum UnsubscriptionType
    {
        /// <summary>The email unsubscribed from campaigns</summary>
        UserUnsubscribe = 1,

        /// <summary>The email got unsubscribed because it filed a complaint</summary>
        Complaint = 2,

        /// <summary>The email got unsubscribed because when it was sent it returned a permanent bounce</summary>
        PermanentBounce = 3
    }
}
