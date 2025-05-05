using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VmPairingInfo
/// </summary>

public partial class VmPairingInfo : IEquatable<VmPairingInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VmPairingInfo" /> class.
    /// </summary>
    /// <param name="MetaData">This is to be used to complete the setup process of a locally deployed virtual edge device..</param>
    /// <param name="EdgeId">EdgeId.</param>
    /// <param name="AuthToken">AuthToken.</param>
    /// <param name="OrgId">OrgId.</param>
    public VmPairingInfo(MetaData MetaData = null, string EdgeId = null, string AuthToken = null, string OrgId = null)
    {
        this.MetaData = MetaData;
        this.EdgeId = EdgeId;
        this.AuthToken = AuthToken;
        this.OrgId = OrgId;

    }



    /// <summary>
    /// This is to be used to complete the setup process of a locally deployed virtual edge device.
    /// </summary>
    /// <value>This is to be used to complete the setup process of a locally deployed virtual edge device.</value>
    [JsonPropertyName("meta-data")]
    public MetaData MetaData { get; set; }



    /// <summary>
    /// Gets or Sets EdgeId
    /// </summary>
    [JsonPropertyName("edge-id")]
    public string EdgeId { get; set; }



    /// <summary>
    /// Gets or Sets AuthToken
    /// </summary>
    [JsonPropertyName("auth-token")]
    public string AuthToken { get; set; }



    /// <summary>
    /// Gets or Sets OrgId
    /// </summary>
    [JsonPropertyName("org-id")]
    public string OrgId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VmPairingInfo {\n");

        sb.Append("  MetaData: ").Append(MetaData).Append("\n");
        sb.Append("  EdgeId: ").Append(EdgeId).Append("\n");
        sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
        sb.Append("  OrgId: ").Append(OrgId).Append("\n");
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
        return Equals(obj as VmPairingInfo);
    }

    /// <summary>
    /// Returns true if VmPairingInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of VmPairingInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VmPairingInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MetaData == other.MetaData ||
                MetaData != null &&
                MetaData.Equals(other.MetaData)
            ) &&
            (
                EdgeId == other.EdgeId ||
                EdgeId != null &&
                EdgeId.Equals(other.EdgeId)
            ) &&
            (
                AuthToken == other.AuthToken ||
                AuthToken != null &&
                AuthToken.Equals(other.AuthToken)
            ) &&
            (
                OrgId == other.OrgId ||
                OrgId != null &&
                OrgId.Equals(other.OrgId)
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
            if (MetaData != null)
            {
                hash = hash * 59 + MetaData.GetHashCode();
            }

            if (EdgeId != null)
            {
                hash = hash * 59 + EdgeId.GetHashCode();
            }

            if (AuthToken != null)
            {
                hash = hash * 59 + AuthToken.GetHashCode();
            }

            if (OrgId != null)
            {
                hash = hash * 59 + OrgId.GetHashCode();
            }

            return hash;
        }
    }
}
