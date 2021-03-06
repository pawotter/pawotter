﻿using UIKit;

namespace Pawotter.iOS.Views
{
    public static class R
    {
        public static UIImage Home => UIImage.FromBundle("ic_home").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
        public static UIImage Local => UIImage.FromBundle("ic_people").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
        public static UIImage Federated => UIImage.FromBundle("ic_public").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
        public static UIImage Notifications => UIImage.FromBundle("ic_notifications").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
        public static UIImage Others => UIImage.FromBundle("ic_more_horiz").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);

        public static UIImage Edit => UIImage.FromBundle("ic_border_color").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
        public static UIImage Search => UIImage.FromBundle("ic_search").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
        public static UIImage Favourite => UIImage.FromBundle("ic_star").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
        public static UIImage Reply => UIImage.FromBundle("ic_reply").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
        public static UIImage Reblog => UIImage.FromBundle("ic_cached").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
    }
}
