﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model
{
    public partial class Page
    {
        [Obsolete("Instead of this member, please use WelcomePage property of the WebSettings object.")]
        public bool WelcomePage
        {
            get
            {
                // return (this.Url == this.ParentTemplate.WebSettings.WelcomePage);
                return (false);
            }
            set
            {
                if (value)
                {
                    // this.ParentTemplate.WebSettings.WelcomePage = this.Url;
                    return;
                }
            }
        }

        [Obsolete("Instead of this constructor, please use the one without the WelcomePage property")]
        public Page(string url, bool overwrite, WikiPageLayout layout, IEnumerable<WebPart> webParts, bool welcomePage = false, ObjectSecurity security = null) :
            this(url, overwrite, layout, webParts, welcomePage, security, null)
        {
        }

        [Obsolete("Instead of this constructor, please use the one without the WelcomePage property")]
        public Page(string url, bool overwrite, WikiPageLayout layout, IEnumerable<WebPart> webParts, bool welcomePage = false, ObjectSecurity security = null, Dictionary<String, String> fields = null) :
            this(url, overwrite, layout, webParts, security, fields)
        {
        }
    }
}