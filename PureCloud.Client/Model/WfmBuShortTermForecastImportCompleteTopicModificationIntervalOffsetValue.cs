using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue
    /// </summary>
    [DataContract]
    public partial class WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue :  IEquatable<WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue" /> class.
        /// </summary>
        /// <param name="IntervalIndex">IntervalIndex.</param>
        /// <param name="Value">Value.</param>
        public WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue(long? IntervalIndex = null, double? Value = null)
        {
            this.IntervalIndex = IntervalIndex;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// Gets or Sets IntervalIndex
        /// </summary>
        [DataMember(Name="intervalIndex", EmitDefaultValue=false)]
        public long? IntervalIndex { get; set; }



        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue {\n");

            sb.Append("  IntervalIndex: ").Append(IntervalIndex).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue);
        }

        /// <summary>
        /// Returns true if WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IntervalIndex == other.IntervalIndex ||
                    this.IntervalIndex != null &&
                    this.IntervalIndex.Equals(other.IntervalIndex)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.IntervalIndex != null)
                    hash = hash * 59 + this.IntervalIndex.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
