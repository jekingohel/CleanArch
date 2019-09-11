using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using CleanArche.Application.Interfaces;
using CleanArche.Application.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public static class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection services) {

            #region "Domain InMemoryBus MediatR"
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            #endregion

            #region "Domain Handlers"
            services.AddScoped<IRequestHandler<CreateCourseCommand,bool>, CourseCommandHandler>();
            #endregion




            #region "Aplication Layer"
            services.AddScoped<ICourseService, CourseService>();

            #endregion

            #region "Repository"
            services.AddScoped<ICourseRepository, CourseRepository>();
            #endregion

            #region "Context"
            services.AddScoped<CleanArchDBContext>();
            #endregion
        }
    }
}