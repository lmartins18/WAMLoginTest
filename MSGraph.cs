using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Broker;

namespace WAMLoginTest
{
    public static class MSGraph
    {
        static string[] scopes = new[] { "User.Read" }; 
        static string clientId = "client-id-here";
        static string tenantId = "/common"; // Common if multi-tenant.
        static string instance = "https://login.microsoftonline.com/common/oauth2/v2.0/authorize";

        // MSAL
        /// <summary>
        /// Sign-in using MSAL and get a token.
        /// </summary>
        /// <param name="handle">parent form Handle property</param>
        /// <returns>Token if login successful, null if not.</returns>
        public static async Task<string?> SignInUserAndGetTokenUsingMSAL(IntPtr handle)
        {
            string authority = string.Concat(instance, tenantId);

            // Initialize the MSAL library by building a public client application
            // WAM
            var application = PublicClientApplicationBuilder
                              .Create(clientId)
                              .WithAuthority(authority)
                              .WithBrokerPreview(true)   // this method exists in Microsoft.Identity.Client.Broker package
                              .Build();
            // https://github.com/AzureAD/microsoft-authentication-library-for-dotnet/wiki/wam


            AuthenticationResult result = default!;
            try
            {
                var accounts = await application.GetAccountsAsync();
                result = await application.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                                          .ExecuteAsync()
                                          .ConfigureAwait(false);
            }
            catch (MsalUiRequiredException)
            {
                try
                {
                    result = await application.AcquireTokenInteractive(scopes)
                                              .WithParentActivityOrWindow(handle)
                                              .ExecuteAsync()
                                              .ConfigureAwait(false);
                }
                catch(Exception)
                {
                    throw;
                }
            }
            return result?.AccessToken; 
        }
    }
}