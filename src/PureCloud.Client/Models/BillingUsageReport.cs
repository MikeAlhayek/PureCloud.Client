using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BillingUsageReport
/// </summary>

public partial class BillingUsageReport : IEquatable<BillingUsageReport>
{
    /// <summary>
    /// Generation status of report
    /// </summary>
    /// <value>Generation status of report</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete
    }
    /// <summary>
    /// Generation status of report
    /// </summary>
    /// <value>Generation status of report</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BillingUsageReport" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BillingUsageReport() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BillingUsageReport" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="StartDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="EndDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Status">Generation status of report.</param>
    /// <param name="Usages">The usages for the given period. (required).</param>
    public BillingUsageReport(string Name = null, DateTime? StartDate = null, DateTime? EndDate = null, StatusEnum? Status = null, List<BillingUsage> Usages = null)
    {
        this.Name = Name;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.Status = Status;
        this.Usages = Usages;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }





    /// <summary>
    /// The usages for the given period.
    /// </summary>
    /// <value>The usages for the given period.</value>
    [JsonPropertyName("usages")]
    public List<BillingUsage> Usages { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BillingUsageReport {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Usages: ").Append(Usages).Append("\n");
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
        return Equals(obj as BillingUsageReport);
    }

    /// <summary>
    /// Returns true if BillingUsageReport instances are equal
    /// </summary>
    /// <param name="other">Instance of BillingUsageReport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BillingUsageReport other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Usages == other.Usages ||
                Usages != null &&
                Usages.SequenceEqual(other.Usages)
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

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Usages != null)
            {
                hash = hash * 59 + Usages.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
