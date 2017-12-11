using System.Collections.Generic;
using SolThoth.PublicProfile.SharedTypes;

namespace SolThoth.PublicProfile.Website.Models
{
    public class NavbarViewModel
    {
        public NavbarViewModel()
        {
            SocialMediaLinks = new List<SocialMedia>
            {
                new SocialMedia("fa-linkedin", "https://www.linkedin.com/in/solthoth/"),
                new SocialMedia("fa-twitter", "https://twitter.com/solthoth"),
                new SocialMedia("fa-github", "https://github.com/solthoth")
            };
        }
        public List<SocialMedia> SocialMediaLinks { get; }
    }
}