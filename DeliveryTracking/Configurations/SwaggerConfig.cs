namespace DeliveryTracking.Configurations
{
    public static class SwaggerConfig
    {
        private static readonly string _appName = "Tracking Delivery";
        private static readonly string _description =
            $"API Rest desenvolvido por mim para simular um controle de estoque";
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.OpenApiInfo
                {
                    Title = _appName,
                    Version = "v1",
                    Description = _description,
                    Contact = new Microsoft.OpenApi.OpenApiContact
                    {
                        Name = "Alisson",
                        Email = "alissonp-alissonp@hotmail.com",
                        Url = new Uri("https://github.com/AlissonLHP97")
                    }
                });
                options.CustomSchemaIds(type => type.FullName);
            });
            return services;
        }
        public static IApplicationBuilder UseSwaggerSpecification(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                options.RoutePrefix = "swagger-ui";
                options.DocumentTitle = _appName;
            });
            return app;
        }
    }
}
