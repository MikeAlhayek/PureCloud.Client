using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IGamificationApi
{
    Task<bool> DeleteEmployeeperformanceExternalmetricsDefinitionAsync(string metricId, CancellationToken cancellationToken = default);

    Task<bool> DeleteGamificationContestAsync(string contestId, CancellationToken cancellationToken = default);

    Task<ExternalMetricDefinition> GetEmployeeperformanceExternalmetricsDefinitionAsync(string metricId, CancellationToken cancellationToken = default);

    Task<ExternalMetricDefinitionListing> GetEmployeeperformanceExternalmetricsDefinitionsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<ContestsResponse> GetGamificationContestAsync(string contestId, CancellationToken cancellationToken = default);

    Task<ContestScoresAgentsPagedList> GetGamificationContestAgentsScoresAsync(string contestId, int? pageNumber = null, int? pageSize = null, string workday = null, string returnsView = null, CancellationToken cancellationToken = default);

    Task<ContestScoresAgentsPagedList> GetGamificationContestAgentsScoresMeAsync(string contestId, int? pageNumber = null, int? pageSize = null, string workday = null, string returnsView = null, CancellationToken cancellationToken = default);

    Task<ContestScoresGroupTrendList> GetGamificationContestAgentsScoresTrendsAsync(string contestId, CancellationToken cancellationToken = default);

    Task<ContestScoresAgentTrendList> GetGamificationContestAgentsScoresTrendsMeAsync(string contestId, CancellationToken cancellationToken = default);

    Task<PrizeImages> GetGamificationContestPrizeimageAsync(string contestId, string prizeImageId, CancellationToken cancellationToken = default);

    Task<GetContestsEssentialsListing> GetGamificationContestsAsync(int? pageNumber = null, int? pageSize = null, string dateStart = null, string dateEnd = null, IList<string> status = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<GetContestsEssentialsListing> GetGamificationContestsMeAsync(int? pageNumber = null, int? pageSize = null, string dateStart = null, string dateEnd = null, IList<string> status = null, string sortBy = null, string sortOrder = null, string view = null, CancellationToken cancellationToken = default);

    Task<InsightsSummary> GetGamificationInsightsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string primaryPeriodStartWorkday, int? pageSize = null, int? pageNumber = null, string sortKey = null, string sortMetricId = null, string sortOrder = null, string userIds = null, CancellationToken cancellationToken = default);

    Task<InsightsDetails> GetGamificationInsightsDetailsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string primaryPeriodStartWorkday, CancellationToken cancellationToken = default);

    Task<InsightsTrend> GetGamificationInsightsGroupsTrendsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string comparativePeriodEndWorkday, string primaryPeriodStartWorkday, string primaryPeriodEndWorkday, CancellationToken cancellationToken = default);

    Task<InsightsTrend> GetGamificationInsightsGroupsTrendsAllAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string comparativePeriodEndWorkday, string primaryPeriodStartWorkday, string primaryPeriodEndWorkday, CancellationToken cancellationToken = default);

    Task<InsightsAgents> GetGamificationInsightsMembersAsync(string filterType, string filterId, string granularity, string startWorkday, CancellationToken cancellationToken = default);

    Task<InsightsRankings> GetGamificationInsightsRankingsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string primaryPeriodStartWorkday, string sortKey, string sortMetricId = null, int? sectionSize = null, string userIds = null, CancellationToken cancellationToken = default);

    Task<UserInsightsTrend> GetGamificationInsightsTrendsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string comparativePeriodEndWorkday, string primaryPeriodStartWorkday, string primaryPeriodEndWorkday, CancellationToken cancellationToken = default);

    Task<InsightsDetails> GetGamificationInsightsUserDetailsAsync(string userId, string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string primaryPeriodStartWorkday, CancellationToken cancellationToken = default);

    Task<UserInsightsTrend> GetGamificationInsightsUserTrendsAsync(string userId, string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string comparativePeriodEndWorkday, string primaryPeriodStartWorkday, string primaryPeriodEndWorkday, CancellationToken cancellationToken = default);

    Task<Leaderboard> GetGamificationLeaderboardAsync(string startWorkday, string endWorkday, string metricId = null, CancellationToken cancellationToken = default);

    Task<Leaderboard> GetGamificationLeaderboardAllAsync(string filterType, string filterId, string startWorkday, string endWorkday, string metricId = null, CancellationToken cancellationToken = default);

    Task<OverallBestPoints> GetGamificationLeaderboardAllBestpointsAsync(string filterType, string filterId, CancellationToken cancellationToken = default);

    Task<OverallBestPoints> GetGamificationLeaderboardBestpointsAsync(CancellationToken cancellationToken = default);

    Task<MetricDefinition> GetGamificationMetricdefinitionAsync(string metricDefinitionId, CancellationToken cancellationToken = default);

    Task<GetMetricDefinitionsResponse> GetGamificationMetricdefinitionsAsync(CancellationToken cancellationToken = default);

    Task<PerformanceProfile> GetGamificationProfileAsync(string profileId, CancellationToken cancellationToken = default);

    Task<MemberListing> GetGamificationProfileMembersAsync(string profileId, CancellationToken cancellationToken = default);

    Task<Metric> GetGamificationProfileMetricAsync(string profileId, string metricId, string workday = null, CancellationToken cancellationToken = default);

    Task<GetMetricResponse> GetGamificationProfileMetricsAsync(string profileId, IList<string> expand = null, string workday = null, string metricIds = null, CancellationToken cancellationToken = default);

    Task<GetMetricsResponse> GetGamificationProfileMetricsObjectiveDetailsAsync(string profileId, string workday = null, CancellationToken cancellationToken = default);

    Task<GetProfilesResponse> GetGamificationProfilesAsync(CancellationToken cancellationToken = default);

    Task<PerformanceProfile> GetGamificationProfilesUserAsync(string userId, string workday = null, CancellationToken cancellationToken = default);

    Task<PerformanceProfile> GetGamificationProfilesUsersMeAsync(string workday = null, CancellationToken cancellationToken = default);

    Task<WorkdayMetricListing> GetGamificationScorecardsAsync(string workday, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<AttendanceStatusListing> GetGamificationScorecardsAttendanceAsync(string startWorkday, string endWorkday, CancellationToken cancellationToken = default);

    Task<UserBestPoints> GetGamificationScorecardsBestpointsAsync(CancellationToken cancellationToken = default);

    Task<SingleWorkdayAveragePoints> GetGamificationScorecardsPointsAverageAsync(string workday, CancellationToken cancellationToken = default);

    Task<WorkdayPointsTrend> GetGamificationScorecardsPointsTrendsAsync(string startWorkday, string endWorkday, string dayOfWeek = null, CancellationToken cancellationToken = default);

    Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUserValuesTrendsAsync(string profileId, string metricId, string userId, string startWorkday, string endWorkday, string referenceWorkday = null, string timeZone = null, CancellationToken cancellationToken = default);

    Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUsersValuesTrendsAsync(string profileId, string metricId, string filterType, string startWorkday, string endWorkday, string filterId = null, string referenceWorkday = null, string timeZone = null, CancellationToken cancellationToken = default);

    Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricValuesTrendsAsync(string profileId, string metricId, string startWorkday, string endWorkday, string filterType = null, string referenceWorkday = null, string timeZone = null, CancellationToken cancellationToken = default);

    Task<WorkdayMetricListing> GetGamificationScorecardsUserAsync(string userId, string workday, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<AttendanceStatusListing> GetGamificationScorecardsUserAttendanceAsync(string userId, string startWorkday, string endWorkday, CancellationToken cancellationToken = default);

    Task<UserBestPoints> GetGamificationScorecardsUserBestpointsAsync(string userId, CancellationToken cancellationToken = default);

    Task<AllTimePoints> GetGamificationScorecardsUserPointsAlltimeAsync(string userId, string endWorkday, CancellationToken cancellationToken = default);

    Task<WorkdayPointsTrend> GetGamificationScorecardsUserPointsTrendsAsync(string userId, string startWorkday, string endWorkday, string dayOfWeek = null, CancellationToken cancellationToken = default);

    Task<WorkdayValuesTrend> GetGamificationScorecardsUserValuesTrendsAsync(string userId, string startWorkday, string endWorkday, string timeZone = null, CancellationToken cancellationToken = default);

    Task<SingleWorkdayAveragePoints> GetGamificationScorecardsUsersPointsAverageAsync(string filterType, string filterId, string workday, CancellationToken cancellationToken = default);

    Task<SingleWorkdayAverageValues> GetGamificationScorecardsUsersValuesAverageAsync(string filterType, string filterId, string workday, string timeZone = null, CancellationToken cancellationToken = default);

    Task<WorkdayValuesTrend> GetGamificationScorecardsUsersValuesTrendsAsync(string filterType, string filterId, string startWorkday, string endWorkday, string timeZone = null, CancellationToken cancellationToken = default);

    Task<SingleWorkdayAverageValues> GetGamificationScorecardsValuesAverageAsync(string workday, string timeZone = null, CancellationToken cancellationToken = default);

    Task<WorkdayValuesTrend> GetGamificationScorecardsValuesTrendsAsync(string startWorkday, string endWorkday, string filterType = null, string referenceWorkday = null, string timeZone = null, CancellationToken cancellationToken = default);

    Task<GamificationStatus> GetGamificationStatusAsync(CancellationToken cancellationToken = default);

    Task<ObjectiveTemplate> GetGamificationTemplateAsync(string templateId, CancellationToken cancellationToken = default);

    Task<GetTemplatesResponse> GetGamificationTemplatesAsync(CancellationToken cancellationToken = default);

    Task<ExternalMetricDefinition> UpdateEmployeeperformanceExternalmetricsDefinitionAsync(string metricId, ExternalMetricDefinitionUpdateRequest body, CancellationToken cancellationToken = default);

    Task<ContestsResponse> UpdateGamificationContestAsync(string contestId, ContestsFinalizeRequest body, CancellationToken cancellationToken = default);

    Task<ExternalMetricDataWriteResponse> CreateEmployeeperformanceExternalmetricsDataAsync(ExternalMetricDataWriteRequest body, CancellationToken cancellationToken = default);

    Task<ExternalMetricDefinition> CreateEmployeeperformanceExternalmetricsDefinitionAsync(ExternalMetricDefinitionCreateRequest body, CancellationToken cancellationToken = default);

    Task<ContestsResponse> CreateGamificationContestAsync(ContestsCreateRequest body, CancellationToken cancellationToken = default);

    Task<UploadUrlResponse> CreateGamificationContestPrizeImageUploadUrlAsync(GamificationContestPrizeImageUploadUrlRequest body, CancellationToken cancellationToken = default);

    Task<PerformanceProfile> ActivateGamificationProfileAsync(string profileId, CancellationToken cancellationToken = default);

    Task<PerformanceProfile> DeactivateGamificationProfileAsync(string profileId, CancellationToken cancellationToken = default);

    Task<Assignment> CreateGamificationProfileMembersAsync(string profileId, AssignUsers body, CancellationToken cancellationToken = default);

    Task<AssignmentValidation> ValidateGamificationProfileMembersAsync(string profileId, ValidateAssignUsers body, CancellationToken cancellationToken = default);

    Task<Metric> CreateGamificationProfileMetricLinkAsync(string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body, CancellationToken cancellationToken = default);

    Task<Metric> CreateGamificationProfileMetricAsync(string profileId, CreateMetric body, CancellationToken cancellationToken = default);

    Task<PerformanceProfile> CreateGamificationProfileAsync(CreatePerformanceProfile body, bool? copyMetrics = null, CancellationToken cancellationToken = default);

    Task<UserProfilesInDateRange> QueryGamificationProfilesForUserAsync(string userId, UserProfilesInDateRangeRequest body, CancellationToken cancellationToken = default);

    Task<UserProfilesInDateRange> QueryGamificationProfilesUsersMeAsync(UserProfilesInDateRangeRequest body, CancellationToken cancellationToken = default);

    Task<ContestsResponse> UpdateGamificationContestAsync(string contestId, ContestsCreateRequest body, CancellationToken cancellationToken = default);

    Task<PerformanceProfile> UpdateGamificationProfileAsync(string profileId, PerformanceProfile body, CancellationToken cancellationToken = default);

    Task<Metric> UpdateGamificationProfileMetricAsync(string profileId, string metricId, CreateMetric body, CancellationToken cancellationToken = default);

    Task<GamificationStatus> UpdateGamificationStatusAsync(GamificationStatus status, CancellationToken cancellationToken = default);
}
