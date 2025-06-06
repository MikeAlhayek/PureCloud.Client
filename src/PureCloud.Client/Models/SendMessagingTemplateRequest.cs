using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SendMessagingTemplateRequest
/// </summary>

public partial class SendMessagingTemplateRequest : IEquatable<SendMessagingTemplateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendMessagingTemplateRequest" /> class.
    /// </summary>
    /// <param name="ResponseId">A Response Management response identifier for a messaging template defined response.</param>
    /// <param name="Parameters">A list of Response Management response substitutions for the response&#39;s messaging template. (Deprecated) use bodyParameters instead..</param>
    /// <param name="HeaderParameters">A list of Response Management header parameter substitutions for the response&#39;s messaging template.</param>
    /// <param name="BodyParameters">A list of Response Management body parameter substitutions for the response&#39;s messaging template.</param>
    /// <param name="ButtonUrlParameters">A list of Response Management button url parameter substitutions for the response&#39;s messaging template.</param>
    public SendMessagingTemplateRequest(string ResponseId = null, List<TemplateParameter> Parameters = null, List<TemplateParameter> HeaderParameters = null, List<TemplateParameter> BodyParameters = null, List<TemplateParameter> ButtonUrlParameters = null)
    {
        this.ResponseId = ResponseId;
        this.Parameters = Parameters;
        this.HeaderParameters = HeaderParameters;
        this.BodyParameters = BodyParameters;
        this.ButtonUrlParameters = ButtonUrlParameters;

    }



    /// <summary>
    /// A Response Management response identifier for a messaging template defined response
    /// </summary>
    /// <value>A Response Management response identifier for a messaging template defined response</value>
    [JsonPropertyName("responseId")]
    public string ResponseId { get; set; }



    /// <summary>
    /// A list of Response Management response substitutions for the response&#39;s messaging template. (Deprecated) use bodyParameters instead.
    /// </summary>
    /// <value>A list of Response Management response substitutions for the response&#39;s messaging template. (Deprecated) use bodyParameters instead.</value>
    [JsonPropertyName("parameters")]
    public List<TemplateParameter> Parameters { get; set; }



    /// <summary>
    /// A list of Response Management header parameter substitutions for the response&#39;s messaging template
    /// </summary>
    /// <value>A list of Response Management header parameter substitutions for the response&#39;s messaging template</value>
    [JsonPropertyName("headerParameters")]
    public List<TemplateParameter> HeaderParameters { get; set; }



    /// <summary>
    /// A list of Response Management body parameter substitutions for the response&#39;s messaging template
    /// </summary>
    /// <value>A list of Response Management body parameter substitutions for the response&#39;s messaging template</value>
    [JsonPropertyName("bodyParameters")]
    public List<TemplateParameter> BodyParameters { get; set; }



    /// <summary>
    /// A list of Response Management button url parameter substitutions for the response&#39;s messaging template
    /// </summary>
    /// <value>A list of Response Management button url parameter substitutions for the response&#39;s messaging template</value>
    [JsonPropertyName("buttonUrlParameters")]
    public List<TemplateParameter> ButtonUrlParameters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SendMessagingTemplateRequest {\n");

        sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
        sb.Append("  Parameters: ").Append(Parameters).Append("\n");
        sb.Append("  HeaderParameters: ").Append(HeaderParameters).Append("\n");
        sb.Append("  BodyParameters: ").Append(BodyParameters).Append("\n");
        sb.Append("  ButtonUrlParameters: ").Append(ButtonUrlParameters).Append("\n");
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
        return Equals(obj as SendMessagingTemplateRequest);
    }

    /// <summary>
    /// Returns true if SendMessagingTemplateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SendMessagingTemplateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SendMessagingTemplateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ResponseId == other.ResponseId ||
                ResponseId != null &&
                ResponseId.Equals(other.ResponseId)
            ) &&
            (
                Parameters == other.Parameters ||
                Parameters != null &&
                Parameters.SequenceEqual(other.Parameters)
            ) &&
            (
                HeaderParameters == other.HeaderParameters ||
                HeaderParameters != null &&
                HeaderParameters.SequenceEqual(other.HeaderParameters)
            ) &&
            (
                BodyParameters == other.BodyParameters ||
                BodyParameters != null &&
                BodyParameters.SequenceEqual(other.BodyParameters)
            ) &&
            (
                ButtonUrlParameters == other.ButtonUrlParameters ||
                ButtonUrlParameters != null &&
                ButtonUrlParameters.SequenceEqual(other.ButtonUrlParameters)
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
            if (ResponseId != null)
            {
                hash = hash * 59 + ResponseId.GetHashCode();
            }

            if (Parameters != null)
            {
                hash = hash * 59 + Parameters.GetHashCode();
            }

            if (HeaderParameters != null)
            {
                hash = hash * 59 + HeaderParameters.GetHashCode();
            }

            if (BodyParameters != null)
            {
                hash = hash * 59 + BodyParameters.GetHashCode();
            }

            if (ButtonUrlParameters != null)
            {
                hash = hash * 59 + ButtonUrlParameters.GetHashCode();
            }

            return hash;
        }
    }
}
