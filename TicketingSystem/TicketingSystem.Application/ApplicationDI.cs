using Microsoft.Extensions.DependencyInjection;
using TicketingSystem.Application.Abstractions.IServices;
using TicketingSystem.Application.Mappers;
using TicketingSystem.Application.Services.AuthServices;
using TicketingSystem.Application.Services.TicketServices;
using TicketingSystem.Application.Services.UserServices;

namespace TicketingSystem.Application
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}