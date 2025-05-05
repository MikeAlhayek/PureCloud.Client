using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Attributes on an element in a journey view
/// </summary>

public partial class JourneyViewElementAttributes : IEquatable<JourneyViewElementAttributes>
{
    /// <summary>
    /// The type of the element (e.g. Event)
    /// </summary>
    /// <value>The type of the element (e.g. Event)</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Event for "Event"
        /// </summary>
        [EnumMember(Value = "Event")]
        Event
    }
    /// <summary>
    /// The type of the element (e.g. Event)
    /// </summary>
    /// <value>The type of the element (e.g. Event)</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElementAttributes" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewElementAttributes() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElementAttributes" /> class.
    /// </summary>
    /// <param name="Type">The type of the element (e.g. Event) (required).</param>
    /// <param name="Id">The identifier for the element based on its type.</param>
    /// <param name="Source">The source for the element (e.g. IVR, Voice, Chat). Used for informational purposes only.</param>
    public JourneyViewElementAttributes(TypeEnum? Type = null, string Id = null, string Source = null)
    {
        this.Type = Type;
        this.Id = Id;
        this.Source = Source;

    }





    /// <summary>
    /// The identifier for the element based on its type
    /// </summary>
    /// <value>The identifier for the element based on its type</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The source for the element (e.g. IVR, Voice, Chat). Used for informational purposes only
    /// </summary>
    /// <value>The source for the element (e.g. IVR, Voice, Chat). Used for informational purposes only</value>
    [JsonPropertyName("source")]
    public string Source { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewElementAttributes {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
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
        return Equals(obj as JourneyViewElementAttributes);
    }

    /// <summary>
    /// Returns true if JourneyViewElementAttributes instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewElementAttributes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewElementAttributes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            return hash;
        }
    }
}
