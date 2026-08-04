using LIS.Application.Interfaces;
using LIS.Application.Services;
using Microsoft.Extensions.DependencyInjection; 

namespace LIS.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ILongestIncreasingSubsequenceService, LongestIncreasingSubsequenceService>();
        return services;
    }
}   