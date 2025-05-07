using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KeyPerformanceIndicator
/// </summary>

public partial class KeyPerformanceIndicator : IEquatable<KeyPerformanceIndicator>
{
    /// <summary>
    /// The optimization type of the Key Performance Indicator.
    /// </summary>
    /// <value>The optimization type of the Key Performance Indicator.</value>
    
    public enum OptimizationTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Maximization for "Maximization"
        /// </summary>
        [EnumMember(Value = "Maximization")]
        Maximization,

        /// <summary>
        /// Enum Minimization for "Minimization"
        /// </summary>
        [EnumMember(Value = "Minimization")]
        Minimization
    }
    /// <summary>
    /// The problem type of the Key Performance Indicator.
    /// </summary>
    /// <value>The problem type of the Key Performance Indicator.</value>
    
    public enum ProblemTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Classification for "Classification"
        /// </summary>
        [EnumMember(Value = "Classification")]
        Classification,

        /// <summary>
        /// Enum Regression for "Regression"
        /// </summary>
        [EnumMember(Value = "Regression")]
        Regression
    }
    /// <summary>
    /// The type of Key Performance Indicator.
    /// </summary>
    /// <value>The type of Key Performance Indicator.</value>
    
    public enum KpiTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Salesconversion for "SalesConversion"
        /// </summary>
        [EnumMember(Value = "SalesConversion")]
        Salesconversion,

        /// <summary>
        /// Enum Churn for "Churn"
        /// </summary>
        [EnumMember(Value = "Churn")]
        Churn,

        /// <summary>
        /// Enum Retention for "Retention"
        /// </summary>
        [EnumMember(Value = "Retention")]
        Retention,

        /// <summary>
        /// Enum Salesvalue for "SalesValue"
        /// </summary>
        [EnumMember(Value = "SalesValue")]
        Salesvalue,

        /// <summary>
        /// Enum Handletime for "HandleTime"
        /// </summary>
        [EnumMember(Value = "HandleTime")]
        Handletime,

        /// <summary>
        /// Enum Nextcontactavoidance for "NextContactAvoidance"
        /// </summary>
        [EnumMember(Value = "NextContactAvoidance")]
        Nextcontactavoidance
    }
    /// <summary>
    /// Source of values for Key Performance Indicator.
    /// </summary>
    /// <value>Source of values for Key Performance Indicator.</value>
    
    public enum SourceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Wrapupcode for "WrapUpCode"
        /// </summary>
        [EnumMember(Value = "WrapUpCode")]
        Wrapupcode,

        /// <summary>
        /// Enum Outcome for "Outcome"
        /// </summary>
        [EnumMember(Value = "Outcome")]
        Outcome,

        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None
    }
    /// <summary>
    /// The status of the Key Performance Indicator.
    /// </summary>
    /// <value>The status of the Key Performance Indicator.</value>
    
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
        /// Enum Enabled for "Enabled"
        /// </summary>
        [EnumMember(Value = "Enabled")]
        Enabled,

        /// <summary>
        /// Enum Disabled for "Disabled"
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    /// <summary>
    /// The group the Key Performance Indicator belongs to.
    /// </summary>
    /// <value>The group the Key Performance Indicator belongs to.</value>
    
    public enum KpiGroupEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom
    }
    /// <summary>
    /// The optimization type of the Key Performance Indicator.
    /// </summary>
    /// <value>The optimization type of the Key Performance Indicator.</value>
    [JsonPropertyName("optimizationType")]
    public OptimizationTypeEnum? OptimizationType { get; set; }
    /// <summary>
    /// The problem type of the Key Performance Indicator.
    /// </summary>
    /// <value>The problem type of the Key Performance Indicator.</value>
    [JsonPropertyName("problemType")]
    public ProblemTypeEnum? ProblemType { get; set; }
    /// <summary>
    /// The type of Key Performance Indicator.
    /// </summary>
    /// <value>The type of Key Performance Indicator.</value>
    [JsonPropertyName("kpiType")]
    public KpiTypeEnum? KpiType { get; set; }
    /// <summary>
    /// Source of values for Key Performance Indicator.
    /// </summary>
    /// <value>Source of values for Key Performance Indicator.</value>
    [JsonPropertyName("source")]
    public SourceEnum? Source { get; set; }
    /// <summary>
    /// The status of the Key Performance Indicator.
    /// </summary>
    /// <value>The status of the Key Performance Indicator.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The group the Key Performance Indicator belongs to.
    /// </summary>
    /// <value>The group the Key Performance Indicator belongs to.</value>
    [JsonPropertyName("kpiGroup")]
    public KpiGroupEnum? KpiGroup { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KeyPerformanceIndicator" /> class.
    /// </summary>
    public KeyPerformanceIndicator()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the Key Performance Indicator.
    /// </summary>
    /// <value>The name of the Key Performance Indicator.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }







    /// <summary>
    /// DateTime indicating when the Key Performance Indicator was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>DateTime indicating when the Key Performance Indicator was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// DateTime indicating when the Key Performance Indicator was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>DateTime indicating when the Key Performance Indicator was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The description of the Key Performance Indicator.
    /// </summary>
    /// <value>The description of the Key Performance Indicator.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }







    /// <summary>
    /// Defines what wrap up codes are mapped to Key Performance Indicator.
    /// </summary>
    /// <value>Defines what wrap up codes are mapped to Key Performance Indicator.</value>
    [JsonPropertyName("wrapUpCodeConfig")]
    public WrapUpCodeConfig WrapUpCodeConfig { get; set; }



    /// <summary>
    /// Defines what outcome ids are mapped to Key Performance Indicator.
    /// </summary>
    /// <value>Defines what outcome ids are mapped to Key Performance Indicator.</value>
    [JsonPropertyName("outcomeConfig")]
    public OutcomeConfig OutcomeConfig { get; set; }







    /// <summary>
    /// Queue IDs on which KPI specification is used.
    /// </summary>
    /// <value>Queue IDs on which KPI specification is used.</value>
    [JsonPropertyName("queues")]
    public List<string> Queues { get; set; }



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
        sb.Append("class KeyPerformanceIndicator {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  OptimizationType: ").Append(OptimizationType).Append("\n");
        sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  KpiType: ").Append(KpiType).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  WrapUpCodeConfig: ").Append(WrapUpCodeConfig).Append("\n");
        sb.Append("  OutcomeConfig: ").Append(OutcomeConfig).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  KpiGroup: ").Append(KpiGroup).Append("\n");
        sb.Append("  Queues: ").Append(Queues).Append("\n");
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
        return Equals(obj as KeyPerformanceIndicator);
    }

    /// <summary>
    /// Returns true if KeyPerformanceIndicator instances are equal
    /// </summary>
    /// <param name="other">Instance of KeyPerformanceIndicator to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KeyPerformanceIndicator other)
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
                OptimizationType == other.OptimizationType ||
                OptimizationType != null &&
                OptimizationType.Equals(other.OptimizationType)
            ) &&
            (
                ProblemType == other.ProblemType ||
                ProblemType != null &&
                ProblemType.Equals(other.ProblemType)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                KpiType == other.KpiType ||
                KpiType != null &&
                KpiType.Equals(other.KpiType)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                WrapUpCodeConfig == other.WrapUpCodeConfig ||
                WrapUpCodeConfig != null &&
                WrapUpCodeConfig.Equals(other.WrapUpCodeConfig)
            ) &&
            (
                OutcomeConfig == other.OutcomeConfig ||
                OutcomeConfig != null &&
                OutcomeConfig.Equals(other.OutcomeConfig)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                KpiGroup == other.KpiGroup ||
                KpiGroup != null &&
                KpiGroup.Equals(other.KpiGroup)
            ) &&
            (
                Queues == other.Queues ||
                Queues != null &&
                Queues.SequenceEqual(other.Queues)
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

            if (OptimizationType != null)
            {
                hash = hash * 59 + OptimizationType.GetHashCode();
            }

            if (ProblemType != null)
            {
                hash = hash * 59 + ProblemType.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (KpiType != null)
            {
                hash = hash * 59 + KpiType.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (WrapUpCodeConfig != null)
            {
                hash = hash * 59 + WrapUpCodeConfig.GetHashCode();
            }

            if (OutcomeConfig != null)
            {
                hash = hash * 59 + OutcomeConfig.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (KpiGroup != null)
            {
                hash = hash * 59 + KpiGroup.GetHashCode();
            }

            if (Queues != null)
            {
                hash = hash * 59 + Queues.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
