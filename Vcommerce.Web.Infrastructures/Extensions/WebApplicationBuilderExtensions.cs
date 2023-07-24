using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Vcommerce.Web.Infrastructures.Extensions;

public static class WebApplicationBuilderExtensions
{
    /// <summary>
    /// This method registers all services with their interfaces and implementations in the given Assembly
    /// The Assembly is taken from the service provided
    /// </summary>
    /// <param name="serviceType">Type of random service implementation used to get the Assembly of the services</param>
    /// <exception cref="InvalidOperationException"></exception>
    public static void AddApplicationServices(this IServiceCollection services,Type serviceType)
    {
        Assembly? serviceAssembly= Assembly.GetAssembly(serviceType);

        if (serviceAssembly == null)
        {
            throw new InvalidOperationException("Invalid service type provided");
        }
        Type[] serviceTypes = serviceAssembly.GetTypes()
            .Where(t=>t.Name.EndsWith("Service") &&!t.IsInterface)
            .ToArray();

        foreach (var implementationType in serviceTypes)
        {
            Type? interfaceType = implementationType.GetInterface($"I{implementationType.Name}");
            if (interfaceType == null)
            {
                throw new InvalidOperationException($"No interface is provided for the service with name {implementationType.Name}");
            }

            services.AddScoped(interfaceType, implementationType);
        }
    }

}