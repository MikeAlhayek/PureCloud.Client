using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// SurveyAggregateQueryPredicate
    /// </summary>
    [DataContract]
    public partial class SurveyAggregateQueryPredicate : IEquatable<SurveyAggregateQueryPredicate>
    {
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
            /// Enum Dimension for "dimension"
            /// </summary>
            [EnumMember(Value = "dimension")]
            Dimension,

            /// <summary>
            /// Enum Property for "property"
            /// </summary>
            [EnumMember(Value = "property")]
            Property,

            /// <summary>
            /// Enum Metric for "metric"
            /// </summary>
            [EnumMember(Value = "metric")]
            Metric
        }
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum DimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,

            /// <summary>
            /// Enum Conversationid for "conversationId"
            /// </summary>
            [EnumMember(Value = "conversationId")]
            Conversationid,

            /// <summary>
            /// Enum Divisionid for "divisionId"
            /// </summary>
            [EnumMember(Value = "divisionId")]
            Divisionid,

            /// <summary>
            /// Enum Externalcontactid for "externalContactId"
            /// </summary>
            [EnumMember(Value = "externalContactId")]
            Externalcontactid,

            /// <summary>
            /// Enum Mediatype for "mediaType"
            /// </summary>
            [EnumMember(Value = "mediaType")]
            Mediatype,

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
            /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
            /// </summary>
            [EnumMember(Value = "requestedRoutingSkillId")]
            Requestedroutingskillid,

            /// <summary>
            /// Enum Surveyanswerid for "surveyAnswerId"
            /// </summary>
            [EnumMember(Value = "surveyAnswerId")]
            Surveyanswerid,

            /// <summary>
            /// Enum Surveycreateddate for "surveyCreatedDate"
            /// </summary>
            [EnumMember(Value = "surveyCreatedDate")]
            Surveycreateddate,

            /// <summary>
            /// Enum Surveyerrorreason for "surveyErrorReason"
            /// </summary>
            [EnumMember(Value = "surveyErrorReason")]
            Surveyerrorreason,

            /// <summary>
            /// Enum Surveyformcontextid for "surveyFormContextId"
            /// </summary>
            [EnumMember(Value = "surveyFormContextId")]
            Surveyformcontextid,

            /// <summary>
            /// Enum Surveyformid for "surveyFormId"
            /// </summary>
            [EnumMember(Value = "surveyFormId")]
            Surveyformid,

            /// <summary>
            /// Enum Surveyformname for "surveyFormName"
            /// </summary>
            [EnumMember(Value = "surveyFormName")]
            Surveyformname,

            /// <summary>
            /// Enum Surveyid for "surveyId"
            /// </summary>
            [EnumMember(Value = "surveyId")]
            Surveyid,

            /// <summary>
            /// Enum Surveypartialresponse for "surveyPartialResponse"
            /// </summary>
            [EnumMember(Value = "surveyPartialResponse")]
            Surveypartialresponse,

            /// <summary>
            /// Enum Surveypreviousstatus for "surveyPreviousStatus"
            /// </summary>
            [EnumMember(Value = "surveyPreviousStatus")]
            Surveypreviousstatus,

            /// <summary>
            /// Enum Surveypromoterscore for "surveyPromoterScore"
            /// </summary>
            [EnumMember(Value = "surveyPromoterScore")]
            Surveypromoterscore,

            /// <summary>
            /// Enum Surveyquestiongroupid for "surveyQuestionGroupId"
            /// </summary>
            [EnumMember(Value = "surveyQuestionGroupId")]
            Surveyquestiongroupid,

            /// <summary>
            /// Enum Surveyquestionid for "surveyQuestionId"
            /// </summary>
            [EnumMember(Value = "surveyQuestionId")]
            Surveyquestionid,

            /// <summary>
            /// Enum Surveystatus for "surveyStatus"
            /// </summary>
            [EnumMember(Value = "surveyStatus")]
            Surveystatus,

            /// <summary>
            /// Enum Surveytype for "surveyType"
            /// </summary>
            [EnumMember(Value = "surveyType")]
            Surveytype,

            /// <summary>
            /// Enum Teamid for "teamId"
            /// </summary>
            [EnumMember(Value = "teamId")]
            Teamid,

            /// <summary>
            /// Enum Userid for "userId"
            /// </summary>
            [EnumMember(Value = "userId")]
            Userid,

            /// <summary>
            /// Enum Wrapupcode for "wrapUpCode"
            /// </summary>
            [EnumMember(Value = "wrapUpCode")]
            Wrapupcode
        }
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
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
            /// Enum Matches for "matches"
            /// </summary>
            [EnumMember(Value = "matches")]
            Matches,

            /// <summary>
            /// Enum Exists for "exists"
            /// </summary>
            [EnumMember(Value = "exists")]
            Exists,

            /// <summary>
            /// Enum Notexists for "notExists"
            /// </summary>
            [EnumMember(Value = "notExists")]
            Notexists
        }
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [DataMember(Name = "dimension", EmitDefaultValue = false)]
        public DimensionEnum? Dimension { get; set; }
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyAggregateQueryPredicate" /> class.
        /// </summary>
        /// <param name="Type">Optional type, can usually be inferred.</param>
        /// <param name="Dimension">Left hand side for dimension predicates.</param>
        /// <param name="Operator">Optional operator, default is matches.</param>
        /// <param name="Value">Right hand side for dimension predicates.</param>
        /// <param name="Range">Right hand side for dimension predicates.</param>
        public SurveyAggregateQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
        {
            this.Type = Type;
            this.Dimension = Dimension;
            this.Operator = Operator;
            this.Value = Value;
            this.Range = Range;

        }









        /// <summary>
        /// Right hand side for dimension predicates
        /// </summary>
        /// <value>Right hand side for dimension predicates</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }



        /// <summary>
        /// Right hand side for dimension predicates
        /// </summary>
        /// <value>Right hand side for dimension predicates</value>
        [DataMember(Name = "range", EmitDefaultValue = false)]
        public NumericRange Range { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurveyAggregateQueryPredicate {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as SurveyAggregateQueryPredicate);
        }

        /// <summary>
        /// Returns true if SurveyAggregateQueryPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of SurveyAggregateQueryPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveyAggregateQueryPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();

                return hash;
            }
        }
    }

}
