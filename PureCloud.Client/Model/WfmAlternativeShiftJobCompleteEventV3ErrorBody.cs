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
    /// WfmAlternativeShiftJobCompleteEventV3ErrorBody
    /// </summary>
    [DataContract]
    public partial class WfmAlternativeShiftJobCompleteEventV3ErrorBody :  IEquatable<WfmAlternativeShiftJobCompleteEventV3ErrorBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAlternativeShiftJobCompleteEventV3ErrorBody" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Message">Message.</param>
        /// <param name="MessageParams">MessageParams.</param>
        public WfmAlternativeShiftJobCompleteEventV3ErrorBody(long? Status = null, string Code = null, string Message = null, Dictionary<string, string> MessageParams = null)
        {
            this.Status = Status;
            this.Code = Code;
            this.Message = Message;
            this.MessageParams = MessageParams;
            
        }
        


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }



        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Gets or Sets MessageParams
        /// </summary>
        [DataMember(Name="messageParams", EmitDefaultValue=false)]
        public Dictionary<string, string> MessageParams { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAlternativeShiftJobCompleteEventV3ErrorBody {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
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
            return this.Equals(obj as WfmAlternativeShiftJobCompleteEventV3ErrorBody);
        }

        /// <summary>
        /// Returns true if WfmAlternativeShiftJobCompleteEventV3ErrorBody instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAlternativeShiftJobCompleteEventV3ErrorBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAlternativeShiftJobCompleteEventV3ErrorBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.MessageParams == other.MessageParams ||
                    this.MessageParams != null &&
                    this.MessageParams.SequenceEqual(other.MessageParams)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.MessageParams != null)
                    hash = hash * 59 + this.MessageParams.GetHashCode();

                return hash;
            }
        }
    }

}
