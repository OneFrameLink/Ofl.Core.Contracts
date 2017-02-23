using System.Net.Http;
using System.Threading;

namespace Ofl.Core.Net.Http
{
    public interface IHttpClientFactory
    {
        HttpClient CreateAsync(CancellationToken cancellationToken);

        HttpClient CreateAsync(HttpMessageHandler handler, CancellationToken cancellationToken);

        HttpClient CreateAsync(HttpMessageHandler handler, bool disposeHandler, CancellationToken cancellationToken);
    }
}
