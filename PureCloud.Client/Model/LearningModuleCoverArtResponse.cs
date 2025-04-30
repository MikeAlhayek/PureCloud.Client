using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Learning module cover art response
    /// </summary>
    [DataContract]
    public partial class LearningModuleCoverArtResponse :  IEquatable<LearningModuleCoverArtResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleCoverArtResponse" /> class.
        /// </summary>
        /// <param name="Url">The URL for the cover art.</param>
        /// <param name="Thumbnails">Thumbnails for the cover art.</param>
        public LearningModuleCoverArtResponse(string Url = null, List<LearningCoverArtThumbnail> Thumbnails = null)
        {
            this.Url = Url;
            this.Thumbnails = Thumbnails;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }



        /// <summary>
        /// The URL for the cover art
        /// </summary>
        /// <value>The URL for the cover art</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Thumbnails for the cover art
        /// </summary>
        /// <value>Thumbnails for the cover art</value>
        [DataMember(Name="thumbnails", EmitDefaultValue=false)]
        public List<LearningCoverArtThumbnail> Thumbnails { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModuleCoverArtResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
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
            return this.Equals(obj as LearningModuleCoverArtResponse);
        }

        /// <summary>
        /// Returns true if LearningModuleCoverArtResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModuleCoverArtResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModuleCoverArtResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Thumbnails == other.Thumbnails ||
                    this.Thumbnails != null &&
                    this.Thumbnails.SequenceEqual(other.Thumbnails)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Thumbnails != null)
                    hash = hash * 59 + this.Thumbnails.GetHashCode();

                return hash;
            }
        }
    }

}
