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
    /// TopicPhrase
    /// </summary>
    [DataContract]
    public partial class TopicPhrase :  IEquatable<TopicPhrase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicPhrase" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Text">Text.</param>
        /// <param name="UtteranceCount">UtteranceCount.</param>
        public TopicPhrase(string Id = null, string Text = null, int? UtteranceCount = null)
        {
            this.Id = Id;
            this.Text = Text;
            this.UtteranceCount = UtteranceCount;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Gets or Sets UtteranceCount
        /// </summary>
        [DataMember(Name="utteranceCount", EmitDefaultValue=false)]
        public int? UtteranceCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicPhrase {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
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
            return this.Equals(obj as TopicPhrase);
        }

        /// <summary>
        /// Returns true if TopicPhrase instances are equal
        /// </summary>
        /// <param name="other">Instance of TopicPhrase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicPhrase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.UtteranceCount == other.UtteranceCount ||
                    this.UtteranceCount != null &&
                    this.UtteranceCount.Equals(other.UtteranceCount)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.UtteranceCount != null)
                    hash = hash * 59 + this.UtteranceCount.GetHashCode();

                return hash;
            }
        }
    }

}
