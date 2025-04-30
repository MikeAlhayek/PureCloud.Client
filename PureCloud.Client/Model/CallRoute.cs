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
    /// CallRoute
    /// </summary>
    [DataContract]
    public partial class CallRoute :  IEquatable<CallRoute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRoute" /> class.
        /// </summary>
        /// <param name="Targets">A list of CallTargets to be called when the CallRoute is executed.</param>
        public CallRoute(List<CallTarget> Targets = null)
        {
            this.Targets = Targets;
            
        }
        


        /// <summary>
        /// A list of CallTargets to be called when the CallRoute is executed
        /// </summary>
        /// <value>A list of CallTargets to be called when the CallRoute is executed</value>
        [DataMember(Name="targets", EmitDefaultValue=false)]
        public List<CallTarget> Targets { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallRoute {\n");

            sb.Append("  Targets: ").Append(Targets).Append("\n");
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
            return this.Equals(obj as CallRoute);
        }

        /// <summary>
        /// Returns true if CallRoute instances are equal
        /// </summary>
        /// <param name="other">Instance of CallRoute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallRoute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Targets == other.Targets ||
                    this.Targets != null &&
                    this.Targets.SequenceEqual(other.Targets)
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
                if (this.Targets != null)
                    hash = hash * 59 + this.Targets.GetHashCode();

                return hash;
            }
        }
    }

}
