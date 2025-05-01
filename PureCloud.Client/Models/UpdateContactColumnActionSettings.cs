using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateContactColumnActionSettings
/// </summary>
[DataContract]
public partial class UpdateContactColumnActionSettings : IEquatable<UpdateContactColumnActionSettings>
{
    /// <summary>
    /// The type of update to make to the specified contact column(s).
    /// </summary>
    /// <value>The type of update to make to the specified contact column(s).</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UpdateOptionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Set for "Set"
        /// </summary>
        [EnumMember(Value = "Set")]
        Set,

        /// <summary>
        /// Enum Increment for "Increment"
        /// </summary>
        [EnumMember(Value = "Increment")]
        Increment,

        /// <summary>
        /// Enum Decrement for "Decrement"
        /// </summary>
        [EnumMember(Value = "Decrement")]
        Decrement,

        /// <summary>
        /// Enum Currenttime for "CurrentTime"
        /// </summary>
        [EnumMember(Value = "CurrentTime")]
        Currenttime
    }
    /// <summary>
    /// The type of update to make to the specified contact column(s).
    /// </summary>
    /// <value>The type of update to make to the specified contact column(s).</value>
    [DataMember(Name = "updateOption", EmitDefaultValue = false)]
    public UpdateOptionEnum? UpdateOption { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateContactColumnActionSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateContactColumnActionSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateContactColumnActionSettings" /> class.
    /// </summary>
    /// <param name="Properties">A mapping of contact columns to their new values. (required).</param>
    /// <param name="UpdateOption">The type of update to make to the specified contact column(s). (required).</param>
    public UpdateContactColumnActionSettings(Dictionary<string, string> Properties = null, UpdateOptionEnum? UpdateOption = null)
    {
        this.Properties = Properties;
        this.UpdateOption = UpdateOption;

    }



    /// <summary>
    /// A mapping of contact columns to their new values.
    /// </summary>
    /// <value>A mapping of contact columns to their new values.</value>
    [DataMember(Name = "properties", EmitDefaultValue = false)]
    public Dictionary<string, string> Properties { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateContactColumnActionSettings {\n");

        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
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
        return Equals(obj as UpdateContactColumnActionSettings);
    }

    /// <summary>
    /// Returns true if UpdateContactColumnActionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateContactColumnActionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateContactColumnActionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
            ) &&
            (
                UpdateOption == other.UpdateOption ||
                UpdateOption != null &&
                UpdateOption.Equals(other.UpdateOption)
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
            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (UpdateOption != null)
            {
                hash = hash * 59 + UpdateOption.GetHashCode();
            }

            return hash;
        }
    }
}
