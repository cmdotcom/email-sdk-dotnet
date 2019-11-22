namespace CM.Email.Models
{
    public class CustomValue
    {
        /// <summary>
        /// The mergefield that you want to replace
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// The value that you want to replace the mergefield with
        /// </summary>
        public string Value { get; set; }
    }
}
