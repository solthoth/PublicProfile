using System.Collections.Generic;

namespace SolThoth.PublicProfile.SharedTypes.DataAccess
{
    public interface IReadOnlyPublicProfileData
    {
        IList<SocialMedia> GetSocialMediaInformation();
    }

    public interface IPublicProfileData : IReadOnlyPublicProfileData
    {
        
    }
}
