﻿namespace COMP003B.Lecture.activity2_1.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;


        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"[Response] {context.Response.StatusCode}");
        }
    }
}
