using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;

namespace HITS.Component.EmailAddressValidator
{
    public class Validate : ComponentBase
    {
        public async Task<ValidateEmailResponse> ValidateEmailAddressAsync(ValidateEmailRequest request)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string apiURL = $"https://api.quickemailverification.com/v1/verify?email={HttpUtility.UrlEncode(request.EmailAddress)}&apikey={request.ApiKey}";
                    return await httpClient.GetFromJsonAsync<ValidateEmailResponse>(apiURL);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
