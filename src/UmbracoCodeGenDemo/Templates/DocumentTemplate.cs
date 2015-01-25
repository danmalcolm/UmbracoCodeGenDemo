using System;
using System.Linq;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using UmbracoCodeGenDemo.Models.DocumentTypes;

namespace UmbracoCodeGenDemo.Templates
{
    public abstract class DocumentTemplate<TDocument> : UmbracoViewPage<RenderModel>
        where TDocument : Page
    {
        private TDocument document;

        protected DocumentTemplate()
        {
        }

        public TDocument Document
        {
            get
            {
                if (document == null)
                {
                    var ctor = typeof(TDocument).GetConstructors().First();
                    document = ctor.Invoke(new object[] { Umbraco.AssignedContentItem }) as TDocument;
                }
                return document;
            }
        }
    }
}