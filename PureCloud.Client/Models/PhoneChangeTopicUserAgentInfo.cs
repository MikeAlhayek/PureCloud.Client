using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneChangeTopicUserAgentInfo
/// </summary>
[DataContract]
public partial class PhoneChangeTopicUserAgentInfo : IEquatable<PhoneChangeTopicUserAgentInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneChangeTopicUserAgentInfo" /> class.
    /// </summary>
    /// <param name="FirmwareVersion">FirmwareVersion.</param>
    /// <param name="Manufacturer">Manufacturer.</param>
    /// <param name="Model">Model.</param>
    public PhoneChangeTopicUserAgentInfo(string FirmwareVersion = null, string Manufacturer = null, string Model = null)
    {
        this.FirmwareVersion = FirmwareVersion;
        this.Manufacturer = Manufacturer;
        this.Model = Model;

    }



    /// <summary>
    /// Gets or Sets FirmwareVersion
    /// </summary>
    [DataMember(Name = "firmwareVersion", EmitDefaultValue = false)]
    public string FirmwareVersion { get; set; }



    /// <summary>
    /// Gets or Sets Manufacturer
    /// </summary>
    [DataMember(Name = "manufacturer", EmitDefaultValue = false)]
    public string Manufacturer { get; set; }



    /// <summary>
    /// Gets or Sets Model
    /// </summary>
    [DataMember(Name = "model", EmitDefaultValue = false)]
    public string Model { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneChangeTopicUserAgentInfo {\n");

        sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
        sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
        sb.Append("  Model: ").Append(Model).Append("\n");
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
        return Equals(obj as PhoneChangeTopicUserAgentInfo);
    }

    /// <summary>
    /// Returns true if PhoneChangeTopicUserAgentInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneChangeTopicUserAgentInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneChangeTopicUserAgentInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FirmwareVersion == other.FirmwareVersion ||
                FirmwareVersion != null &&
                FirmwareVersion.Equals(other.FirmwareVersion)
            ) &&
            (
                Manufacturer == other.Manufacturer ||
                Manufacturer != null &&
                Manufacturer.Equals(other.Manufacturer)
            ) &&
            (
                Model == other.Model ||
                Model != null &&
                Model.Equals(other.Model)
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
            if (FirmwareVersion != null)
            {
                hash = hash * 59 + FirmwareVersion.GetHashCode();
            }

            if (Manufacturer != null)
            {
                hash = hash * 59 + Manufacturer.GetHashCode();
            }

            if (Model != null)
            {
                hash = hash * 59 + Model.GetHashCode();
            }

            return hash;
        }
    }
}
