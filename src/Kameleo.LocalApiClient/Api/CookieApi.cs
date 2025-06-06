﻿/*
 * kameleo-local-api
 *
 * You can use the following API endpoints to communicate with the local running Kameleo programmatically.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Kameleo.LocalApiClient.Client;
using Kameleo.LocalApiClient.Model;

namespace Kameleo.LocalApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICookieApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Adds a list of cookies to the profile, allowing you to inject cookies before starting the profile. If cookies already exist for a domain,  they will be replaced with the new ones.
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="cookieRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;BrowserCookie&gt;</returns>
        List<BrowserCookie> AddCookies(Guid guid, List<CookieRequest> cookieRequest = default(List<CookieRequest>), int operationIndex = 0);

        /// <summary>
        /// Adds a list of cookies to the profile, allowing you to inject cookies before starting the profile. If cookies already exist for a domain,  they will be replaced with the new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="cookieRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;BrowserCookie&gt;</returns>
        ApiResponse<List<BrowserCookie>> AddCookiesWithHttpInfo(Guid guid, List<CookieRequest> cookieRequest = default(List<CookieRequest>), int operationIndex = 0);
        /// <summary>
        /// Deletes all the cookies stored in the profile, which will likely log the profile out of all websites.
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteCookies(Guid guid, int operationIndex = 0);

        /// <summary>
        /// Deletes all the cookies stored in the profile, which will likely log the profile out of all websites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCookiesWithHttpInfo(Guid guid, int operationIndex = 0);
        /// <summary>
        /// Retrieves the list of cookies stored in the profile&#39;s browser. Note that this list does not include session cookies, which are not  persisted between browser launches.
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;BrowserCookie&gt;</returns>
        List<BrowserCookie> ListCookies(Guid guid, int operationIndex = 0);

        /// <summary>
        /// Retrieves the list of cookies stored in the profile&#39;s browser. Note that this list does not include session cookies, which are not  persisted between browser launches.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;BrowserCookie&gt;</returns>
        ApiResponse<List<BrowserCookie>> ListCookiesWithHttpInfo(Guid guid, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICookieApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Adds a list of cookies to the profile, allowing you to inject cookies before starting the profile. If cookies already exist for a domain,  they will be replaced with the new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="cookieRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;BrowserCookie&gt;</returns>
        System.Threading.Tasks.Task<List<BrowserCookie>> AddCookiesAsync(Guid guid, List<CookieRequest> cookieRequest = default(List<CookieRequest>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Adds a list of cookies to the profile, allowing you to inject cookies before starting the profile. If cookies already exist for a domain,  they will be replaced with the new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="cookieRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;BrowserCookie&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BrowserCookie>>> AddCookiesWithHttpInfoAsync(Guid guid, List<CookieRequest> cookieRequest = default(List<CookieRequest>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Deletes all the cookies stored in the profile, which will likely log the profile out of all websites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCookiesAsync(Guid guid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Deletes all the cookies stored in the profile, which will likely log the profile out of all websites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCookiesWithHttpInfoAsync(Guid guid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Retrieves the list of cookies stored in the profile&#39;s browser. Note that this list does not include session cookies, which are not  persisted between browser launches.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;BrowserCookie&gt;</returns>
        System.Threading.Tasks.Task<List<BrowserCookie>> ListCookiesAsync(Guid guid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the list of cookies stored in the profile&#39;s browser. Note that this list does not include session cookies, which are not  persisted between browser launches.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;BrowserCookie&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BrowserCookie>>> ListCookiesWithHttpInfoAsync(Guid guid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICookieApi : ICookieApiSync, ICookieApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CookieApi : ICookieApi
    {
        private Kameleo.LocalApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CookieApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CookieApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CookieApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CookieApi(string basePath)
        {
            this.Configuration = Kameleo.LocalApiClient.Client.Configuration.MergeConfigurations(
                Kameleo.LocalApiClient.Client.GlobalConfiguration.Instance,
                new Kameleo.LocalApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Kameleo.LocalApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Kameleo.LocalApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Kameleo.LocalApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CookieApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CookieApi(Kameleo.LocalApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Kameleo.LocalApiClient.Client.Configuration.MergeConfigurations(
                Kameleo.LocalApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Kameleo.LocalApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Kameleo.LocalApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Kameleo.LocalApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CookieApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CookieApi(Kameleo.LocalApiClient.Client.ISynchronousClient client, Kameleo.LocalApiClient.Client.IAsynchronousClient asyncClient, Kameleo.LocalApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Kameleo.LocalApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Kameleo.LocalApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Kameleo.LocalApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Kameleo.LocalApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Kameleo.LocalApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Adds a list of cookies to the profile, allowing you to inject cookies before starting the profile. If cookies already exist for a domain,  they will be replaced with the new ones. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="cookieRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;BrowserCookie&gt;</returns>
        public List<BrowserCookie> AddCookies(Guid guid, List<CookieRequest> cookieRequest = default(List<CookieRequest>), int operationIndex = 0)
        {
            Kameleo.LocalApiClient.Client.ApiResponse<List<BrowserCookie>> localVarResponse = AddCookiesWithHttpInfo(guid, cookieRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Adds a list of cookies to the profile, allowing you to inject cookies before starting the profile. If cookies already exist for a domain,  they will be replaced with the new ones. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="cookieRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;BrowserCookie&gt;</returns>
        public Kameleo.LocalApiClient.Client.ApiResponse<List<BrowserCookie>> AddCookiesWithHttpInfo(Guid guid, List<CookieRequest> cookieRequest = default(List<CookieRequest>), int operationIndex = 0)
        {
            Kameleo.LocalApiClient.Client.RequestOptions localVarRequestOptions = new Kameleo.LocalApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("guid", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(guid)); // path parameter
            localVarRequestOptions.Data = cookieRequest;

            localVarRequestOptions.Operation = "CookieApi.AddCookies";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<List<BrowserCookie>>("/profiles/{guid}/cookies", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddCookies", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Adds a list of cookies to the profile, allowing you to inject cookies before starting the profile. If cookies already exist for a domain,  they will be replaced with the new ones. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="cookieRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;BrowserCookie&gt;</returns>
        public async System.Threading.Tasks.Task<List<BrowserCookie>> AddCookiesAsync(Guid guid, List<CookieRequest> cookieRequest = default(List<CookieRequest>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Kameleo.LocalApiClient.Client.ApiResponse<List<BrowserCookie>> localVarResponse = await AddCookiesWithHttpInfoAsync(guid, cookieRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Adds a list of cookies to the profile, allowing you to inject cookies before starting the profile. If cookies already exist for a domain,  they will be replaced with the new ones. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="cookieRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;BrowserCookie&gt;)</returns>
        public async System.Threading.Tasks.Task<Kameleo.LocalApiClient.Client.ApiResponse<List<BrowserCookie>>> AddCookiesWithHttpInfoAsync(Guid guid, List<CookieRequest> cookieRequest = default(List<CookieRequest>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Kameleo.LocalApiClient.Client.RequestOptions localVarRequestOptions = new Kameleo.LocalApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("guid", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(guid)); // path parameter
            localVarRequestOptions.Data = cookieRequest;

            localVarRequestOptions.Operation = "CookieApi.AddCookies";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<List<BrowserCookie>>("/profiles/{guid}/cookies", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddCookies", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletes all the cookies stored in the profile, which will likely log the profile out of all websites. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteCookies(Guid guid, int operationIndex = 0)
        {
            DeleteCookiesWithHttpInfo(guid);
        }

        /// <summary>
        /// Deletes all the cookies stored in the profile, which will likely log the profile out of all websites. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Kameleo.LocalApiClient.Client.ApiResponse<Object> DeleteCookiesWithHttpInfo(Guid guid, int operationIndex = 0)
        {
            Kameleo.LocalApiClient.Client.RequestOptions localVarRequestOptions = new Kameleo.LocalApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("guid", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(guid)); // path parameter

            localVarRequestOptions.Operation = "CookieApi.DeleteCookies";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/profiles/{guid}/cookies", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCookies", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletes all the cookies stored in the profile, which will likely log the profile out of all websites. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCookiesAsync(Guid guid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            await DeleteCookiesWithHttpInfoAsync(guid, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes all the cookies stored in the profile, which will likely log the profile out of all websites. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Kameleo.LocalApiClient.Client.ApiResponse<Object>> DeleteCookiesWithHttpInfoAsync(Guid guid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Kameleo.LocalApiClient.Client.RequestOptions localVarRequestOptions = new Kameleo.LocalApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("guid", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(guid)); // path parameter

            localVarRequestOptions.Operation = "CookieApi.DeleteCookies";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/profiles/{guid}/cookies", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCookies", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the list of cookies stored in the profile&#39;s browser. Note that this list does not include session cookies, which are not  persisted between browser launches. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;BrowserCookie&gt;</returns>
        public List<BrowserCookie> ListCookies(Guid guid, int operationIndex = 0)
        {
            Kameleo.LocalApiClient.Client.ApiResponse<List<BrowserCookie>> localVarResponse = ListCookiesWithHttpInfo(guid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the list of cookies stored in the profile&#39;s browser. Note that this list does not include session cookies, which are not  persisted between browser launches. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;BrowserCookie&gt;</returns>
        public Kameleo.LocalApiClient.Client.ApiResponse<List<BrowserCookie>> ListCookiesWithHttpInfo(Guid guid, int operationIndex = 0)
        {
            Kameleo.LocalApiClient.Client.RequestOptions localVarRequestOptions = new Kameleo.LocalApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("guid", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(guid)); // path parameter

            localVarRequestOptions.Operation = "CookieApi.ListCookies";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<BrowserCookie>>("/profiles/{guid}/cookies", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCookies", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the list of cookies stored in the profile&#39;s browser. Note that this list does not include session cookies, which are not  persisted between browser launches. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;BrowserCookie&gt;</returns>
        public async System.Threading.Tasks.Task<List<BrowserCookie>> ListCookiesAsync(Guid guid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Kameleo.LocalApiClient.Client.ApiResponse<List<BrowserCookie>> localVarResponse = await ListCookiesWithHttpInfoAsync(guid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the list of cookies stored in the profile&#39;s browser. Note that this list does not include session cookies, which are not  persisted between browser launches. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">The unique identifier of the profile</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;BrowserCookie&gt;)</returns>
        public async System.Threading.Tasks.Task<Kameleo.LocalApiClient.Client.ApiResponse<List<BrowserCookie>>> ListCookiesWithHttpInfoAsync(Guid guid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Kameleo.LocalApiClient.Client.RequestOptions localVarRequestOptions = new Kameleo.LocalApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Kameleo.LocalApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("guid", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(guid)); // path parameter

            localVarRequestOptions.Operation = "CookieApi.ListCookies";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<BrowserCookie>>("/profiles/{guid}/cookies", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCookies", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
