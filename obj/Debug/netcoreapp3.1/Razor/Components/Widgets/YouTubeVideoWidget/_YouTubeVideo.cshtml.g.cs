#pragma checksum "D:\Projects\Xperience13\CoreComponents\MPSubmission\RBT-Xperience-Core-Components-YouTube-Video\Components\Widgets\YouTubeVideoWidget\_YouTubeVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c37b3d1103228bf1e3f900d04488fded49c4f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_Widgets_YouTubeVideoWidget__YouTubeVideo), @"mvc.1.0.view", @"/Components/Widgets/YouTubeVideoWidget/_YouTubeVideo.cshtml")]
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
#line 1 "D:\Projects\Xperience13\CoreComponents\MPSubmission\RBT-Xperience-Core-Components-YouTube-Video\Components\Widgets\YouTubeVideoWidget\_YouTubeVideo.cshtml"
using RBT.Xperience.Core.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c37b3d1103228bf1e3f900d04488fded49c4f8d", @"/Components/Widgets/YouTubeVideoWidget/_YouTubeVideo.cshtml")]
    #nullable restore
    public class Components_Widgets_YouTubeVideoWidget__YouTubeVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YouTubeVideoWidgetViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projects\Xperience13\CoreComponents\MPSubmission\RBT-Xperience-Core-Components-YouTube-Video\Components\Widgets\YouTubeVideoWidget\_YouTubeVideo.cshtml"
  
    var VideoURL = string.Format("{0}{1}{2}", @Model.VideoURL, @Model.VideoURL.Contains("?") ? "&" : "?", Model.VideoParameters.TrimStart(new char[]
    {
'&'
    }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Xperience13\CoreComponents\MPSubmission\RBT-Xperience-Core-Components-YouTube-Video\Components\Widgets\YouTubeVideoWidget\_YouTubeVideo.cshtml"
 if (VideoURL != null && VideoURL.Contains("youtube") )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <iframe");
            BeginWriteAttribute("width", "  width=\"", 326, "\"", 347, 1);
#nullable restore
#line 12 "D:\Projects\Xperience13\CoreComponents\MPSubmission\RBT-Xperience-Core-Components-YouTube-Video\Components\Widgets\YouTubeVideoWidget\_YouTubeVideo.cshtml"
WriteAttributeValue("", 335, Model.Width, 335, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("height", " height=\"", 348, "\"", 370, 1);
#nullable restore
#line 12 "D:\Projects\Xperience13\CoreComponents\MPSubmission\RBT-Xperience-Core-Components-YouTube-Video\Components\Widgets\YouTubeVideoWidget\_YouTubeVideo.cshtml"
WriteAttributeValue("", 357, Model.Height, 357, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 371, "\"", 386, 1);
#nullable restore
#line 12 "D:\Projects\Xperience13\CoreComponents\MPSubmission\RBT-Xperience-Core-Components-YouTube-Video\Components\Widgets\YouTubeVideoWidget\_YouTubeVideo.cshtml"
WriteAttributeValue("", 377, VideoURL, 377, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 387, "\"", 395, 0);
            EndWriteAttribute();
            WriteLiteral(" ></iframe>\r\n");
#nullable restore
#line 13 "D:\Projects\Xperience13\CoreComponents\MPSubmission\RBT-Xperience-Core-Components-YouTube-Video\Components\Widgets\YouTubeVideoWidget\_YouTubeVideo.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YouTubeVideoWidgetViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591