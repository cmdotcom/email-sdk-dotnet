namespace CM.Email.Models
{
    public class MergeTag
    {
        /// <summary>
        /// The name of the merge tag
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value of the merge tag. This is the placeholder that will be replaced in the body of the mail, for example: {{ Recipient.Url }}
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The field in the address object it should be replaced with, for example: Recipient.MergeFieldValue1
        /// </summary>
        public string Mapping { get; set; }
    }
}
