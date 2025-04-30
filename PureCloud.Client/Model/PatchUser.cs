using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// PatchUser
    /// </summary>
    [DataContract]
    public partial class PatchUser :  IEquatable<PatchUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUser" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="PreferredName">Preferred full name of agent.</param>
        /// <param name="AcdAutoAnswer">The value that denotes if acdAutoAnswer is set on the user.</param>
        public PatchUser(string Id = null, string PreferredName = null, bool? AcdAutoAnswer = null)
        {
            this.Id = Id;
            this.PreferredName = PreferredName;
            this.AcdAutoAnswer = AcdAutoAnswer;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Preferred full name of agent
        /// </summary>
        /// <value>Preferred full name of agent</value>
        [DataMember(Name="preferredName", EmitDefaultValue=false)]
        public string PreferredName { get; set; }



        /// <summary>
        /// The value that denotes if acdAutoAnswer is set on the user
        /// </summary>
        /// <value>The value that denotes if acdAutoAnswer is set on the user</value>
        [DataMember(Name="acdAutoAnswer", EmitDefaultValue=false)]
        public bool? AcdAutoAnswer { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchUser {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PreferredName: ").Append(PreferredName).Append("\n");
            sb.Append("  AcdAutoAnswer: ").Append(AcdAutoAnswer).Append("\n");
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
            return this.Equals(obj as PatchUser);
        }

        /// <summary>
        /// Returns true if PatchUser instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchUser other)
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
                    this.PreferredName == other.PreferredName ||
                    this.PreferredName != null &&
                    this.PreferredName.Equals(other.PreferredName)
                ) &&
                (
                    this.AcdAutoAnswer == other.AcdAutoAnswer ||
                    this.AcdAutoAnswer != null &&
                    this.AcdAutoAnswer.Equals(other.AcdAutoAnswer)
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

                if (this.PreferredName != null)
                    hash = hash * 59 + this.PreferredName.GetHashCode();

                if (this.AcdAutoAnswer != null)
                    hash = hash * 59 + this.AcdAutoAnswer.GetHashCode();

                return hash;
            }
        }
    }

}
