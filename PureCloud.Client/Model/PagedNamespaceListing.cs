using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// PagedNamespaceListing
    /// </summary>
    [DataContract]
    public partial class PagedNamespaceListing :  IEquatable<PagedNamespaceListing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedNamespaceListing" /> class.
        /// </summary>
        public PagedNamespaceListing()
        {
            
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PagedNamespaceListing {\n");

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
            return this.Equals(obj as PagedNamespaceListing);
        }

        /// <summary>
        /// Returns true if PagedNamespaceListing instances are equal
        /// </summary>
        /// <param name="other">Instance of PagedNamespaceListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PagedNamespaceListing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true && false;
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
                return hash;
            }
        }
    }

}
