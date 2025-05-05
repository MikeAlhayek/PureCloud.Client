using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A journey view
/// </summary>

public partial class JourneyView : IEquatable<JourneyView>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyView" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">A description of the journey view.</param>
    /// <param name="Interval">An absolute timeframe for the journey view, expressed as an ISO 8601 interval. Only one of interval or duration must be specified. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    /// <param name="Duration">A relative timeframe for the journey view, expressed as an ISO 8601 duration. Only one of interval or duration must be specified. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
    /// <param name="Elements">The elements within the journey view (required).</param>
    /// <param name="Charts">A list of charts to measure within context of the elements of the the journey view.</param>
    public JourneyView(string Name = null, string Description = null, string Interval = null, string Duration = null, List<JourneyViewElement> Elements = null, List<JourneyViewChart> Charts = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Interval = Interval;
        this.Duration = Duration;
        this.Elements = Elements;
        this.Charts = Charts;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A description of the journey view
    /// </summary>
    /// <value>A description of the journey view</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The version of the journey view
    /// </summary>
    /// <value>The version of the journey view</value>
    [JsonPropertyName("version")]
    public int? Version { get; private set; }



    /// <summary>
    /// User that has created the view.
    /// </summary>
    /// <value>User that has created the view.</value>
    [JsonPropertyName("createdBy")]
    public JourneyViewUser CreatedBy { get; private set; }



    /// <summary>
    /// User that has modified the view.
    /// </summary>
    /// <value>User that has modified the view.</value>
    [JsonPropertyName("modifiedBy")]
    public JourneyViewUser ModifiedBy { get; private set; }



    /// <summary>
    /// An absolute timeframe for the journey view, expressed as an ISO 8601 interval. Only one of interval or duration must be specified. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>An absolute timeframe for the journey view, expressed as an ISO 8601 interval. Only one of interval or duration must be specified. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// A relative timeframe for the journey view, expressed as an ISO 8601 duration. Only one of interval or duration must be specified. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>A relative timeframe for the journey view, expressed as an ISO 8601 duration. Only one of interval or duration must be specified. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }



    /// <summary>
    /// The elements within the journey view
    /// </summary>
    /// <value>The elements within the journey view</value>
    [JsonPropertyName("elements")]
    public List<JourneyViewElement> Elements { get; set; }



    /// <summary>
    /// A list of charts to measure within context of the elements of the the journey view
    /// </summary>
    /// <value>A list of charts to measure within context of the elements of the the journey view</value>
    [JsonPropertyName("charts")]
    public List<JourneyViewChart> Charts { get; set; }



    /// <summary>
    /// The date when the journey view was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the journey view was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The date when this version of the journey view was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when this version of the journey view was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyView {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Duration: ").Append(Duration).Append("\n");
        sb.Append("  Elements: ").Append(Elements).Append("\n");
        sb.Append("  Charts: ").Append(Charts).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as JourneyView);
    }

    /// <summary>
    /// Returns true if JourneyView instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyView other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Duration == other.Duration ||
                Duration != null &&
                Duration.Equals(other.Duration)
            ) &&
            (
                Elements == other.Elements ||
                Elements != null &&
                Elements.SequenceEqual(other.Elements)
            ) &&
            (
                Charts == other.Charts ||
                Charts != null &&
                Charts.SequenceEqual(other.Charts)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Duration != null)
            {
                hash = hash * 59 + Duration.GetHashCode();
            }

            if (Elements != null)
            {
                hash = hash * 59 + Elements.GetHashCode();
            }

            if (Charts != null)
            {
                hash = hash * 59 + Charts.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
