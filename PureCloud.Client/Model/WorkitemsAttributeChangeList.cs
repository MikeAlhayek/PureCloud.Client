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
    /// WorkitemsAttributeChangeList
    /// </summary>
    [DataContract]
    public partial class WorkitemsAttributeChangeList :  IEquatable<WorkitemsAttributeChangeList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemsAttributeChangeList" /> class.
        /// </summary>
        /// <param name="NewValue">New property value.</param>
        /// <param name="OldValue">Old property value.</param>
        public WorkitemsAttributeChangeList(List<Object> NewValue = null, List<Object> OldValue = null)
        {
            this.NewValue = NewValue;
            this.OldValue = OldValue;
            
        }
        


        /// <summary>
        /// New property value
        /// </summary>
        /// <value>New property value</value>
        [DataMember(Name="newValue", EmitDefaultValue=false)]
        public List<Object> NewValue { get; set; }



        /// <summary>
        /// Old property value
        /// </summary>
        /// <value>Old property value</value>
        [DataMember(Name="oldValue", EmitDefaultValue=false)]
        public List<Object> OldValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemsAttributeChangeList {\n");

            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
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
            return this.Equals(obj as WorkitemsAttributeChangeList);
        }

        /// <summary>
        /// Returns true if WorkitemsAttributeChangeList instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemsAttributeChangeList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemsAttributeChangeList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NewValue == other.NewValue ||
                    this.NewValue != null &&
                    this.NewValue.SequenceEqual(other.NewValue)
                ) &&
                (
                    this.OldValue == other.OldValue ||
                    this.OldValue != null &&
                    this.OldValue.SequenceEqual(other.OldValue)
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
                if (this.NewValue != null)
                    hash = hash * 59 + this.NewValue.GetHashCode();

                if (this.OldValue != null)
                    hash = hash * 59 + this.OldValue.GetHashCode();

                return hash;
            }
        }
    }

}
