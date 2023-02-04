using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenAI.GPT3.DotNetStandard.Interfaces;
using OpenAI.GPT3.DotNetStandard.Managers;

namespace OpenAI.GPT3.DotNetStandard.Extensions
{
    public static class OpenAIServiceCollectionExtensions
    {
        public static IServiceCollection AddOpenAIService(this IServiceCollection services)
        {
            services.AddOptions<OpenAiOptions>();
            services.AddHttpClient<IOpenAIService, OpenAIService>();
            var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
            services.Configure<OpenAiOptions>(configuration.GetSection(OpenAiOptions.SettingKey));
            return services;
        }

        public static IServiceCollection AddOpenAIService(this IServiceCollection services, Action<OpenAiOptions> setupAction)
        {
            services.AddOptions<OpenAiOptions>().Configure(setupAction);
            services.AddHttpClient<IOpenAIService, OpenAIService>();
            return services;
        }
    }
}