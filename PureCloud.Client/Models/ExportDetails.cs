using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExportDetails
/// </summary>

public partial class ExportDetails : IEquatable<ExportDetails>
{
    /// <summary>
    /// The export type for the flow. Default: 'Yaml'.
    /// </summary>
    /// <value>The export type for the flow. Default: 'Yaml'.</value>
    
    public enum ExportTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Architect for "Architect"
        /// </summary>
        [EnumMember(Value = "Architect")]
        Architect,

        /// <summary>
        /// Enum Yaml for "Yaml"
        /// </summary>
        [EnumMember(Value = "Yaml")]
        Yaml
    }
    /// <summary>
    /// The export type for the flow. Default: 'Yaml'.
    /// </summary>
    /// <value>The export type for the flow. Default: 'Yaml'.</value>
    [JsonPropertyName("exportType")]
    public ExportTypeEnum? ExportType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExportDetails" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExportDetails() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExportDetails" /> class.
    /// </summary>
    /// <param name="Flow">The flow to export. If you do not provide the flow ID, you must provide both the name and type. (required).</param>
    /// <param name="FileName">Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens..</param>
    /// <param name="ExportType">The export type for the flow. Default: &#39;Yaml&#39;..</param>
    public ExportDetails(ArchitectFlowReference Flow = null, string FileName = null, ExportTypeEnum? ExportType = null)
    {
        this.Flow = Flow;
        this.FileName = FileName;
        this.ExportType = ExportType;

    }



    /// <summary>
    /// The flow to export. If you do not provide the flow ID, you must provide both the name and type.
    /// </summary>
    /// <value>The flow to export. If you do not provide the flow ID, you must provide both the name and type.</value>
    [JsonPropertyName("flow")]
    public ArchitectFlowReference Flow { get; set; }



    /// <summary>
    /// Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens.
    /// </summary>
    /// <value>Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens.</value>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExportDetails {\n");

        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  ExportType: ").Append(ExportType).Append("\n");
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
        return Equals(obj as ExportDetails);
    }

    /// <summary>
    /// Returns true if ExportDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of ExportDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExportDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                ExportType == other.ExportType ||
                ExportType != null &&
                ExportType.Equals(other.ExportType)
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
            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (ExportType != null)
            {
                hash = hash * 59 + ExportType.GetHashCode();
            }

            return hash;
        }
    }
}
