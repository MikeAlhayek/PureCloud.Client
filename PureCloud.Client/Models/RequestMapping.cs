using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RequestMapping
/// </summary>

public partial class RequestMapping : IEquatable<RequestMapping>
{
    /// <summary>
    /// Type of the value supplied
    /// </summary>
    /// <value>Type of the value supplied</value>
    
    public enum AttributeTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum String for "String"
        /// </summary>
        [EnumMember(Value = "String")]
        String,

        /// <summary>
        /// Enum Number for "Number"
        /// </summary>
        [EnumMember(Value = "Number")]
        Number,

        /// <summary>
        /// Enum Integer for "Integer"
        /// </summary>
        [EnumMember(Value = "Integer")]
        Integer,

        /// <summary>
        /// Enum Boolean for "Boolean"
        /// </summary>
        [EnumMember(Value = "Boolean")]
        Boolean
    }
    /// <summary>
    /// Method of finding value to use with Attribute
    /// </summary>
    /// <value>Method of finding value to use with Attribute</value>
    
    public enum MappingTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Lookup for "Lookup"
        /// </summary>
        [EnumMember(Value = "Lookup")]
        Lookup,

        /// <summary>
        /// Enum Hardcoded for "HardCoded"
        /// </summary>
        [EnumMember(Value = "HardCoded")]
        Hardcoded
    }
    /// <summary>
    /// Type of the value supplied
    /// </summary>
    /// <value>Type of the value supplied</value>
    [JsonPropertyName("attributeType")]
    public AttributeTypeEnum? AttributeType { get; set; }
    /// <summary>
    /// Method of finding value to use with Attribute
    /// </summary>
    /// <value>Method of finding value to use with Attribute</value>
    [JsonPropertyName("mappingType")]
    public MappingTypeEnum? MappingType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RequestMapping" /> class.
    /// </summary>
    /// <param name="Name">Name of the Integration Action Attribute to supply the value for.</param>
    /// <param name="AttributeType">Type of the value supplied.</param>
    /// <param name="MappingType">Method of finding value to use with Attribute.</param>
    /// <param name="Value">Value to supply for the specified Attribute.</param>
    public RequestMapping(string Name = null, AttributeTypeEnum? AttributeType = null, MappingTypeEnum? MappingType = null, string Value = null)
    {
        this.Name = Name;
        this.AttributeType = AttributeType;
        this.MappingType = MappingType;
        this.Value = Value;

    }



    /// <summary>
    /// Name of the Integration Action Attribute to supply the value for
    /// </summary>
    /// <value>Name of the Integration Action Attribute to supply the value for</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }







    /// <summary>
    /// Value to supply for the specified Attribute
    /// </summary>
    /// <value>Value to supply for the specified Attribute</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RequestMapping {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  AttributeType: ").Append(AttributeType).Append("\n");
        sb.Append("  MappingType: ").Append(MappingType).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as RequestMapping);
    }

    /// <summary>
    /// Returns true if RequestMapping instances are equal
    /// </summary>
    /// <param name="other">Instance of RequestMapping to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RequestMapping other)
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
                AttributeType == other.AttributeType ||
                AttributeType != null &&
                AttributeType.Equals(other.AttributeType)
            ) &&
            (
                MappingType == other.MappingType ||
                MappingType != null &&
                MappingType.Equals(other.MappingType)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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

            if (AttributeType != null)
            {
                hash = hash * 59 + AttributeType.GetHashCode();
            }

            if (MappingType != null)
            {
                hash = hash * 59 + MappingType.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
