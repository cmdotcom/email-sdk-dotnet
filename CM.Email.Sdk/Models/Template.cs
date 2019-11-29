using System;

namespace CM.Email.Sdk.Models
{
    public class Template
    {
        /// <summary>
        /// The ID of the template
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The accountID of the template
        /// </summary>
        public Guid? AccountID { get; set; }

        /// <summary>
        /// The name of the template
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the template
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The html body of the template. This is the body that recipients with a normal e-mail client will get
        /// </summary>
        public string HtmlBody { get; set; }

        /// <summary>
        /// The text body of the template. This is the body that recipients will get when their e-mail client doesn't support HTML
        /// </summary>
        public string TextBody { get; set; }

        /// <summary>
        /// The json of the template. This field is only used when you use our editor. You can leave this blank
        /// </summary>
        public string Json { get; set; }

        /// <summary>
        /// The mergefields that will be replaced using campaigns
        /// </summary>
        public MergeFields MergeFields { get; set; }

        /// <summary>
        /// When the template was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// When the template was last modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// When the template was deleted
        /// </summary>
        public DateTime? DeletedOn { get; set; }
    }
}
