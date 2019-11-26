using CM.Email.Exceptions;
using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CM.Email
{
    public abstract class BaseClient
    {
        private const string apiKeyHeader = "X-CM-PRODUCTTOKEN";
        private const string jsonMediaType = "application/json";
        private readonly Encoding encoding = Encoding.UTF8;

        private readonly HttpClient _httpClient;
        private readonly Guid _apiKey;
        private readonly string _baseUrl;

        public BaseClient(HttpClient httpClient, Guid apiKey, string baseUrl)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
            _baseUrl = baseUrl;
        }

        #region Get functions

        /// <summary>
        /// Performs a REST GET request
        /// </summary>
        /// <typeparam name="T">The expected response type</typeparam>
        /// <param name="url">The url extension for the endpoint</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        protected async Task<T> GetAsync<T>([NotNull] string url, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"{_baseUrl}{url}"))
            {
                AddDefaultRequestHeaders(request);

                var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
                await EnsureSuccessStatusCodeAsync(response).ConfigureAwait(false);

                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (string.IsNullOrWhiteSpace(json))
                    return default;

                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        /// <summary>
        /// Performs a REST GET request returning a paginated result
        /// </summary>
        /// <typeparam name="T">The expected response type</typeparam>
        /// <param name="url">The url extension for the endpoint</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        protected async Task<Paginated<T>> GetPaginatedAsync<T>([NotNull] string url, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"{_baseUrl}{url}"))
            {
                AddDefaultRequestHeaders(request);

                var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
                await EnsureSuccessStatusCodeAsync(response).ConfigureAwait(false);

                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                var items = JsonConvert.DeserializeObject<T[]>(json);

                int.TryParse(response.Headers.GetValues("X-CM-PAGINATION-SKIP").FirstOrDefault(), out var skip);
                int.TryParse(response.Headers.GetValues("X-CM-PAGINATION-TAKE").FirstOrDefault(), out var take);
                int.TryParse(response.Headers.GetValues("X-CM-PAGINATION-TOTAL").FirstOrDefault(), out var total);

                return new Paginated<T>(items, skip, take, total);
            }
        }

        #endregion

        #region Post functions

        /// <summary>
        /// Performs a REST POST request
        /// </summary>
        /// <param name="url">The url extension for the endpoint</param>
        /// <param name="data">The object that will be send with your request</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        protected async Task PostAsync([NotNull] string url, [CanBeNull] object data, CancellationToken cancellationToken)
        {
            await PostAsync<object>(url, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Performs a REST POST request.
        /// </summary>
        /// <typeparam name="T">The entity type you are expecting back from the request</typeparam>
        /// <param name="url">The url extension for the endpoint</param>
        /// <param name="data">The object that will be send with your request</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns>The returned response</returns>
        protected async Task<T> PostAsync<T>([NotNull] string url, [CanBeNull] object data, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, $"{_baseUrl}{url}"))
            {
                AddDefaultRequestHeaders(request);
                request.Content = data != null ? new StringContent(JsonConvert.SerializeObject(data), encoding, jsonMediaType) : null;

                var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
                await EnsureSuccessStatusCodeAsync(response).ConfigureAwait(false);

                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (string.IsNullOrWhiteSpace(json))
                    return default;

                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        #endregion

        #region Put functions

        /// <summary>
        /// Performs a REST PUT request
        /// </summary>
        /// <param name="url">The url extension for the endpoint</param>
        /// <param name="data">The object that will be send with your request</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        protected async Task PutAsync([NotNull] string url, [CanBeNull] object data, CancellationToken cancellationToken)
        {
            await PutAsync<object>(url, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Performs a REST PUT request
        /// </summary>
        /// <typeparam name="T">The expected response type</typeparam>
        /// <param name="url">The url extension for the endpoint</param>
        /// <param name="data">The object that will be send with your request</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns>The returned response</returns>
        protected async Task<T> PutAsync<T>([NotNull] string url, [CanBeNull] object data, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Put, $"{_baseUrl}{url}"))
            {
                AddDefaultRequestHeaders(request);
                request.Content = data != null ? new StringContent(JsonConvert.SerializeObject(data), encoding, jsonMediaType) : null;

                var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
                await EnsureSuccessStatusCodeAsync(response).ConfigureAwait(false);

                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (string.IsNullOrWhiteSpace(json))
                    return default;

                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        #endregion

        #region Delete functions

        /// <summary>
        /// Performs a REST DELETE request
        /// </summary>
        /// <param name="url">The url extension for the endpoint</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        protected async Task DeleteAsync([NotNull] string url, CancellationToken cancellationToken)
        {
            await DeleteAsync<object>(url, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Performs a REST DELETE request
        /// </summary>
        /// <typeparam name="T">The expected response type</typeparam>
        /// <param name="url">The url extension for the endpoint</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        protected async Task<T> DeleteAsync<T>([NotNull] string url, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Delete, $"{_baseUrl}{url}"))
            {
                AddDefaultRequestHeaders(request);

                var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
                await EnsureSuccessStatusCodeAsync(response).ConfigureAwait(false);

                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (string.IsNullOrWhiteSpace(json))
                    return default;

                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        #endregion

        #region Other client functions

        private void AddDefaultRequestHeaders(HttpRequestMessage request)
        {
            request.Headers.Add(apiKeyHeader, _apiKey.ToString());
        }

        private async Task EnsureSuccessStatusCodeAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return;

            string content = string.Empty;
            var originalMessage = new
            {
                Message = (string)null,
                MessageCode = (string)null,
                MessageDetail = (string)null
            };

            if (response.Content != null)
            {
                content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                response.Content.Dispose();

                try
                {
                    // Try to deserialize the message to get the original message, message code and message detail, this only works for exceptions that are mapped
                    originalMessage = JsonConvert.DeserializeAnonymousType(content, originalMessage);
                }
                catch (Exception)
                {
                    // Don't do anything, no need for it!
                }
            }

            throw new ApiResponseException(
                response.StatusCode,
                content,
                originalMessage.Message,
                originalMessage.MessageCode,
                originalMessage.MessageDetail
            );
        }

        #endregion
    }
}
