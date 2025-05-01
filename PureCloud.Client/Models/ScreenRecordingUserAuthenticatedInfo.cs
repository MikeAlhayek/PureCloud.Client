using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ScreenRecordingUserAuthenticatedInfo
/// </summary>
[DataContract]
public partial class ScreenRecordingUserAuthenticatedInfo : IEquatable<ScreenRecordingUserAuthenticatedInfo>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ScreenRecordingUserAuthenticatedInfo" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScreenRecordingUserAuthenticatedInfo() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScreenRecordingUserAuthenticatedInfo" /> class.
    /// </summary>
    /// <param name="BackgroundAssistantId">Id of Genesys Cloud Background Assistant (required).</param>
    public ScreenRecordingUserAuthenticatedInfo(string BackgroundAssistantId = null)
    {
        this.BackgroundAssistantId = BackgroundAssistantId;

    }



    /// <summary>
    /// Id of Genesys Cloud Background Assistant
    /// </summary>
    /// <value>Id of Genesys Cloud Background Assistant</value>
    [DataMember(Name = "backgroundAssistantId", EmitDefaultValue = false)]
    public string BackgroundAssistantId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScreenRecordingUserAuthenticatedInfo {\n");

        sb.Append("  BackgroundAssistantId: ").Append(BackgroundAssistantId).Append("\n");
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
        return this.Equals(obj as ScreenRecordingUserAuthenticatedInfo);
    }

    /// <summary>
    /// Returns true if ScreenRecordingUserAuthenticatedInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of ScreenRecordingUserAuthenticatedInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScreenRecordingUserAuthenticatedInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.BackgroundAssistantId == other.BackgroundAssistantId ||
                this.BackgroundAssistantId != null &&
                this.BackgroundAssistantId.Equals(other.BackgroundAssistantId)
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
            if (this.BackgroundAssistantId != null)
            {
                hash = hash * 59 + this.BackgroundAssistantId.GetHashCode();
            }

            return hash;
        }
    }
}
