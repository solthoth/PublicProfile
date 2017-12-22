using System;
using System.Collections.Generic;
using SolThoth.PublicProfile.SharedTypes;
using SolThoth.PublicProfile.SharedTypes.DataAccess;

namespace SolThoth.PublicProfile.DataAccess.Fixed
{
    public class FixedPublicProfileData : IPublicProfileData
    {
        private List<SocialMedia> SocialMediaContext;

        public FixedPublicProfileData()
        {
        }

        private void Initialize()
        {
            SocialMediaContext = new List<SocialMedia> 
            { 
                new SocialMedia("fa-linkedin", "https://www.linkedin.com/in/solthoth/", true),
                new SocialMedia("fa-twitter", "https://twitter.com/solthoth", true),
                new SocialMedia("fa-github", "https://github.com/solthoth", true)
            };

        }

        public IList<SocialMedia> GetSocialMediaInformation()
        {
            return SocialMediaContext;
        }
    }
}
