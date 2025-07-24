using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// A complex type that defines service provider attributes or subattributes and their qualities.
/// </summary>

public sealed class ScimV2SchemaAttribute
{
    /// <summary>
    /// The data type of the attribute.
    /// </summary>
    /// <value>The data type of the attribute.</value>
    
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
        /// Enum String for "string"
        /// </summary>
        [EnumMember(Value = "string")]
        String,

        /// <summary>
        /// Enum Boolean for "boolean"
        /// </summary>
        [EnumMember(Value = "boolean")]
        Boolean,

        /// <summary>
        /// Enum Decimal for "decimal"
        /// </summary>
        [EnumMember(Value = "decimal")]
        Decimal,

        /// <summary>
        /// Enum Integer for "integer"
        /// </summary>
        [EnumMember(Value = "integer")]
        Integer,

        /// <summary>
        /// Enum Datetime for "dateTime"
        /// </summary>
        [EnumMember(Value = "dateTime")]
        Datetime,

        /// <summary>
        /// Enum Reference for "reference"
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,

        /// <summary>
        /// Enum Complex for "complex"
        /// </summary>
        [EnumMember(Value = "complex")]
        Complex
    }
    /// <summary>
    /// The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".
    /// </summary>
    /// <value>The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".</value>
    
    public enum MutabilityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Readwrite for "readWrite"
        /// </summary>
        [EnumMember(Value = "readWrite")]
        Readwrite,

        /// <summary>
        /// Enum Readonly for "readOnly"
        /// </summary>
        [EnumMember(Value = "readOnly")]
        Readonly,

        /// <summary>
        /// Enum Immutable for "immutable"
        /// </summary>
        [EnumMember(Value = "immutable")]
        Immutable,

        /// <summary>
        /// Enum Writeonly for "writeOnly"
        /// </summary>
        [EnumMember(Value = "writeOnly")]
        Writeonly
    }
    /// <summary>
    /// The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.
    /// </summary>
    /// <value>The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.</value>
    
    public enum ReturnedEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Always for "always"
        /// </summary>
        [EnumMember(Value = "always")]
        Always,

        /// <summary>
        /// Enum Never for "never"
        /// </summary>
        [EnumMember(Value = "never")]
        Never,

        /// <summary>
        /// Enum Default for "default"
        /// </summary>
        [EnumMember(Value = "default")]
        Default,

        /// <summary>
        /// Enum Request for "request"
        /// </summary>
        [EnumMember(Value = "request")]
        Request
    }
    /// <summary>
    /// The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".
    /// </summary>
    /// <value>The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".</value>
    
    public enum UniquenessEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Enum Server for "server"
        /// </summary>
        [EnumMember(Value = "server")]
        Server,

        /// <summary>
        /// Enum Global for "global"
        /// </summary>
        [EnumMember(Value = "global")]
        Global
    }
    /// <summary>
    /// Gets or Sets ReferenceTypes
    /// </summary>
    
    public enum ReferenceTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User,

        /// <summary>
        /// Enum Group for "Group"
        /// </summary>
        [EnumMember(Value = "Group")]
        Group,

        /// <summary>
        /// Enum External for "external"
        /// </summary>
        [EnumMember(Value = "external")]
        External,

        /// <summary>
        /// Enum Uri for "uri"
        /// </summary>
        [EnumMember(Value = "uri")]
        Uri
    }
    /// <summary>
    /// The data type of the attribute.
    /// </summary>
    /// <value>The data type of the attribute.</value>
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".
    /// </summary>
    /// <value>The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".</value>
    public MutabilityEnum? Mutability { get; set; }
    /// <summary>
    /// The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.
    /// </summary>
    /// <value>The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.</value>
    public ReturnedEnum? Returned { get; set; }
    /// <summary>
    /// The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".
    /// </summary>
    /// <value>The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".</value>
    public UniquenessEnum? Uniqueness { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2SchemaAttribute" /> class.
    /// </summary>



    /// <summary>
    /// The name of the attribute.
    /// </summary>
    /// <value>The name of the attribute.</value>
    public string Name { get; set; }





    /// <summary>
    /// The list of subattributes for an attribute of the type \&quot;complex\&quot;. Uses the same schema as \&quot;attributes\&quot;.
    /// </summary>
    /// <value>The list of subattributes for an attribute of the type \&quot;complex\&quot;. Uses the same schema as \&quot;attributes\&quot;.</value>
    public IEnumerable<ScimV2SchemaAttribute> SubAttributes { get; set; }



    /// <summary>
    /// Indicates whether an attribute contains multiple values.
    /// </summary>
    /// <value>Indicates whether an attribute contains multiple values.</value>
    public bool? MultiValued { get; set; }



    /// <summary>
    /// The description of the attribute.
    /// </summary>
    /// <value>The description of the attribute.</value>
    public string Description { get; set; }



    /// <summary>
    /// Indicates whether an attribute is required.
    /// </summary>
    /// <value>Indicates whether an attribute is required.</value>
    public bool? Required { get; set; }



    /// <summary>
    /// The list of standard values that service providers may use. Service providers may ignore unsupported values.
    /// </summary>
    /// <value>The list of standard values that service providers may use. Service providers may ignore unsupported values.</value>
    public IEnumerable<string> CanonicalValues { get; set; }



    /// <summary>
    /// Indicates whether a string attribute is case-sensitive. If set to \&quot;true\&quot;, the server preserves case sensitivity. If set to \&quot;false\&quot;, the server may change the case. The server also uses case sensitivity when evaluating filters. See section 3.4.2.2 \&quot;Filtering\&quot; in RFC 7644 for details.
    /// </summary>
    /// <value>Indicates whether a string attribute is case-sensitive. If set to \&quot;true\&quot;, the server preserves case sensitivity. If set to \&quot;false\&quot;, the server may change the case. The server also uses case sensitivity when evaluating filters. See section 3.4.2.2 \&quot;Filtering\&quot; in RFC 7644 for details.</value>
    public bool? CaseExact { get; set; }









    /// <summary>
    /// The list of SCIM resource types that may be referenced. Only applies when \&quot;type\&quot; is set to \&quot;reference\&quot;.
    /// </summary>
    /// <value>The list of SCIM resource types that may be referenced. Only applies when \&quot;type\&quot; is set to \&quot;reference\&quot;.</value>
    public IEnumerable<ReferenceTypesEnum> ReferenceTypes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Returns true if ScimV2SchemaAttribute instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2SchemaAttribute to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
