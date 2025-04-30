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
    /// ConversationCallEventTopicFaxStatus
    /// </summary>
    [DataContract]
    public partial class ConversationCallEventTopicFaxStatus :  IEquatable<ConversationCallEventTopicFaxStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCallEventTopicFaxStatus" /> class.
        /// </summary>
        /// <param name="Direction">Direction.</param>
        /// <param name="ExpectedPages">ExpectedPages.</param>
        /// <param name="ActivePage">ActivePage.</param>
        /// <param name="LinesTransmitted">LinesTransmitted.</param>
        /// <param name="BytesTransmitted">BytesTransmitted.</param>
        /// <param name="DataRate">DataRate.</param>
        /// <param name="PageErrors">PageErrors.</param>
        /// <param name="LineErrors">LineErrors.</param>
        public ConversationCallEventTopicFaxStatus(string Direction = null, long? ExpectedPages = null, long? ActivePage = null, long? LinesTransmitted = null, long? BytesTransmitted = null, long? DataRate = null, long? PageErrors = null, long? LineErrors = null)
        {
            this.Direction = Direction;
            this.ExpectedPages = ExpectedPages;
            this.ActivePage = ActivePage;
            this.LinesTransmitted = LinesTransmitted;
            this.BytesTransmitted = BytesTransmitted;
            this.DataRate = DataRate;
            this.PageErrors = PageErrors;
            this.LineErrors = LineErrors;
            
        }
        


        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }



        /// <summary>
        /// Gets or Sets ExpectedPages
        /// </summary>
        [DataMember(Name="expectedPages", EmitDefaultValue=false)]
        public long? ExpectedPages { get; set; }



        /// <summary>
        /// Gets or Sets ActivePage
        /// </summary>
        [DataMember(Name="activePage", EmitDefaultValue=false)]
        public long? ActivePage { get; set; }



        /// <summary>
        /// Gets or Sets LinesTransmitted
        /// </summary>
        [DataMember(Name="linesTransmitted", EmitDefaultValue=false)]
        public long? LinesTransmitted { get; set; }



        /// <summary>
        /// Gets or Sets BytesTransmitted
        /// </summary>
        [DataMember(Name="bytesTransmitted", EmitDefaultValue=false)]
        public long? BytesTransmitted { get; set; }



        /// <summary>
        /// Gets or Sets DataRate
        /// </summary>
        [DataMember(Name="dataRate", EmitDefaultValue=false)]
        public long? DataRate { get; set; }



        /// <summary>
        /// Gets or Sets PageErrors
        /// </summary>
        [DataMember(Name="pageErrors", EmitDefaultValue=false)]
        public long? PageErrors { get; set; }



        /// <summary>
        /// Gets or Sets LineErrors
        /// </summary>
        [DataMember(Name="lineErrors", EmitDefaultValue=false)]
        public long? LineErrors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationCallEventTopicFaxStatus {\n");

            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ExpectedPages: ").Append(ExpectedPages).Append("\n");
            sb.Append("  ActivePage: ").Append(ActivePage).Append("\n");
            sb.Append("  LinesTransmitted: ").Append(LinesTransmitted).Append("\n");
            sb.Append("  BytesTransmitted: ").Append(BytesTransmitted).Append("\n");
            sb.Append("  DataRate: ").Append(DataRate).Append("\n");
            sb.Append("  PageErrors: ").Append(PageErrors).Append("\n");
            sb.Append("  LineErrors: ").Append(LineErrors).Append("\n");
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
            return this.Equals(obj as ConversationCallEventTopicFaxStatus);
        }

        /// <summary>
        /// Returns true if ConversationCallEventTopicFaxStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationCallEventTopicFaxStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationCallEventTopicFaxStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.ExpectedPages == other.ExpectedPages ||
                    this.ExpectedPages != null &&
                    this.ExpectedPages.Equals(other.ExpectedPages)
                ) &&
                (
                    this.ActivePage == other.ActivePage ||
                    this.ActivePage != null &&
                    this.ActivePage.Equals(other.ActivePage)
                ) &&
                (
                    this.LinesTransmitted == other.LinesTransmitted ||
                    this.LinesTransmitted != null &&
                    this.LinesTransmitted.Equals(other.LinesTransmitted)
                ) &&
                (
                    this.BytesTransmitted == other.BytesTransmitted ||
                    this.BytesTransmitted != null &&
                    this.BytesTransmitted.Equals(other.BytesTransmitted)
                ) &&
                (
                    this.DataRate == other.DataRate ||
                    this.DataRate != null &&
                    this.DataRate.Equals(other.DataRate)
                ) &&
                (
                    this.PageErrors == other.PageErrors ||
                    this.PageErrors != null &&
                    this.PageErrors.Equals(other.PageErrors)
                ) &&
                (
                    this.LineErrors == other.LineErrors ||
                    this.LineErrors != null &&
                    this.LineErrors.Equals(other.LineErrors)
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
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.ExpectedPages != null)
                    hash = hash * 59 + this.ExpectedPages.GetHashCode();

                if (this.ActivePage != null)
                    hash = hash * 59 + this.ActivePage.GetHashCode();

                if (this.LinesTransmitted != null)
                    hash = hash * 59 + this.LinesTransmitted.GetHashCode();

                if (this.BytesTransmitted != null)
                    hash = hash * 59 + this.BytesTransmitted.GetHashCode();

                if (this.DataRate != null)
                    hash = hash * 59 + this.DataRate.GetHashCode();

                if (this.PageErrors != null)
                    hash = hash * 59 + this.PageErrors.GetHashCode();

                if (this.LineErrors != null)
                    hash = hash * 59 + this.LineErrors.GetHashCode();

                return hash;
            }
        }
    }

}
