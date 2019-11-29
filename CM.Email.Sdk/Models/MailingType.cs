namespace CM.Email.Models
{
    public enum MailingType
    {
        /// <summary>A normal newsletter mailing</summary>
        Newsletter = 1,
        
        /// <summary>A test for a newsletter mailing (Only supported in the Emailmailings app and not for creating or updating mailings)</summary>
        TestNewsletter = 2,

        /// <summary>A Triggered mailing for sending transaction mail with the same editor and statistic features</summary>
        Triggered = 3,

        /// <summary>A test for a Triggered mailing (Only supported in the Emailmailings app and not for creating or updating mailings)</summary>
        TestTriggered = 4,

        /// <summary>The mailing is a AB test variation of a AB test mailing (This is what will be send out during the test fase)</summary>
        ABTestVariation = 5,
        
        /// <summary>The mailing that will be send out when the winning mailing (ABTestVariation) has been calculated</summary>
        ABTestResult = 6
    }
}
