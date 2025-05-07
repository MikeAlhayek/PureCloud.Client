using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Current action function configuration and zip upload configuration.
/// </summary>

public partial class FunctionConfig : IEquatable<FunctionConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FunctionConfig" /> class.
    /// </summary>
    public FunctionConfig()
    {

    }



    /// <summary>
    /// Action identifier.
    /// </summary>
    /// <value>Action identifier.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Function configuration.
    /// </summary>
    /// <value>Function configuration.</value>
    [JsonPropertyName("function")]
    public Function Function { get; set; }



    /// <summary>
    /// Zip file configuration and state.
    /// </summary>
    /// <value>Zip file configuration and state.</value>
    [JsonPropertyName("zip")]
    public FunctionZipConfig Zip { get; set; }



    /// <summary>
    /// History of failed zip upload file configuration including their state and error messages. Contains no more than last ten failures.
    /// </summary>
    /// <value>History of failed zip upload file configuration including their state and error messages. Contains no more than last ten failures.</value>
    [JsonPropertyName("uploadExceptionHistory")]
    public List<FunctionZipConfig> UploadExceptionHistory { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FunctionConfig {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Function: ").Append(Function).Append("\n");
        sb.Append("  Zip: ").Append(Zip).Append("\n");
        sb.Append("  UploadExceptionHistory: ").Append(UploadExceptionHistory).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as FunctionConfig);
    }

    /// <summary>
    /// Returns true if FunctionConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of FunctionConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FunctionConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Function == other.Function ||
                Function != null &&
                Function.Equals(other.Function)
            ) &&
            (
                Zip == other.Zip ||
                Zip != null &&
                Zip.Equals(other.Zip)
            ) &&
            (
                UploadExceptionHistory == other.UploadExceptionHistory ||
                UploadExceptionHistory != null &&
                UploadExceptionHistory.SequenceEqual(other.UploadExceptionHistory)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Function != null)
            {
                hash = hash * 59 + Function.GetHashCode();
            }

            if (Zip != null)
            {
                hash = hash * 59 + Zip.GetHashCode();
            }

            if (UploadExceptionHistory != null)
            {
                hash = hash * 59 + UploadExceptionHistory.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
