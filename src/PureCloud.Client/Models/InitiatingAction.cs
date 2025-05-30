using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InitiatingAction
/// </summary>

public partial class InitiatingAction : IEquatable<InitiatingAction>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InitiatingAction" /> class.
    /// </summary>
    /// <param name="TransactionId">Id of the audit initiating the transaction.</param>
    /// <param name="ActionContext">Action of the audit initiating the transaction.</param>
    public InitiatingAction(string TransactionId = null, string ActionContext = null)
    {
        this.TransactionId = TransactionId;
        this.ActionContext = ActionContext;

    }



    /// <summary>
    /// Id of the audit initiating the transaction
    /// </summary>
    /// <value>Id of the audit initiating the transaction</value>
    [JsonPropertyName("transactionId")]
    public string TransactionId { get; set; }



    /// <summary>
    /// Action of the audit initiating the transaction
    /// </summary>
    /// <value>Action of the audit initiating the transaction</value>
    [JsonPropertyName("actionContext")]
    public string ActionContext { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InitiatingAction {\n");

        sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
        sb.Append("  ActionContext: ").Append(ActionContext).Append("\n");
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
        return Equals(obj as InitiatingAction);
    }

    /// <summary>
    /// Returns true if InitiatingAction instances are equal
    /// </summary>
    /// <param name="other">Instance of InitiatingAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InitiatingAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TransactionId == other.TransactionId ||
                TransactionId != null &&
                TransactionId.Equals(other.TransactionId)
            ) &&
            (
                ActionContext == other.ActionContext ||
                ActionContext != null &&
                ActionContext.Equals(other.ActionContext)
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
            if (TransactionId != null)
            {
                hash = hash * 59 + TransactionId.GetHashCode();
            }

            if (ActionContext != null)
            {
                hash = hash * 59 + ActionContext.GetHashCode();
            }

            return hash;
        }
    }
}
