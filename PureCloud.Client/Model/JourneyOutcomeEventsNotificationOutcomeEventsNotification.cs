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
    /// JourneyOutcomeEventsNotificationOutcomeEventsNotification
    /// </summary>
    [DataContract]
    public partial class JourneyOutcomeEventsNotificationOutcomeEventsNotification :  IEquatable<JourneyOutcomeEventsNotificationOutcomeEventsNotification>
    {
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Outcomeachievedevent for "OutcomeAchievedEvent"
            /// </summary>
            [EnumMember(Value = "OutcomeAchievedEvent")]
            Outcomeachievedevent,
            
            /// <summary>
            /// Enum Outcomeattributionevent for "OutcomeAttributionEvent"
            /// </summary>
            [EnumMember(Value = "OutcomeAttributionEvent")]
            Outcomeattributionevent
        }
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationOutcomeEventsNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="ExternalContact">ExternalContact.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="CustomerId">CustomerId.</param>
        /// <param name="CustomerIdType">CustomerIdType.</param>
        /// <param name="Session">Session.</param>
        /// <param name="EventType">EventType.</param>
        /// <param name="OutcomeAchievedEvent">OutcomeAchievedEvent.</param>
        /// <param name="OutcomeAttributionEventMessage">OutcomeAttributionEventMessage.</param>
        public JourneyOutcomeEventsNotificationOutcomeEventsNotification(string Id = null, string CorrelationId = null, JourneyOutcomeEventsNotificationExternalContact ExternalContact = null, DateTime? CreatedDate = null, string CustomerId = null, string CustomerIdType = null, JourneyOutcomeEventsNotificationSession Session = null, EventTypeEnum? EventType = null, JourneyOutcomeEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent = null, JourneyOutcomeEventsNotificationOutcomeAttributionMessage OutcomeAttributionEventMessage = null)
        {
            this.Id = Id;
            this.CorrelationId = CorrelationId;
            this.ExternalContact = ExternalContact;
            this.CreatedDate = CreatedDate;
            this.CustomerId = CustomerId;
            this.CustomerIdType = CustomerIdType;
            this.Session = Session;
            this.EventType = EventType;
            this.OutcomeAchievedEvent = OutcomeAchievedEvent;
            this.OutcomeAttributionEventMessage = OutcomeAttributionEventMessage;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }



        /// <summary>
        /// Gets or Sets ExternalContact
        /// </summary>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public JourneyOutcomeEventsNotificationExternalContact ExternalContact { get; set; }



        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }



        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }



        /// <summary>
        /// Gets or Sets CustomerIdType
        /// </summary>
        [DataMember(Name="customerIdType", EmitDefaultValue=false)]
        public string CustomerIdType { get; set; }



        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public JourneyOutcomeEventsNotificationSession Session { get; set; }





        /// <summary>
        /// Gets or Sets OutcomeAchievedEvent
        /// </summary>
        [DataMember(Name="outcomeAchievedEvent", EmitDefaultValue=false)]
        public JourneyOutcomeEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent { get; set; }



        /// <summary>
        /// Gets or Sets OutcomeAttributionEventMessage
        /// </summary>
        [DataMember(Name="outcomeAttributionEventMessage", EmitDefaultValue=false)]
        public JourneyOutcomeEventsNotificationOutcomeAttributionMessage OutcomeAttributionEventMessage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyOutcomeEventsNotificationOutcomeEventsNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  OutcomeAchievedEvent: ").Append(OutcomeAchievedEvent).Append("\n");
            sb.Append("  OutcomeAttributionEventMessage: ").Append(OutcomeAttributionEventMessage).Append("\n");
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
            return this.Equals(obj as JourneyOutcomeEventsNotificationOutcomeEventsNotification);
        }

        /// <summary>
        /// Returns true if JourneyOutcomeEventsNotificationOutcomeEventsNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyOutcomeEventsNotificationOutcomeEventsNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyOutcomeEventsNotificationOutcomeEventsNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.ExternalContact == other.ExternalContact ||
                    this.ExternalContact != null &&
                    this.ExternalContact.Equals(other.ExternalContact)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) &&
                (
                    this.CustomerIdType == other.CustomerIdType ||
                    this.CustomerIdType != null &&
                    this.CustomerIdType.Equals(other.CustomerIdType)
                ) &&
                (
                    this.Session == other.Session ||
                    this.Session != null &&
                    this.Session.Equals(other.Session)
                ) &&
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) &&
                (
                    this.OutcomeAchievedEvent == other.OutcomeAchievedEvent ||
                    this.OutcomeAchievedEvent != null &&
                    this.OutcomeAchievedEvent.Equals(other.OutcomeAchievedEvent)
                ) &&
                (
                    this.OutcomeAttributionEventMessage == other.OutcomeAttributionEventMessage ||
                    this.OutcomeAttributionEventMessage != null &&
                    this.OutcomeAttributionEventMessage.Equals(other.OutcomeAttributionEventMessage)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();

                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();

                if (this.CustomerIdType != null)
                    hash = hash * 59 + this.CustomerIdType.GetHashCode();

                if (this.Session != null)
                    hash = hash * 59 + this.Session.GetHashCode();

                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();

                if (this.OutcomeAchievedEvent != null)
                    hash = hash * 59 + this.OutcomeAchievedEvent.GetHashCode();

                if (this.OutcomeAttributionEventMessage != null)
                    hash = hash * 59 + this.OutcomeAttributionEventMessage.GetHashCode();

                return hash;
            }
        }
    }

}
