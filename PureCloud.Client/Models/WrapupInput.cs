using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WrapupInput
/// </summary>

public partial class WrapupInput : IEquatable<WrapupInput>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WrapupInput" /> class.
    /// </summary>
    /// <param name="Code">The user configured wrap up code id..</param>
    /// <param name="Name">The user configured wrap up code name..</param>
    /// <param name="Notes">Text entered by the agent to describe the call or disposition..</param>
    /// <param name="Tags">List of tags selected by the agent to describe the call or disposition..</param>
    /// <param name="DurationSeconds">The length of time in seconds that the agent spent doing after call work..</param>
    /// <param name="EndTime">The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Provisional">Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later..</param>
    /// <param name="DisableEndTimeUpdates">Prevent updates to wrapup end time when set to true..</param>
    public WrapupInput(string Code = null, string Name = null, string Notes = null, List<string> Tags = null, int? DurationSeconds = null, DateTime? EndTime = null, bool? Provisional = null, bool? DisableEndTimeUpdates = null)
    {
        this.Code = Code;
        this.Name = Name;
        this.Notes = Notes;
        this.Tags = Tags;
        this.DurationSeconds = DurationSeconds;
        this.EndTime = EndTime;
        this.Provisional = Provisional;
        this.DisableEndTimeUpdates = DisableEndTimeUpdates;

    }



    /// <summary>
    /// The user configured wrap up code id.
    /// </summary>
    /// <value>The user configured wrap up code id.</value>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// The user configured wrap up code name.
    /// </summary>
    /// <value>The user configured wrap up code name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Text entered by the agent to describe the call or disposition.
    /// </summary>
    /// <value>Text entered by the agent to describe the call or disposition.</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// List of tags selected by the agent to describe the call or disposition.
    /// </summary>
    /// <value>List of tags selected by the agent to describe the call or disposition.</value>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }



    /// <summary>
    /// The length of time in seconds that the agent spent doing after call work.
    /// </summary>
    /// <value>The length of time in seconds that the agent spent doing after call work.</value>
    [JsonPropertyName("durationSeconds")]
    public int? DurationSeconds { get; set; }



    /// <summary>
    /// The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later.
    /// </summary>
    /// <value>Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later.</value>
    [JsonPropertyName("provisional")]
    public bool? Provisional { get; set; }



    /// <summary>
    /// Prevent updates to wrapup end time when set to true.
    /// </summary>
    /// <value>Prevent updates to wrapup end time when set to true.</value>
    [JsonPropertyName("disableEndTimeUpdates")]
    public bool? DisableEndTimeUpdates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WrapupInput {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  Provisional: ").Append(Provisional).Append("\n");
        sb.Append("  DisableEndTimeUpdates: ").Append(DisableEndTimeUpdates).Append("\n");
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
        return Equals(obj as WrapupInput);
    }

    /// <summary>
    /// Returns true if WrapupInput instances are equal
    /// </summary>
    /// <param name="other">Instance of WrapupInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WrapupInput other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                DurationSeconds == other.DurationSeconds ||
                DurationSeconds != null &&
                DurationSeconds.Equals(other.DurationSeconds)
            ) &&
            (
                EndTime == other.EndTime ||
                EndTime != null &&
                EndTime.Equals(other.EndTime)
            ) &&
            (
                Provisional == other.Provisional ||
                Provisional != null &&
                Provisional.Equals(other.Provisional)
            ) &&
            (
                DisableEndTimeUpdates == other.DisableEndTimeUpdates ||
                DisableEndTimeUpdates != null &&
                DisableEndTimeUpdates.Equals(other.DisableEndTimeUpdates)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (DurationSeconds != null)
            {
                hash = hash * 59 + DurationSeconds.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            if (Provisional != null)
            {
                hash = hash * 59 + Provisional.GetHashCode();
            }

            if (DisableEndTimeUpdates != null)
            {
                hash = hash * 59 + DisableEndTimeUpdates.GetHashCode();
            }

            return hash;
        }
    }
}
