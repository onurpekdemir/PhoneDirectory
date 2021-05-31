#pragma checksum "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aadca3bb8dab76408f9c4fea4b0e8c03fa1b6b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\_ViewImports.cshtml"
using PD.Client.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\_ViewImports.cshtml"
using PD.Client.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aadca3bb8dab76408f9c4fea4b0e8c03fa1b6b63", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad822b4d24b9c28dd0527d897325db87561f24f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactQueryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<a href=""/contact/add"" class=""btn btn-success btn-lg btn-block""> Add New Contact</a>

<div class=""pt-2""></div>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Last Name</th>
            <th scope=""col"">Firm</th>
            <th width=""15%"" scope=""col""></th>
            <th width=""10%"" scope=""col""></th>
            <th width=""10%"" scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml"
           Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml"
           Write(Model[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml"
           Write(Model[i].Firm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 732, "\"", 768, 2);
            WriteAttributeValue("", 739, "/contact/details/", 739, 17, true);
#nullable restore
#line 26 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml"
WriteAttributeValue("", 756, Model[i].ID, 756, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Contact Info</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 832, "\"", 867, 2);
            WriteAttributeValue("", 839, "/contact/update/", 839, 16, true);
#nullable restore
#line 27 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml"
WriteAttributeValue("", 855, Model[i].ID, 855, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Update</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 928, "\"", 963, 2);
            WriteAttributeValue("", 935, "/contact/delete/", 935, 16, true);
#nullable restore
#line 28 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml"
WriteAttributeValue("", 951, Model[i].ID, 951, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "D:\Projects\PhoneDirectory\PD.Client.Web\Views\Contact\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactQueryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
