using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAppEventsNotificationApp
/// </summary>
[DataContract]
public partial class JourneyAppEventsNotificationApp : IEquatable<JourneyAppEventsNotificationApp>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationApp" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Namespace">Namespace.</param>
    /// <param name="Version">Version.</param>
    /// <param name="BuildNumber">BuildNumber.</param>
    public JourneyAppEventsNotificationApp(string Name = null, string Namespace = null, string Version = null, string BuildNumber = null)
    {
        this.Name = Name;
        this.Namespace = Namespace;
        this.Version = Version;
        this.BuildNumber = BuildNumber;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [DataMember(Name = "namespace", EmitDefaultValue = false)]
    public string Namespace { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; set; }



    /// <summary>
    /// Gets or Sets BuildNumber
    /// </summary>
    [DataMember(Name = "buildNumber", EmitDefaultValue = false)]
    public string BuildNumber { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAppEventsNotificationApp {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
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
        return Equals(obj as JourneyAppEventsNotificationApp);
    }

    /// <summary>
    /// Returns true if JourneyAppEventsNotificationApp instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAppEventsNotificationApp to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAppEventsNotificationApp other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Namespace == other.Namespace ||
                Namespace != null &&
                Namespace.Equals(other.Namespace)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                BuildNumber == other.BuildNumber ||
                BuildNumber != null &&
                BuildNumber.Equals(other.BuildNumber)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Namespace != null)
            {
                hash = hash * 59 + Namespace.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (BuildNumber != null)
            {
                hash = hash * 59 + BuildNumber.GetHashCode();
            }

            return hash;
        }
    }
}
