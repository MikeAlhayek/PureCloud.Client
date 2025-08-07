using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IJourneyApi
{
    /// <summary>
    /// Delete single action map.
    /// </summary>
    /// <param name="actionMapId">ID of the action map.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if the deletion was successful, false otherwise.</returns>
    Task<bool> DeleteJourneyActionmapAsync(string actionMapId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a single action template.
    /// </summary>
    /// <param name="actionTemplateId">ID of the action template.</param>
    /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have its state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if the deletion was successful, false otherwise.</returns>
    Task<bool> DeleteJourneyActiontemplateAsync(string actionTemplateId, bool? hardDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an outcome.
    /// </summary>
    /// <param name="outcomeId">ID of the outcome.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if the deletion was successful, false otherwise.</returns>
    Task<bool> DeleteJourneyOutcomeAsync(string outcomeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an outcome predictor.
    /// </summary>
    /// <param name="predictorId">ID of predictor</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if the deletion was successful, false otherwise.</returns>
    Task<bool> DeleteJourneyOutcomesPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a segment.
    /// </summary>
    /// <param name="segmentId">ID of the segment.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if the deletion was successful, false otherwise.</returns>
    Task<bool> DeleteJourneySegmentAsync(string segmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Journey View by ID
    /// </summary>
    /// <param name="viewId">viewId</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if the deletion was successful, false otherwise.</returns>
    Task<bool> DeleteJourneyViewAsync(string viewId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the Schedule of a JourneyView
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewSchedule> DeleteJourneyViewSchedulesAsync(string viewId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get status for async query for journey aggregates
    /// </summary>
    /// <param name="jobId">jobId</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<AsyncQueryStatus> GetAnalyticsJourneysAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetch a page of results for an async query
    /// </summary>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyAsyncAggregateQueryResponse> GetAnalyticsJourneysAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all sessions for a given external contact.
    /// </summary>
    /// <param name="contactId">ExternalContact ID</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned.</param>
    /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<SessionListing> GetExternalcontactsContactJourneySessionsAsync(string contactId, string pageSize = null, string after = null, bool? includeMerged = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single action map.
    /// </summary>
    /// <param name="actionMapId">ID of the action map.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionMap> GetJourneyActionmapAsync(string actionMapId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all action maps.
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortBy">Field(s) to sort by</param>
    /// <param name="filterField">Field to filter by</param>
    /// <param name="filterValue">Value to filter by</param>
    /// <param name="actionMapIds">IDs of action maps to return</param>
    /// <param name="queryFields">Query fields</param>
    /// <param name="queryValue">Query value</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionMapListing> GetJourneyActionmapsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, IEnumerable<string> actionMapIds = null, IEnumerable<string> queryFields = null, string queryValue = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get status of job
    /// </summary>
    /// <param name="jobId">ID of the job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<string> GetJourneyActionmapsEstimatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get estimates from completed job.
    /// </summary>
    /// <param name="jobId">ID of the job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionMapEstimateResult> GetJourneyActionmapsEstimatesJobResultsAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single action target.
    /// </summary>
    /// <param name="actionTargetId">ID of the action target.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionTarget> GetJourneyActiontargetAsync(string actionTargetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all action targets.
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionTargetListing> GetJourneyActiontargetsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single action template.
    /// </summary>
    /// <param name="actionTemplateId">ID of the action template.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionTemplate> GetJourneyActiontemplateAsync(string actionTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all action templates.
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortBy">Field(s) to sort by</param>
    /// <param name="mediaType">Media type</param>
    /// <param name="state">Action template state.</param>
    /// <param name="queryFields">Query fields</param>
    /// <param name="queryValue">Query value</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionTemplateListing> GetJourneyActiontemplatesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, IEnumerable<string> queryFields = null, string queryValue = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Send a ping.
    /// </summary>
    /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
    /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
    /// <param name="dl">Document location of the ping.</param>
    /// <param name="dt">Document title of the ping.</param>
    /// <param name="appNamespace">Namespace the ping is being sent for.</param>
    /// <param name="sessionId">ID of the customer's session.</param>
    /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last beacon was sent to Genesys.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<DeploymentPing> GetJourneyDeploymentCustomerPingAsync(string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single outcome.
    /// </summary>
    /// <param name="outcomeId">ID of the outcome.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<Outcome> GetJourneyOutcomeAsync(string outcomeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all outcomes.
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortBy">Field(s) to sort by</param>
    /// <param name="outcomeIds">IDs of outcomes to return</param>
    /// <param name="queryFields">Query fields</param>
    /// <param name="queryValue">Query value</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<OutcomeListing> GetJourneyOutcomesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, IEnumerable<string> outcomeIds = null, IEnumerable<string> queryFields = null, string queryValue = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get job status.
    /// </summary>
    /// <param name="jobId">ID of the job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<OutcomeAttributionJobStateResponse> GetJourneyOutcomesAttributionsJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get outcome attribution entities from completed job.
    /// </summary>
    /// <param name="jobId">ID of the job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<OutcomeAttributionResponseListing> GetJourneyOutcomesAttributionsJobResultsAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single outcome predictor.
    /// </summary>
    /// <param name="predictorId">ID of predictor</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<OutcomePredictor> GetJourneyOutcomesPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all outcome predictors.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<OutcomePredictorListing> GetJourneyOutcomesPredictorsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single segment.
    /// </summary>
    /// <param name="segmentId">ID of the segment.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneySegment> GetJourneySegmentAsync(string segmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all segments.
    /// </summary>
    /// <param name="sortBy">Field(s) to sort by</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="isActive">Determines whether or not to show only active segments.</param>
    /// <param name="segmentIds">IDs of segments to return</param>
    /// <param name="queryFields">Query fields</param>
    /// <param name="queryValue">Query value</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<SegmentListing> GetJourneySegmentsAsync(string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, IEnumerable<string> segmentIds = null, IEnumerable<string> queryFields = null, string queryValue = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single session.
    /// </summary>
    /// <param name="sessionId">ID of the session.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<Session> GetJourneySessionAsync(string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all events for a given session.
    /// </summary>
    /// <param name="sessionId">ID of the session.</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned.</param>
    /// <param name="eventType">Event type to filter by.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<EventListing> GetJourneySessionEventsAsync(string sessionId, string pageSize = null, string after = null, string eventType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve latest outcome score associated with a session for all outcomes.
    /// </summary>
    /// <param name="sessionId">ID of the session.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<OutcomeScoresResult> GetJourneySessionOutcomescoresAsync(string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Journey View by ID
    /// </summary>
    /// <param name="viewId">viewId</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyView> GetJourneyViewAsync(string viewId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the Schedule for a JourneyView
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewSchedule> GetJourneyViewSchedulesAsync(string viewId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Journey View by ID and version
    /// </summary>
    /// <param name="viewId">viewId</param>
    /// <param name="versionId">versionId</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyView> GetJourneyViewVersionAsync(string viewId, string versionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Chart by ID
    /// </summary>
    /// <param name="viewId">viewId</param>
    /// <param name="journeyViewVersion">Journey View Version</param>
    /// <param name="chartId">chartId</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewChart> GetJourneyViewVersionChartAsync(string viewId, string journeyViewVersion, string chartId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Chart by ID and version
    /// </summary>
    /// <param name="viewId">viewId</param>
    /// <param name="journeyViewVersion">Journey View Version</param>
    /// <param name="chartId">chartId</param>
    /// <param name="chartVersion">chartVersion</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewChart> GetJourneyViewVersionChartVersionAsync(string viewId, string journeyViewVersion, string chartId, string chartVersion, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Journey View Job
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="journeyVersionId">Journey View Version</param>
    /// <param name="jobId">JobId</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewJob> GetJourneyViewVersionJobAsync(string viewId, string journeyVersionId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Journey View Job results
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="journeyViewVersion">Journey View Version</param>
    /// <param name="jobId">JobId</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewResult> GetJourneyViewVersionJobResultsAsync(string viewId, string journeyViewVersion, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Journey View Chart Job results
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="journeyVersionId">Journey View Version</param>
    /// <param name="jobId">JobId</param>
    /// <param name="chartId">ChartId</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewChartResult> GetJourneyViewVersionJobResultsChartAsync(string viewId, string journeyVersionId, string jobId, string chartId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the latest Job of a Journey View
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="journeyVersionId">Journey View Version</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewJob> GetJourneyViewVersionJobsLatestAsync(string viewId, string journeyVersionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Journey Views
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="nameOrCreatedBy">Journey View name or the user who created them</param>
    /// <param name="expand">Parameter to request additional data to return in Journey payload</param>
    /// <param name="id">ID of the Journey View</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewListing> GetJourneyViewsAsync(int? pageNumber = null, int? pageSize = null, string nameOrCreatedBy = null, string expand = null, string id = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the date and time range of data being captured for Journey Views
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<DataRange> GetJourneyViewsDataDetailsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Journey View Event Definition
    /// </summary>
    /// <param name="eventDefinitionId">Event Definition ID</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyEventDefinition> GetJourneyViewsEventdefinitionAsync(string eventDefinitionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Journey View Event Definitions
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyEventDefinitionListing> GetJourneyViewsEventdefinitionsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the Journey View jobs
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="interval">An interval of time to filter for. Defaults to today if not provided. Date time is represented as an ISO-8601 string.</param>
    /// <param name="statuses">JobStatuses. Defaults to all if not provided.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewJobListing> GetJourneyViewsJobsAsync(int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of Schedule Entities for a Journey View
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewScheduleListing> GetJourneyViewsSchedulesAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update single action map.
    /// </summary>
    /// <param name="actionMapId">ID of the action map.</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionMap> PatchJourneyActionmapAsync(string actionMapId, PatchActionMap body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a single action target.
    /// </summary>
    /// <param name="actionTargetId">ID of the action target.</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionTarget> PatchJourneyActiontargetAsync(string actionTargetId, PatchActionTarget body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a single action template.
    /// </summary>
    /// <param name="actionTemplateId">ID of the action template.</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionTemplate> PatchJourneyActiontemplateAsync(string actionTemplateId, PatchActionTemplate body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an outcome.
    /// </summary>
    /// <param name="outcomeId">ID of the outcome.</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<Outcome> PatchJourneyOutcomeAsync(string outcomeId, PatchOutcome body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a segment.
    /// </summary>
    /// <param name="segmentId">ID of the segment.</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneySegment> PatchJourneySegmentAsync(string segmentId, PatchSegment body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Journey View Job
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="journeyVersionId">Journey View Version</param>
    /// <param name="jobId">JobId</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewJob> PatchJourneyViewVersionJobAsync(string viewId, string journeyVersionId, string jobId, JourneyViewJob body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Submit async job to perform a journey analytics query
    /// </summary>
    /// <param name="body">query</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<AsyncQueryResponse> CreateAnalyticsJourneysAggregatesJobsAsync(JourneyAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for journey aggregates
    /// </summary>
    /// <param name="body">query</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyAggregateQueryResponse> CreateAnalyticsJourneysAggregatesQueryAsync(JourneyAggregationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an action map.
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionMap> CreateJourneyActionmapsAsync(ActionMap body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for estimates
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<EstimateJobAsyncResponse> CreateJourneyActionmapsEstimatesJobsAsync(ActionMapEstimateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a single action template.
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<ActionTemplate> CreateJourneyActiontemplatesAsync(ActionTemplate body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sends an action event, which is used for changing the state of actions that have been offered to the user.
    /// </summary>
    /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task CreateJourneyDeploymentActioneventAsync(string deploymentId, ActionEventRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Send a Journey App Event
    /// </summary>
    /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<AppEventResponse> CreateJourneyDeploymentAppeventsAsync(string deploymentId, AppEventRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Send a Journey Web Event
    /// </summary>
    /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<WebEventResponse> CreateJourneyDeploymentWebeventsAsync(string deploymentId, WebEventRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for flow paths.
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<FlowPaths> CreateJourneyFlowsPathsQueryAsync(FlowPathsQuery body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an outcome.
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<Outcome> CreateJourneyOutcomesAsync(OutcomeRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Submit async job to perform an outcome attribution on a list of outcome touch points.
    /// </summary>
    /// <param name="body">outcome attribution request</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<OutcomeAttributionAsyncResponse> CreateJourneyOutcomesAttributionsJobsAsync(OutcomeAttributionListing body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an outcome predictor.
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<OutcomePredictor> CreateJourneyOutcomesPredictorsAsync(OutcomePredictorRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a segment.
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneySegment> CreateJourneySegmentsAsync(JourneySegmentRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Schedule a JourneyView
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="body">JourneyViewSchedule</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewSchedule> CreateJourneyViewSchedulesAsync(string viewId, JourneyViewSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Execute a Journey View Job
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="journeyVersionId">Journey View Version</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewJob> CreateJourneyViewVersionJobsAsync(string viewId, string journeyVersionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new version of a Journey View
    /// </summary>
    /// <param name="viewId">viewId</param>
    /// <param name="body">JourneyView</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyView> CreateJourneyViewVersionsAsync(string viewId, JourneyView body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Journey View
    /// </summary>
    /// <param name="body">JourneyView</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyView> CreateJourneyViewsAsync(JourneyView body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate whether an encoding exist for a label/value combination.
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<EntityListing> CreateJourneyViewsEncodingsValidateAsync(IEnumerable<Label> body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the Schedule for a JourneyView
    /// </summary>
    /// <param name="viewId">Journey View Id</param>
    /// <param name="body">JourneyViewSchedule</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyViewSchedule> UpdateJourneyViewSchedulesAsync(string viewId, JourneyViewSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Journey View
    /// </summary>
    /// <param name="viewId">viewId</param>
    /// <param name="versionId">versionId</param>
    /// <param name="body">JourneyView</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    Task<JourneyView> UpdateJourneyViewVersionAsync(string viewId, string versionId, JourneyView body, CancellationToken cancellationToken = default);
}
