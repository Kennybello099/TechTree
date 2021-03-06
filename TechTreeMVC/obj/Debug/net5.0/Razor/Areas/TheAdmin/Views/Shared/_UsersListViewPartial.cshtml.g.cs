#pragma checksum "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0c198f22f2ac0314ce9da44616c28e804599953"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TheAdmin_Views_Shared__UsersListViewPartial), @"mvc.1.0.view", @"/Areas/TheAdmin/Views/Shared/_UsersListViewPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\_ViewImports.cshtml"
using TechTreeMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\_ViewImports.cshtml"
using TechTreeMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
using TechTreeMVC.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c198f22f2ac0314ce9da44616c28e804599953", @"/Areas/TheAdmin/Views/Shared/_UsersListViewPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6c93a25d24de5e6ff0ab9f9cc1602c453eebbb", @"/Areas/TheAdmin/Views/_ViewImports.cshtml")]
    public class Areas_TheAdmin_Views_Shared__UsersListViewPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechTreeMVC.Areas.TheAdmin.Models.UsersCategoryListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
         if (Model.Users != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
             foreach (var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td style=\"text-align:center\">\r\n");
#nullable restore
#line 18 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
                 if (Model.UsersSelected != null && Model.UsersSelected.Contains(user, new CompareUsers()))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\" checked");
            BeginWriteAttribute("value", " value=\"", 697, "\"", 713, 1);
#nullable restore
#line 20 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 705, user.Id, 705, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 21 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\"");
            BeginWriteAttribute("value", " value=\"", 886, "\"", 902, 1);
#nullable restore
#line 24 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 894, user.Id, 894, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 25 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\PC\source\repos\MyTechTree\TechTreeMVC\Areas\TheAdmin\Views\Shared\_UsersListViewPartial.cshtml"
              

         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechTreeMVC.Areas.TheAdmin.Models.UsersCategoryListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
