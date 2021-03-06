﻿using System.Text.RegularExpressions;

namespace ParserSitemap.Infrastructure
{
    public static class Helpers
    {
        public static string GetSiteMapUrl(string siteUrl, string currentUrl)  
        {
            string res;

            if (!siteUrl.Contains("http://") && !siteUrl.Contains("https://"))
            {
                if (!siteUrl.StartsWith("/"))
                {
                    var site = "/" + siteUrl;
                    res = currentUrl + site;
                }
                else
                {
                    res = currentUrl + siteUrl;
                }
            }
            else if(siteUrl.Contains(currentUrl))
            {
                res = siteUrl;
            }
            else
            {
                res = string.Empty;
            }
            return res;
        }        
    }
}