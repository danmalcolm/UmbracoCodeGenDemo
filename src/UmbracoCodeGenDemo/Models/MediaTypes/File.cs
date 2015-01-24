namespace MyWeb.Models
{
    using System;
    using Umbraco.CodeGen.Annotations;
    
    [MediaType(Icon="icon-document", Thumbnail="icon-document")]
    public partial class File : Umbraco.CodeGen.WaitForSixTwo.PublishedContentModel
    {
        public File(Umbraco.Core.Models.IPublishedContent content) : 
                base(content)
        {
        }
        [GenericProperty(DisplayName="Upload file", Definition="Textstring", Tab="File")]
        public virtual String UmbracoFile
        {
            get
            {
                return GetValue<String>("umbracoFile");
            }
        }
        [GenericProperty(DisplayName="Type", Definition="Textstring", Tab="File")]
        public virtual String UmbracoExtension
        {
            get
            {
                return GetValue<String>("umbracoExtension");
            }
        }
        [GenericProperty(DisplayName="Size", Definition="Textstring", Tab="File")]
        public virtual String UmbracoBytes
        {
            get
            {
                return GetValue<String>("umbracoBytes");
            }
        }
    }
}
