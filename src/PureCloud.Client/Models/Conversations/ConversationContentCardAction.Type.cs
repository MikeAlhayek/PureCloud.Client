// Rename the enum to avoid the CS0101 conflict with another 'Type' definition in the same namespace.
using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConversationContentCardActionType
{
    OutdatedSdkVersion,
    Link,
    Postback,
    Unknown
}
