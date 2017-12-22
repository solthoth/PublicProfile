using System;

namespace SolThoth.PublicProfile.SharedTypes
{
    public class SocialMedia
    {
        public SocialMedia(string cssIcon, string url, bool active)
        {
            CssIcon = cssIcon;
            Url = url;
            Active = active;
        }
        public string Url { get; set; }
        public string CssIcon { get; set; }
        public bool Active { get; set; }
    }
}
