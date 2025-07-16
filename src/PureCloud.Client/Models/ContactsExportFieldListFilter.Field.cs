using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContactsExportFieldListFilterFieldEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Divisionid for "DivisionId"
    /// </summary>
    [EnumMember(Value = "DivisionId")]
    Divisionid,

    /// <summary>
    /// Enum Contactclassification for "ContactClassification"
    /// </summary>
    [EnumMember(Value = "ContactClassification")]
    Contactclassification,

    /// <summary>
    /// Enum Externalorganizationid for "ExternalOrganizationId"
    /// </summary>
    [EnumMember(Value = "ExternalOrganizationId")]
    Externalorganizationid
}
