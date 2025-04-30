using System.Runtime.Serialization;
using System.Text;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// AsyncQueryResponse
    /// </summary>
    [DataContract]
    public partial class AsyncQueryResponse : IEquatable<AsyncQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncQueryResponse" /> class.
        /// </summary>
        /// <param name="JobId">Unique identifier for the async query execution. Can be used to check the status of the query and retrieve results..</param>
        public AsyncQueryResponse(string JobId = null)
        {
            this.JobId = JobId;

        }



        /// <summary>
        /// Unique identifier for the async query execution. Can be used to check the status of the query and retrieve results.
        /// </summary>
        /// <value>Unique identifier for the async query execution. Can be used to check the status of the query and retrieve results.</value>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public string JobId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncQueryResponse {\n");

            sb.Append("  JobId: ").Append(JobId).Append("\n");
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
            return this.Equals(obj as AsyncQueryResponse);
        }

        /// <summary>
        /// Returns true if AsyncQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
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
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();

                return hash;
            }
        }
    }

}
