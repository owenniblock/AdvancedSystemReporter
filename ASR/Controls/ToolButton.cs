﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Resources;
using Sitecore.Web.UI;
using Sitecore.Shell.Framework.Commands;

namespace ASR.Controls
{
    public class ToolButton:Sitecore.Web.UI.HtmlControls.Toolbutton
    {
        protected override void DoRender(System.Web.UI.HtmlTextWriter output)
        {
            base.Icon = this.Icon;
            base.DoRender(output);
        }
        public override void LoadFromItem(Sitecore.Data.Items.Item item)
        {
            base.LoadFromItem(item);
            this.Icon = base.Icon;
        }
        public new string Icon
        {
            get
            {
                return base.GetViewStateString("icon");
            }
            set
            {
                if (value != Icon)
                {
                    base.SetViewStateString("icon", value);
                }
            }
        }
    }
}
