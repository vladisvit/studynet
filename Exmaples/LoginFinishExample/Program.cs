using LoginFinishExample.Interfaces;
using LoginFinishExample.Services;
using LoginFinishExample.Services.Logger;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

static IHostBuilder CreateHostBuilder(string[] args) =>
  Host.CreateDefaultBuilder(args).ConfigureServices(
    (_, services) =>
        services.AddHostedService<HostedService>()
        .AddSingleton<IUserRepository, UserPepository>()
        .AddSingleton<IValidation, Validation>()
        .AddScoped<IUserInput, UserInput>()
        .AddScoped<IMessageWriter, ConsoleMessageWriter>()
        .AddScoped<ILoginService, LoginService>());

CreateHostBuilder(args).Build().Run();