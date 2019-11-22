namespace CM.Email.Models
{
    public class SpecialLink
    {
        /// <summary>
        /// The of the link, this should be either system or link
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The label of the link. This is just for recognizing the link, it won't replace the label in the body
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// This is the placeholder in the body that will be replaced, for example [[ SpecialLink.link2 ]]
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// The url this link should map to, for example: https://www.cm.com. This can also be a merge field, for example: {{ Recipient.Url }}
        /// </summary>
        public string Mapping { get; set; }

        /// <summary>
        /// The name of the tag
        /// </summary>
        public string Tag { get; set; }
    }
}
