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
    /// WorkitemManualAssign
    /// </summary>
    [DataContract]
    public partial class WorkitemManualAssign :  IEquatable<WorkitemManualAssign>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemManualAssign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemManualAssign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemManualAssign" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for this user. (required).</param>
        public WorkitemManualAssign(string Id = null)
        {
            this.Id = Id;
            
        }
        


        /// <summary>
        /// The globally unique identifier for this user.
        /// </summary>
        /// <value>The globally unique identifier for this user.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemManualAssign {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as WorkitemManualAssign);
        }

        /// <summary>
        /// Returns true if WorkitemManualAssign instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemManualAssign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemManualAssign other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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

                return hash;
            }
        }
    }

}
