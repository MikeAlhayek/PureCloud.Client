using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SplittingInformation
/// </summary>

public partial class SplittingInformation : IEquatable<SplittingInformation>
{
    /// <summary>
    /// The splitting criteria type
    /// </summary>
    /// <value>The splitting criteria type</value>
    
    public enum CriteriaEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Percentage for "Percentage"
        /// </summary>
        [EnumMember(Value = "Percentage")]
        Percentage,

        /// <summary>
        /// Enum Quantity for "Quantity"
        /// </summary>
        [EnumMember(Value = "Quantity")]
        Quantity,

        /// <summary>
        /// Enum Column for "Column"
        /// </summary>
        [EnumMember(Value = "Column")]
        Column,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom
    }
    /// <summary>
    /// The splitting criteria type
    /// </summary>
    /// <value>The splitting criteria type</value>
    [JsonPropertyName("criteria")]
    public CriteriaEnum? Criteria { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SplittingInformation" /> class.
    /// </summary>
    /// <param name="Criteria">The splitting criteria type.</param>
    /// <param name="CriteriaValue">The criteria value for the specified criteria type.</param>
    /// <param name="CreateRemainderContactList">Whether to create remainder contact list.</param>
    /// <param name="UseWaterfallRule">Whether to use waterfall rule.</param>
    public SplittingInformation(CriteriaEnum? Criteria = null, string CriteriaValue = null, bool? CreateRemainderContactList = null, bool? UseWaterfallRule = null)
    {
        this.Criteria = Criteria;
        this.CriteriaValue = CriteriaValue;
        this.CreateRemainderContactList = CreateRemainderContactList;
        this.UseWaterfallRule = UseWaterfallRule;

    }





    /// <summary>
    /// The criteria value for the specified criteria type
    /// </summary>
    /// <value>The criteria value for the specified criteria type</value>
    [JsonPropertyName("criteriaValue")]
    public string CriteriaValue { get; set; }



    /// <summary>
    /// Whether to create remainder contact list
    /// </summary>
    /// <value>Whether to create remainder contact list</value>
    [JsonPropertyName("createRemainderContactList")]
    public bool? CreateRemainderContactList { get; set; }



    /// <summary>
    /// Whether to use waterfall rule
    /// </summary>
    /// <value>Whether to use waterfall rule</value>
    [JsonPropertyName("useWaterfallRule")]
    public bool? UseWaterfallRule { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SplittingInformation {\n");

        sb.Append("  Criteria: ").Append(Criteria).Append("\n");
        sb.Append("  CriteriaValue: ").Append(CriteriaValue).Append("\n");
        sb.Append("  CreateRemainderContactList: ").Append(CreateRemainderContactList).Append("\n");
        sb.Append("  UseWaterfallRule: ").Append(UseWaterfallRule).Append("\n");
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
        return Equals(obj as SplittingInformation);
    }

    /// <summary>
    /// Returns true if SplittingInformation instances are equal
    /// </summary>
    /// <param name="other">Instance of SplittingInformation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SplittingInformation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Criteria == other.Criteria ||
                Criteria != null &&
                Criteria.Equals(other.Criteria)
            ) &&
            (
                CriteriaValue == other.CriteriaValue ||
                CriteriaValue != null &&
                CriteriaValue.Equals(other.CriteriaValue)
            ) &&
            (
                CreateRemainderContactList == other.CreateRemainderContactList ||
                CreateRemainderContactList != null &&
                CreateRemainderContactList.Equals(other.CreateRemainderContactList)
            ) &&
            (
                UseWaterfallRule == other.UseWaterfallRule ||
                UseWaterfallRule != null &&
                UseWaterfallRule.Equals(other.UseWaterfallRule)
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
            if (Criteria != null)
            {
                hash = hash * 59 + Criteria.GetHashCode();
            }

            if (CriteriaValue != null)
            {
                hash = hash * 59 + CriteriaValue.GetHashCode();
            }

            if (CreateRemainderContactList != null)
            {
                hash = hash * 59 + CreateRemainderContactList.GetHashCode();
            }

            if (UseWaterfallRule != null)
            {
                hash = hash * 59 + UseWaterfallRule.GetHashCode();
            }

            return hash;
        }
    }
}
