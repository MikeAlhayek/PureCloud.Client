using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAction
/// </summary>
[DataContract]
public partial class JourneyAction : IEquatable<JourneyAction>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyAction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAction" /> class.
    /// </summary>
    /// <param name="Id">The ID of an action from the Journey System (an action is spawned from an actionMap) (required).</param>
    /// <param name="ActionMap">Details about the action map from the Journey System which triggered this action (required).</param>
    public JourneyAction(string Id = null, JourneyActionMap ActionMap = null)
    {
        this.Id = Id;
        this.ActionMap = ActionMap;

    }



    /// <summary>
    /// The ID of an action from the Journey System (an action is spawned from an actionMap)
    /// </summary>
    /// <value>The ID of an action from the Journey System (an action is spawned from an actionMap)</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Details about the action map from the Journey System which triggered this action
    /// </summary>
    /// <value>Details about the action map from the Journey System which triggered this action</value>
    [DataMember(Name = "actionMap", EmitDefaultValue = false)]
    public JourneyActionMap ActionMap { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAction {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
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
        return this.Equals(obj as JourneyAction);
    }

    /// <summary>
    /// Returns true if JourneyAction instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.ActionMap == other.ActionMap ||
                this.ActionMap != null &&
                this.ActionMap.Equals(other.ActionMap)
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
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.ActionMap != null)
            {
                hash = hash * 59 + this.ActionMap.GetHashCode();
            }

            return hash;
        }
    }
}
