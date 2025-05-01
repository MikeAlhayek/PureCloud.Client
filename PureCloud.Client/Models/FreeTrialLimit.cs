using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FreeTrialLimit
/// </summary>
[DataContract]
public partial class FreeTrialLimit : IEquatable<FreeTrialLimit>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FreeTrialLimit" /> class.
    /// </summary>
    /// <param name="Key">Key.</param>
    /// <param name="DefaultValue">DefaultValue.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Resource">Resource.</param>
    public FreeTrialLimit(string Key = null, long? DefaultValue = null, string Description = null, string Resource = null)
    {
        this.Key = Key;
        this.DefaultValue = DefaultValue;
        this.Description = Description;
        this.Resource = Resource;

    }



    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name = "key", EmitDefaultValue = false)]
    public string Key { get; set; }



    /// <summary>
    /// Gets or Sets DefaultValue
    /// </summary>
    [DataMember(Name = "defaultValue", EmitDefaultValue = false)]
    public long? DefaultValue { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [DataMember(Name = "resource", EmitDefaultValue = false)]
    public string Resource { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FreeTrialLimit {\n");

        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Resource: ").Append(Resource).Append("\n");
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
        return Equals(obj as FreeTrialLimit);
    }

    /// <summary>
    /// Returns true if FreeTrialLimit instances are equal
    /// </summary>
    /// <param name="other">Instance of FreeTrialLimit to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FreeTrialLimit other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Key == other.Key ||
                Key != null &&
                Key.Equals(other.Key)
            ) &&
            (
                DefaultValue == other.DefaultValue ||
                DefaultValue != null &&
                DefaultValue.Equals(other.DefaultValue)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Resource == other.Resource ||
                Resource != null &&
                Resource.Equals(other.Resource)
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
            if (Key != null)
            {
                hash = hash * 59 + Key.GetHashCode();
            }

            if (DefaultValue != null)
            {
                hash = hash * 59 + DefaultValue.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Resource != null)
            {
                hash = hash * 59 + Resource.GetHashCode();
            }

            return hash;
        }
    }
}
