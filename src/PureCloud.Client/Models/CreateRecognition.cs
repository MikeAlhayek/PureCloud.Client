using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateRecognition
{
    /// <summary>
    /// The type of the recognition
    /// </summary>
    /// <value>The type of the recognition</value>
    public CreateRecognitionTypeEnum? Type { get; set; }

    /// <summary>
    /// The context type (optional)
    /// </summary>
    /// <value>The context type (optional)</value>
    public CreateRecognitionContextTypeEnum? ContextType { get; set; }

    /// <summary>
    /// The recipient of the recognition
    /// </summary>
    /// <value>The recipient of the recognition</value>
    public string RecipientId { get; set; }

    /// <summary>
    /// The title of the recognition. Max length of 100 characters (optional)
    /// </summary>
    /// <value>The title of the recognition. Max length of 100 characters (optional)</value>
    public string Title { get; set; }

    /// <summary>
    /// The note of the recognition. Max length of 800 characters (optional)
    /// </summary>
    /// <value>The note of the recognition. Max length of 800 characters (optional)</value>
    public string Note { get; set; }

    /// <summary>
    /// The context id (optional)
    /// </summary>
    /// <value>The context id (optional)</value>
    public string ContextId { get; set; }
}
