using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ICarrierServicesApi
{
    Task<EmergencyLocation> GetCarrierservicesIntegrationsEmergencylocationsMeAsync(string phoneNumber, CancellationToken cancellationToken = default);

    Task<EmergencyLocation> CreateCarrierservicesIntegrationsEmergencylocationsMeAsync(EmergencyLocation body, CancellationToken cancellationToken = default);
}
