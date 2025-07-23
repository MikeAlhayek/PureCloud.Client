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
}