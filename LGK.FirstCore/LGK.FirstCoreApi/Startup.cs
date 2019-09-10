using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;
using LGK.FirstCore.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LGK.FirstCoreApi
{
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IUserRepository, UserRepository>();   //注册数据访问层 接口与实现类 
            services.AddScoped<IRoleRepository, RoleRepository>();   //注册数据访问层 接口与实现类  


            //注册跨域服务，允许所有来源
            services.AddCors(options =>
                options.AddPolicy("AllowAnyCors",
                p => p.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin().AllowCredentials().AllowAnyOrigin())
            );

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "test"
                });


                // 为 Swagger JSON and UI设置xml文档注释路径
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);


                //获取应用程序所在目录（绝对路径，不受工作目录影响，建议采用此方法获取路径）
                var xmlPath = Path.Combine(basePath, "SwaggerDemo.xml");


                //如果需要显示控制器注释只需将第二个参数设置为true
                options.IncludeXmlComments(xmlPath, true);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //允许跨域访问
            app.UseCors("AllowAnyCors");
            app.UseHttpsRedirection();
            app.UseMvc();

            //配置Swagger  
            //浏览地址：http://localhost:50449/index.html
            app.UseSwagger();


            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "test");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
