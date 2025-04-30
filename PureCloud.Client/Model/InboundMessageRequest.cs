using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// InboundMessageRequest
    /// </summary>
    [DataContract]
    public partial class InboundMessageRequest :  IEquatable<InboundMessageRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundMessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundMessageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundMessageRequest" /> class.
        /// </summary>
        /// <param name="QueueId">The ID of the queue to use for routing the email conversation. This field is mutually exclusive with flowId.</param>
        /// <param name="FlowId">The ID of the flow to use for routing email conversation. This field is mutually exclusive with queueId.</param>
        /// <param name="Provider">The name of the provider that is sourcing the email such as Oracle, Salesforce, etc. (required).</param>
        /// <param name="SkillIds">The list of skill ID&#39;s to use for routing..</param>
        /// <param name="LanguageId">The ID of the language to use for routing..</param>
        /// <param name="Priority">The priority to assign to the conversation for routing..</param>
        /// <param name="Attributes">The list of attributes to associate with the customer participant..</param>
        /// <param name="ToAddress">The email address of the recipient of the email..</param>
        /// <param name="ToName">The name of the recipient of the email..</param>
        /// <param name="FromAddress">The email address of the sender of the email..</param>
        /// <param name="FromName">The name of the sender of the email..</param>
        /// <param name="Subject">The subject of the email.</param>
        public InboundMessageRequest(string QueueId = null, string FlowId = null, string Provider = null, List<string> SkillIds = null, string LanguageId = null, int? Priority = null, Dictionary<string, string> Attributes = null, string ToAddress = null, string ToName = null, string FromAddress = null, string FromName = null, string Subject = null)
        {
            this.QueueId = QueueId;
            this.FlowId = FlowId;
            this.Provider = Provider;
            this.SkillIds = SkillIds;
            this.LanguageId = LanguageId;
            this.Priority = Priority;
            this.Attributes = Attributes;
            this.ToAddress = ToAddress;
            this.ToName = ToName;
            this.FromAddress = FromAddress;
            this.FromName = FromName;
            this.Subject = Subject;
            
        }
        


        /// <summary>
        /// The ID of the queue to use for routing the email conversation. This field is mutually exclusive with flowId
        /// </summary>
        /// <value>The ID of the queue to use for routing the email conversation. This field is mutually exclusive with flowId</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The ID of the flow to use for routing email conversation. This field is mutually exclusive with queueId
        /// </summary>
        /// <value>The ID of the flow to use for routing email conversation. This field is mutually exclusive with queueId</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }



        /// <summary>
        /// The name of the provider that is sourcing the email such as Oracle, Salesforce, etc.
        /// </summary>
        /// <value>The name of the provider that is sourcing the email such as Oracle, Salesforce, etc.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }



        /// <summary>
        /// The list of skill ID&#39;s to use for routing.
        /// </summary>
        /// <value>The list of skill ID&#39;s to use for routing.</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }



        /// <summary>
        /// The ID of the language to use for routing.
        /// </summary>
        /// <value>The ID of the language to use for routing.</value>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }



        /// <summary>
        /// The priority to assign to the conversation for routing.
        /// </summary>
        /// <value>The priority to assign to the conversation for routing.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// The list of attributes to associate with the customer participant.
        /// </summary>
        /// <value>The list of attributes to associate with the customer participant.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }



        /// <summary>
        /// The email address of the recipient of the email.
        /// </summary>
        /// <value>The email address of the recipient of the email.</value>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public string ToAddress { get; set; }



        /// <summary>
        /// The name of the recipient of the email.
        /// </summary>
        /// <value>The name of the recipient of the email.</value>
        [DataMember(Name="toName", EmitDefaultValue=false)]
        public string ToName { get; set; }



        /// <summary>
        /// The email address of the sender of the email.
        /// </summary>
        /// <value>The email address of the sender of the email.</value>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public string FromAddress { get; set; }



        /// <summary>
        /// The name of the sender of the email.
        /// </summary>
        /// <value>The name of the sender of the email.</value>
        [DataMember(Name="fromName", EmitDefaultValue=false)]
        public string FromName { get; set; }



        /// <summary>
        /// The subject of the email
        /// </summary>
        /// <value>The subject of the email</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundMessageRequest {\n");

            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  ToName: ").Append(ToName).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  FromName: ").Append(FromName).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InboundMessageRequest);
        }

        /// <summary>
        /// Returns true if InboundMessageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InboundMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundMessageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.LanguageId == other.LanguageId ||
                    this.LanguageId != null &&
                    this.LanguageId.Equals(other.LanguageId)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.ToAddress == other.ToAddress ||
                    this.ToAddress != null &&
                    this.ToAddress.Equals(other.ToAddress)
                ) &&
                (
                    this.ToName == other.ToName ||
                    this.ToName != null &&
                    this.ToName.Equals(other.ToName)
                ) &&
                (
                    this.FromAddress == other.FromAddress ||
                    this.FromAddress != null &&
                    this.FromAddress.Equals(other.FromAddress)
                ) &&
                (
                    this.FromName == other.FromName ||
                    this.FromName != null &&
                    this.FromName.Equals(other.FromName)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
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
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();

                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();

                if (this.ToName != null)
                    hash = hash * 59 + this.ToName.GetHashCode();

                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();

                if (this.FromName != null)
                    hash = hash * 59 + this.FromName.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                return hash;
            }
        }
    }

}
