using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IDataExtensionsApi
{
    Task<Coretype> GetDataextensionsCoretypeAsync(string coretypeName, CancellationToken cancellationToken = default);

    Task<CoretypeListing> GetDataextensionsCoretypesAsync(CancellationToken cancellationToken = default);

    Task<SchemaQuantityLimits> GetDataextensionsLimitsAsync(CancellationToken cancellationToken = default);
}
