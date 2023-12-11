using System.Diagnostics;
using Microsoft.Maui.Handlers;

namespace CustomNavRendererDemo
{
    public static class ToolbarHandlerMapper
    {
        public static void Initialize()
        {
            ToolbarHandler.Mapper.AppendToMapping("ToolbarHandlerMapper", (handler, toolbar) =>
            {
                Debug.WriteLine("In ToolbarHandlerMapper");

#if IOS
                var navigationBar = handler.PlatformView as UIKit.UINavigationBar;
                
                navigationBar.BackgroundColor = UIKit.UIColor.Orange;

#elif ANDROID

                var materialToolbar = handler.PlatformView as Google.Android.Material.AppBar.MaterialToolbar;

                materialToolbar.Title = "Set in ToolbarHandlerMapper";
                materialToolbar.TitleCentered = true;

#endif
            });
        }
    }
}

