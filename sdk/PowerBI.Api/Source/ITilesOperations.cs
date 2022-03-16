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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TilesOperations operations.
    /// </summary>
    public partial interface ITilesOperations
    {
        /// <summary>
        /// Generates an embed token to view the specified tile from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// &gt; [!IMPORTANT]
        /// &gt; This API call is only relevant to the [embed for your
        /// customers](/power-bi/developer/embed-sample-for-customers)
        /// scenario. To learn more about using this API, see [Considerations
        /// when generating an embed
        /// token](/power-bi/developer/embedded/generate-embed-token).
        ///
        /// ## Permissions
        ///
        /// - When using a service principal for authentication, refer to
        /// [Embed Power BI content with service
        /// principal](/power-bi/developer/embed-service-principal) and
        /// [Considerations and
        /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        /// - This API call can be called by a service principal profile.
        ///
        /// ## Required Scope
        ///
        /// All of the following:
        ///
        /// - Dashboard.ReadWrite.All or Dashboard.Read.All
        /// - Report.ReadWrite.All or Report.Read.All
        /// - Dataset.ReadWrite.All or Dataset.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard ID
        /// </param>
        /// <param name='tileId'>
        /// The tile ID
        /// </param>
        /// <param name='requestParameters'>
        /// Generate token parameters
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<EmbedToken>> GenerateTokenInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, System.Guid tileId, GenerateTokenRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
