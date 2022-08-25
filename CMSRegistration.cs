using CMS;
using Kentico.PageBuilder.Web.Mvc;
using RBT.Xperience.Core.Components;

[assembly: AssemblyDiscoverable]
[assembly: RegisterWidget("RBT.Xperience.Core.Components.YouTubeVideo",
    typeof(YouTubeVideoWidgetViewComponent),
    "YouTube Video",
    typeof(YouTubeVideoWidgetProperties),
    Description = "Insert the video from specified YouTube URL location..",
    IconClass = "icon-brand-youtube")]
