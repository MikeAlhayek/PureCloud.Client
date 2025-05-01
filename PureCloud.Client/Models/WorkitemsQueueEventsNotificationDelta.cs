using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemsQueueEventsNotificationDelta
/// </summary>
[DataContract]
public partial class WorkitemsQueueEventsNotificationDelta : IEquatable<WorkitemsQueueEventsNotificationDelta>
{
    /// <summary>
    /// Gets or Sets Op
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OpEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Add for "add"
        /// </summary>
        [EnumMember(Value = "add")]
        Add,

        /// <summary>
        /// Enum Remove for "remove"
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove,

        /// <summary>
        /// Enum Replace for "replace"
        /// </summary>
        [EnumMember(Value = "replace")]
        Replace,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets Op
    /// </summary>
    [DataMember(Name = "op", EmitDefaultValue = false)]
    public OpEnum? Op { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemsQueueEventsNotificationDelta" /> class.
    /// </summary>
    /// <param name="Op">Op.</param>
    /// <param name="Field">Field.</param>
    /// <param name="OldValue">OldValue.</param>
    /// <param name="NewValue">NewValue.</param>
    public WorkitemsQueueEventsNotificationDelta(OpEnum? Op = null, string Field = null, string OldValue = null, string NewValue = null)
    {
        this.Op = Op;
        this.Field = Field;
        this.OldValue = OldValue;
        this.NewValue = NewValue;

    }





    /// <summary>
    /// Gets or Sets Field
    /// </summary>
    [DataMember(Name = "field", EmitDefaultValue = false)]
    public string Field { get; set; }



    /// <summary>
    /// Gets or Sets OldValue
    /// </summary>
    [DataMember(Name = "oldValue", EmitDefaultValue = false)]
    public string OldValue { get; set; }



    /// <summary>
    /// Gets or Sets NewValue
    /// </summary>
    [DataMember(Name = "newValue", EmitDefaultValue = false)]
    public string NewValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemsQueueEventsNotificationDelta {\n");

        sb.Append("  Op: ").Append(Op).Append("\n");
        sb.Append("  Field: ").Append(Field).Append("\n");
        sb.Append("  OldValue: ").Append(OldValue).Append("\n");
        sb.Append("  NewValue: ").Append(NewValue).Append("\n");
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
        return Equals(obj as WorkitemsQueueEventsNotificationDelta);
    }

    /// <summary>
    /// Returns true if WorkitemsQueueEventsNotificationDelta instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemsQueueEventsNotificationDelta to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemsQueueEventsNotificationDelta other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Op == other.Op ||
                Op != null &&
                Op.Equals(other.Op)
            ) &&
            (
                Field == other.Field ||
                Field != null &&
                Field.Equals(other.Field)
            ) &&
            (
                OldValue == other.OldValue ||
                OldValue != null &&
                OldValue.Equals(other.OldValue)
            ) &&
            (
                NewValue == other.NewValue ||
                NewValue != null &&
                NewValue.Equals(other.NewValue)
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
            if (Op != null)
            {
                hash = hash * 59 + Op.GetHashCode();
            }

            if (Field != null)
            {
                hash = hash * 59 + Field.GetHashCode();
            }

            if (OldValue != null)
            {
                hash = hash * 59 + OldValue.GetHashCode();
            }

            if (NewValue != null)
            {
                hash = hash * 59 + NewValue.GetHashCode();
            }

            return hash;
        }
    }
}
