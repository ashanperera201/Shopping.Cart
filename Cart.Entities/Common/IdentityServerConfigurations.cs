#region References
#endregion

#region Namespace
namespace Cart.Entities.Common
{
    public class IdentityServerConfigurations
    {
        public string IdentityServerURL { get; set; }
        public string RequireHttpsMetadata { get; set; }
        public string Audience { get; set; }
        public string AudienceLocalDbOTP { get; set; }
        public string AudienceLocalDbAdal { get; set; }
        public string IdentityServerClientIdLocalDb { get; set; }
        public string IdentityServerClientIdLocalDbOTP { get; set; }
        public string IdentityServerClientIdAd { get; set; }
        public string IdentityServerClientIdAdal { get; set; }
        public string LocalDBOTPClientSecret { get; set; }
        public string ADALClientSecret { get; set; }
        public string identityServerTokenEndpoint { get; set; }
        public string identityServerRevocationEndpoint { get; set; }
        public string identityServerUserInfoEndpoint { get; set; }
        public string EncryptionKey { get; set; }
        public string EncryptionIV { get; set; }
    }
}
#endregion