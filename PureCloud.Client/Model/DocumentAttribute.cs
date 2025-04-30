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
    /// DocumentAttribute
    /// </summary>
    [DataContract]
    public partial class DocumentAttribute :  IEquatable<DocumentAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAttribute" /> class.
        /// </summary>
        /// <param name="Attribute">Attribute.</param>
        /// <param name="Values">Values.</param>
        public DocumentAttribute(PureCloudPlatform.Client.V2.Model.Attribute Attribute = null, List<string> Values = null)
        {
            this.Attribute = Attribute;
            this.Values = Values;
            
        }
        


        /// <summary>
        /// Gets or Sets Attribute
        /// </summary>
        [DataMember(Name="attribute", EmitDefaultValue=false)]
        public PureCloudPlatform.Client.V2.Model.Attribute Attribute { get; set; }



        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentAttribute {\n");

            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as DocumentAttribute);
        }

        /// <summary>
        /// Returns true if DocumentAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentAttribute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Attribute == other.Attribute ||
                    this.Attribute != null &&
                    this.Attribute.Equals(other.Attribute)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Attribute != null)
                    hash = hash * 59 + this.Attribute.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                return hash;
            }
        }
    }

}
