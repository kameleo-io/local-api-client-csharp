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
    public interface IKernelApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Installs a kernel to the local file system.
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>KernelResponse</returns>
        KernelResponse InstallKernel(Guid id, int operationIndex = 0);

        /// <summary>
        /// Installs a kernel to the local file system.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of KernelResponse</returns>
        ApiResponse<KernelResponse> InstallKernelWithHttpInfo(Guid id, int operationIndex = 0);
        /// <summary>
        /// Gets the list of all the available kernels.
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;KernelResponse&gt;</returns>
        List<KernelResponse> ListKernels(int operationIndex = 0);

        /// <summary>
        /// Gets the list of all the available kernels.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;KernelResponse&gt;</returns>
        ApiResponse<List<KernelResponse>> ListKernelsWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Removes a kernel from the local file system.
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>KernelResponse</returns>
        KernelResponse RemoveKernel(Guid id, int operationIndex = 0);

        /// <summary>
        /// Removes a kernel from the local file system.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of KernelResponse</returns>
        ApiResponse<KernelResponse> RemoveKernelWithHttpInfo(Guid id, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKernelApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Installs a kernel to the local file system.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KernelResponse</returns>
        System.Threading.Tasks.Task<KernelResponse> InstallKernelAsync(Guid id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Installs a kernel to the local file system.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KernelResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<KernelResponse>> InstallKernelWithHttpInfoAsync(Guid id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Gets the list of all the available kernels.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;KernelResponse&gt;</returns>
        System.Threading.Tasks.Task<List<KernelResponse>> ListKernelsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Gets the list of all the available kernels.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;KernelResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<KernelResponse>>> ListKernelsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Removes a kernel from the local file system.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KernelResponse</returns>
        System.Threading.Tasks.Task<KernelResponse> RemoveKernelAsync(Guid id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Removes a kernel from the local file system.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KernelResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<KernelResponse>> RemoveKernelWithHttpInfoAsync(Guid id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKernelApi : IKernelApiSync, IKernelApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KernelApi : IKernelApi
    {
        private Kameleo.LocalApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="KernelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KernelApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KernelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KernelApi(string basePath)
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
        /// Initializes a new instance of the <see cref="KernelApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KernelApi(Kameleo.LocalApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="KernelApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public KernelApi(Kameleo.LocalApiClient.Client.ISynchronousClient client, Kameleo.LocalApiClient.Client.IAsynchronousClient asyncClient, Kameleo.LocalApiClient.Client.IReadableConfiguration configuration)
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
        /// Installs a kernel to the local file system. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>KernelResponse</returns>
        public KernelResponse InstallKernel(Guid id, int operationIndex = 0)
        {
            Kameleo.LocalApiClient.Client.ApiResponse<KernelResponse> localVarResponse = InstallKernelWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Installs a kernel to the local file system. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of KernelResponse</returns>
        public Kameleo.LocalApiClient.Client.ApiResponse<KernelResponse> InstallKernelWithHttpInfo(Guid id, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("id", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "KernelApi.InstallKernel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<KernelResponse>("/kernels/{id}/install", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InstallKernel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Installs a kernel to the local file system. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KernelResponse</returns>
        public async System.Threading.Tasks.Task<KernelResponse> InstallKernelAsync(Guid id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Kameleo.LocalApiClient.Client.ApiResponse<KernelResponse> localVarResponse = await InstallKernelWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Installs a kernel to the local file system. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KernelResponse)</returns>
        public async System.Threading.Tasks.Task<Kameleo.LocalApiClient.Client.ApiResponse<KernelResponse>> InstallKernelWithHttpInfoAsync(Guid id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "KernelApi.InstallKernel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<KernelResponse>("/kernels/{id}/install", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InstallKernel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets the list of all the available kernels. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;KernelResponse&gt;</returns>
        public List<KernelResponse> ListKernels(int operationIndex = 0)
        {
            Kameleo.LocalApiClient.Client.ApiResponse<List<KernelResponse>> localVarResponse = ListKernelsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the list of all the available kernels. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;KernelResponse&gt;</returns>
        public Kameleo.LocalApiClient.Client.ApiResponse<List<KernelResponse>> ListKernelsWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "KernelApi.ListKernels";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<KernelResponse>>("/kernels", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListKernels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets the list of all the available kernels. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;KernelResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<KernelResponse>> ListKernelsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Kameleo.LocalApiClient.Client.ApiResponse<List<KernelResponse>> localVarResponse = await ListKernelsWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the list of all the available kernels. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;KernelResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<Kameleo.LocalApiClient.Client.ApiResponse<List<KernelResponse>>> ListKernelsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "KernelApi.ListKernels";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<KernelResponse>>("/kernels", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListKernels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Removes a kernel from the local file system. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>KernelResponse</returns>
        public KernelResponse RemoveKernel(Guid id, int operationIndex = 0)
        {
            Kameleo.LocalApiClient.Client.ApiResponse<KernelResponse> localVarResponse = RemoveKernelWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Removes a kernel from the local file system. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of KernelResponse</returns>
        public Kameleo.LocalApiClient.Client.ApiResponse<KernelResponse> RemoveKernelWithHttpInfo(Guid id, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("id", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "KernelApi.RemoveKernel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<KernelResponse>("/kernels/{id}/remove", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveKernel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Removes a kernel from the local file system. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KernelResponse</returns>
        public async System.Threading.Tasks.Task<KernelResponse> RemoveKernelAsync(Guid id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Kameleo.LocalApiClient.Client.ApiResponse<KernelResponse> localVarResponse = await RemoveKernelWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Removes a kernel from the local file system. 
        /// </summary>
        /// <exception cref="Kameleo.LocalApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the kernel.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KernelResponse)</returns>
        public async System.Threading.Tasks.Task<Kameleo.LocalApiClient.Client.ApiResponse<KernelResponse>> RemoveKernelWithHttpInfoAsync(Guid id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Kameleo.LocalApiClient.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "KernelApi.RemoveKernel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<KernelResponse>("/kernels/{id}/remove", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveKernel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
