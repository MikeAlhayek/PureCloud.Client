using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ModelMetaData
/// </summary>

public partial class ModelMetaData : IEquatable<ModelMetaData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ModelMetaData" /> class.
    /// </summary>
    /// <param name="DownloadUrls">List of URLs to fetch the result of the forecast metadata. This field is populated only if session state is Complete.</param>
    /// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
    public ModelMetaData(List<string> DownloadUrls = null, ModelMetaDataResult DownloadResult = null)
    {
        this.DownloadUrls = DownloadUrls;
        this.DownloadResult = DownloadResult;

    }



    /// <summary>
    /// List of URLs to fetch the result of the forecast metadata. This field is populated only if session state is Complete
    /// </summary>
    /// <value>List of URLs to fetch the result of the forecast metadata. This field is populated only if session state is Complete</value>
    [JsonPropertyName("downloadUrls")]
    public List<string> DownloadUrls { get; set; }



    /// <summary>
    /// Result will always come via downloadUrls; however the schema is included for documentation
    /// </summary>
    /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
    [JsonPropertyName("downloadResult")]
    public ModelMetaDataResult DownloadResult { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ModelMetaData {\n");

        sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
        sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
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
        return Equals(obj as ModelMetaData);
    }

    /// <summary>
    /// Returns true if ModelMetaData instances are equal
    /// </summary>
    /// <param name="other">Instance of ModelMetaData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ModelMetaData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DownloadUrls == other.DownloadUrls ||
                DownloadUrls != null &&
                DownloadUrls.SequenceEqual(other.DownloadUrls)
            ) &&
            (
                DownloadResult == other.DownloadResult ||
                DownloadResult != null &&
                DownloadResult.Equals(other.DownloadResult)
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
            if (DownloadUrls != null)
            {
                hash = hash * 59 + DownloadUrls.GetHashCode();
            }

            if (DownloadResult != null)
            {
                hash = hash * 59 + DownloadResult.GetHashCode();
            }

            return hash;
        }
    }
}
