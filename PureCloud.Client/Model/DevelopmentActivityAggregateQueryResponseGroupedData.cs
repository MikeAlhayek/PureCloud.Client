using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// DevelopmentActivityAggregateQueryResponseGroupedData
    /// </summary>
    [DataContract]
    public partial class DevelopmentActivityAggregateQueryResponseGroupedData :  IEquatable<DevelopmentActivityAggregateQueryResponseGroupedData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopmentActivityAggregateQueryResponseGroupedData" /> class.
        /// </summary>
        /// <param name="Group">The group values for this data.</param>
        /// <param name="Data">The metrics in this group.</param>
        public DevelopmentActivityAggregateQueryResponseGroupedData(Dictionary<string, string> Group = null, List<DevelopmentActivityAggregateQueryResponseData> Data = null)
        {
            this.Group = Group;
            this.Data = Data;
            
        }
        


        /// <summary>
        /// The group values for this data
        /// </summary>
        /// <value>The group values for this data</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Dictionary<string, string> Group { get; set; }



        /// <summary>
        /// The metrics in this group
        /// </summary>
        /// <value>The metrics in this group</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<DevelopmentActivityAggregateQueryResponseData> Data { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevelopmentActivityAggregateQueryResponseGroupedData {\n");

            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as DevelopmentActivityAggregateQueryResponseGroupedData);
        }

        /// <summary>
        /// Returns true if DevelopmentActivityAggregateQueryResponseGroupedData instances are equal
        /// </summary>
        /// <param name="other">Instance of DevelopmentActivityAggregateQueryResponseGroupedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DevelopmentActivityAggregateQueryResponseGroupedData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(other.Group)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();

                return hash;
            }
        }
    }

}
