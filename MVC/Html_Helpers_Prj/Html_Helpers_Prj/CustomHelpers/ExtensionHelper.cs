﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Html_Helpers_Prj.CustomHelpers
{
    public static class ExtensionHelper
    {
        public static IHtmlString RedLabel(this HtmlHelper helper, string content)
        {
            string str = String.Format("<label><i><font color=red>{0}</font></i></label>", content);
            return new HtmlString(str);
        }

        public static IHtmlString GreenLabel(this HtmlHelper helper, string content)
        {
            string str = String.Format("<label><i><font color=green>{0}</font></i></label>", content);
            return new HtmlString(str);
        }
    }
}