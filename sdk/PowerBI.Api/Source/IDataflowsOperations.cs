// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DataflowsOperations operations.
    /// </summary>
    public partial interface IDataflowsOperations
    {
        /// <summary>
        /// Exports the specified dataflow definition to a JSON file.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile.
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All or Dataflow.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Stream>> GetDataflowWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a dataflow from Power BI data prep storage, including its
        /// definition file and model.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile.
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeleteDataflowWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates dataflow properties, capabilities and settings.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='dataflowUpdateRequest'>
        /// Patch dataflow properties, capabilities and settings
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateDataflowWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, DataflowUpdateRequestMessage dataflowUpdateRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Triggers a refresh for the specified dataflow.
        /// </summary>
        /// <remarks>
        ///
        /// Supported email notification options are **MailOnFailure** and
        /// **NoNotification**. **MailOnCompletion** isn't supported.
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile.
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='refreshRequest'>
        /// </param>
        /// <param name='processType'>
        /// Type of refresh process to use.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> RefreshDataflowWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, RefreshRequest refreshRequest = default(RefreshRequest), System.Guid? processType = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of data sources for the specified dataflow.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile.
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All or Dataflow.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Datasources>> GetDataflowDataSourcesWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all dataflows from the specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile.
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All or Dataflow.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Dataflows>> GetDataflowsWithHttpMessagesAsync(System.Guid groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of upstream dataflows for the specified dataflow.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile.
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All or Dataflow.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DependentDataflows>> GetUpstreamDataflowsInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates the refresh schedule for a specified dataflow.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile.
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='refreshScheduleRequest'>
        /// The dataflow refresh schedule to create or update
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateRefreshScheduleWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, RefreshScheduleRequest refreshScheduleRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of transactions for the specified dataflow.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All or Dataflow.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DataflowTransactions>> GetDataflowTransactionsWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Attempts to cancel the specified transactions.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataflow.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='transactionId'>
        /// The transaction ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DataflowTransactionStatus>> CancelDataflowTransactionWithHttpMessagesAsync(System.Guid groupId, System.Guid transactionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of upstream dataflows for the specified dataflow.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DependentDataflows>> GetUpstreamDataflowsInGroupAsAdminWithHttpMessagesAsync(System.Guid groupId, System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of dataflows from the specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a boolean condition
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Dataflows>> GetDataflowsInGroupAsAdminWithHttpMessagesAsync(System.Guid groupId, string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of dataflows for the organization.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='filter'>
        /// Filters the results, based on a boolean condition
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Dataflows>> GetDataflowsAsAdminWithHttpMessagesAsync(string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports the definition for the specified dataflow to a JSON file.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Stream>> ExportDataflowAsAdminWithHttpMessagesAsync(System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of data sources for the specified dataflow.
        /// </summary>
        /// <remarks>
        ///
        /// Deleted data sources will still appear in the response. This may
        /// include both cloud and on-premise data gateway sources. For more
        /// information see [Dataflows considerations and
        /// limitations](/power-bi/transform-model/dataflows/dataflows-features-limitations).
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Datasources>> GetDataflowDatasourcesAsAdminWithHttpMessagesAsync(System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of users that have access to the specified dataflow.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='dataflowId'>
        /// The dataflow ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DataflowUsers>> GetDataflowUsersAsAdminWithHttpMessagesAsync(System.Guid dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
