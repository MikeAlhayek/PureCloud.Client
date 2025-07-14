using PureCloud.Client.Models;
using System.Threading;
using System.Threading.Tasks;

namespace PureCloud.Client.Contracts;

public interface IEmailsApi
{
    Task<bool> DeleteEmailsSettingsThreadingAsync(CancellationToken cancellationToken = default);

    Task<EmailSettings> GetEmailsSettingsAsync(CancellationToken cancellationToken = default);

    Task<EmailThreadingSettings> GetEmailsSettingsThreadingAsync(CancellationToken cancellationToken = default);

    Task<EmailSettings> UpdateEmailsSettingsAsync(EmailSettings body, CancellationToken cancellationToken = default);

    Task<EmailThreadingSettings> UpdateEmailsSettingsThreadingAsync(EmailThreadingSettings body, CancellationToken cancellationToken = default);
}
