namespace CM.Email.Sdk.Models
{
    public enum TestMetricType
    {
        /// <summary>The rate of emails opened/sent (Example: 3 opened / 4 sent = OpenRate 0.75</summary>
        ByOpenRate = 1,

        /// <summary>The rate of emails clicked/sent (Example: 2 clicked / 4 sent = ClickRate 0.5</summary>
        ByClickRate = 2,

        /// <summary>The rate of emails clicked/opened (Example: 2 clicked / 3 opened = ClickThroughRate 0.67</summary>
        ByClickThroughRate = 3
    }
}
