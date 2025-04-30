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
    /// TransferDestination
    /// </summary>
    [DataContract]
    public partial class TransferDestination :  IEquatable<TransferDestination>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestination" /> class.
        /// </summary>
        /// <param name="UserId">The id of the user if the command destination is a user..</param>
        /// <param name="Address">The destination address if the command destination is an endpoint..</param>
        public TransferDestination(string UserId = null, string Address = null)
        {
            this.UserId = UserId;
            this.Address = Address;
            
        }
        


        /// <summary>
        /// The id of the user if the command destination is a user.
        /// </summary>
        /// <value>The id of the user if the command destination is a user.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// The destination address if the command destination is an endpoint.
        /// </summary>
        /// <value>The destination address if the command destination is an endpoint.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferDestination {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(obj as TransferDestination);
        }

        /// <summary>
        /// Returns true if TransferDestination instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferDestination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferDestination other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                return hash;
            }
        }
    }

}
