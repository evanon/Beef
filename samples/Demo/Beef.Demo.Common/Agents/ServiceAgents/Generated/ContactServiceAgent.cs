/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Beef.Entities;
using Beef.WebApi;
using Newtonsoft.Json.Linq;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Agents.ServiceAgents
{
    /// <summary>
    /// Defines the Contact Web API service agent.
    /// </summary>
    public partial interface IContactServiceAgent
    {
        /// <summary>
        /// Gets the <see cref="Contact"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<ContactCollectionResult>> GetAllAsync(WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Gets the <see cref="Contact"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<Contact>> GetAsync(Guid id, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Creates the <see cref="Contact"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/> object.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<Contact>> CreateAsync(Contact value, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Updates the <see cref="Contact"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/> object.</param>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<Contact>> UpdateAsync(Contact value, Guid id, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Deletes the <see cref="Contact"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult> DeleteAsync(Guid id, WebApiRequestOptions? requestOptions = null);
    }

    /// <summary>
    /// Provides the Contact Web API service agent.
    /// </summary>
    public partial class ContactServiceAgent : WebApiServiceAgentBase<ContactServiceAgent>, IContactServiceAgent
    {
        /// <summary>
        /// Static constructor.
        /// </summary>
        static ContactServiceAgent()
        {
            Register(() =>
            {
                var rd = WebApiServiceAgentManager.Get<ContactServiceAgent>();
                return rd == null ? null : new ContactServiceAgent(rd.Client, rd.BeforeRequest!);
            }, false);
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactServiceAgent"/> class with a <paramref name="httpClient"/>.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
        /// <param name="beforeRequest">The <see cref="Action{HttpRequestMessage}"/> to invoke before the <see cref="HttpRequestMessage">Http Request</see> is made (see <see cref="WebApiServiceAgentBase.BeforeRequest"/>).</param>
        public ContactServiceAgent(HttpClient? httpClient = null, Action<HttpRequestMessage>? beforeRequest = null) : base(httpClient, beforeRequest) { }

        /// <summary>
        /// Gets the <see cref="Contact"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<ContactCollectionResult>> GetAllAsync(WebApiRequestOptions? requestOptions = null)
        {
            return base.GetCollectionResultAsync<ContactCollectionResult, ContactCollection, Contact>("api/v1/contacts", requestOptions: requestOptions,
                args: Array.Empty<WebApiArg>());
        }

        /// <summary>
        /// Gets the <see cref="Contact"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Contact>> GetAsync(Guid id, WebApiRequestOptions? requestOptions = null)
        {
            return base.GetAsync<Contact>("api/v1/contacts/{id}", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<Guid>("id", id) });
        }

        /// <summary>
        /// Creates the <see cref="Contact"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/> object.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Contact>> CreateAsync(Contact value, WebApiRequestOptions? requestOptions = null)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return base.PostAsync<Contact>("api/v1/contacts", value, requestOptions: requestOptions,
                args: Array.Empty<WebApiArg>());
        }

        /// <summary>
        /// Updates the <see cref="Contact"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/> object.</param>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Contact>> UpdateAsync(Contact value, Guid id, WebApiRequestOptions? requestOptions = null)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return base.PutAsync<Contact>("api/v1/contacts/{id}", value, requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<Guid>("id", id) });
        }

        /// <summary>
        /// Deletes the <see cref="Contact"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> DeleteAsync(Guid id, WebApiRequestOptions? requestOptions = null)
        {
            return base.DeleteAsync("api/v1/contacts/{id}", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<Guid>("id", id) });
        }
    }
}

#pragma warning restore IDE0005
#nullable restore