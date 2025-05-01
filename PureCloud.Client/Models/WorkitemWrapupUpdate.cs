using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemWrapupUpdate
/// </summary>
[DataContract]
public partial class WorkitemWrapupUpdate : IEquatable<WorkitemWrapupUpdate>
{
    /// <summary>
    /// Action to be performed for the wrapup code.
    /// </summary>
    /// <value>Action to be performed for the wrapup code.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Add for "Add"
        /// </summary>
        [EnumMember(Value = "Add")]
        Add,

        /// <summary>
        /// Enum Remove for "Remove"
        /// </summary>
        [EnumMember(Value = "Remove")]
        Remove
    }
    /// <summary>
    /// Action to be performed for the wrapup code.
    /// </summary>
    /// <value>Action to be performed for the wrapup code.</value>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public ActionEnum? Action { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemWrapupUpdate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkitemWrapupUpdate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemWrapupUpdate" /> class.
    /// </summary>
    /// <param name="Action">Action to be performed for the wrapup code. (required).</param>
    /// <param name="WrapupCode">The wrapup code which will be added/removed. (required).</param>
    public WorkitemWrapupUpdate(ActionEnum? Action = null, string WrapupCode = null)
    {
        this.Action = Action;
        this.WrapupCode = WrapupCode;

    }





    /// <summary>
    /// The wrapup code which will be added/removed.
    /// </summary>
    /// <value>The wrapup code which will be added/removed.</value>
    [DataMember(Name = "wrapupCode", EmitDefaultValue = false)]
    public string WrapupCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemWrapupUpdate {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  WrapupCode: ").Append(WrapupCode).Append("\n");
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
        return Equals(obj as WorkitemWrapupUpdate);
    }

    /// <summary>
    /// Returns true if WorkitemWrapupUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemWrapupUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemWrapupUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                WrapupCode == other.WrapupCode ||
                WrapupCode != null &&
                WrapupCode.Equals(other.WrapupCode)
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
            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (WrapupCode != null)
            {
                hash = hash * 59 + WrapupCode.GetHashCode();
            }

            return hash;
        }
    }
}
