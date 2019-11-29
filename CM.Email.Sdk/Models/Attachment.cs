namespace CM.Email.Models
{
    public class Attachment
    {
        /// <summary>
        /// The filename of the attachment, for example: "CalendarInvite.ics"
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The base64 encoded content of the attachment
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The ContentID can be specified for images, to reference it in your image tag in your HTML. You can use "cid:yourcontentid" in the src tag of the image to display the image inline
        /// </summary>
        public string ContentID { get; set; }
    }
}
