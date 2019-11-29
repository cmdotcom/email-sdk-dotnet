using System.Collections.Generic;

namespace CM.Email.Sdk.Models
{
    public class MergeFields
    {
        /// <summary>
        /// The mergetags available. See merge tag object definition
        /// </summary>
        public List<MergeTag> MergeTags { get; set; }

        /// <summary>
        /// The special links available. See special link object definition
        /// </summary>
        public List<SpecialLink> SpecialLinks { get; set; }

        /// <summary>
        /// Constructing the MergeField object to add MergeTags and SpecialLinks
        /// </summary>
        public MergeFields()
        {
            MergeTags = new List<MergeTag>();
            SpecialLinks = new List<SpecialLink>();
        }
    }
}
