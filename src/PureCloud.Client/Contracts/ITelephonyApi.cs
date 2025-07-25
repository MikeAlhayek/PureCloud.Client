using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ITelephonyApi
{
    Task<MediaRegions> GetMediaRegionsAsync(CancellationToken cancellationToken = default);

    Task<Callmessage> GetSipMessageAsync(string conversationId, CancellationToken cancellationToken = default);

    Task<Callheader> GetSipHeadersAsync(string conversationId, IEnumerable<string> keys = null, CancellationToken cancellationToken = default);

    Task<SipSearchResult> GetSipTracesAsync(DateTime dateStart, DateTime dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null, CancellationToken cancellationToken = default);

    Task<SignedUrlResponse> GetSipTraceDownloadAsync(string downloadId, CancellationToken cancellationToken = default);

    Task<SipDownloadResponse> CreateSipTraceDownloadAsync(SIPSearchPublicRequest request, CancellationToken cancellationToken = default);
}