using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TestExecutionResult
/// </summary>
[DataContract]
public partial class TestExecutionResult : IEquatable<TestExecutionResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TestExecutionResult" /> class.
    /// </summary>
    /// <param name="Operations">Execution operations performed as part of the test.</param>
    /// <param name="Error">The final error encountered during the test that resulted in test failure.</param>
    /// <param name="FinalResult">The final result of the test. This is the response that would be returned during normal action execution.</param>
    /// <param name="Success">Indicates whether or not the test was a success.</param>
    public TestExecutionResult(List<TestExecutionOperationResult> Operations = null, ErrorBody Error = null, object FinalResult = null, bool? Success = null)
    {
        this.Operations = Operations;
        this.Error = Error;
        this.FinalResult = FinalResult;
        this.Success = Success;

    }



    /// <summary>
    /// Execution operations performed as part of the test
    /// </summary>
    /// <value>Execution operations performed as part of the test</value>
    [DataMember(Name = "operations", EmitDefaultValue = false)]
    public List<TestExecutionOperationResult> Operations { get; set; }



    /// <summary>
    /// The final error encountered during the test that resulted in test failure
    /// </summary>
    /// <value>The final error encountered during the test that resulted in test failure</value>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public ErrorBody Error { get; set; }



    /// <summary>
    /// The final result of the test. This is the response that would be returned during normal action execution
    /// </summary>
    /// <value>The final result of the test. This is the response that would be returned during normal action execution</value>
    [DataMember(Name = "finalResult", EmitDefaultValue = false)]
    public object FinalResult { get; set; }



    /// <summary>
    /// Indicates whether or not the test was a success
    /// </summary>
    /// <value>Indicates whether or not the test was a success</value>
    [DataMember(Name = "success", EmitDefaultValue = false)]
    public bool? Success { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TestExecutionResult {\n");

        sb.Append("  Operations: ").Append(Operations).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  FinalResult: ").Append(FinalResult).Append("\n");
        sb.Append("  Success: ").Append(Success).Append("\n");
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
        return Equals(obj as TestExecutionResult);
    }

    /// <summary>
    /// Returns true if TestExecutionResult instances are equal
    /// </summary>
    /// <param name="other">Instance of TestExecutionResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TestExecutionResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Operations == other.Operations ||
                Operations != null &&
                Operations.SequenceEqual(other.Operations)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            ) &&
            (
                FinalResult == other.FinalResult ||
                FinalResult != null &&
                FinalResult.Equals(other.FinalResult)
            ) &&
            (
                Success == other.Success ||
                Success != null &&
                Success.Equals(other.Success)
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
            if (Operations != null)
            {
                hash = hash * 59 + Operations.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (FinalResult != null)
            {
                hash = hash * 59 + FinalResult.GetHashCode();
            }

            if (Success != null)
            {
                hash = hash * 59 + Success.GetHashCode();
            }

            return hash;
        }
    }
}
