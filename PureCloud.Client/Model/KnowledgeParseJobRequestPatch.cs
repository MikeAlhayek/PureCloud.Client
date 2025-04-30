using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// KnowledgeParseJobRequestPatch
    /// </summary>
    [DataContract]
    public partial class KnowledgeParseJobRequestPatch :  IEquatable<KnowledgeParseJobRequestPatch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeParseJobRequestPatch" /> class.
        /// </summary>
        /// <param name="Hints">Hinted titles for the parser..</param>
        public KnowledgeParseJobRequestPatch(List<string> Hints = null)
        {
            this.Hints = Hints;
            
        }
        


        /// <summary>
        /// Hinted titles for the parser.
        /// </summary>
        /// <value>Hinted titles for the parser.</value>
        [DataMember(Name="hints", EmitDefaultValue=false)]
        public List<string> Hints { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeParseJobRequestPatch {\n");

            sb.Append("  Hints: ").Append(Hints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as KnowledgeParseJobRequestPatch);
        }

        /// <summary>
        /// Returns true if KnowledgeParseJobRequestPatch instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeParseJobRequestPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeParseJobRequestPatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Hints == other.Hints ||
                    this.Hints != null &&
                    this.Hints.SequenceEqual(other.Hints)
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
                if (this.Hints != null)
                    hash = hash * 59 + this.Hints.GetHashCode();

                return hash;
            }
        }
    }

}
