using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A criteria type that can be used in tandem with other criteria type to create queries of executionData
/// </summary>

public partial class QueryCriteria : IEquatable<QueryCriteria>
{
    /// <summary>
    /// The is the name of the criteria that can be queried.
    /// </summary>
    /// <value>The is the name of the criteria that can be queried.</value>
    
    public enum CriteriaKeyEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Flowstartdatetime for "FlowStartDateTime"
        /// </summary>
        [EnumMember(Value = "FlowStartDateTime")]
        Flowstartdatetime,

        /// <summary>
        /// Enum Flowenddatetime for "FlowEndDateTime"
        /// </summary>
        [EnumMember(Value = "FlowEndDateTime")]
        Flowenddatetime,

        /// <summary>
        /// Enum Conversationid for "ConversationId"
        /// </summary>
        [EnumMember(Value = "ConversationId")]
        Conversationid,

        /// <summary>
        /// Enum Workitemid for "WorkitemId"
        /// </summary>
        [EnumMember(Value = "WorkitemId")]
        Workitemid,

        /// <summary>
        /// Enum Flowtype for "FlowType"
        /// </summary>
        [EnumMember(Value = "FlowType")]
        Flowtype,

        /// <summary>
        /// Enum Flowid for "FlowId"
        /// </summary>
        [EnumMember(Value = "FlowId")]
        Flowid,

        /// <summary>
        /// Enum Flowerrorreason for "FlowErrorReason"
        /// </summary>
        [EnumMember(Value = "FlowErrorReason")]
        Flowerrorreason,

        /// <summary>
        /// Enum Flowwarningreason for "FlowWarningReason"
        /// </summary>
        [EnumMember(Value = "FlowWarningReason")]
        Flowwarningreason,

        /// <summary>
        /// Enum Flowalternateexecutionid for "FlowAlternateExecutionId"
        /// </summary>
        [EnumMember(Value = "FlowAlternateExecutionId")]
        Flowalternateexecutionid,

        /// <summary>
        /// Enum Flowobjectexecutionid for "FlowObjectExecutionId"
        /// </summary>
        [EnumMember(Value = "FlowObjectExecutionId")]
        Flowobjectexecutionid,

        /// <summary>
        /// Enum Flowactionid for "FlowActionId"
        /// </summary>
        [EnumMember(Value = "FlowActionId")]
        Flowactionid,

        /// <summary>
        /// Enum Flowactiontype for "FlowActionType"
        /// </summary>
        [EnumMember(Value = "FlowActionType")]
        Flowactiontype,

        /// <summary>
        /// Enum Flowactionoutputpathid for "FlowActionOutputPathId"
        /// </summary>
        [EnumMember(Value = "FlowActionOutputPathId")]
        Flowactionoutputpathid,

        /// <summary>
        /// Enum Flowactionoutputpathname for "FlowActionOutputPathName"
        /// </summary>
        [EnumMember(Value = "FlowActionOutputPathName")]
        Flowactionoutputpathname,

        /// <summary>
        /// Enum Flowactionidoutputpathid for "FlowActionIdOutputPathId"
        /// </summary>
        [EnumMember(Value = "FlowActionIdOutputPathId")]
        Flowactionidoutputpathid,

        /// <summary>
        /// Enum Flowactionidoutputpathname for "FlowActionIdOutputPathName"
        /// </summary>
        [EnumMember(Value = "FlowActionIdOutputPathName")]
        Flowactionidoutputpathname,

        /// <summary>
        /// Enum Flowactiontypeoutputpathid for "FlowActionTypeOutputPathId"
        /// </summary>
        [EnumMember(Value = "FlowActionTypeOutputPathId")]
        Flowactiontypeoutputpathid,

        /// <summary>
        /// Enum Flowactiontypeoutputpathname for "FlowActionTypeOutputPathName"
        /// </summary>
        [EnumMember(Value = "FlowActionTypeOutputPathName")]
        Flowactiontypeoutputpathname,

        /// <summary>
        /// Enum Botid for "BotId"
        /// </summary>
        [EnumMember(Value = "BotId")]
        Botid,

        /// <summary>
        /// Enum Boterrorreason for "BotErrorReason"
        /// </summary>
        [EnumMember(Value = "BotErrorReason")]
        Boterrorreason,

        /// <summary>
        /// Enum Botflowexecutionid for "BotFlowExecutionId"
        /// </summary>
        [EnumMember(Value = "BotFlowExecutionId")]
        Botflowexecutionid,

        /// <summary>
        /// Enum Botobjectexecutionid for "BotObjectExecutionId"
        /// </summary>
        [EnumMember(Value = "BotObjectExecutionId")]
        Botobjectexecutionid
    }
    /// <summary>
    /// Gets or Sets CriteriaGroups
    /// </summary>
    
    public enum CriteriaGroupsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Flow for "flow"
        /// </summary>
        [EnumMember(Value = "flow")]
        Flow,

        /// <summary>
        /// Enum Bot for "bot"
        /// </summary>
        [EnumMember(Value = "bot")]
        Bot
    }
    /// <summary>
    /// The type of data for the criteria (string, int, etc).
    /// </summary>
    /// <value>The type of data for the criteria (string, int, etc).</value>
    
    public enum DataTypeEnum
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
        /// Enum Guid for "guid"
        /// </summary>
        [EnumMember(Value = "guid")]
        Guid,

        /// <summary>
        /// Enum Datetime for "dateTime"
        /// </summary>
        [EnumMember(Value = "dateTime")]
        Datetime
    }
    /// <summary>
    /// The is the name of the criteria that can be queried.
    /// </summary>
    /// <value>The is the name of the criteria that can be queried.</value>
    [JsonPropertyName("criteriaKey")]
    public CriteriaKeyEnum? CriteriaKey { get; set; }
    /// <summary>
    /// The type of data for the criteria (string, int, etc).
    /// </summary>
    /// <value>The type of data for the criteria (string, int, etc).</value>
    [JsonPropertyName("dataType")]
    public DataTypeEnum? DataType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryCriteria" /> class.
    /// </summary>
    /// <param name="CriteriaKey">The is the name of the criteria that can be queried..</param>
    /// <param name="CriteriaGroups">The executionData type that this criteria item can be used on..</param>
    /// <param name="Description">The is the description of the criteria..</param>
    /// <param name="Operators">A list of operators that can be used on this criteria..</param>
    /// <param name="DataType">The type of data for the criteria (string, int, etc)..</param>
    /// <param name="CategoryInfo">A logical grouping and display order for this item..</param>
    public QueryCriteria(CriteriaKeyEnum? CriteriaKey = null, List<CriteriaGroupsEnum> CriteriaGroups = null, string Description = null, List<string> Operators = null, DataTypeEnum? DataType = null, CriteriaCategoryInfo CategoryInfo = null)
    {
        this.CriteriaKey = CriteriaKey;
        this.CriteriaGroups = CriteriaGroups;
        this.Description = Description;
        this.Operators = Operators;
        this.DataType = DataType;
        this.CategoryInfo = CategoryInfo;

    }





    /// <summary>
    /// The executionData type that this criteria item can be used on.
    /// </summary>
    /// <value>The executionData type that this criteria item can be used on.</value>
    [JsonPropertyName("criteriaGroups")]
    public List<CriteriaGroupsEnum> CriteriaGroups { get; set; }



    /// <summary>
    /// The is the description of the criteria.
    /// </summary>
    /// <value>The is the description of the criteria.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// A list of operators that can be used on this criteria.
    /// </summary>
    /// <value>A list of operators that can be used on this criteria.</value>
    [JsonPropertyName("operators")]
    public List<string> Operators { get; set; }





    /// <summary>
    /// A logical grouping and display order for this item.
    /// </summary>
    /// <value>A logical grouping and display order for this item.</value>
    [JsonPropertyName("categoryInfo")]
    public CriteriaCategoryInfo CategoryInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryCriteria {\n");

        sb.Append("  CriteriaKey: ").Append(CriteriaKey).Append("\n");
        sb.Append("  CriteriaGroups: ").Append(CriteriaGroups).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Operators: ").Append(Operators).Append("\n");
        sb.Append("  DataType: ").Append(DataType).Append("\n");
        sb.Append("  CategoryInfo: ").Append(CategoryInfo).Append("\n");
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
        return Equals(obj as QueryCriteria);
    }

    /// <summary>
    /// Returns true if QueryCriteria instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryCriteria to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryCriteria other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CriteriaKey == other.CriteriaKey ||
                CriteriaKey != null &&
                CriteriaKey.Equals(other.CriteriaKey)
            ) &&
            (
                CriteriaGroups == other.CriteriaGroups ||
                CriteriaGroups != null &&
                CriteriaGroups.SequenceEqual(other.CriteriaGroups)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Operators == other.Operators ||
                Operators != null &&
                Operators.SequenceEqual(other.Operators)
            ) &&
            (
                DataType == other.DataType ||
                DataType != null &&
                DataType.Equals(other.DataType)
            ) &&
            (
                CategoryInfo == other.CategoryInfo ||
                CategoryInfo != null &&
                CategoryInfo.Equals(other.CategoryInfo)
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
            if (CriteriaKey != null)
            {
                hash = hash * 59 + CriteriaKey.GetHashCode();
            }

            if (CriteriaGroups != null)
            {
                hash = hash * 59 + CriteriaGroups.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Operators != null)
            {
                hash = hash * 59 + Operators.GetHashCode();
            }

            if (DataType != null)
            {
                hash = hash * 59 + DataType.GetHashCode();
            }

            if (CategoryInfo != null)
            {
                hash = hash * 59 + CategoryInfo.GetHashCode();
            }

            return hash;
        }
    }
}
