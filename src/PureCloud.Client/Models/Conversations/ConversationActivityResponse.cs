using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationActivityResponse
/// </summary>

public partial class ConversationActivityResponse : IEquatable<ConversationActivityResponse>
{
    /// <summary>
    /// Dimension that is used as an entityId
    /// </summary>
    /// <value>Dimension that is used as an entityId</value>
    
    public enum EntityIdDimensionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Activerouting for "activeRouting"
        /// </summary>
        [EnumMember(Value = "activeRouting")]
        Activerouting,

        /// <summary>
        /// Enum Addressfrom for "addressFrom"
        /// </summary>
        [EnumMember(Value = "addressFrom")]
        Addressfrom,

        /// <summary>
        /// Enum Addressto for "addressTo"
        /// </summary>
        [EnumMember(Value = "addressTo")]
        Addressto,

        /// <summary>
        /// Enum Agentscore for "agentScore"
        /// </summary>
        [EnumMember(Value = "agentScore")]
        Agentscore,

        /// <summary>
        /// Enum Ani for "ani"
        /// </summary>
        [EnumMember(Value = "ani")]
        Ani,

        /// <summary>
        /// Enum Conversationid for "conversationId"
        /// </summary>
        [EnumMember(Value = "conversationId")]
        Conversationid,

        /// <summary>
        /// Enum Convertedfrom for "convertedFrom"
        /// </summary>
        [EnumMember(Value = "convertedFrom")]
        Convertedfrom,

        /// <summary>
        /// Enum Convertedto for "convertedTo"
        /// </summary>
        [EnumMember(Value = "convertedTo")]
        Convertedto,

        /// <summary>
        /// Enum Direction for "direction"
        /// </summary>
        [EnumMember(Value = "direction")]
        Direction,

        /// <summary>
        /// Enum Dnis for "dnis"
        /// </summary>
        [EnumMember(Value = "dnis")]
        Dnis,

        /// <summary>
        /// Enum Mediatype for "mediaType"
        /// </summary>
        [EnumMember(Value = "mediaType")]
        Mediatype,

        /// <summary>
        /// Enum Participantname for "participantName"
        /// </summary>
        [EnumMember(Value = "participantName")]
        Participantname,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Requestedlanguageid for "requestedLanguageId"
        /// </summary>
        [EnumMember(Value = "requestedLanguageId")]
        Requestedlanguageid,

        /// <summary>
        /// Enum Requestedrouting for "requestedRouting"
        /// </summary>
        [EnumMember(Value = "requestedRouting")]
        Requestedrouting,

        /// <summary>
        /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
        /// </summary>
        [EnumMember(Value = "requestedRoutingSkillId")]
        Requestedroutingskillid,

        /// <summary>
        /// Enum Routingpriority for "routingPriority"
        /// </summary>
        [EnumMember(Value = "routingPriority")]
        Routingpriority,

        /// <summary>
        /// Enum Scoredagentid for "scoredAgentId"
        /// </summary>
        [EnumMember(Value = "scoredAgentId")]
        Scoredagentid,

        /// <summary>
        /// Enum Sessionid for "sessionId"
        /// </summary>
        [EnumMember(Value = "sessionId")]
        Sessionid,

        /// <summary>
        /// Enum Teamid for "teamId"
        /// </summary>
        [EnumMember(Value = "teamId")]
        Teamid,

        /// <summary>
        /// Enum Usedrouting for "usedRouting"
        /// </summary>
        [EnumMember(Value = "usedRouting")]
        Usedrouting,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid
    }
    /// <summary>
    /// Dimension that is used as an entityId
    /// </summary>
    /// <value>Dimension that is used as an entityId</value>
    [JsonPropertyName("entityIdDimension")]
    public EntityIdDimensionEnum? EntityIdDimension { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationActivityResponse" /> class.
    /// </summary>
    /// <param name="Results">Query results.</param>
    /// <param name="EntityIdDimension">Dimension that is used as an entityId.</param>
    public ConversationActivityResponse(List<ConversationActivityData> Results = null, EntityIdDimensionEnum? EntityIdDimension = null)
    {
        this.Results = Results;
        this.EntityIdDimension = EntityIdDimension;

    }



    /// <summary>
    /// Query results
    /// </summary>
    /// <value>Query results</value>
    [JsonPropertyName("results")]
    public List<ConversationActivityData> Results { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationActivityResponse {\n");

        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  EntityIdDimension: ").Append(EntityIdDimension).Append("\n");
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
        return Equals(obj as ConversationActivityResponse);
    }

    /// <summary>
    /// Returns true if ConversationActivityResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationActivityResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationActivityResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
            ) &&
            (
                EntityIdDimension == other.EntityIdDimension ||
                EntityIdDimension != null &&
                EntityIdDimension.Equals(other.EntityIdDimension)
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
            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (EntityIdDimension != null)
            {
                hash = hash * 59 + EntityIdDimension.GetHashCode();
            }

            return hash;
        }
    }
}
