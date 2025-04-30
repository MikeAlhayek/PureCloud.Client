using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// EvaluationQualityV2TopicEvaluationScoringSet
    /// </summary>
    [DataContract]
    public partial class EvaluationQualityV2TopicEvaluationScoringSet :  IEquatable<EvaluationQualityV2TopicEvaluationScoringSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationQualityV2TopicEvaluationScoringSet" /> class.
        /// </summary>
        /// <param name="TotalScore">TotalScore.</param>
        /// <param name="TotalCriticalScore">TotalCriticalScore.</param>
        public EvaluationQualityV2TopicEvaluationScoringSet(long? TotalScore = null, long? TotalCriticalScore = null)
        {
            this.TotalScore = TotalScore;
            this.TotalCriticalScore = TotalCriticalScore;
            
        }
        


        /// <summary>
        /// Gets or Sets TotalScore
        /// </summary>
        [DataMember(Name="totalScore", EmitDefaultValue=false)]
        public long? TotalScore { get; set; }



        /// <summary>
        /// Gets or Sets TotalCriticalScore
        /// </summary>
        [DataMember(Name="totalCriticalScore", EmitDefaultValue=false)]
        public long? TotalCriticalScore { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationQualityV2TopicEvaluationScoringSet {\n");

            sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
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
            return this.Equals(obj as EvaluationQualityV2TopicEvaluationScoringSet);
        }

        /// <summary>
        /// Returns true if EvaluationQualityV2TopicEvaluationScoringSet instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationQualityV2TopicEvaluationScoringSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationQualityV2TopicEvaluationScoringSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalScore == other.TotalScore ||
                    this.TotalScore != null &&
                    this.TotalScore.Equals(other.TotalScore)
                ) &&
                (
                    this.TotalCriticalScore == other.TotalCriticalScore ||
                    this.TotalCriticalScore != null &&
                    this.TotalCriticalScore.Equals(other.TotalCriticalScore)
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
                if (this.TotalScore != null)
                    hash = hash * 59 + this.TotalScore.GetHashCode();

                if (this.TotalCriticalScore != null)
                    hash = hash * 59 + this.TotalCriticalScore.GetHashCode();

                return hash;
            }
        }
    }

}
