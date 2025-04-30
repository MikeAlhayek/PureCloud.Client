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
    /// DetectedDialogAct
    /// </summary>
    [DataContract]
    public partial class DetectedDialogAct :  IEquatable<DetectedDialogAct>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedDialogAct" /> class.
        /// </summary>
        public DetectedDialogAct()
        {
            
        }
        


        /// <summary>
        /// The name of the detected dialog act.
        /// </summary>
        /// <value>The name of the detected dialog act.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }



        /// <summary>
        /// The probability of the detected dialog act.
        /// </summary>
        /// <value>The probability of the detected dialog act.</value>
        [DataMember(Name="probability", EmitDefaultValue=false)]
        public double? Probability { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectedDialogAct {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
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
            return this.Equals(obj as DetectedDialogAct);
        }

        /// <summary>
        /// Returns true if DetectedDialogAct instances are equal
        /// </summary>
        /// <param name="other">Instance of DetectedDialogAct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectedDialogAct other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Probability == other.Probability ||
                    this.Probability != null &&
                    this.Probability.Equals(other.Probability)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Probability != null)
                    hash = hash * 59 + this.Probability.GetHashCode();

                return hash;
            }
        }
    }

}
