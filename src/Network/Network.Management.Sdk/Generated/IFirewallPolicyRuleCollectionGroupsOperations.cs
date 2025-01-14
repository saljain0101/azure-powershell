// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// FirewallPolicyRuleCollectionGroupsOperations operations.
    /// </summary>
    public partial interface IFirewallPolicyRuleCollectionGroupsOperations
    {
        /// <summary>
        /// Deletes the specified FirewallPolicyRuleCollectionGroup.
        /// </summary>
        /// <remarks>
        /// Deletes the specified FirewallPolicyRuleCollectionGroup.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='ruleCollectionGroupName'>
        /// The name of the FirewallPolicyRuleCollectionGroup.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the specified FirewallPolicyRuleCollectionGroup.
        /// </summary>
        /// <remarks>
        /// Gets the specified FirewallPolicyRuleCollectionGroup.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='ruleCollectionGroupName'>
        /// The name of the FirewallPolicyRuleCollectionGroup.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FirewallPolicyRuleCollectionGroup>> GetWithHttpMessagesAsync(string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates the specified FirewallPolicyRuleCollectionGroup.
        /// </summary>
        /// <remarks>
        /// Creates or updates the specified FirewallPolicyRuleCollectionGroup.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='ruleCollectionGroupName'>
        /// The name of the FirewallPolicyRuleCollectionGroup.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update
        /// FirewallPolicyRuleCollectionGroup operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FirewallPolicyRuleCollectionGroup>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroup parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource.
        /// </summary>
        /// <remarks>
        /// Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<FirewallPolicyRuleCollectionGroup>>> ListWithHttpMessagesAsync(string resourceGroupName, string firewallPolicyName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes the specified FirewallPolicyRuleCollectionGroup.
        /// </summary>
        /// <remarks>
        /// Deletes the specified FirewallPolicyRuleCollectionGroup.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='ruleCollectionGroupName'>
        /// The name of the FirewallPolicyRuleCollectionGroup.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates the specified FirewallPolicyRuleCollectionGroup.
        /// </summary>
        /// <remarks>
        /// Creates or updates the specified FirewallPolicyRuleCollectionGroup.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='ruleCollectionGroupName'>
        /// The name of the FirewallPolicyRuleCollectionGroup.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update
        /// FirewallPolicyRuleCollectionGroup operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FirewallPolicyRuleCollectionGroup>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroup parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource.
        /// </summary>
        /// <remarks>
        /// Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<FirewallPolicyRuleCollectionGroup>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}