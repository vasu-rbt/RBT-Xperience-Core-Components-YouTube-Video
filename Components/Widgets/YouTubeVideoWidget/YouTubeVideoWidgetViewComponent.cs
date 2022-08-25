using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace RBT.Xperience.Core.Components
{
    public class YouTubeVideoWidgetViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ComponentViewModel<YouTubeVideoWidgetProperties> componentViewModel)
        {
            var properties = componentViewModel.Properties;
            var viewModel = new YouTubeVideoWidgetViewModel
            {
                VideoURL = (properties.VideoURL != null) ? properties.VideoURL.Replace("/watch?v=", "/embed/") : string.Empty,
                Width = properties.Width,
                Height = properties.Height,
                VideoParameters = GetYouTubeVideo(properties.IsShowRelatedVideos, properties.IsFullScreen, properties.IsAutoPlay)
            };
            return View("~/Components/Widgets/YouTubeVideoWidget/_YouTubeVideo.cshtml", viewModel);
        }
        private string GetYouTubeVideo(bool relVideos, bool fullScreen, bool autoPlay)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(autoPlay ? "&autoplay=1&mute=1" : string.Empty);
            stringBuilder.Append(fullScreen ? "&fs=1" : "&fs=0");
            stringBuilder.Append((!relVideos) ? "&rel=0" : string.Empty);
            stringBuilder.Append("&enablejsapi=1&version=3");
            return stringBuilder.ToString();
        }

    }
}