using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LastAttemptByColumnConditionSettings
/// </summary>
[DataContract]
public partial class LastAttemptByColumnConditionSettings : IEquatable<LastAttemptByColumnConditionSettings>
{
    /// <summary>
    /// The operator to use when comparing values.
    /// </summary>
    /// <value>The operator to use when comparing values.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Before for "Before"
        /// </summary>
        [EnumMember(Value = "Before")]
        Before,

        /// <summary>
        /// Enum After for "After"
        /// </summary>
        [EnumMember(Value = "After")]
        After
    }
    /// <summary>
    /// The operator to use when comparing values.
    /// </summary>
    /// <value>The operator to use when comparing values.</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LastAttemptByColumnConditionSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LastAttemptByColumnConditionSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LastAttemptByColumnConditionSettings" /> class.
    /// </summary>
    /// <param name="EmailColumnName">The name of the contact column to evaluate for Email..</param>
    /// <param name="SmsColumnName">The name of the contact column to evaluate for SMS..</param>
    /// <param name="Operator">The operator to use when comparing values. (required).</param>
    /// <param name="Value">The period value to compare against the contact&#39;s data. (required).</param>
    public LastAttemptByColumnConditionSettings(string EmailColumnName = null, string SmsColumnName = null, OperatorEnum? Operator = null, string Value = null)
    {
        this.EmailColumnName = EmailColumnName;
        this.SmsColumnName = SmsColumnName;
        this.Operator = Operator;
        this.Value = Value;

    }



    /// <summary>
    /// The name of the contact column to evaluate for Email.
    /// </summary>
    /// <value>The name of the contact column to evaluate for Email.</value>
    [DataMember(Name = "emailColumnName", EmitDefaultValue = false)]
    public string EmailColumnName { get; set; }



    /// <summary>
    /// The name of the contact column to evaluate for SMS.
    /// </summary>
    /// <value>The name of the contact column to evaluate for SMS.</value>
    [DataMember(Name = "smsColumnName", EmitDefaultValue = false)]
    public string SmsColumnName { get; set; }





    /// <summary>
    /// The period value to compare against the contact&#39;s data.
    /// </summary>
    /// <value>The period value to compare against the contact&#39;s data.</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LastAttemptByColumnConditionSettings {\n");

        sb.Append("  EmailColumnName: ").Append(EmailColumnName).Append("\n");
        sb.Append("  SmsColumnName: ").Append(SmsColumnName).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as LastAttemptByColumnConditionSettings);
    }

    /// <summary>
    /// Returns true if LastAttemptByColumnConditionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of LastAttemptByColumnConditionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LastAttemptByColumnConditionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EmailColumnName == other.EmailColumnName ||
                EmailColumnName != null &&
                EmailColumnName.Equals(other.EmailColumnName)
            ) &&
            (
                SmsColumnName == other.SmsColumnName ||
                SmsColumnName != null &&
                SmsColumnName.Equals(other.SmsColumnName)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (EmailColumnName != null)
            {
                hash = hash * 59 + EmailColumnName.GetHashCode();
            }

            if (SmsColumnName != null)
            {
                hash = hash * 59 + SmsColumnName.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
