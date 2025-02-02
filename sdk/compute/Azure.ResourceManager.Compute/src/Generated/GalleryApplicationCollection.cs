// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="GalleryApplicationResource" /> and their operations.
    /// Each <see cref="GalleryApplicationResource" /> in the collection will belong to the same instance of <see cref="GalleryResource" />.
    /// To get a <see cref="GalleryApplicationCollection" /> instance call the GetGalleryApplications method from an instance of <see cref="GalleryResource" />.
    /// </summary>
    public partial class GalleryApplicationCollection : ArmCollection, IEnumerable<GalleryApplicationResource>, IAsyncEnumerable<GalleryApplicationResource>
    {
        private readonly ClientDiagnostics _galleryApplicationClientDiagnostics;
        private readonly GalleryApplicationsRestOperations _galleryApplicationRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationCollection"/> class for mocking. </summary>
        protected GalleryApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GalleryApplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _galleryApplicationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", GalleryApplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GalleryApplicationResource.ResourceType, out string galleryApplicationApiVersion);
            _galleryApplicationRestClient = new GalleryApplicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, galleryApplicationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GalleryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GalleryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a gallery Application Definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}
        /// Operation Id: GalleryApplications_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> or <paramref name="galleryApplication"/> is null. </exception>
        public virtual async Task<ArmOperation<GalleryApplicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string galleryApplicationName, GalleryApplicationData galleryApplication, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));
            Argument.AssertNotNull(galleryApplication, nameof(galleryApplication));

            using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryApplicationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<GalleryApplicationResource>(new GalleryApplicationOperationSource(Client), _galleryApplicationClientDiagnostics, Pipeline, _galleryApplicationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a gallery Application Definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}
        /// Operation Id: GalleryApplications_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> or <paramref name="galleryApplication"/> is null. </exception>
        public virtual ArmOperation<GalleryApplicationResource> CreateOrUpdate(WaitUntil waitUntil, string galleryApplicationName, GalleryApplicationData galleryApplication, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));
            Argument.AssertNotNull(galleryApplication, nameof(galleryApplication));

            using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryApplicationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication, cancellationToken);
                var operation = new ComputeArmOperation<GalleryApplicationResource>(new GalleryApplicationOperationSource(Client), _galleryApplicationClientDiagnostics, Pipeline, _galleryApplicationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a gallery Application Definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}
        /// Operation Id: GalleryApplications_Get
        /// </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual async Task<Response<GalleryApplicationResource>> GetAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a gallery Application Definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}
        /// Operation Id: GalleryApplications_Get
        /// </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<GalleryApplicationResource> Get(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List gallery Application Definitions in a gallery.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications
        /// Operation Id: GalleryApplications_ListByGallery
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryApplicationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryApplicationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryApplicationRestClient.ListByGalleryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplicationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryApplicationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryApplicationRestClient.ListByGalleryNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplicationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List gallery Application Definitions in a gallery.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications
        /// Operation Id: GalleryApplications_ListByGallery
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryApplicationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryApplicationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryApplicationRestClient.ListByGallery(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplicationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryApplicationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryApplicationRestClient.ListByGalleryNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplicationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}
        /// Operation Id: GalleryApplications_Get
        /// </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}
        /// Operation Id: GalleryApplications_Get
        /// </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(galleryApplicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}
        /// Operation Id: GalleryApplications_Get
        /// </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual async Task<Response<GalleryApplicationResource>> GetIfExistsAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _galleryApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GalleryApplicationResource>(null, response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}
        /// Operation Id: GalleryApplications_Get
        /// </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<GalleryApplicationResource> GetIfExists(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _galleryApplicationClientDiagnostics.CreateScope("GalleryApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GalleryApplicationResource>(null, response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GalleryApplicationResource> IEnumerable<GalleryApplicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryApplicationResource> IAsyncEnumerable<GalleryApplicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
