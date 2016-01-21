using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace RefactorView.Infraestructure.Html
{
    public static class BootstrapHelpers
    {
        private const string PartialBaseFolder = "~/Views/Shared/Controls/";
        private const string LabelClass = "control-label";
        private const string InputClass = "form-control";
        public static MvcHtmlString BootstrapTextboxFor<T,TValue>
            (this HtmlHelper<T> helper,
            Expression<Func<T,TValue>> property,
            Size controlSize)
        {            
            var labelSize = controlSize.GetComplement().ToString();
            var containerSize = controlSize.ToString();

            var labelClasses = $"{LabelClass} {labelSize}";            
               
            var control = new FormControl()
            {
                Label = helper.LabelFor(property,new {@class=labelClasses}),
                Control = helper.TextBoxFor(property, new { @class = InputClass }),
                ContainerSize = containerSize,
                Validation = helper.ValidationMessageFor(property)
            };

            return helper.Partial(PartialBaseFolder+"FormControl.cshtml", control);
        }
    }
}