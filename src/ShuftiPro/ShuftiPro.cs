using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShuftiPro.Contracts;
using ShuftiPro.Exceptions;
using ShuftiPro.Options;

namespace ShuftiPro
{
    public class ShuftiPro : IShuftiPro
    {
        private static readonly Uri BaseUri = new Uri("https://api.shuftipro.com");
        private readonly ShuftiProCredentials clientCredentials;
        private readonly HttpClient httpClient;

        public ShuftiPro()
        {
            httpClient = new HttpClient { BaseAddress = BaseUri };
        }

        public ShuftiPro(HttpClient client)
        {
            httpClient = client;
            httpClient.BaseAddress = BaseUri;
        }
        public ShuftiPro(ShuftiProCredentials clientCredentials) : this()
        {
            EnsureCredentialsIsValid(clientCredentials);
            this.clientCredentials = clientCredentials;
        }

        public ShuftiPro(HttpClient client, ShuftiProCredentials clientCredentials) : this(client)
        {
            EnsureCredentialsIsValid(clientCredentials);
            this.clientCredentials = clientCredentials;
        }

        public async Task<ShuftiProFeedback> VerifyAsync(ShuftiProVerification verification)
        {
            this.EnsureRequestIsValid(verification);

            return await this.MakeCall<ShuftiProFeedback>(HttpMethod.Post, null, verification, this.clientCredentials)
                .ConfigureAwait(false);
        }

        public async Task<ShuftiProFeedback> VerifyAsync(ShuftiProVerification verification, ShuftiProCredentials requestCredentials)
        {
            this.EnsureRequestIsValid(verification);

            return await this.MakeCall<ShuftiProFeedback>(HttpMethod.Post, null, verification, requestCredentials)
                .ConfigureAwait(false);
        }

        public async Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference)
        {
            this.EnsureRequestIsValid(reference);

            return await this.MakeCall<ShuftiProStatus>(HttpMethod.Post, new Uri("/status", UriKind.Relative),
                reference, this.clientCredentials).ConfigureAwait(false);
        }

        public async Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference, ShuftiProCredentials requestCredentials)
        {
            this.EnsureRequestIsValid(reference);

            return await this
                .MakeCall<ShuftiProStatus>(HttpMethod.Post, new Uri("/status", UriKind.Relative), reference,
                    requestCredentials).ConfigureAwait(false);
        }

        protected void EnsureRequestIsValid(object request)
        {
            var context = new ValidationContext(request);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(request, context, results))
            {
                throw new ValidationException(results.First().ErrorMessage);
            }
        }

        private void EnsureCredentialsIsValid(ShuftiProCredentials credentials)
        {
            if (credentials == null || string.IsNullOrEmpty(credentials.ClientId) || string.IsNullOrEmpty(credentials.SecretKey))
            {
                throw new ShuftiProException("Empty credentials not allowed");
            }
        }

        private AuthenticationHeaderValue GetAuthorizationHeader(ShuftiProCredentials credentials)
        {
            this.EnsureCredentialsIsValid(credentials);
            var parameter = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{credentials.ClientId}:{credentials.SecretKey}"));
            var authorization = new AuthenticationHeaderValue(AuthenticationSchemes.Basic.ToString(), parameter);
            return authorization;
        }

        protected async Task<TResponse> MakeCall<TResponse>(HttpMethod method, Uri requestUri, object content, ShuftiProCredentials credentials)
        {
            var httpRequest = new HttpRequestMessage(method, requestUri);
            httpRequest.Headers.Authorization = this.GetAuthorizationHeader(credentials);

            var requestContent = JsonConvert.SerializeObject(content);
            httpRequest.Content = new StringContent(requestContent, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.SendAsync(httpRequest);
                var responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TResponse>(responseContent);
            }
            catch (Exception e)
            {
                throw new ShuftiProException(e.Message, e);
            }
        }
    }
}
