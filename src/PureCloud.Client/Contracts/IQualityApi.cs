using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IQualityApi
{
    /// <summary>
    /// Gets a list of agent activities
    /// </summary>
    /// <param name="pageSize">The total page size requested</param>
    /// <param name="pageNumber">The page number requested</param>
    /// <param name="sortBy">variable name requested to sort by</param>
    /// <param name="expand">variable name requested by expand list</param>
    /// <param name="nextPage">next page token</param>
    /// <param name="previousPage">Previous page token</param>
    /// <param name="startTime">Start time of agent activity based on assigned date</param>
    /// <param name="endTime">End time of agent activity based on assigned date</param>
    /// <param name="agentUserId">user id of agent requested</param>
    /// <param name="evaluatorUserId">user id of the evaluator</param>
    /// <param name="name">name</param>
    /// <param name="group">group id</param>
    /// <param name="agentTeamId">team id of agents to be considered</param>
    /// <param name="formContextId">shared id between form versions</param>
    /// <param name="userState">user state filter parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent activity listing</returns>
    Task<AgentActivityEntityListing> GetQualityAgentsActivityAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, IEnumerable<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null, string userState = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a calibration by id
    /// </summary>
    /// <param name="calibrationId">Calibration ID</param>
    /// <param name="calibratorId">calibratorId</param>
    /// <param name="conversationId">conversationId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Calibration</returns>
    Task<Calibration> GetQualityCalibrationAsync(string calibrationId, string calibratorId = null, string conversationId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an evaluation
    /// </summary>
    /// <param name="conversationId">conversationId</param>
    /// <param name="evaluationId">evaluationId</param>
    /// <param name="expand">agent, evaluator, evaluationForm</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Evaluation</returns>
    Task<EvaluationResponse> GetQualityConversationEvaluationAsync(string conversationId, string evaluationId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an evaluation form
    /// </summary>
    /// <param name="formId">Form ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Evaluation form</returns>
    Task<EvaluationFormResponse> GetQualityFormsEvaluationAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a survey form
    /// </summary>
    /// <param name="surveyId">Survey ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Survey</returns>
    Task<Survey> GetQualitySurveyAsync(string surveyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a calibration
    /// </summary>
    /// <param name="calibratorId">calibratorId</param>
    /// <param name="body">Calibration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Calibration</returns>
    Task<Calibration> CreateQualityCalibrationAsync(string calibratorId, CalibrationCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an evaluation
    /// </summary>
    /// <param name="conversationId">conversationId</param>
    /// <param name="body">Evaluation</param>
    /// <param name="expand">evaluatorId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Evaluation</returns>
    Task<EvaluationResponse> CreateQualityConversationEvaluationAsync(string conversationId, EvaluationCreateBody body, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an evaluation form
    /// </summary>
    /// <param name="body">Evaluation form</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Evaluation form</returns>
    Task<EvaluationFormResponse> CreateQualityFormsEvaluationAsync(EvaluationForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an evaluation form
    /// </summary>
    /// <param name="formId">Form ID</param>
    /// <param name="body">Evaluation form</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Evaluation form</returns>
    Task<EvaluationFormResponse> UpdateQualityFormsEvaluationAsync(string formId, EvaluationForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a survey form
    /// </summary>
    /// <param name="formId">Form ID</param>
    /// <param name="body">Survey form</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Survey form</returns>
    Task<SurveyForm> UpdateQualityFormsSurveyAsync(string formId, SurveyForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a calibration
    /// </summary>
    /// <param name="calibrationId">Calibration ID</param>
    /// <param name="calibratorId">calibratorId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Calibration</returns>
    Task<Calibration> DeleteQualityCalibrationAsync(string calibrationId, string calibratorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an evaluation
    /// </summary>
    /// <param name="conversationId">conversationId</param>
    /// <param name="evaluationId">evaluationId</param>
    /// <param name="expand">evaluatorId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Evaluation</returns>
    Task<EvaluationResponse> DeleteQualityConversationEvaluationAsync(string conversationId, string evaluationId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get AnalyticsEvaluationsAggregatesJob
    /// </summary>
    /// <param name="jobId">jobId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AsyncQueryStatus</returns>
    Task<AsyncQueryStatus> GetAnalyticsEvaluationsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get AnalyticsEvaluationsAggregatesJobResults
    /// </summary>
    /// <param name="jobId">jobId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationAsyncAggregateQueryResponse</returns>
    Task<EvaluationAsyncAggregateQueryResponse> GetAnalyticsEvaluationsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get AnalyticsSurveysAggregatesJob
    /// </summary>
    /// <param name="jobId">jobId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AsyncQueryStatus</returns>
    Task<AsyncQueryStatus> GetAnalyticsSurveysAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get AnalyticsSurveysAggregatesJobResults
    /// </summary>
    /// <param name="jobId">jobId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyAsyncAggregateQueryResponse</returns>
    Task<SurveyAsyncAggregateQueryResponse> GetAnalyticsSurveysAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Calibrations
    /// </summary>
    /// <param name="calibratorId">calibratorId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>CalibrationEntityListing</returns>
    Task<CalibrationEntityListing> GetQualityCalibrationsAsync(string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ConversationsAuditsQueryTransactionId
    /// </summary>
    /// <param name="transactionId">transactionId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QualityAuditQueryExecutionStatusResponse</returns>
    Task<QualityAuditQueryExecutionStatusResponse> GetQualityConversationsAuditsQueryTransactionIdAsync(string transactionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ConversationsAuditsQueryTransactionIdResults
    /// </summary>
    /// <param name="transactionId">transactionId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QualityAuditQueryExecutionResultsResponse</returns>
    Task<QualityAuditQueryExecutionResultsResponse> GetQualityConversationsAuditsQueryTransactionIdResultsAsync(string transactionId, string cursor = null, int? pageSize = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get EvaluationsQuery
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationEntityListing</returns>
    Task<EvaluationEntityListing> GetQualityEvaluationsQueryAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, IEnumerable<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null, bool? includeDeletedUsers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Form
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>bool</returns>
    Task<bool> DeleteQualityFormAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete FormsEvaluation
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>bool</returns>
    Task<bool> DeleteQualityFormsEvaluationAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete FormsSurvey
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>bool</returns>
    Task<bool> DeleteQualityFormsSurveyAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get EvaluatorsActivity
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AgentActivityEntityListing</returns>
    Task<AgentActivityEntityListing> GetQualityEvaluatorsActivityAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, IEnumerable<string> permission = null, string group = null, string agentTeamId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Form
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationForm</returns>
    Task<EvaluationForm> GetQualityFormAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get FormVersions
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponseEntityListing</returns>
    Task<EvaluationFormResponseEntityListing> GetQualityFormVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Forms
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponseEntityListing</returns>
    Task<EvaluationFormResponseEntityListing> GetQualityFormsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get FormsEvaluationVersions
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponseEntityListing</returns>
    Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get FormsEvaluations
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponseEntityListing</returns>
    Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get FormsSurvey
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyForm</returns>
    Task<SurveyForm> GetQualityFormsSurveyAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get FormsSurveys
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyFormEntityListing</returns>
    Task<SurveyFormEntityListing> GetQualityFormsSurveysAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get FormsSurveysBulk
    /// </summary>
    /// <param name="ids">ids</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyFormEntityListing</returns>
    Task<SurveyFormEntityListing> GetQualityFormsSurveysBulkAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get FormsSurveyVersions
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyFormEntityListing</returns>
    Task<SurveyFormEntityListing> GetQualityFormsSurveyVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Publishedform
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationForm</returns>
    Task<EvaluationForm> GetQualityPublishedformAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Publishedforms
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponseEntityListing</returns>
    Task<EvaluationFormResponseEntityListing> GetQualityPublishedformsAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get PublishedformsEvaluation
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponse</returns>
    Task<EvaluationFormResponse> GetQualityPublishedformsEvaluationAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get PublishedformsEvaluations
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponseEntityListing</returns>
    Task<EvaluationFormResponseEntityListing> GetQualityPublishedformsEvaluationsAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get PublishedformsSurvey
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyForm</returns>
    Task<SurveyForm> GetQualityPublishedformsSurveyAsync(string formId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get PublishedformsSurveys
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyFormEntityListing</returns>
    Task<SurveyFormEntityListing> GetQualityPublishedformsSurveysAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SurveysScorable
    /// </summary>
    /// <param name="customerSurveyUrl">customerSurveyUrl</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ScorableSurvey</returns>
    Task<ScorableSurvey> GetQualitySurveysScorableAsync(string customerSurveyUrl, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create AnalyticsEvaluationsAggregatesJob
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AsyncQueryStatus</returns>
    Task<AsyncQueryStatus> CreateAnalyticsEvaluationsAggregatesJobAsync(EvaluationAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create AnalyticsEvaluationsAggregatesQuery
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationAggregateQueryResponse</returns>
    Task<EvaluationAggregateQueryResponse> CreateAnalyticsEvaluationsAggregatesQueryAsync(EvaluationAggregationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create AnalyticsSurveysAggregatesJob
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AsyncQueryStatus</returns>
    Task<AsyncQueryStatus> CreateAnalyticsSurveysAggregatesJobAsync(SurveyAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create AnalyticsSurveysAggregatesQuery
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyAggregateQueryResponse</returns>
    Task<SurveyAggregateQueryResponse> CreateAnalyticsSurveysAggregatesQueryAsync(SurveyAggregationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ConversationsAuditsQuery
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QualityAuditQueryExecutionStatusResponse</returns>
    Task<QualityAuditQueryExecutionStatusResponse> CreateQualityConversationsAuditsQueryAsync(QMAuditQueryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create EvaluationsAggregatesQueryMe
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationAggregateQueryResponse</returns>
    Task<EvaluationAggregateQueryResponse> CreateQualityEvaluationsAggregatesQueryMeAsync(EvaluationAggregationQueryMe body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create EvaluationsScoring
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationScoringSet</returns>
    Task<EvaluationScoringSet> CreateQualityEvaluationsScoringAsync(EvaluationFormAndScoringSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Forms
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponse</returns>
    Task<EvaluationFormResponse> CreateQualityFormsAsync(EvaluationForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create FormsSurveys
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyForm</returns>
    Task<SurveyForm> CreateQualityFormsSurveysAsync(SurveyForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Publishedforms
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponse</returns>
    Task<EvaluationFormResponse> CreateQualityPublishedformsAsync(PublishForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create PublishedformsEvaluations
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponse</returns>
    Task<EvaluationFormResponse> CreateQualityPublishedformsEvaluationsAsync(PublishForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create PublishedformsSurveys
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyForm</returns>
    Task<SurveyForm> CreateQualityPublishedformsSurveysAsync(PublishForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create SurveysScoring
    /// </summary>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SurveyScoringSet</returns>
    Task<SurveyScoringSet> CreateQualitySurveysScoringAsync(SurveyFormAndScoringSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Calibration
    /// </summary>
    /// <param name="calibrationId">calibrationId</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Calibration</returns>
    Task<Calibration> UpdateQualityCalibrationAsync(string calibrationId, Calibration body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update ConversationEvaluation
    /// </summary>
    /// <param name="conversationId">conversationId</param>
    /// <param name="evaluationId">evaluationId</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationResponse</returns>
    Task<EvaluationResponse> UpdateQualityConversationEvaluationAsync(string conversationId, string evaluationId, Evaluation body, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Form
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EvaluationFormResponse</returns>
    Task<EvaluationFormResponse> UpdateQualityFormAsync(string formId, EvaluationForm body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update FormsEvaluationAiscoringSettings
    /// </summary>
    /// <param name="formId">formId</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AiScoringSettings</returns>
    Task<AiScoringSettings> UpdateQualityFormsEvaluationAiscoringSettingsAsync(string formId, AiScoringSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update SurveysScorable
    /// </summary>
    /// <param name="customerSurveyUrl">customerSurveyUrl</param>
    /// <param name="body">body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ScorableSurvey</returns>
    Task<ScorableSurvey> UpdateQualitySurveysScorableAsync(string customerSurveyUrl, ScorableSurvey body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the surveys for a conversation
    /// </summary>
    /// <param name="conversationId">conversationId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of Survey</returns>
    Task<List<Survey>> GetQualityConversationSurveysAsync(string conversationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve evaluation forms by their context ids
    /// </summary>
    /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of EvaluationFormResponse</returns>
    Task<List<EvaluationFormResponse>> GetQualityFormsEvaluationsBulkContextsAsync(IEnumerable<string> contextId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve survey forms by their context ids
    /// </summary>
    /// <param name="contextId">A comma-delimited list of valid survey form context ids</param>
    /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of SurveyForm</returns>
    Task<List<SurveyForm>> GetQualityFormsSurveysBulkContextsAsync(IEnumerable<string> contextId, bool? published = null, CancellationToken cancellationToken = default);
}
