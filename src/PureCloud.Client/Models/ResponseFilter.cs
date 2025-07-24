using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Used to filter response queries
/// </summary>
public sealed class ResponseFilter
{
    /// <summary>
    /// Filter operation: IN, EQUALS, NOTEQUALS.
    /// </summary>
    /// <value>Filter operation: IN, EQUALS, NOTEQUALS.</value>
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum In for "IN"
        /// </summary>
        [EnumMember(Value = "IN")]
        In,

        /// <summary>
        /// Enum Equals for "EQUALS"
        /// </summary>
        [EnumMember(Value = "EQUALS")]
        Equals,

        /// <summary>
        /// Enum Notequals for "NOTEQUALS"
        /// </summary>
        [EnumMember(Value = "NOTEQUALS")]
        Notequals
    }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    public string Operator { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    public IEnumerable<string> Values { get; set; }
}
