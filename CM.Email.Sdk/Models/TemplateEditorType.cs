namespace CM.Email.Sdk.Models
{
    public enum TemplateEditorType
    {
        /// <summary>The Drag & Drop editor type is for use with the Drag & Drop editor in the EmailCampaigns webapp. (Don't use this type for custom HTML templates)</summary>
        DragAndDropEditor = 1,
        /// <summary>A normal HTML template (Use this when you want to save custom HTML templates</summary>
        HtmlEditor = 2
    }
}
