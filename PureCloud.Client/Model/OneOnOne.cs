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
    /// OneOnOne
    /// </summary>
    [DataContract]
    public partial class OneOnOne :  IEquatable<OneOnOne>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneOnOne" /> class.
        /// </summary>
        /// <param name="PinnedMessages">Room&#39;s pinned messages.</param>
        public OneOnOne(List<AddressableEntityRef> PinnedMessages = null)
        {
            this.PinnedMessages = PinnedMessages;
            
        }
        


        /// <summary>
        /// Room&#39;s pinned messages
        /// </summary>
        /// <value>Room&#39;s pinned messages</value>
        [DataMember(Name="pinnedMessages", EmitDefaultValue=false)]
        public List<AddressableEntityRef> PinnedMessages { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OneOnOne {\n");

            sb.Append("  PinnedMessages: ").Append(PinnedMessages).Append("\n");
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
            return this.Equals(obj as OneOnOne);
        }

        /// <summary>
        /// Returns true if OneOnOne instances are equal
        /// </summary>
        /// <param name="other">Instance of OneOnOne to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneOnOne other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PinnedMessages == other.PinnedMessages ||
                    this.PinnedMessages != null &&
                    this.PinnedMessages.SequenceEqual(other.PinnedMessages)
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
                if (this.PinnedMessages != null)
                    hash = hash * 59 + this.PinnedMessages.GetHashCode();

                return hash;
            }
        }
    }

}
