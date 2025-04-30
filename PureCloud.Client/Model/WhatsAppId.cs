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
    /// User information for a WhatsApp account
    /// </summary>
    [DataContract]
    public partial class WhatsAppId :  IEquatable<WhatsAppId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppId" /> class.
        /// </summary>
        /// <param name="PhoneNumber">The phone number associated with this WhatsApp account.</param>
        /// <param name="DisplayName">The displayName of this person&#39;s account in WhatsApp.</param>
        public WhatsAppId(PhoneNumber PhoneNumber = null, string DisplayName = null)
        {
            this.PhoneNumber = PhoneNumber;
            this.DisplayName = DisplayName;
            
        }
        


        /// <summary>
        /// The phone number associated with this WhatsApp account
        /// </summary>
        /// <value>The phone number associated with this WhatsApp account</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public PhoneNumber PhoneNumber { get; set; }



        /// <summary>
        /// The displayName of this person&#39;s account in WhatsApp
        /// </summary>
        /// <value>The displayName of this person&#39;s account in WhatsApp</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppId {\n");

            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(obj as WhatsAppId);
        }

        /// <summary>
        /// Returns true if WhatsAppId instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
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
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();

                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                return hash;
            }
        }
    }

}
