﻿using CoreGraphics;
using Pawotter.iOS.Views.Components;
using UIKit;
using Pawotter.Core.Consts;
using System;

namespace Pawotter.iOS.Views.Notification
{
    public sealed class NotificationHeader : UICollectionReusableView
    {
        readonly UISegmentedControl segmentedControl = new UISegmentedControl("All", "Mentions") { SelectedSegment = 0 };
        readonly Border bottomBorder = new Border();

        public NotificationHeader() { CommonInit(); }
        public NotificationHeader(IntPtr handle) : base(handle) { CommonInit(); }

        void CommonInit()
        {
            BackgroundColor = ColorConsts.Background.Color();
            AddSubviews(segmentedControl, bottomBorder);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            segmentedControl.Frame = new CGRect(L.PaddingM, L.PaddingM, this.Width().MinusPadding(), L.Banner.MinusPadding());
            bottomBorder.Frame = new CGRect(0, this.Height() - L.BorderW, this.Width(), L.BorderW);
        }
    }
}
