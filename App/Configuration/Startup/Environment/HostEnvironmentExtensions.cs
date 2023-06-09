namespace Microsoft.Extensions.Hosting;


public static class HostEnvironmentEnvExtensions
{
    public static bool IsTesting(this IHostEnvironment hostEnvironment)
    {
        return hostEnvironment.IsEnvironment("Testing");
    }

    public static bool IsLocal(this IHostEnvironment hostEnvironment)
    {
        return hostEnvironment.IsEnvironment("Local");
    }
}
