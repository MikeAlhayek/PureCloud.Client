using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerRulesetConfigChangeCondition
/// </summary>
[DataContract]
public partial class DialerRulesetConfigChangeCondition : IEquatable<DialerRulesetConfigChangeCondition>
{
    /// <summary>
    /// Determines the type of the value associated with the condition
    /// </summary>
    /// <value>Determines the type of the value associated with the condition</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ValueTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum String for "STRING"
        /// </summary>
        [EnumMember(Value = "STRING")]
        String,

        /// <summary>
        /// Enum Numeric for "NUMERIC"
        /// </summary>
        [EnumMember(Value = "NUMERIC")]
        Numeric,

        /// <summary>
        /// Enum Datetime for "DATETIME"
        /// </summary>
        [EnumMember(Value = "DATETIME")]
        Datetime,

        /// <summary>
        /// Enum Period for "PERIOD"
        /// </summary>
        [EnumMember(Value = "PERIOD")]
        Period
    }
    /// <summary>
    /// An operation type for condition evaluation
    /// </summary>
    /// <value>An operation type for condition evaluation</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Equals for "EQUALS"
        /// </summary>
        [EnumMember(Value = "EQUALS")]
        Equals,

        /// <summary>
        /// Enum LessThan for "LESS_THAN"
        /// </summary>
        [EnumMember(Value = "LESS_THAN")]
        LessThan,

        /// <summary>
        /// Enum LessThanEquals for "LESS_THAN_EQUALS"
        /// </summary>
        [EnumMember(Value = "LESS_THAN_EQUALS")]
        LessThanEquals,

        /// <summary>
        /// Enum GreaterThan for "GREATER_THAN"
        /// </summary>
        [EnumMember(Value = "GREATER_THAN")]
        GreaterThan,

        /// <summary>
        /// Enum GreaterThanEquals for "GREATER_THAN_EQUALS"
        /// </summary>
        [EnumMember(Value = "GREATER_THAN_EQUALS")]
        GreaterThanEquals,

        /// <summary>
        /// Enum Contains for "CONTAINS"
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        Contains,

        /// <summary>
        /// Enum BeginsWith for "BEGINS_WITH"
        /// </summary>
        [EnumMember(Value = "BEGINS_WITH")]
        BeginsWith,

        /// <summary>
        /// Enum EndsWith for "ENDS_WITH"
        /// </summary>
        [EnumMember(Value = "ENDS_WITH")]
        EndsWith,

        /// <summary>
        /// Enum Before for "BEFORE"
        /// </summary>
        [EnumMember(Value = "BEFORE")]
        Before,

        /// <summary>
        /// Enum After for "AFTER"
        /// </summary>
        [EnumMember(Value = "AFTER")]
        After
    }
    /// <summary>
    /// Determines the type of the property associated with the condition
    /// </summary>
    /// <value>Determines the type of the property associated with the condition</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PropertyTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum AttemptByColumn for "LAST_ATTEMPT_BY_COLUMN"
        /// </summary>
        [EnumMember(Value = "LAST_ATTEMPT_BY_COLUMN")]
        AttemptByColumn,

        /// <summary>
        /// Enum AttemptOverall for "LAST_ATTEMPT_OVERALL"
        /// </summary>
        [EnumMember(Value = "LAST_ATTEMPT_OVERALL")]
        AttemptOverall,

        /// <summary>
        /// Enum ResultByColumn for "LAST_RESULT_BY_COLUMN"
        /// </summary>
        [EnumMember(Value = "LAST_RESULT_BY_COLUMN")]
        ResultByColumn,

        /// <summary>
        /// Enum ResultOverall for "LAST_RESULT_OVERALL"
        /// </summary>
        [EnumMember(Value = "LAST_RESULT_OVERALL")]
        ResultOverall
    }
    /// <summary>
    /// Determines the type of the value associated with the condition
    /// </summary>
    /// <value>Determines the type of the value associated with the condition</value>
    [DataMember(Name = "valueType", EmitDefaultValue = false)]
    public ValueTypeEnum? ValueType { get; set; }
    /// <summary>
    /// An operation type for condition evaluation
    /// </summary>
    /// <value>An operation type for condition evaluation</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Determines the type of the property associated with the condition
    /// </summary>
    /// <value>Determines the type of the property associated with the condition</value>
    [DataMember(Name = "propertyType", EmitDefaultValue = false)]
    public PropertyTypeEnum? PropertyType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeCondition" /> class.
    /// </summary>
    /// <param name="DataAction">A UriReference for a resource.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Type">The type of the condition.</param>
    /// <param name="Inverted">Indicates whether to evaluate for the opposite of the stated condition; default is false.</param>
    /// <param name="AttributeName">An attribute name associated with the condition (applies only to certain rule conditions).</param>
    /// <param name="Value">A value associated with the condition.</param>
    /// <param name="ValueType">Determines the type of the value associated with the condition.</param>
    /// <param name="Operator">An operation type for condition evaluation.</param>
    /// <param name="Codes">List of wrap-up code identifiers (used only in conditions of type &#39;wrapupCondition&#39;).</param>
    /// <param name="PropertyType">Determines the type of the property associated with the condition.</param>
    /// <param name="Property">A value associated with the property type of this condition.</param>
    /// <param name="DataNotFoundResolution">The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition..</param>
    /// <param name="ContactIdField">The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition..</param>
    /// <param name="CallAnalysisResultField">The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition..</param>
    /// <param name="AgentWrapupField">The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition..</param>
    /// <param name="ContactColumnToDataActionFieldMappings">A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition..</param>
    /// <param name="Predicates">A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition..</param>
    public DialerRulesetConfigChangeCondition(DialerRulesetConfigChangeUriReference DataAction = null, Dictionary<string, object> AdditionalProperties = null, string Type = null, bool? Inverted = null, string AttributeName = null, string Value = null, ValueTypeEnum? ValueType = null, OperatorEnum? Operator = null, List<string> Codes = null, PropertyTypeEnum? PropertyType = null, string Property = null, bool? DataNotFoundResolution = null, string ContactIdField = null, string CallAnalysisResultField = null, string AgentWrapupField = null, List<DialerRulesetConfigChangeContactColumnToDataActionFieldMapping> ContactColumnToDataActionFieldMappings = null, List<DialerRulesetConfigChangeDataActionConditionPredicate> Predicates = null)
    {
        this.DataAction = DataAction;
        this.AdditionalProperties = AdditionalProperties;
        this.Type = Type;
        this.Inverted = Inverted;
        this.AttributeName = AttributeName;
        this.Value = Value;
        this.ValueType = ValueType;
        this.Operator = Operator;
        this.Codes = Codes;
        this.PropertyType = PropertyType;
        this.Property = Property;
        this.DataNotFoundResolution = DataNotFoundResolution;
        this.ContactIdField = ContactIdField;
        this.CallAnalysisResultField = CallAnalysisResultField;
        this.AgentWrapupField = AgentWrapupField;
        this.ContactColumnToDataActionFieldMappings = ContactColumnToDataActionFieldMappings;
        this.Predicates = Predicates;

    }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [DataMember(Name = "dataAction", EmitDefaultValue = false)]
    public DialerRulesetConfigChangeUriReference DataAction { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The type of the condition
    /// </summary>
    /// <value>The type of the condition</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// Indicates whether to evaluate for the opposite of the stated condition; default is false
    /// </summary>
    /// <value>Indicates whether to evaluate for the opposite of the stated condition; default is false</value>
    [DataMember(Name = "inverted", EmitDefaultValue = false)]
    public bool? Inverted { get; set; }



    /// <summary>
    /// An attribute name associated with the condition (applies only to certain rule conditions)
    /// </summary>
    /// <value>An attribute name associated with the condition (applies only to certain rule conditions)</value>
    [DataMember(Name = "attributeName", EmitDefaultValue = false)]
    public string AttributeName { get; set; }



    /// <summary>
    /// A value associated with the condition
    /// </summary>
    /// <value>A value associated with the condition</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }







    /// <summary>
    /// List of wrap-up code identifiers (used only in conditions of type &#39;wrapupCondition&#39;)
    /// </summary>
    /// <value>List of wrap-up code identifiers (used only in conditions of type &#39;wrapupCondition&#39;)</value>
    [DataMember(Name = "codes", EmitDefaultValue = false)]
    public List<string> Codes { get; set; }





    /// <summary>
    /// A value associated with the property type of this condition
    /// </summary>
    /// <value>A value associated with the property type of this condition</value>
    [DataMember(Name = "property", EmitDefaultValue = false)]
    public string Property { get; set; }



    /// <summary>
    /// The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition.
    /// </summary>
    /// <value>The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition.</value>
    [DataMember(Name = "dataNotFoundResolution", EmitDefaultValue = false)]
    public bool? DataNotFoundResolution { get; set; }



    /// <summary>
    /// The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition.
    /// </summary>
    /// <value>The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition.</value>
    [DataMember(Name = "contactIdField", EmitDefaultValue = false)]
    public string ContactIdField { get; set; }



    /// <summary>
    /// The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition.
    /// </summary>
    /// <value>The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition.</value>
    [DataMember(Name = "callAnalysisResultField", EmitDefaultValue = false)]
    public string CallAnalysisResultField { get; set; }



    /// <summary>
    /// The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition.
    /// </summary>
    /// <value>The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition.</value>
    [DataMember(Name = "agentWrapupField", EmitDefaultValue = false)]
    public string AgentWrapupField { get; set; }



    /// <summary>
    /// A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition.
    /// </summary>
    /// <value>A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition.</value>
    [DataMember(Name = "contactColumnToDataActionFieldMappings", EmitDefaultValue = false)]
    public List<DialerRulesetConfigChangeContactColumnToDataActionFieldMapping> ContactColumnToDataActionFieldMappings { get; set; }



    /// <summary>
    /// A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition.
    /// </summary>
    /// <value>A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition.</value>
    [DataMember(Name = "predicates", EmitDefaultValue = false)]
    public List<DialerRulesetConfigChangeDataActionConditionPredicate> Predicates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerRulesetConfigChangeCondition {\n");

        sb.Append("  DataAction: ").Append(DataAction).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Inverted: ").Append(Inverted).Append("\n");
        sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  ValueType: ").Append(ValueType).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Codes: ").Append(Codes).Append("\n");
        sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
        sb.Append("  Property: ").Append(Property).Append("\n");
        sb.Append("  DataNotFoundResolution: ").Append(DataNotFoundResolution).Append("\n");
        sb.Append("  ContactIdField: ").Append(ContactIdField).Append("\n");
        sb.Append("  CallAnalysisResultField: ").Append(CallAnalysisResultField).Append("\n");
        sb.Append("  AgentWrapupField: ").Append(AgentWrapupField).Append("\n");
        sb.Append("  ContactColumnToDataActionFieldMappings: ").Append(ContactColumnToDataActionFieldMappings).Append("\n");
        sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
        return this.Equals(obj as DialerRulesetConfigChangeCondition);
    }

    /// <summary>
    /// Returns true if DialerRulesetConfigChangeCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerRulesetConfigChangeCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerRulesetConfigChangeCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.DataAction == other.DataAction ||
                this.DataAction != null &&
                this.DataAction.Equals(other.DataAction)
            ) &&
            (
                this.AdditionalProperties == other.AdditionalProperties ||
                this.AdditionalProperties != null &&
                this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Inverted == other.Inverted ||
                this.Inverted != null &&
                this.Inverted.Equals(other.Inverted)
            ) &&
            (
                this.AttributeName == other.AttributeName ||
                this.AttributeName != null &&
                this.AttributeName.Equals(other.AttributeName)
            ) &&
            (
                this.Value == other.Value ||
                this.Value != null &&
                this.Value.Equals(other.Value)
            ) &&
            (
                this.ValueType == other.ValueType ||
                this.ValueType != null &&
                this.ValueType.Equals(other.ValueType)
            ) &&
            (
                this.Operator == other.Operator ||
                this.Operator != null &&
                this.Operator.Equals(other.Operator)
            ) &&
            (
                this.Codes == other.Codes ||
                this.Codes != null &&
                this.Codes.SequenceEqual(other.Codes)
            ) &&
            (
                this.PropertyType == other.PropertyType ||
                this.PropertyType != null &&
                this.PropertyType.Equals(other.PropertyType)
            ) &&
            (
                this.Property == other.Property ||
                this.Property != null &&
                this.Property.Equals(other.Property)
            ) &&
            (
                this.DataNotFoundResolution == other.DataNotFoundResolution ||
                this.DataNotFoundResolution != null &&
                this.DataNotFoundResolution.Equals(other.DataNotFoundResolution)
            ) &&
            (
                this.ContactIdField == other.ContactIdField ||
                this.ContactIdField != null &&
                this.ContactIdField.Equals(other.ContactIdField)
            ) &&
            (
                this.CallAnalysisResultField == other.CallAnalysisResultField ||
                this.CallAnalysisResultField != null &&
                this.CallAnalysisResultField.Equals(other.CallAnalysisResultField)
            ) &&
            (
                this.AgentWrapupField == other.AgentWrapupField ||
                this.AgentWrapupField != null &&
                this.AgentWrapupField.Equals(other.AgentWrapupField)
            ) &&
            (
                this.ContactColumnToDataActionFieldMappings == other.ContactColumnToDataActionFieldMappings ||
                this.ContactColumnToDataActionFieldMappings != null &&
                this.ContactColumnToDataActionFieldMappings.SequenceEqual(other.ContactColumnToDataActionFieldMappings)
            ) &&
            (
                this.Predicates == other.Predicates ||
                this.Predicates != null &&
                this.Predicates.SequenceEqual(other.Predicates)
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
            if (this.DataAction != null)
            {
                hash = hash * 59 + this.DataAction.GetHashCode();
            }

            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.Inverted != null)
            {
                hash = hash * 59 + this.Inverted.GetHashCode();
            }

            if (this.AttributeName != null)
            {
                hash = hash * 59 + this.AttributeName.GetHashCode();
            }

            if (this.Value != null)
            {
                hash = hash * 59 + this.Value.GetHashCode();
            }

            if (this.ValueType != null)
            {
                hash = hash * 59 + this.ValueType.GetHashCode();
            }

            if (this.Operator != null)
            {
                hash = hash * 59 + this.Operator.GetHashCode();
            }

            if (this.Codes != null)
            {
                hash = hash * 59 + this.Codes.GetHashCode();
            }

            if (this.PropertyType != null)
            {
                hash = hash * 59 + this.PropertyType.GetHashCode();
            }

            if (this.Property != null)
            {
                hash = hash * 59 + this.Property.GetHashCode();
            }

            if (this.DataNotFoundResolution != null)
            {
                hash = hash * 59 + this.DataNotFoundResolution.GetHashCode();
            }

            if (this.ContactIdField != null)
            {
                hash = hash * 59 + this.ContactIdField.GetHashCode();
            }

            if (this.CallAnalysisResultField != null)
            {
                hash = hash * 59 + this.CallAnalysisResultField.GetHashCode();
            }

            if (this.AgentWrapupField != null)
            {
                hash = hash * 59 + this.AgentWrapupField.GetHashCode();
            }

            if (this.ContactColumnToDataActionFieldMappings != null)
            {
                hash = hash * 59 + this.ContactColumnToDataActionFieldMappings.GetHashCode();
            }

            if (this.Predicates != null)
            {
                hash = hash * 59 + this.Predicates.GetHashCode();
            }

            return hash;
        }
    }
}
