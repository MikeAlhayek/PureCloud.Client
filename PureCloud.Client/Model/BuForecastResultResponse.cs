using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BuForecastResultResponse
    /// </summary>
    [DataContract]
    public partial class BuForecastResultResponse : IEquatable<BuForecastResultResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuForecastResultResponse" /> class.
        /// </summary>
        /// <param name="Result">The result of the operation.  Populated whenever the result is small enough to pass through the api directly.</param>
        /// <param name="DownloadUrl">The download url to fetch the result.  Only populated if the result is too large to pass through the api directly.</param>
        public BuForecastResultResponse(BuForecastResult Result = null, string DownloadUrl = null)
        {
            this.Result = Result;
            this.DownloadUrl = DownloadUrl;

        }



        /// <summary>
        /// The result of the operation.  Populated whenever the result is small enough to pass through the api directly
        /// </summary>
        /// <value>The result of the operation.  Populated whenever the result is small enough to pass through the api directly</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public BuForecastResult Result { get; set; }



        /// <summary>
        /// The download url to fetch the result.  Only populated if the result is too large to pass through the api directly
        /// </summary>
        /// <value>The download url to fetch the result.  Only populated if the result is too large to pass through the api directly</value>
        [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
        public string DownloadUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuForecastResultResponse {\n");

            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
            return this.Equals(obj as BuForecastResultResponse);
        }

        /// <summary>
        /// Returns true if BuForecastResultResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuForecastResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuForecastResultResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
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
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                return hash;
            }
        }
    }

}
