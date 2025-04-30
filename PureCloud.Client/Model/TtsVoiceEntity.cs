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
    /// TtsVoiceEntity
    /// </summary>
    [DataContract]
    public partial class TtsVoiceEntity :  IEquatable<TtsVoiceEntity>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TtsVoiceEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceEntity" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Gender">The gender of the TTS voice (required).</param>
        /// <param name="Language">The language supported by the TTS voice (required).</param>
        /// <param name="Engine">Ths TTS engine this voice belongs to (required).</param>
        /// <param name="IsDefault">The voice is the default voice for its language.</param>
        public TtsVoiceEntity(string Name = null, string Gender = null, string Language = null, TtsEngineEntity Engine = null, bool? IsDefault = null)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Language = Language;
            this.Engine = Engine;
            this.IsDefault = IsDefault;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The gender of the TTS voice
        /// </summary>
        /// <value>The gender of the TTS voice</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }



        /// <summary>
        /// The language supported by the TTS voice
        /// </summary>
        /// <value>The language supported by the TTS voice</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Ths TTS engine this voice belongs to
        /// </summary>
        /// <value>Ths TTS engine this voice belongs to</value>
        [DataMember(Name="engine", EmitDefaultValue=false)]
        public TtsEngineEntity Engine { get; set; }



        /// <summary>
        /// The voice is the default voice for its language
        /// </summary>
        /// <value>The voice is the default voice for its language</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtsVoiceEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Engine: ").Append(Engine).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as TtsVoiceEntity);
        }

        /// <summary>
        /// Returns true if TtsVoiceEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of TtsVoiceEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TtsVoiceEntity other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Engine == other.Engine ||
                    this.Engine != null &&
                    this.Engine.Equals(other.Engine)
                ) &&
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Engine != null)
                    hash = hash * 59 + this.Engine.GetHashCode();

                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
