using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// SessionEndDetails
    /// </summary>
    [DataContract]
    public partial class SessionEndDetails :  IEquatable<SessionEndDetails>
    {
        /// <summary>
        /// The type of termination handling that resulted in the session end. It can be either Exit or Disconnect
        /// </summary>
        /// <value>The type of termination handling that resulted in the session end. It can be either Exit or Disconnect</value>
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
            /// Enum Disconnect for "Disconnect"
            /// </summary>
            [EnumMember(Value = "Disconnect")]
            Disconnect,
            
            /// <summary>
            /// Enum Exit for "Exit"
            /// </summary>
            [EnumMember(Value = "Exit")]
            Exit
        }
        /// <summary>
        /// The type of termination handling that resulted in the session end. It can be either Exit or Disconnect
        /// </summary>
        /// <value>The type of termination handling that resulted in the session end. It can be either Exit or Disconnect</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEndDetails" /> class.
        /// </summary>
        /// <param name="Type">The type of termination handling that resulted in the session end. It can be either Exit or Disconnect.</param>
        /// <param name="Reason">The reason for termination action. It can be due to an error or normal flow execution.</param>
        public SessionEndDetails(TypeEnum? Type = null, string Reason = null)
        {
            this.Type = Type;
            this.Reason = Reason;
            
        }
        




        /// <summary>
        /// The reason for termination action. It can be due to an error or normal flow execution
        /// </summary>
        /// <value>The reason for termination action. It can be due to an error or normal flow execution</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionEndDetails {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as SessionEndDetails);
        }

        /// <summary>
        /// Returns true if SessionEndDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of SessionEndDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionEndDetails other)
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
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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

                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                return hash;
            }
        }
    }

}
