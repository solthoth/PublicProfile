using System;

namespace SolThoth.PublicProfile.SharedTypes
{
    public class SocialMedia
    {
        public SocialMedia(string cssIcon, string url)
        {
            CssIcon = cssIcon;
            Url = url;
        }
        public string Url { get; set; }
        public string CssIcon { get; set; }
    }
}
