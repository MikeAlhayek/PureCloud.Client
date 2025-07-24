using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum Code
{
    OutdatedSdkVersion,
    Messageexpired,
    Ratelimited,
    Messagenotallowed,
    Generalerror,
    Unsupportedmessage,
    Unknownmessage,
    Invalidmessagestructure,
    Invaliddestination,
    Servererror,
    Mediatypenotallowed,
    Invalidmediacontentlength,
    Recipientoptedout
}
