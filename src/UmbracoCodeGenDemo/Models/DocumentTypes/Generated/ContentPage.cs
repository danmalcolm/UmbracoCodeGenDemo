namespace UmbracoCodeGenDemo.Models.DocumentTypes
{
    using System;
    using Umbraco.CodeGen.Annotations;
    
    [DocumentType(Description="Basic editable content page", Icon=".sprTreeFolder", Thumbnail="folder.png", DefaultTemplate="ContentPage", AllowedTemplates=new String[] {
            "ContentPage"}, Structure=new System.Type[] {
            typeof(ContentPage)})]
    public partial class ContentPage : Page
    {
        public ContentPage(Umbraco.Core.Models.IPublishedContent content) : 
                base(content)
        {
        }
        [GenericProperty(Description="Main content", Definition="Richtext editor", Tab="Content")]
        public virtual System.Web.IHtmlString Content
        {
            get
            {
                return GetValue<System.Web.IHtmlString>("content");
            }
        }
    }
}
