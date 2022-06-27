using System.Text.Json;

namespace TMU_OIT_SC.Web.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                //switch (error)
                //{

                //}
                var result = JsonSerializer.Serialize(new { Code = 500, Message = error?.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
