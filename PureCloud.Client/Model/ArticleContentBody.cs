using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ArticleContentBody
    /// </summary>
    [DataContract]
    public partial class ArticleContentBody : IEquatable<ArticleContentBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleContentBody" /> class.
        /// </summary>
        public ArticleContentBody()
        {

        }



        /// <summary>
        /// Presigned URL to retrieve the document content.
        /// </summary>
        /// <value>Presigned URL to retrieve the document content.</value>
        [DataMember(Name = "locationUrl", EmitDefaultValue = false)]
        public string LocationUrl { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArticleContentBody {\n");

            sb.Append("  LocationUrl: ").Append(LocationUrl).Append("\n");
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
            return this.Equals(obj as ArticleContentBody);
        }

        /// <summary>
        /// Returns true if ArticleContentBody instances are equal
        /// </summary>
        /// <param name="other">Instance of ArticleContentBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleContentBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LocationUrl == other.LocationUrl ||
                    this.LocationUrl != null &&
                    this.LocationUrl.Equals(other.LocationUrl)
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
                if (this.LocationUrl != null)
                    hash = hash * 59 + this.LocationUrl.GetHashCode();

                return hash;
            }
        }
    }

}
