using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// CommunicationTranslationList
    /// </summary>
    [DataContract]
    public partial class CommunicationTranslationList :  IEquatable<CommunicationTranslationList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationTranslationList" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        public CommunicationTranslationList(List<CommunicationTranslation> Entities = null)
        {
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<CommunicationTranslation> Entities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommunicationTranslationList {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as CommunicationTranslationList);
        }

        /// <summary>
        /// Returns true if CommunicationTranslationList instances are equal
        /// </summary>
        /// <param name="other">Instance of CommunicationTranslationList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommunicationTranslationList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }
    }

}
