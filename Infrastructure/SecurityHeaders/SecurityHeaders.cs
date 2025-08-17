using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using StoreWeb.Infrastructure.SecurityHeaders;

namespace Infrastructure.SecurityHeaders;

internal static class Startup
{
    internal static IApplicationBuilder UseSecurityHeaders(this IApplicationBuilder app, IConfiguration config)
    {
        var settings = config.GetSection(nameof(SecurityHeaderSettings)).Get<SecurityHeaderSettings>();

        if (settings?.Enable is true)
        {
            app.Use(async (context, next) =>
            {
                if (!context.Response.HasStarted)
                {
                    if (!string.IsNullOrWhiteSpace(settings.Headers.XFrameOptions))
                        context.Response.Headers.Append(HeaderNames.Xframeoptions, settings.Headers.XFrameOptions);

                    if (!string.IsNullOrWhiteSpace(settings.Headers.XContentTypeOptions))
                        context.Response.Headers.Append(HeaderNames.Xcontenttypeoptions, settings.Headers.XContentTypeOptions);

                    if (!string.IsNullOrWhiteSpace(settings.Headers.ReferrerPolicy))
                        context.Response.Headers.Append(HeaderNames.Referrerpolicy, settings.Headers.ReferrerPolicy);

                    if (!string.IsNullOrWhiteSpace(settings.Headers.PermissionsPolicy))
                        context.Response.Headers.Append(HeaderNames.Permissionspolicy, settings.Headers.PermissionsPolicy);

                    if (!string.IsNullOrWhiteSpace(settings.Headers.SameSite))
                        context.Response.Headers.Append(HeaderNames.Samesite, settings.Headers.SameSite);
                }

                await next();
            });
        }

        return app;
    }
}
