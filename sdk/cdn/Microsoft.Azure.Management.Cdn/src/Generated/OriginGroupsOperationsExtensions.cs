// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OriginGroupsOperations.
    /// </summary>
    public static partial class OriginGroupsOperationsExtensions
    {
            /// <summary>
            /// Lists all of the existing origin groups within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            public static IPage<OriginGroup> ListByEndpoint(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return operations.ListByEndpointAsync(resourceGroupName, profileName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the existing origin groups within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<OriginGroup>> ListByEndpointAsync(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEndpointWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            public static OriginGroup Get(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName)
            {
                return operations.GetAsync(resourceGroupName, profileName, endpointName, originGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OriginGroup> GetAsync(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new origin group within the specified endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='originGroup'>
            /// Origin group properties
            /// </param>
            public static OriginGroup Create(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroup originGroup)
            {
                return operations.CreateAsync(resourceGroupName, profileName, endpointName, originGroupName, originGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new origin group within the specified endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='originGroup'>
            /// Origin group properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OriginGroup> CreateAsync(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroup originGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originGroupName, originGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='originGroupUpdateProperties'>
            /// Origin group properties
            /// </param>
            public static OriginGroup Update(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupUpdateParameters originGroupUpdateProperties)
            {
                return operations.UpdateAsync(resourceGroupName, profileName, endpointName, originGroupName, originGroupUpdateProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='originGroupUpdateProperties'>
            /// Origin group properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OriginGroup> UpdateAsync(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupUpdateParameters originGroupUpdateProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originGroupName, originGroupUpdateProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            public static void Delete(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName)
            {
                operations.DeleteAsync(resourceGroupName, profileName, endpointName, originGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new origin group within the specified endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='originGroup'>
            /// Origin group properties
            /// </param>
            public static OriginGroup BeginCreate(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroup originGroup)
            {
                return operations.BeginCreateAsync(resourceGroupName, profileName, endpointName, originGroupName, originGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new origin group within the specified endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='originGroup'>
            /// Origin group properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OriginGroup> BeginCreateAsync(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroup originGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originGroupName, originGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='originGroupUpdateProperties'>
            /// Origin group properties
            /// </param>
            public static OriginGroup BeginUpdate(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupUpdateParameters originGroupUpdateProperties)
            {
                return operations.BeginUpdateAsync(resourceGroupName, profileName, endpointName, originGroupName, originGroupUpdateProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='originGroupUpdateProperties'>
            /// Origin group properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OriginGroup> BeginUpdateAsync(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupUpdateParameters originGroupUpdateProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originGroupName, originGroupUpdateProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            public static void BeginDelete(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName)
            {
                operations.BeginDeleteAsync(resourceGroupName, profileName, endpointName, originGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing origin group within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originGroupName'>
            /// Name of the origin group which is unique within the endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IOriginGroupsOperations operations, string resourceGroupName, string profileName, string endpointName, string originGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all of the existing origin groups within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<OriginGroup> ListByEndpointNext(this IOriginGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByEndpointNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the existing origin groups within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<OriginGroup>> ListByEndpointNextAsync(this IOriginGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEndpointNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
