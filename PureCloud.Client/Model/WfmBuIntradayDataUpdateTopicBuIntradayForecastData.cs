using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// WfmBuIntradayDataUpdateTopicBuIntradayForecastData
    /// </summary>
    [DataContract]
    public partial class WfmBuIntradayDataUpdateTopicBuIntradayForecastData :  IEquatable<WfmBuIntradayDataUpdateTopicBuIntradayForecastData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicBuIntradayForecastData" /> class.
        /// </summary>
        /// <param name="Offered">Offered.</param>
        /// <param name="AverageHandleTimeSeconds">AverageHandleTimeSeconds.</param>
        public WfmBuIntradayDataUpdateTopicBuIntradayForecastData(double? Offered = null, double? AverageHandleTimeSeconds = null)
        {
            this.Offered = Offered;
            this.AverageHandleTimeSeconds = AverageHandleTimeSeconds;
            
        }
        


        /// <summary>
        /// Gets or Sets Offered
        /// </summary>
        [DataMember(Name="offered", EmitDefaultValue=false)]
        public double? Offered { get; set; }



        /// <summary>
        /// Gets or Sets AverageHandleTimeSeconds
        /// </summary>
        [DataMember(Name="averageHandleTimeSeconds", EmitDefaultValue=false)]
        public double? AverageHandleTimeSeconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuIntradayDataUpdateTopicBuIntradayForecastData {\n");

            sb.Append("  Offered: ").Append(Offered).Append("\n");
            sb.Append("  AverageHandleTimeSeconds: ").Append(AverageHandleTimeSeconds).Append("\n");
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
            return this.Equals(obj as WfmBuIntradayDataUpdateTopicBuIntradayForecastData);
        }

        /// <summary>
        /// Returns true if WfmBuIntradayDataUpdateTopicBuIntradayForecastData instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicBuIntradayForecastData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuIntradayDataUpdateTopicBuIntradayForecastData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Offered == other.Offered ||
                    this.Offered != null &&
                    this.Offered.Equals(other.Offered)
                ) &&
                (
                    this.AverageHandleTimeSeconds == other.AverageHandleTimeSeconds ||
                    this.AverageHandleTimeSeconds != null &&
                    this.AverageHandleTimeSeconds.Equals(other.AverageHandleTimeSeconds)
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
                if (this.Offered != null)
                    hash = hash * 59 + this.Offered.GetHashCode();

                if (this.AverageHandleTimeSeconds != null)
                    hash = hash * 59 + this.AverageHandleTimeSeconds.GetHashCode();

                return hash;
            }
        }
    }

}
