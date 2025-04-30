using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// OutlierInfo
    /// </summary>
    [DataContract]
    public partial class OutlierInfo :  IEquatable<OutlierInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlierInfo" /> class.
        /// </summary>
        /// <param name="Outlier">Boolean to identify if an outlier or not..</param>
        /// <param name="Score">Outlier score for this utterance. The score is always 0 or greater and higher the score, the more outlier..</param>
        public OutlierInfo(bool? Outlier = null, float? Score = null)
        {
            this.Outlier = Outlier;
            this.Score = Score;
            
        }
        


        /// <summary>
        /// Boolean to identify if an outlier or not.
        /// </summary>
        /// <value>Boolean to identify if an outlier or not.</value>
        [DataMember(Name="outlier", EmitDefaultValue=false)]
        public bool? Outlier { get; set; }



        /// <summary>
        /// Outlier score for this utterance. The score is always 0 or greater and higher the score, the more outlier.
        /// </summary>
        /// <value>Outlier score for this utterance. The score is always 0 or greater and higher the score, the more outlier.</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public float? Score { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutlierInfo {\n");

            sb.Append("  Outlier: ").Append(Outlier).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(obj as OutlierInfo);
        }

        /// <summary>
        /// Returns true if OutlierInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of OutlierInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlierInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Outlier == other.Outlier ||
                    this.Outlier != null &&
                    this.Outlier.Equals(other.Outlier)
                ) &&
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
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
                if (this.Outlier != null)
                    hash = hash * 59 + this.Outlier.GetHashCode();

                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();

                return hash;
            }
        }
    }

}
