using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IFlowsApi
{
    Task<AsyncQueryStatus> GetAnalyticsFlowsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<FlowAsyncAggregateQueryResponse> GetAnalyticsFlowsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<FlowActivityResponse> CreateAnalyticsFlowsActivityQueryAsync(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsFlowsAggregatesJobsAsync(FlowAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<FlowAggregateQueryResponse> CreateAnalyticsFlowsAggregatesQueryAsync(FlowAggregationQuery body, CancellationToken cancellationToken = default);

    Task<FlowObservationQueryResponse> CreateAnalyticsFlowsObservationsQueryAsync(FlowObservationQuery body, CancellationToken cancellationToken = default);
}
