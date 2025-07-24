using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM phone number.
/// </summary>

public sealed class ScimPhoneNumber
{
    /// <summary>
    /// The type of phone number.
    /// </summary>
    /// <value>The type of phone number.</value>
    
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
        /// Enum Work for "work"
        /// </summary>
        [EnumMember(Value = "work")]
        Work,

        /// <summary>
        /// Enum Work2 for "work2"
        /// </summary>
        [EnumMember(Value = "work2")]
        Work2,

        /// <summary>
        /// Enum Work3 for "work3"
        /// </summary>
        [EnumMember(Value = "work3")]
        Work3,

        /// <summary>
        /// Enum Work4 for "work4"
        /// </summary>
        [EnumMember(Value = "work4")]
        Work4,

        /// <summary>
        /// Enum Home for "home"
        /// </summary>
        [EnumMember(Value = "home")]
        Home,

        /// <summary>
        /// Enum Mobile for "mobile"
        /// </summary>
        [EnumMember(Value = "mobile")]
        Mobile,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// Enum Microsoftteams for "microsoftteams"
        /// </summary>
        [EnumMember(Value = "microsoftteams")]
        Microsoftteams,

        /// <summary>
        /// Enum Zoomphone for "zoomphone"
        /// </summary>
        [EnumMember(Value = "zoomphone")]
        Zoomphone,

        /// <summary>
        /// Enum Eightbyeight for "eightbyeight"
        /// </summary>
        [EnumMember(Value = "eightbyeight")]
        Eightbyeight
    }
    /// <summary>
    /// The type of phone number.
    /// </summary>
    /// <value>The type of phone number.</value>
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimPhoneNumber" /> class.
    /// </summary>
    /// <param name="Value">The phone number in E.164 or tel URI format, for example, tel:+nnnnnnnn; ext&#x3D;xxxxx..</param>
    /// <param name="Type">The type of phone number..</param>
    /// <param name="Primary">Indicates whether the phone number is the primary phone number..</param>



    /// <summary>
    /// The phone number in E.164 or tel URI format, for example, tel:+nnnnnnnn; ext&#x3D;xxxxx.
    /// </summary>
    /// <value>The phone number in E.164 or tel URI format, for example, tel:+nnnnnnnn; ext&#x3D;xxxxx.</value>
    public string Value { get; set; }





    /// <summary>
    /// Indicates whether the phone number is the primary phone number.
    /// </summary>
    /// <value>Indicates whether the phone number is the primary phone number.</value>
    public bool? Primary { get; set; }


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
    /// Returns true if ScimPhoneNumber instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimPhoneNumber to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
