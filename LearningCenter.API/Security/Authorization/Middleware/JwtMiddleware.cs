using LearningCenter.API.Security.Authorization.Handlers.Interfaces;
using LearningCenter.API.Security.Authorization.Settings;
using LearningCenter.API.Security.Domain.Services;
using Microsoft.Extensions.Options;

namespace LearningCenter.API.Security.Authorization.Middleware;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly AppSettings _appSettings;

    public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
    {
        _next = next;
        _appSettings = appSettings.Value;
    }

    public async Task Invoke(
        HttpContext context,
        IUserService userService,
        IJwtHandler handler)
    {
       // Get Token
       var token = context.Request.Headers["Authorization"]
           .FirstOrDefault()?
           .Split(" ")
           .Last();
       // Extract userId
       var userId = handler.ValidateToken(token);

       // Store in context if not null
       if (userId != null)
           context.Items["User"] = await userService.GetByIdAsync(userId.Value);
       
       // Call next in chain
       await _next(context);
    }
}