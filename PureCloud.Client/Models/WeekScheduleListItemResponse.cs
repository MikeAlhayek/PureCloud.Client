using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// WeekScheduleListItemResponse
/// </summary>
[DataContract]
public partial class WeekScheduleListItemResponse : IEquatable<WeekScheduleListItemResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WeekScheduleListItemResponse" /> class.
    /// </summary>
    /// <param name="WeekDate">First day of this week schedule in yyyy-MM-dd format.</param>
    /// <param name="Description">Description of the week schedule.</param>
    /// <param name="Published">Whether the week schedule is published.</param>
    /// <param name="GenerationResults">Summary of the results from the schedule run.</param>
    /// <param name="ShortTermForecast">Short term forecast associated with this schedule.</param>
    /// <param name="Metadata">Version metadata for this work plan.</param>
    public WeekScheduleListItemResponse(string WeekDate = null, string Description = null, bool? Published = null, WeekScheduleGenerationResult GenerationResults = null, ShortTermForecastReference ShortTermForecast = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.WeekDate = WeekDate;
        this.Description = Description;
        this.Published = Published;
        this.GenerationResults = GenerationResults;
        this.ShortTermForecast = ShortTermForecast;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }



    /// <summary>
    /// First day of this week schedule in yyyy-MM-dd format
    /// </summary>
    /// <value>First day of this week schedule in yyyy-MM-dd format</value>
    [DataMember(Name = "weekDate", EmitDefaultValue = false)]
    public string WeekDate { get; set; }



    /// <summary>
    /// Description of the week schedule
    /// </summary>
    /// <value>Description of the week schedule</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Whether the week schedule is published
    /// </summary>
    /// <value>Whether the week schedule is published</value>
    [DataMember(Name = "published", EmitDefaultValue = false)]
    public bool? Published { get; set; }



    /// <summary>
    /// Summary of the results from the schedule run
    /// </summary>
    /// <value>Summary of the results from the schedule run</value>
    [DataMember(Name = "generationResults", EmitDefaultValue = false)]
    public WeekScheduleGenerationResult GenerationResults { get; set; }



    /// <summary>
    /// Short term forecast associated with this schedule
    /// </summary>
    /// <value>Short term forecast associated with this schedule</value>
    [DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
    public ShortTermForecastReference ShortTermForecast { get; set; }



    /// <summary>
    /// Version metadata for this work plan
    /// </summary>
    /// <value>Version metadata for this work plan</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WeekScheduleListItemResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as WeekScheduleListItemResponse);
    }

    /// <summary>
    /// Returns true if WeekScheduleListItemResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WeekScheduleListItemResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WeekScheduleListItemResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                GenerationResults == other.GenerationResults ||
                GenerationResults != null &&
                GenerationResults.Equals(other.GenerationResults)
            ) &&
            (
                ShortTermForecast == other.ShortTermForecast ||
                ShortTermForecast != null &&
                ShortTermForecast.Equals(other.ShortTermForecast)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (GenerationResults != null)
            {
                hash = hash * 59 + GenerationResults.GetHashCode();
            }

            if (ShortTermForecast != null)
            {
                hash = hash * 59 + ShortTermForecast.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
