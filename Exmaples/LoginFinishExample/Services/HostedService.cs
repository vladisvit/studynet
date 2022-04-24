using LoginFinishExample.Interfaces;
using Microsoft.Extensions.Hosting;

namespace LoginFinishExample.Services
{
  internal class HostedService : IHostedService
  {
    private readonly IMessageWriter _messageWriter;
    private readonly ILoginService _loginService;
    private readonly TaskCompletionSource _source = new();

    public HostedService(IMessageWriter messageWriter, ILoginService loginService)
    {
      _messageWriter = messageWriter;
      _loginService = loginService;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
      _messageWriter.Write($"Loggin running at: {DateTimeOffset.Now}");

      await _loginService.LoginExecute().ConfigureAwait(false);
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
      _messageWriter.Write($"Loggin stopped at: {DateTimeOffset.Now}");
      return Task.CompletedTask;
    }
  }
}
