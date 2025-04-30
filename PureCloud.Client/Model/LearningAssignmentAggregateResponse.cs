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
    /// LearningAssignmentAggregateResponse
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentAggregateResponse :  IEquatable<LearningAssignmentAggregateResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentAggregateResponse" /> class.
        /// </summary>
        /// <param name="Results">The results of the query.</param>
        public LearningAssignmentAggregateResponse(List<LearningAssignmentAggregateQueryResponseGroupedData> Results = null)
        {
            this.Results = Results;
            
        }
        


        /// <summary>
        /// The results of the query
        /// </summary>
        /// <value>The results of the query</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<LearningAssignmentAggregateQueryResponseGroupedData> Results { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentAggregateResponse {\n");

            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as LearningAssignmentAggregateResponse);
        }

        /// <summary>
        /// Returns true if LearningAssignmentAggregateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentAggregateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentAggregateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                return hash;
            }
        }
    }

}
