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
    /// QueueObservationQueryClause
    /// </summary>
    [DataContract]
    public partial class QueueObservationQueryClause :  IEquatable<QueueObservationQueryClause>
    {
        /// <summary>
        /// Boolean operation to apply to the provided predicates
        /// </summary>
        /// <value>Boolean operation to apply to the provided predicates</value>
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
            /// Enum And for "and"
            /// </summary>
            [EnumMember(Value = "and")]
            And,
            
            /// <summary>
            /// Enum Or for "or"
            /// </summary>
            [EnumMember(Value = "or")]
            Or
        }
        /// <summary>
        /// Boolean operation to apply to the provided predicates
        /// </summary>
        /// <value>Boolean operation to apply to the provided predicates</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueObservationQueryClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueueObservationQueryClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueObservationQueryClause" /> class.
        /// </summary>
        /// <param name="Type">Boolean operation to apply to the provided predicates (required).</param>
        /// <param name="Predicates">Like a three-word sentence: (attribute-name) (operator) (target-value). (required).</param>
        public QueueObservationQueryClause(TypeEnum? Type = null, List<QueueObservationQueryPredicate> Predicates = null)
        {
            this.Type = Type;
            this.Predicates = Predicates;
            
        }
        




        /// <summary>
        /// Like a three-word sentence: (attribute-name) (operator) (target-value).
        /// </summary>
        /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value).</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<QueueObservationQueryPredicate> Predicates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueObservationQueryClause {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
            return this.Equals(obj as QueueObservationQueryClause);
        }

        /// <summary>
        /// Returns true if QueueObservationQueryClause instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueObservationQueryClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueObservationQueryClause other)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();

                return hash;
            }
        }
    }

}
