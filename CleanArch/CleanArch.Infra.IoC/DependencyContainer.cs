using Microsoft.Extensions.DependencyInjection;
using MediatR;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using CleanArch.Domain.Core.Bus;
using CleanArch.Bus;
using CleanArch.Domain.Commands;
using CleanArch.Domain.ComandHandlers;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application layer
            services.AddScoped<ICourseService, CourseService>();

            //Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            //Domain InMemoryBus Mediator
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Command Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CreateCourseCommandHandler>();

            // Data layer
            services.AddScoped<UniversityDbContext>();
        }
    }
}
