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
    /// DocumentBody
    /// </summary>
    [DataContract]
    public partial class DocumentBody :  IEquatable<DocumentBody>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBody" /> class.
        /// </summary>
        /// <param name="Blocks">The list of building blocks for the document body. (required).</param>
        public DocumentBody(List<DocumentBodyBlock> Blocks = null)
        {
            this.Blocks = Blocks;
            
        }
        


        /// <summary>
        /// The list of building blocks for the document body.
        /// </summary>
        /// <value>The list of building blocks for the document body.</value>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public List<DocumentBodyBlock> Blocks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBody {\n");

            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
            return this.Equals(obj as DocumentBody);
        }

        /// <summary>
        /// Returns true if DocumentBody instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Blocks == other.Blocks ||
                    this.Blocks != null &&
                    this.Blocks.SequenceEqual(other.Blocks)
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
                if (this.Blocks != null)
                    hash = hash * 59 + this.Blocks.GetHashCode();

                return hash;
            }
        }
    }

}
