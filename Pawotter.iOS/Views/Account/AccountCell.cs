﻿using Pawotter.iOS.Views.Components;
using CoreGraphics;
using UIKit;
using System;

namespace Pawotter.iOS.Views.Account
{
    public class AccountCell : BaseCollectionViewCell
    {
        public static nfloat H => L.SmallUserIcon.Height.PlusDoublePadding();

        readonly UserIcon userIcon = new UserIcon();
        readonly Label displayName = new Label { Font = L.BoldFont, Text = "DisplayName" };
        readonly MetadataLabel acct = new MetadataLabel { Text = "userid@instance" };
        readonly FollowButton followButton = new FollowButton();

        public AccountCell() { CommonInit(); }
        public AccountCell(IntPtr handle) : base(handle) { CommonInit(); }

        void CommonInit()
        {
            userIcon.BackgroundColor = UIColor.Orange;
            AddSubviews(userIcon, displayName, acct, followButton);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            var textW = this.Width() - 100;
            userIcon.Frame = new CGRect(L.PaddingL, L.PaddingL, L.SmallUserIcon.Width, L.SmallUserIcon.Height);
            followButton.Frame = new CGRect(this.Width().MinusPadding() - FollowButton.Size.Width, userIcon.MinY(), FollowButton.Size.Width, FollowButton.Size.Height);
            displayName.Frame = new CGRect(userIcon.MaxX().PlusPadding(), userIcon.MinY(), textW, L.NormalFont.LineHeight);
            acct.Frame = new CGRect(displayName.X(), displayName.MaxY(), textW, L.NormalFont.LineHeight);
        }
    }
}
