using Banking_Management_System.Exceptions;
using System.Text.Json;

namespace Banking_Management_System.Middleware
{
    public class GlobalExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next= next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }

            catch (AcountNotFoundException ex)
            {
                await HandleException(context, StatusCodes.Status404NotFound, ex.Message);
            }

            catch (DuplicateAccountException ex)
            {
                await HandleException(context, StatusCodes.Status409Conflict, ex.Message);
            }

            catch (InvalidBalanceException ex)
            {
                await HandleException(context, StatusCodes.Status400BadRequest, ex.Message);
            }

            catch (UserNotFoundException ex)
            {
                await HandleException(context, StatusCodes.Status404NotFound, ex.Message);
            }

            catch (Exception ex)
            {
                await HandleException(context, StatusCodes.Status500InternalServerError,
                    "An unexpected error occurred.");
            }
        }

        private static async Task HandleException(HttpContext context, int statusCode, string message)
        {
            context.Response.ContentType = "application/json";

            context.Response.StatusCode = statusCode;

            var response = new ErrorResponse
            {
                StatusCode = statusCode,
                Message = message,
                TimeStamp = DateTime.UtcNow
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
