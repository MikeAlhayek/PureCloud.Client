using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestCompleteData
/// </summary>
[DataContract]
public partial class ContestCompleteData : IEquatable<ContestCompleteData>
{
    /// <summary>
    /// Anonymization of the contest
    /// </summary>
    /// <value>Anonymization of the contest</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AnonymizationEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Noanonymization for "NoAnonymization"
        /// </summary>
        [EnumMember(Value = "NoAnonymization")]
        Noanonymization,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum Allexcepttop for "AllExceptTop"
        /// </summary>
        [EnumMember(Value = "AllExceptTop")]
        Allexcepttop
    }
    /// <summary>
    /// Anonymization of the contest
    /// </summary>
    /// <value>Anonymization of the contest</value>
    [DataMember(Name = "anonymization", EmitDefaultValue = false)]
    public AnonymizationEnum? Anonymization { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestCompleteData" /> class.
    /// </summary>
    /// <param name="DateEnd">End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="Anonymization">Anonymization of the contest.</param>
    /// <param name="Metrics">Metrics of the contest.</param>
    /// <param name="Prizes">Prizes of the contest.</param>
    /// <param name="Winners">Winners of the contest.</param>
    public ContestCompleteData(string DateEnd = null, AnonymizationEnum? Anonymization = null, List<ContestDataMetrics> Metrics = null, List<ContestDataPrizes> Prizes = null, List<ContestDataWinners> Winners = null)
    {
        this.DateEnd = DateEnd;
        this.Anonymization = Anonymization;
        this.Metrics = Metrics;
        this.Prizes = Prizes;
        this.Winners = Winners;

    }



    /// <summary>
    /// End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateEnd", EmitDefaultValue = false)]
    public string DateEnd { get; set; }





    /// <summary>
    /// Metrics of the contest
    /// </summary>
    /// <value>Metrics of the contest</value>
    [DataMember(Name = "metrics", EmitDefaultValue = false)]
    public List<ContestDataMetrics> Metrics { get; set; }



    /// <summary>
    /// Prizes of the contest
    /// </summary>
    /// <value>Prizes of the contest</value>
    [DataMember(Name = "prizes", EmitDefaultValue = false)]
    public List<ContestDataPrizes> Prizes { get; set; }



    /// <summary>
    /// Winners of the contest
    /// </summary>
    /// <value>Winners of the contest</value>
    [DataMember(Name = "winners", EmitDefaultValue = false)]
    public List<ContestDataWinners> Winners { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestCompleteData {\n");

        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  Anonymization: ").Append(Anonymization).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  Prizes: ").Append(Prizes).Append("\n");
        sb.Append("  Winners: ").Append(Winners).Append("\n");
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
        return Equals(obj as ContestCompleteData);
    }

    /// <summary>
    /// Returns true if ContestCompleteData instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestCompleteData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestCompleteData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                Anonymization == other.Anonymization ||
                Anonymization != null &&
                Anonymization.Equals(other.Anonymization)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                Prizes == other.Prizes ||
                Prizes != null &&
                Prizes.SequenceEqual(other.Prizes)
            ) &&
            (
                Winners == other.Winners ||
                Winners != null &&
                Winners.SequenceEqual(other.Winners)
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
            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (Anonymization != null)
            {
                hash = hash * 59 + Anonymization.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (Prizes != null)
            {
                hash = hash * 59 + Prizes.GetHashCode();
            }

            if (Winners != null)
            {
                hash = hash * 59 + Winners.GetHashCode();
            }

            return hash;
        }
    }
}
