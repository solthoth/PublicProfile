using System.Diagnostics.Contracts;
using SolThoth.PublicProfile.SharedTypes.DataAccess;

namespace SolThoth.PublicProfile.DataAccess
{
    public static class Factory
    {
        public static IPublicProfileData GetPublicProfileContext()
        {
            Contract.Ensures(Contract.Result<IPublicProfileData>() != null);
            return new Fixed.FixedPublicProfileData();   
        }
    }
}
