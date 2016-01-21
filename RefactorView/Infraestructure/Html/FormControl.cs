using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RefactorView.Infraestructure.Html
{
    public class FormControl
    {
        public MvcHtmlString Label { get; set; }
        public MvcHtmlString Control { get; set; }
        public MvcHtmlString Validation { get; set; }
        public string ContainerSize { get; set; }
    }
}