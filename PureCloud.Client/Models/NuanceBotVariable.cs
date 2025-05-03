using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Model for a Nuance bot variable
/// </summary>

public partial class NuanceBotVariable : IEquatable<NuanceBotVariable>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceBotVariable" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NuanceBotVariable() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceBotVariable" /> class.
    /// </summary>
    /// <param name="Id">The variable ID (required).</param>
    /// <param name="Name">The variable display name (required).</param>
    /// <param name="Description">The variable description.</param>
    /// <param name="Reserved">True if the variable is a reserved variable.</param>
    /// <param name="SimpleVariableInfo">The type information for this variable.</param>
    /// <param name="ComplexGenericVariableInfo">The type information for this variable.</param>
    public NuanceBotVariable(string Id = null, string Name = null, string Description = null, bool? Reserved = null, string SimpleVariableInfo = null, ComplexVariableInfo ComplexGenericVariableInfo = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Reserved = Reserved;
        this.SimpleVariableInfo = SimpleVariableInfo;
        this.ComplexGenericVariableInfo = ComplexGenericVariableInfo;

    }



    /// <summary>
    /// The variable ID
    /// </summary>
    /// <value>The variable ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The variable display name
    /// </summary>
    /// <value>The variable display name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The variable description
    /// </summary>
    /// <value>The variable description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// True if the variable is a reserved variable
    /// </summary>
    /// <value>True if the variable is a reserved variable</value>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }



    /// <summary>
    /// The type information for this variable
    /// </summary>
    /// <value>The type information for this variable</value>
    [JsonPropertyName("simpleVariableInfo")]
    public string SimpleVariableInfo { get; set; }



    /// <summary>
    /// The type information for this variable
    /// </summary>
    /// <value>The type information for this variable</value>
    [JsonPropertyName("complexGenericVariableInfo")]
    public ComplexVariableInfo ComplexGenericVariableInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NuanceBotVariable {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Reserved: ").Append(Reserved).Append("\n");
        sb.Append("  SimpleVariableInfo: ").Append(SimpleVariableInfo).Append("\n");
        sb.Append("  ComplexGenericVariableInfo: ").Append(ComplexGenericVariableInfo).Append("\n");
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
        return Equals(obj as NuanceBotVariable);
    }

    /// <summary>
    /// Returns true if NuanceBotVariable instances are equal
    /// </summary>
    /// <param name="other">Instance of NuanceBotVariable to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NuanceBotVariable other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Reserved == other.Reserved ||
                Reserved != null &&
                Reserved.Equals(other.Reserved)
            ) &&
            (
                SimpleVariableInfo == other.SimpleVariableInfo ||
                SimpleVariableInfo != null &&
                SimpleVariableInfo.Equals(other.SimpleVariableInfo)
            ) &&
            (
                ComplexGenericVariableInfo == other.ComplexGenericVariableInfo ||
                ComplexGenericVariableInfo != null &&
                ComplexGenericVariableInfo.Equals(other.ComplexGenericVariableInfo)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Reserved != null)
            {
                hash = hash * 59 + Reserved.GetHashCode();
            }

            if (SimpleVariableInfo != null)
            {
                hash = hash * 59 + SimpleVariableInfo.GetHashCode();
            }

            if (ComplexGenericVariableInfo != null)
            {
                hash = hash * 59 + ComplexGenericVariableInfo.GetHashCode();
            }

            return hash;
        }
    }
}
