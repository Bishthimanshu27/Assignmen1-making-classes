﻿using System.Web;
using System.Web.Mvc;

namespace Assignment1MakingClasses
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
