using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuthorizationSettings
/// </summary>
[DataContract]
public partial class AuthorizationSettings : IEquatable<AuthorizationSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthorizationSettings" /> class.
    /// </summary>
    /// <param name="AnalysisEnabled">Boolean showing if organization is opted in or not to unused role/perm analysis.</param>
    /// <param name="AnalysisDays">Integer number of days to analyze user usage.</param>
    public AuthorizationSettings(bool? AnalysisEnabled = null, int? AnalysisDays = null)
    {
        this.AnalysisEnabled = AnalysisEnabled;
        this.AnalysisDays = AnalysisDays;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Boolean showing if organization is opted in or not to unused role/perm analysis
    /// </summary>
    /// <value>Boolean showing if organization is opted in or not to unused role/perm analysis</value>
    [DataMember(Name = "analysisEnabled", EmitDefaultValue = false)]
    public bool? AnalysisEnabled { get; set; }



    /// <summary>
    /// Integer number of days to analyze user usage
    /// </summary>
    /// <value>Integer number of days to analyze user usage</value>
    [DataMember(Name = "analysisDays", EmitDefaultValue = false)]
    public int? AnalysisDays { get; set; }



    /// <summary>
    /// The date and time of the most recent unused role calculation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time of the most recent unused role calculation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateLastCalculated", EmitDefaultValue = false)]
    public DateTime? DateLastCalculated { get; private set; }



    /// <summary>
    /// The date of the most recent org activity used for analysis. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date of the most recent org activity used for analysis. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateLastActive", EmitDefaultValue = false)]
    public string DateLastActive { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuthorizationSettings {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  AnalysisEnabled: ").Append(AnalysisEnabled).Append("\n");
        sb.Append("  AnalysisDays: ").Append(AnalysisDays).Append("\n");
        sb.Append("  DateLastCalculated: ").Append(DateLastCalculated).Append("\n");
        sb.Append("  DateLastActive: ").Append(DateLastActive).Append("\n");
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
        return Equals(obj as AuthorizationSettings);
    }

    /// <summary>
    /// Returns true if AuthorizationSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AuthorizationSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthorizationSettings other)
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
                AnalysisEnabled == other.AnalysisEnabled ||
                AnalysisEnabled != null &&
                AnalysisEnabled.Equals(other.AnalysisEnabled)
            ) &&
            (
                AnalysisDays == other.AnalysisDays ||
                AnalysisDays != null &&
                AnalysisDays.Equals(other.AnalysisDays)
            ) &&
            (
                DateLastCalculated == other.DateLastCalculated ||
                DateLastCalculated != null &&
                DateLastCalculated.Equals(other.DateLastCalculated)
            ) &&
            (
                DateLastActive == other.DateLastActive ||
                DateLastActive != null &&
                DateLastActive.Equals(other.DateLastActive)
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

            if (AnalysisEnabled != null)
            {
                hash = hash * 59 + AnalysisEnabled.GetHashCode();
            }

            if (AnalysisDays != null)
            {
                hash = hash * 59 + AnalysisDays.GetHashCode();
            }

            if (DateLastCalculated != null)
            {
                hash = hash * 59 + DateLastCalculated.GetHashCode();
            }

            if (DateLastActive != null)
            {
                hash = hash * 59 + DateLastActive.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
