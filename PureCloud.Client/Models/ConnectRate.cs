using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConnectRate
/// </summary>
[DataContract]
public partial class ConnectRate : IEquatable<ConnectRate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConnectRate" /> class.
    /// </summary>
    public ConnectRate()
    {

    }



    /// <summary>
    /// Number of call attempts made
    /// </summary>
    /// <value>Number of call attempts made</value>
    [DataMember(Name = "attempts", EmitDefaultValue = false)]
    public long? Attempts { get; private set; }



    /// <summary>
    /// Number of calls with a live voice detected
    /// </summary>
    /// <value>Number of calls with a live voice detected</value>
    [DataMember(Name = "connects", EmitDefaultValue = false)]
    public long? Connects { get; private set; }



    /// <summary>
    /// Ratio of connects to attempts
    /// </summary>
    /// <value>Ratio of connects to attempts</value>
    [DataMember(Name = "connectRatio", EmitDefaultValue = false)]
    public double? ConnectRatio { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConnectRate {\n");

        sb.Append("  Attempts: ").Append(Attempts).Append("\n");
        sb.Append("  Connects: ").Append(Connects).Append("\n");
        sb.Append("  ConnectRatio: ").Append(ConnectRatio).Append("\n");
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
        return Equals(obj as ConnectRate);
    }

    /// <summary>
    /// Returns true if ConnectRate instances are equal
    /// </summary>
    /// <param name="other">Instance of ConnectRate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConnectRate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Attempts == other.Attempts ||
                Attempts != null &&
                Attempts.Equals(other.Attempts)
            ) &&
            (
                Connects == other.Connects ||
                Connects != null &&
                Connects.Equals(other.Connects)
            ) &&
            (
                ConnectRatio == other.ConnectRatio ||
                ConnectRatio != null &&
                ConnectRatio.Equals(other.ConnectRatio)
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
            if (Attempts != null)
            {
                hash = hash * 59 + Attempts.GetHashCode();
            }

            if (Connects != null)
            {
                hash = hash * 59 + Connects.GetHashCode();
            }

            if (ConnectRatio != null)
            {
                hash = hash * 59 + ConnectRatio.GetHashCode();
            }

            return hash;
        }
    }
}
