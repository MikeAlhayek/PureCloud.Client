using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CurrentUserScheduleRequestBody
/// </summary>

public partial class CurrentUserScheduleRequestBody : IEquatable<CurrentUserScheduleRequestBody>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentUserScheduleRequestBody" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CurrentUserScheduleRequestBody() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentUserScheduleRequestBody" /> class.
    /// </summary>
    /// <param name="StartDate">Beginning of the range of schedules to fetch, in ISO-8601 format (required).</param>
    /// <param name="EndDate">End of the range of schedules to fetch, in ISO-8601 format (required).</param>
    /// <param name="LoadFullWeeks">Whether to load the full week&#39;s schedule (for the current user) of any week overlapping the start/end date query parameters, defaults to false.</param>
    public CurrentUserScheduleRequestBody(DateTime? StartDate = null, DateTime? EndDate = null, bool? LoadFullWeeks = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.LoadFullWeeks = LoadFullWeeks;

    }



    /// <summary>
    /// Beginning of the range of schedules to fetch, in ISO-8601 format
    /// </summary>
    /// <value>Beginning of the range of schedules to fetch, in ISO-8601 format</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// End of the range of schedules to fetch, in ISO-8601 format
    /// </summary>
    /// <value>End of the range of schedules to fetch, in ISO-8601 format</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Whether to load the full week&#39;s schedule (for the current user) of any week overlapping the start/end date query parameters, defaults to false
    /// </summary>
    /// <value>Whether to load the full week&#39;s schedule (for the current user) of any week overlapping the start/end date query parameters, defaults to false</value>
    [JsonPropertyName("loadFullWeeks")]
    public bool? LoadFullWeeks { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CurrentUserScheduleRequestBody {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  LoadFullWeeks: ").Append(LoadFullWeeks).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as CurrentUserScheduleRequestBody);
    }

    /// <summary>
    /// Returns true if CurrentUserScheduleRequestBody instances are equal
    /// </summary>
    /// <param name="other">Instance of CurrentUserScheduleRequestBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CurrentUserScheduleRequestBody other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                LoadFullWeeks == other.LoadFullWeeks ||
                LoadFullWeeks != null &&
                LoadFullWeeks.Equals(other.LoadFullWeeks)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (LoadFullWeeks != null)
            {
                hash = hash * 59 + LoadFullWeeks.GetHashCode();
            }

            return hash;
        }
    }
}
