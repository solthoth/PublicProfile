using SolThoth.PublicProfile.SharedTypes.DataAccess;

namespace SolThoth.PublicProfile.DataAccess
{
    public static class Factory
    {
        public static IPublicProfileData GetPublicProfileContext()
        {
            return new Fixed.FixedPublicProfileData();   
        }
    }
}
