﻿using System.Web;
using System.Web.Mvc;

namespace EXPRESS_PDA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
