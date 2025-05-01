using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserStations
/// </summary>
[DataContract]
public partial class UserStations : IEquatable<UserStations>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserStations" /> class.
    /// </summary>
    public UserStations()
    {

    }



    /// <summary>
    /// Current associated station for this user.
    /// </summary>
    /// <value>Current associated station for this user.</value>
    [DataMember(Name = "associatedStation", EmitDefaultValue = false)]
    public UserStation AssociatedStation { get; private set; }



    /// <summary>
    /// The station where the user can be reached based on their default and associated station.
    /// </summary>
    /// <value>The station where the user can be reached based on their default and associated station.</value>
    [DataMember(Name = "effectiveStation", EmitDefaultValue = false)]
    public UserStation EffectiveStation { get; private set; }



    /// <summary>
    /// Default station to be used if not associated with a station.
    /// </summary>
    /// <value>Default station to be used if not associated with a station.</value>
    [DataMember(Name = "defaultStation", EmitDefaultValue = false)]
    public UserStation DefaultStation { get; private set; }



    /// <summary>
    /// Last associated station for this user.
    /// </summary>
    /// <value>Last associated station for this user.</value>
    [DataMember(Name = "lastAssociatedStation", EmitDefaultValue = false)]
    public UserStation LastAssociatedStation { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserStations {\n");

        sb.Append("  AssociatedStation: ").Append(AssociatedStation).Append("\n");
        sb.Append("  EffectiveStation: ").Append(EffectiveStation).Append("\n");
        sb.Append("  DefaultStation: ").Append(DefaultStation).Append("\n");
        sb.Append("  LastAssociatedStation: ").Append(LastAssociatedStation).Append("\n");
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
        return Equals(obj as UserStations);
    }

    /// <summary>
    /// Returns true if UserStations instances are equal
    /// </summary>
    /// <param name="other">Instance of UserStations to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserStations other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AssociatedStation == other.AssociatedStation ||
                AssociatedStation != null &&
                AssociatedStation.Equals(other.AssociatedStation)
            ) &&
            (
                EffectiveStation == other.EffectiveStation ||
                EffectiveStation != null &&
                EffectiveStation.Equals(other.EffectiveStation)
            ) &&
            (
                DefaultStation == other.DefaultStation ||
                DefaultStation != null &&
                DefaultStation.Equals(other.DefaultStation)
            ) &&
            (
                LastAssociatedStation == other.LastAssociatedStation ||
                LastAssociatedStation != null &&
                LastAssociatedStation.Equals(other.LastAssociatedStation)
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
            if (AssociatedStation != null)
            {
                hash = hash * 59 + AssociatedStation.GetHashCode();
            }

            if (EffectiveStation != null)
            {
                hash = hash * 59 + EffectiveStation.GetHashCode();
            }

            if (DefaultStation != null)
            {
                hash = hash * 59 + DefaultStation.GetHashCode();
            }

            if (LastAssociatedStation != null)
            {
                hash = hash * 59 + LastAssociatedStation.GetHashCode();
            }

            return hash;
        }
    }
}
