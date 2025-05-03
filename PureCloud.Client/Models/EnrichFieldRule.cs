using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EnrichFieldRule
/// </summary>

public partial class EnrichFieldRule : IEquatable<EnrichFieldRule>
{
    /// <summary>
    /// The behavior for how to combine data from the request body and the database.
    /// </summary>
    /// <value>The behavior for how to combine data from the request body and the database.</value>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alwaysuseprovided for "AlwaysUseProvided"
        /// </summary>
        [EnumMember(Value = "AlwaysUseProvided")]
        Alwaysuseprovided,

        /// <summary>
        /// Enum Preferexisting for "PreferExisting"
        /// </summary>
        [EnumMember(Value = "PreferExisting")]
        Preferexisting,

        /// <summary>
        /// Enum Preferprovided for "PreferProvided"
        /// </summary>
        [EnumMember(Value = "PreferProvided")]
        Preferprovided
    }
    /// <summary>
    /// The behavior for how to combine items in array field from the request body and the database.
    /// </summary>
    /// <value>The behavior for how to combine items in array field from the request body and the database.</value>
    
    public enum ArrayActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Replace for "Replace"
        /// </summary>
        [EnumMember(Value = "Replace")]
        Replace,

        /// <summary>
        /// Enum Extend for "Extend"
        /// </summary>
        [EnumMember(Value = "Extend")]
        Extend,

        /// <summary>
        /// Enum Fill for "Fill"
        /// </summary>
        [EnumMember(Value = "Fill")]
        Fill
    }
    /// <summary>
    /// The behavior for how to combine data from the request body and the database.
    /// </summary>
    /// <value>The behavior for how to combine data from the request body and the database.</value>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// The behavior for how to combine items in array field from the request body and the database.
    /// </summary>
    /// <value>The behavior for how to combine items in array field from the request body and the database.</value>
    [JsonPropertyName("arrayAction")]
    public ArrayActionEnum? ArrayAction { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EnrichFieldRule" /> class.
    /// </summary>
    /// <param name="Field">A restricted JSONPath naming the specific field this combining behavior should apply to. You may use dot-notation for named fields, and array indexing for lists, but nothing more sophisticated (e.g. wildcards, sublists, filter expressions, etc). For example, to target the &#x60;firstName&#x60; field of a Contact, this should be \&quot;$.firstName\&quot;..</param>
    /// <param name="Action">The behavior for how to combine data from the request body and the database..</param>
    /// <param name="ArrayAction">The behavior for how to combine items in array field from the request body and the database..</param>
    public EnrichFieldRule(string Field = null, ActionEnum? Action = null, ArrayActionEnum? ArrayAction = null)
    {
        this.Field = Field;
        this.Action = Action;
        this.ArrayAction = ArrayAction;

    }



    /// <summary>
    /// A restricted JSONPath naming the specific field this combining behavior should apply to. You may use dot-notation for named fields, and array indexing for lists, but nothing more sophisticated (e.g. wildcards, sublists, filter expressions, etc). For example, to target the &#x60;firstName&#x60; field of a Contact, this should be \&quot;$.firstName\&quot;.
    /// </summary>
    /// <value>A restricted JSONPath naming the specific field this combining behavior should apply to. You may use dot-notation for named fields, and array indexing for lists, but nothing more sophisticated (e.g. wildcards, sublists, filter expressions, etc). For example, to target the &#x60;firstName&#x60; field of a Contact, this should be \&quot;$.firstName\&quot;.</value>
    [JsonPropertyName("field")]
    public string Field { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EnrichFieldRule {\n");

        sb.Append("  Field: ").Append(Field).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  ArrayAction: ").Append(ArrayAction).Append("\n");
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
        return Equals(obj as EnrichFieldRule);
    }

    /// <summary>
    /// Returns true if EnrichFieldRule instances are equal
    /// </summary>
    /// <param name="other">Instance of EnrichFieldRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EnrichFieldRule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Field == other.Field ||
                Field != null &&
                Field.Equals(other.Field)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                ArrayAction == other.ArrayAction ||
                ArrayAction != null &&
                ArrayAction.Equals(other.ArrayAction)
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
            if (Field != null)
            {
                hash = hash * 59 + Field.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (ArrayAction != null)
            {
                hash = hash * 59 + ArrayAction.GetHashCode();
            }

            return hash;
        }
    }
}
