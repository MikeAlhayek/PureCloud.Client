using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentStepSignedCookie
/// </summary>
[DataContract]
public partial class LearningAssignmentStepSignedCookie : IEquatable<LearningAssignmentStepSignedCookie>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentStepSignedCookie" /> class.
    /// </summary>
    public LearningAssignmentStepSignedCookie()
    {

    }



    /// <summary>
    /// The base URL for the signed cookie
    /// </summary>
    /// <value>The base URL for the signed cookie</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; private set; }



    /// <summary>
    /// The cookie values required to access content from the base URL
    /// </summary>
    /// <value>The cookie values required to access content from the base URL</value>
    [DataMember(Name = "cookieValues", EmitDefaultValue = false)]
    public Dictionary<string, string> CookieValues { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentStepSignedCookie {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  CookieValues: ").Append(CookieValues).Append("\n");
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
        return Equals(obj as LearningAssignmentStepSignedCookie);
    }

    /// <summary>
    /// Returns true if LearningAssignmentStepSignedCookie instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentStepSignedCookie to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentStepSignedCookie other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                CookieValues == other.CookieValues ||
                CookieValues != null &&
                CookieValues.SequenceEqual(other.CookieValues)
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (CookieValues != null)
            {
                hash = hash * 59 + CookieValues.GetHashCode();
            }

            return hash;
        }
    }
}
