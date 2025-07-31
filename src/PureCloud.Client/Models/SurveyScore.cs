namespace PureCloud.Client.Models;

public sealed class SurveyScore
{
    public float? TotalScore { get; set; }
    public float? TotalCriticalScore { get; set; }
    public float? TotalNonCriticalScore { get; set; }
    public IEnumerable<SurveyQuestionScore> QuestionGroupScores { get; set; }
    public IEnumerable<SurveyQuestionGroupScore> QuestionScores { get; set; }
}