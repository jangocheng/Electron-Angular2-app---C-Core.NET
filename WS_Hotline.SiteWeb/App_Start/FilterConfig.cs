﻿using System.Web;
using System.Web.Mvc;

namespace WS_Hotline.SiteWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
