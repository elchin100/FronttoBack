#pragma checksum "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04a758a420203ab8efc38a7d451f11d07652f7f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trainers_Index), @"mvc.1.0.view", @"/Views/Trainers/Index.cshtml")]
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
#line 2 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\_ViewImports.cshtml"
using P129Mentor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a758a420203ab8efc38a7d451f11d07652f7f6", @"/Views/Trainers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e509731788b299fbfdc6184d96feefa13bcf03ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Trainers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Trainer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"" data-aos=""fade-in"">

    <!-- ======= Breadcrumbs ======= -->
    <div class=""breadcrumbs"">
        <div class=""container"">
            <h2>Trainers</h2>
            <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
        </div>
    </div><!-- End Breadcrumbs -->
    <!-- ======= Trainers Section ======= -->
    <section id=""trainers"" class=""trainers"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"" data-aos=""zoom-in"" data-aos-delay=""100"">
");
#nullable restore
#line 20 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
                 foreach (Trainer trainer in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                        <div class=\"member\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 958, "\"", 998, 2);
            WriteAttributeValue("", 964, "assets/img/trainers/", 964, 20, true);
#nullable restore
#line 24 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 984, trainer.Image, 984, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1017, "\"", 1023, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"member-content\">\r\n                                <h4>");
#nullable restore
#line 26 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
                               Write(trainer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <span>");
#nullable restore
#line 27 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
                                 Write(trainer.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 29 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
                               Write(trainer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <div class=\"social\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1435, "\"", 1463, 3);
            WriteAttributeValue("", 1442, "(", 1442, 1, true);
#nullable restore
#line 32 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 1443, trainer.TwitterUrl, 1443, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1462, ")", 1462, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1538, "\"", 1567, 3);
            WriteAttributeValue("", 1545, "(", 1545, 1, true);
#nullable restore
#line 33 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 1546, trainer.FacebookUrl, 1546, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1566, ")", 1566, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1643, "\"", 1672, 2);
            WriteAttributeValue("", 1650, "(", 1650, 1, true);
#nullable restore
#line 34 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 1651, trainer.InstagramUrl, 1651, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1749, "\"", 1777, 2);
            WriteAttributeValue("", 1756, "(", 1756, 1, true);
#nullable restore
#line 35 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 1757, trainer.LinkedinUrl, 1757, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\Users\Elchin\source\repos\P129Mentor\P129Mentor\Views\Trainers\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n</section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Trainer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
