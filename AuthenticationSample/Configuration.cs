namespace AuthenticationSample
{
    public class Configuration
    {
        public const string ClientId = "32cc9525-3271-4a78-8693-7eeabe849217"; // Put your mobile app ClientId
        public const string Authority = "https://login.windows.net/bp.com/"; // Default authority for Azure AD
        public const string Resource = "https://bpsorsafetyapptesttempwa.azurewebsites.net/"; // Put your API ID URI 
        public const string RedirectUri = "https://bp.com/bpsorsafetyAppClient"; // Put your mobile app Redirect Uri (declared in Azure AD Apps)
        public const string ApiUri = "https://bpsorsafetyapptesttempwa.azurewebsites.net/"; // Put you API actual URL
        public const string Proxy = "http://10.198.255.114:8888/"; // Put you API actual URL
        
    }
}
