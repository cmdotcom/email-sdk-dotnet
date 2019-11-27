using CM.Email.Models;
using JetBrains.Annotations;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CM.Email
{
    /// <summary>
    /// This client provides all endpoint methods to communicate with the EmailCampaigns API
    /// </summary>
    [PublicAPI]
    public class EmailClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClient" /> class
        /// </summary>
        /// <param name="httpClient">The HttpClient to use for sending the instruction. You should use this as a singleton for your entire application</param>
        /// <param name="apiKey">Your Product token, used for authentication (Found in the EmailCampaigns app in the "API credentials" page in Settings</param>
        /// <param name="baseUrl">The base URL of the CM Email Campaigns API (Optional)</param>
        public EmailClient(HttpClient httpClient, Guid apiKey, string baseUrl = "https://api.cmtelecom.com") : base(httpClient, apiKey, baseUrl) { }

        #region From domains

        /// <summary>
        /// Get all fromdomains from an account
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="skip">The amount of entities to skip from the result (Optional)</param>
        /// <param name="take">The amount of entities to retrieve from the result (Optional)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Paginated<FromDomain>> GetFromDomainsAsync(Guid accountID, int? skip = null, int? take = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/fromdomains");

            if (skip != default) query.Add("skip", skip);
            if (take != default) query.Add("take", take);

            return await GetPaginatedAsync<FromDomain>(query, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific fromdomain
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="fromDomainID">This is the ID of the FromDomain that you want to retrieve</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<FromDomain> GetFromDomainAsync(Guid accountID, Guid fromDomainID, CancellationToken cancellationToken = default)
        {
            return await GetAsync<FromDomain>($"/bulkemail/v1.0/accounts/{accountID}/fromdomains/{fromDomainID}", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a new fromdomain
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="fromDomain">The FromDomain object you want to create</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<FromDomain> CreateFromDomainAsync(Guid accountID, FromDomain fromDomain, CancellationToken cancellationToken = default)
        {
            return await PostAsync<FromDomain>($"/bulkemail/v1.0/accounts/{accountID}/fromdomains", fromDomain, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Verify a fromdomain
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="fromDomainID">This is the ID of the FromDomain that you want to verify</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<FromDomain> VerifyFromDomainAsync(Guid accountID, Guid fromDomainID, CancellationToken cancellationToken = default)
        {
            return await PostAsync<FromDomain>($"/bulkemail/v1.0/accounts/{accountID}/fromdomains/{fromDomainID}/verify", null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a fromdomain
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="fromDomainID">This is the ID of the FromDomain that you want to delete</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task DeleteFromDomainAsync(Guid accountID, Guid fromDomainID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/fromdomains/{fromDomainID}", cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region From addresses

        /// <summary>
        /// Get all fromaddresses
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="skip">The amount of entities to skip from the result (Optional)</param>
        /// <param name="take">The amount of entities to retrieve from the result (Optional)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Paginated<FromAddress>> GetFromAddressesAsync(Guid accountID, int? skip = null, int? take = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/fromaddresses");

            if (skip != default) query.Add("skip", skip);
            if (take != default) query.Add("take", take);

            return await GetPaginatedAsync<FromAddress>(query, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific fromaddress
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="fromAddressID">This is the ID of the FromAddress that you want to retrieve</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<FromAddress> GetFromAddressAsync(Guid accountID, Guid fromAddressID, CancellationToken cancellationToken = default)
        {
            return await GetAsync<FromAddress>($"/bulkemail/v1.0/accounts/{accountID}/fromaddresses/{fromAddressID}", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a new fromaddress
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="fromAddress">This is the FromAddress that you want to create</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<FromAddress> CreateFromAddressAsync(Guid accountID, FromAddress fromAddress, CancellationToken cancellationToken = default)
        {
            return await PostAsync<FromAddress>($"/bulkemail/v1.0/accounts/{accountID}/fromaddresses", fromAddress, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update a fromaddress except for the emailaddress
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="fromAddressID">This is the ID of the FromAddress that you want to update</param>
        /// <param name="fromAddress">This is the updated FromAddress object with it's new updated values</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<FromAddress> UpdateFromAddressAsync(Guid accountID, Guid fromAddressID, FromAddress fromAddress, CancellationToken cancellationToken = default)
        {
            return await PutAsync<FromAddress>($"/bulkemail/v1.0/accounts/{accountID}/fromaddresses/{fromAddressID}", fromAddress, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a fromaddress
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="fromAddressID">This is the ID of the FromAddress that you want to delete</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task DeleteFromAddressAsync(Guid accountID, Guid fromAddressID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/fromaddresses/{fromAddressID}", cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region Templates

        /// <summary>
        /// Get all templates
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="skip">The amount of entities to skip from the result (Optional)</param>
        /// <param name="take">The amount of entities to retrieve from the result (Optional)</param>
        /// <param name="includeHtmlBody">Whether to include the html body in the response (Optional)</param>
        /// <param name="includeTextBody">Whether to include the text body in the response (Optional)</param>
        /// <param name="includeJson">Whether to include the template json in the response (Optional)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Paginated<Template>> GetTemplatesAsync(Guid accountID, int? skip = null, int? take = null, bool? includeHtmlBody = null, bool? includeTextBody = null, bool? includeJson = null, string filter = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/templates");

            if (skip != default) query.Add("skip", skip);
            if (take != default) query.Add("take", take);
            if (includeHtmlBody != default) query.Add("includeHtmlBody", includeHtmlBody);
            if (includeTextBody != default) query.Add("includeTextBody", includeTextBody);
            if (includeJson != default) query.Add("includeJson", includeJson);
            if (filter != default) query.Add("filter", filter);

            return await GetPaginatedAsync<Template>(query, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific template
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="templateID">This is the ID of the Template that you want to retrieve</param>
        /// <param name="includeHtmlBody">Whether to include the html body in the response (Optional)</param>
        /// <param name="includeTextBody">Whether to include the text body in the response (Optional)</param>
        /// <param name="includeJson">Whether to include the template json in the response (Optional)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Template> GetTemplateAsync(Guid accountID, Guid templateID, bool? includeHtmlBody = null, bool? includeTextBody = null, bool? includeJson = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/templates");

            if (includeHtmlBody != default) query.Add("includeHtmlBody", includeHtmlBody);
            if (includeTextBody != default) query.Add("includeTextBody", includeTextBody);
            if (includeJson != default) query.Add("includeJson", includeJson);

            return await GetAsync<Template>($"/bulkemail/v1.0/accounts/{accountID}/templates/{templateID}", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a new template
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="template">This is the Template that you want to create</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Template> CreateTemplateAsync(Guid accountID, Template template, CancellationToken cancellationToken = default)
        {
            return await PostAsync<Template>($"/bulkemail/v1.0/accounts/{accountID}/templates", template, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update a template
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="templateID">This is the ID of the Template that you want to update</param>
        /// <param name="template">This is the Template that you want to update</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Template> UpdateTemplateAsync(Guid accountID, Guid templateID, Template template, CancellationToken cancellationToken = default)
        {
            return await PutAsync<Template>($"/bulkemail/v1.0/accounts/{accountID}/templates/{templateID}", template, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a template
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="templateID">This is the ID of the Template that you want to delete</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task DeleteTemplateAsync(Guid accountID, Guid templateID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/templates/{templateID}", cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region Campaigns

        /// <summary>
        /// Get all campaigns
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="skip">The amount of entities to skip from the result (Optional)</param>
        /// <param name="take">The amount of entities to retrieve from the result (Optional)</param>
        /// <param name="filter">The text that you want to filter the results on (Optional)</param>
        /// <param name="campaignTypeID">This is the ID of the CampaignType that you want filter the campaigns on</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Paginated<Campaign>> GetCampaignsAsync(Guid accountID, int? skip = null, int? take = null, string filter = null, string campaignTypeID = null, string[] campaignTags = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/campaigns");
            
            if (skip != default) query.Add("skip", skip);
            if (take != default) query.Add("take", take);
            if (filter != default) query.Add("filter", filter);
            if (campaignTypeID != default) query.Add("campaignTypeID", campaignTypeID);
            if (campaignTags != default(string[])) query.AddRange("campaignTags", campaignTags);

            return await GetPaginatedAsync<Campaign>(query, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to retrieve</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Campaign> GetCampaignAsync(Guid accountID, Guid campaignID, CancellationToken cancellationToken = default)
        {
            return await GetAsync<Campaign>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaign">This is the Campaign that you want to create</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Campaign> CreateCampaignAsync(Guid accountID, Campaign campaign, CancellationToken cancellationToken = default)
        {
            return await PostAsync<Campaign>($"/bulkemail/v1.0/accounts/{accountID}/campaigns", campaign, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to update</param>
        /// <param name="campaign">This is the Campaign that you want to update</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Campaign> UpdateCampaignAsync(Guid accountID, Guid campaignID, Campaign campaign, CancellationToken cancellationToken = default)
        {
            return await PutAsync<Campaign>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}", campaign, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to delete</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task DeleteCampaignAsync(Guid accountID, Guid campaignID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Clone a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to clone/duplicate</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Campaign> CloneCampaignAsync(Guid accountID, Guid campaignID, CancellationToken cancellationToken = default)
        {
            return await PostAsync<Campaign>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/clone", null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the campaign's statistics
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign of which you want to retrieve the statistics</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<CampaignStatistics> GetCampaignStatisticsAsync(Guid accountID, Guid campaignID, CancellationToken cancellationToken = default)
        {
            return await GetAsync<CampaignStatistics>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/statistics", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the campaign's click statistics
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign of which you want to retrieve the click statistics</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<CampaignClickStatistic[]> GetCampaignClickStatisticsAsync(Guid accountID, Guid campaignID, CancellationToken cancellationToken = default)
        {
            return await GetAsync<CampaignClickStatistic[]>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/statistics/clicks", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the campaign's detailed statistics
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign of which you want t retrieve the detailed statistics</param>
        /// <param name="skip">The amount of entities to skip from the result (Optional)</param>
        /// <param name="take">The amount of entities to retrieve from the result (Optional)</param>
        /// <param name="filter">Filter for email addresses (Optional)</param>
        /// <param name="includeSentItems">Whether to include items that are sent (Optional)</param>
        /// <param name="includeDeliveredItems">Whether to include items that are delivered (Optional)</param>
        /// <param name="includeOpenedItems">Whether to include items that are opened (Optional)</param>
        /// <param name="includeBouncedItem">Whether to include items that are bounced (Optional)</param>
        /// <param name="includeComplainedItems">Whether to include items that are complained (Optional)</param>
        /// <param name="includeUnsubscribedItems">Whether to include items that are unsubscribed (Optional)</param>
        /// <param name="includeBlacklistedItems">Whether to include items that are blacklisted</param>
        /// <param name="includeClickedItems">Whether to include items that are clicked</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Paginated<CampaignStatisticDetail>> GetCampaignStatisticDetailsAsync(Guid accountID, Guid campaignID, int? skip = null, int? take = null, string filter = null, bool? includeSentItems = null, bool? includeDeliveredItems = null, bool? includeOpenedItems = null, bool? includeBouncedItem = null, bool? includeComplainedItems = null, bool? includeUnsubscribedItems = null, bool? includeBlacklistedItems = null, bool? includeClickedItems = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/statistics/details");

            if (skip != default) query.Add("skip", skip);
            if (take != default) query.Add("take", take);
            if (filter != default) query.Add("filter", filter);
            if (includeSentItems != default) query.Add("includeSentItems", includeSentItems);
            if (includeDeliveredItems != default) query.Add("includeDeliveredItems", includeDeliveredItems);
            if (includeOpenedItems != default) query.Add("includeOpenedItems", includeOpenedItems);
            if (includeBouncedItem != default) query.Add("includeBouncedItems", includeBouncedItem);
            if (includeComplainedItems != default) query.Add("includeComplainedItems", includeComplainedItems);
            if (includeUnsubscribedItems != default) query.Add("includeUnsubscribedItems", includeUnsubscribedItems);
            if (includeBlacklistedItems != default) query.Add("includeBlacklistedItems", includeBlacklistedItems);
            if (includeClickedItems != default) query.Add("includeClickedItems", includeClickedItems);

            return await GetAsync<Paginated<CampaignStatisticDetail>>(query, cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region Mailings

        /// <summary>
        /// Get all mailings for a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to retrieve the mailings for</param>
        /// <param name="includeTemplateHtmlBody">Whether to include the html body in the response (Optional)</param>
        /// <param name="includeTemplateTextBody">Whether to include the text body in the response (Optional)</param>
        /// <param name="includeTemplateJson">Whether to include the template json in the response (Optional)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Mailing[]> GetMailingsForCampaignAsync(Guid accountID, Guid campaignID, bool? includeTemplateHtmlBody = null, bool? includeTemplateTextBody = null, bool? includeTemplateJson = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/mailings");

            if (includeTemplateHtmlBody != default) query.Add("includeTemplateHtmlBody", includeTemplateHtmlBody);
            if (includeTemplateTextBody != default) query.Add("includeTemplateTextBody", includeTemplateTextBody);
            if (includeTemplateJson != default) query.Add("includeTemplateJson", includeTemplateJson);

            return await GetAsync<Mailing[]>(query, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific mailing for a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to retrieve the specific mailing for</param>
        /// <param name="mailingID">This is the ID of the mailing that you want to retrieve/param>
        /// <param name="includeTemplateHtmlBody">Whether to include the html body in the response (Optional)</param>
        /// <param name="includeTemplateTextBody">Whether to include the text body in the response (Optional)</param>
        /// <param name="includeTemplateJson">Whether to include the template json in the response (Optional)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Mailing> GetMailingForCampaignAsync(Guid accountID, Guid campaignID, Guid mailingID, bool? includeTemplateHtmlBody = null, bool? includeTemplateTextBody = null, bool? includeTemplateJson = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/mailings/{mailingID}");

            if (includeTemplateHtmlBody != default) query.Add("includeTemplateHtmlBody", includeTemplateHtmlBody);
            if (includeTemplateTextBody != default) query.Add("includeTemplateTextBody", includeTemplateTextBody);
            if (includeTemplateJson != default) query.Add("includeTemplateJson", includeTemplateJson);

            return await GetAsync<Mailing>(query, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a mailing for a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to create the mailing for</param>
        /// <param name="mailing">This is the Mailing that you want to create</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Mailing> CreateMailingForCampaignAsync(Guid accountID, Guid campaignID, Mailing mailing, CancellationToken cancellationToken = default)
        {
            return await PostAsync<Mailing>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/mailings", mailing, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update a mailing for a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to update the mailing for</param>
        /// <param name="mailingID">This is the ID of the Mailing that you want to update</param>
        /// <param name="mailing">This is the Mailing that you want to update</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Mailing> UpdateMailingForCampaignAsync(Guid accountID, Guid campaignID, Guid mailingID, Mailing mailing, CancellationToken cancellationToken = default)
        {
            return await PutAsync<Mailing>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/mailings/{mailingID}", mailing, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a mailing for a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign that you want to delete the mailing for</param>
        /// <param name="mailingID">This is the ID of the Mailing that you want to elete</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task DeleteMailingForCampaignAsync(Guid accountID, Guid campaignID, Guid mailingID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/mailings/{mailingID}", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get statistics of a mailing
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Campaign of the Mailing that you want to retrieve the mailing statistics for</param>
        /// <param name="mailingID">This is the ID of the Mailing that you want to retrieve the statistics for</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<MailingStatistics> GetMailingStatisticsAsync(Guid accountID, Guid campaignID, Guid mailingID, CancellationToken cancellationToken = default)
        {
            return await GetAsync<MailingStatistics>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/mailings/{mailingID}", cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region Mails

        /// <summary>
        /// Send a single mail without a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="mail">This is the mail that you want to send</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Mail> SendMailAsync(Guid accountID, Mail mail, CancellationToken cancellationToken = default)
        {
            return await PostAsync<Mail>($"/bulkemail/v1.0/accounts/{accountID}/mails", mail, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a campaign mail through a triggered campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the Triggered Campaign that you want to send the mail through</param>
        /// <param name="campaignMail">This is the triggered CampaignMail that you want to send</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<CampaignMail> SendCampaignMailAsync(Guid accountID, Guid campaignID, CampaignMail campaignMail, CancellationToken cancellationToken = default)
        {
            return await PostAsync<CampaignMail>($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/mails", campaignMail, cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region Unsubscriptions
        
        /// <summary>
        /// Get all unsubscripitons
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="skip">The amount of entities to skip from the result (Optional)</param>
        /// <param name="take">The amount of entities to retrieve from the result (Optional)</param>
        /// <param name="filter">The text that you want to filter the results on (Optional)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Paginated<Unsubscription>> GetUnsubscriptionsAsync(Guid accountID, int? skip = null, int? take = null, string filter = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/unsubscriptions");

            if (skip != default) query.Add("skip", skip);
            if (take != default) query.Add("take", take);
            if (filter != default) query.Add("filter", filter);

            return await GetPaginatedAsync<Unsubscription>(query, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create an unsubscription
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="unsubscription">This is the Unsubscriptions that you want to create</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Unsubscription> CreateUnsubscriptionAsync(Guid accountID, Unsubscription unsubscription, CancellationToken cancellationToken = default)
        {
            return await PostAsync<Unsubscription>($"/bulkemail/v1.0/accounts/{accountID}/unsubscriptions", unsubscription, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete an unsubscription
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="unsubscriptionID">This is the ID of the Unsubscription that you want to delete</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task DeleteUnsubscriptionAsync(Guid accountID, Guid unsubscriptionID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/unsubscriptions/{unsubscriptionID}", cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region Campaign tags

        /// <summary>
        /// Get all campaign tags
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="skip">The amount of entities to skip from the result (Optional)</param>
        /// <param name="take">The amount of entities to retrieve from the result (Optional)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Paginated<CampaignTag>> GetCampaignTagsAsync(Guid accountID, int? skip = null, int? take = null, CancellationToken cancellationToken = default)
        {
            QueryStringBuilder query = new QueryStringBuilder($"/bulkemail/v1.0/accounts/{accountID}/campaigntags");

            if (skip != default) query.Add("skip", skip);
            if (take != default) query.Add("take", take);

            return await GetPaginatedAsync<CampaignTag>(query, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific campaign tag
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignTagID">The ID of the campaign tag that you want to retrieve</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<CampaignTag> GetCampaignTagAsync(Guid accountID, Guid campaignTagID, CancellationToken cancellationToken = default)
        {
            return await GetAsync<CampaignTag>($"/bulkemail/v1.0/accounts/{accountID}/campaigntags/{campaignTagID}", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a campaign tag
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignTag">This is the campaign tag that you want to create</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<CampaignTag> CreateCampaignTagAsync(Guid accountID, CampaignTag campaignTag, CancellationToken cancellationToken = default)
        {
            return await PostAsync<CampaignTag>($"/bulkemail/v1.0/accounts/{accountID}/campaigntags", campaignTag, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update a campaign tag
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignTagID">The ID of the campaign tag that you want to update</param>
        /// <param name="campaignTag">This is the updated campaign tag</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<CampaignTag> UpdateCampaignTagAsync(Guid accountID, Guid campaignTagID, CampaignTag campaignTag, CancellationToken cancellationToken = default)
        {
            return await PutAsync<CampaignTag>($"/bulkemail/v1.0/accounts/{accountID}/campaigntags/{campaignTagID}", campaignTag, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a campaign tag
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignTagID">The ID of the campaign tag that you want to delete</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task DeleteCampaignTagAsync(Guid accountID, Guid campaignTagID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/campaigntags/{campaignTagID}", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Add a campaign tag to a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the campaign that you want to add the campaign tag to</param>
        /// <param name="campaignTagID">The ID of the campaign tag that you want to add to the campaign</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task AddCampaignTagToCampaignAsync(Guid accountID, Guid campaignID, Guid campaignTagID, CancellationToken cancellationToken = default)
        {
            await PostAsync($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/campaigntags/{campaignTagID}", null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Remove a campaign tag from a campaign
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="campaignID">This is the ID of the campaign that you want to remove the campaign tag from</param>
        /// <param name="campaignTagID">The ID of the campaign tag that you want to remove from the campaign</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task RemoveCampaignTagFromCampaignAsync(Guid accountID, Guid campaignID, Guid campaignTagID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/campaigns/{campaignID}/campaigntags/{campaignTagID}", cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region Webhooks

        /// <summary>
        /// Get the currently configured webhook
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Webhook> GetWebhookAsync(Guid accountID, CancellationToken cancellationToken = default)
        {
            return await GetAsync<Webhook>($"/bulkemail/v1.0/accounts/{accountID}/webhooks", cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Set the webhook to receive mail events in your own API
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="webhook">This is the Webhook that you want to set</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task<Webhook> SetWebhookAsync(Guid accountID, Webhook webhook, CancellationToken cancellationToken = default)
        {
            return await PutAsync<Webhook>($"/bulkemail/v1.0/accounts/{accountID}/webhooks", webhook, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete the currently configured webhook
        /// </summary>
        /// <param name="accountID">Your Account ID, used for authorization (Found in the EmailCampaigns app in the "API credentials" page in Settings)</param>
        /// <param name="cancellationToken">An optional cancellation token to abort this request</param>
        /// <returns></returns>
        public async Task DeleteWebhookAsync(Guid accountID, CancellationToken cancellationToken = default)
        {
            await DeleteAsync($"/bulkemail/v1.0/accounts/{accountID}/webhooks", cancellationToken).ConfigureAwait(false);
        }

        #endregion      
    }
}
