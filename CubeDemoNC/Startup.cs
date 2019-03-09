﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NewLife.Cube;

namespace CubeDemoNC
{
    public class Startup
    {
        public Startup()
        {

        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCube();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // 使用Cube前添加自己的管道
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseCube();
        }
    }
}