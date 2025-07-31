using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IQualityApi
{
    Task<AgentActivityEntityListing> GetQualityAgentsActivityAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, IEnumerable<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null, string userState = null, CancellationToken cancellationToken = default);

    Task<Calibration> GetQualityCalibrationAsync(string calibrationId, string calibratorId = null, string conversationId = null, CancellationToken cancellationToken = default);

    Task<EvaluationResponse> GetQualityConversationEvaluationAsync(string conversationId, string evaluationId, string expand = null, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponse> GetQualityFormsEvaluationAsync(string formId, CancellationToken cancellationToken = default);

    Task<Survey> GetQualitySurveyAsync(string surveyId, CancellationToken cancellationToken = default);

    Task<Calibration> CreateQualityCalibrationAsync(string calibratorId, CalibrationCreate body, CancellationToken cancellationToken = default);

    Task<EvaluationResponse> CreateQualityConversationEvaluationAsync(string conversationId, EvaluationCreateBody body, string expand = null, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponse> CreateQualityFormsEvaluationAsync(EvaluationForm body, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponse> UpdateQualityFormsEvaluationAsync(string formId, EvaluationForm body, CancellationToken cancellationToken = default);

    Task<SurveyForm> UpdateQualityFormsSurveyAsync(string formId, SurveyForm body, CancellationToken cancellationToken = default);

    Task<Calibration> DeleteQualityCalibrationAsync(string calibrationId, string calibratorId, CancellationToken cancellationToken = default);

    Task<EvaluationResponse> DeleteQualityConversationEvaluationAsync(string conversationId, string evaluationId, string expand = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsEvaluationsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<EvaluationAsyncAggregateQueryResponse> GetAnalyticsEvaluationsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsSurveysAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<SurveyAsyncAggregateQueryResponse> GetAnalyticsSurveysAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<CalibrationEntityListing> GetQualityCalibrationsAsync(string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, CancellationToken cancellationToken = default);

    Task<QualityAuditQueryExecutionStatusResponse> GetQualityConversationsAuditsQueryTransactionIdAsync(string transactionId, CancellationToken cancellationToken = default);

    Task<QualityAuditQueryExecutionResultsResponse> GetQualityConversationsAuditsQueryTransactionIdResultsAsync(string transactionId, string cursor = null, int? pageSize = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<EvaluationEntityListing> GetQualityEvaluationsQueryAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, IEnumerable<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null, bool? includeDeletedUsers = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteQualityFormAsync(string formId, CancellationToken cancellationToken = default);

    Task<bool> DeleteQualityFormsEvaluationAsync(string formId, CancellationToken cancellationToken = default);

    Task<bool> DeleteQualityFormsSurveyAsync(string formId, CancellationToken cancellationToken = default);

    Task<AgentActivityEntityListing> GetQualityEvaluatorsActivityAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, IEnumerable<string> permission = null, string group = null, string agentTeamId = null, CancellationToken cancellationToken = default);

    Task<EvaluationForm> GetQualityFormAsync(string formId, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponseEntityListing> GetQualityFormVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<EvaluationFormEntityListing> GetQualityFormsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<EvaluationFormEntityListing> GetQualityFormsEvaluationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<SurveyForm> GetQualityFormsSurveyAsync(string formId, CancellationToken cancellationToken = default);

    Task<SurveyFormEntityListing> GetQualityFormsSurveysAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<SurveyFormEntityListing> GetQualityFormsSurveysBulkAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default);

    Task<SurveyFormEntityListing> GetQualityFormsSurveyVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<EvaluationForm> GetQualityPublishedformAsync(string formId, CancellationToken cancellationToken = default);

    Task<EvaluationFormEntityListing> GetQualityPublishedformsAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponse> GetQualityPublishedformsEvaluationAsync(string formId, CancellationToken cancellationToken = default);

    Task<EvaluationFormEntityListing> GetQualityPublishedformsEvaluationsAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null, CancellationToken cancellationToken = default);

    Task<SurveyForm> GetQualityPublishedformsSurveyAsync(string formId, CancellationToken cancellationToken = default);

    Task<SurveyFormEntityListing> GetQualityPublishedformsSurveysAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null, CancellationToken cancellationToken = default);

    Task<ScorableSurvey> GetQualitySurveysScorableAsync(string customerSurveyUrl, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> CreateAnalyticsEvaluationsAggregatesJobAsync(EvaluationAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<EvaluationAggregateQueryResponse> CreateAnalyticsEvaluationsAggregatesQueryAsync(EvaluationAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> CreateAnalyticsSurveysAggregatesJobAsync(SurveyAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<SurveyAggregateQueryResponse> CreateAnalyticsSurveysAggregatesQueryAsync(SurveyAggregationQuery body, CancellationToken cancellationToken = default);

    Task<QualityAuditQueryExecutionStatusResponse> CreateQualityConversationsAuditsQueryAsync(QMAuditQueryRequest body, CancellationToken cancellationToken = default);

    Task<EvaluationAggregateQueryResponse> CreateQualityEvaluationsAggregatesQueryMeAsync(EvaluationAggregationQueryMe body, CancellationToken cancellationToken = default);

    Task<EvaluationScoringSet> CreateQualityEvaluationsScoringAsync(EvaluationFormAndScoringSet body, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponse> CreateQualityFormsAsync(EvaluationForm body, CancellationToken cancellationToken = default);

    Task<SurveyForm> CreateQualityFormsSurveysAsync(SurveyForm body, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponse> CreateQualityPublishedformsAsync(PublishForm body, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponse> CreateQualityPublishedformsEvaluationsAsync(PublishForm body, CancellationToken cancellationToken = default);

    Task<SurveyForm> CreateQualityPublishedformsSurveysAsync(PublishForm body, CancellationToken cancellationToken = default);

    Task<SurveyScore> CreateQualitySurveysScoringAsync(SurveyFormAndScoringSet body, CancellationToken cancellationToken = default);

    Task<Calibration> UpdateQualityCalibrationAsync(string calibrationId, Calibration body, CancellationToken cancellationToken = default);

    Task<EvaluationResponse> UpdateQualityConversationEvaluationAsync(string conversationId, string evaluationId, Evaluation body, string expand = null, CancellationToken cancellationToken = default);

    Task<EvaluationFormResponse> UpdateQualityFormAsync(string formId, EvaluationForm body, CancellationToken cancellationToken = default);

    Task<AiScoringSettings> UpdateQualityFormsEvaluationAiscoringSettingsAsync(string formId, AiScoringSettings body, CancellationToken cancellationToken = default);

    Task<ScorableSurvey> UpdateQualitySurveysScorableAsync(string customerSurveyUrl, ScorableSurvey body, CancellationToken cancellationToken = default);
}