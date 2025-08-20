using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWidgetsApi
{
    /// <summary>
    /// List Widget deployments
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WidgetDeploymentEntityListing</returns>
    [Obsolete]
    Task<WidgetDeploymentEntityListing> GetWidgetDeploymentsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Widget deployment
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="deploymentId">Widget Config Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WidgetDeployment</returns>
    [Obsolete]
    Task<WidgetDeployment> GetWidgetDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Widget deployment
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="deployment">Deployment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WidgetDeployment</returns>
    [Obsolete]
    Task<WidgetDeployment> CreateWidgetDeploymentAsync(WidgetDeployment deployment, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Widget deployment
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="deploymentId">Widget Config Id</param>
    /// <param name="deployment">Deployment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WidgetDeployment</returns>
    [Obsolete]
    Task<WidgetDeployment> UpdateWidgetDeploymentAsync(string deploymentId, WidgetDeployment deployment, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Widget deployment
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="deploymentId">Widget Config Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task&lt;bool&gt;</returns>
    [Obsolete]
    Task<bool> DeleteWidgetDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default);
}
