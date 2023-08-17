using Microsoft.CodeAnalysis.CSharp.Syntax;


using System.Security.Claims;

namespace Vcommerce.Web.Infrastructures.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string? GetId(this ClaimsPrincipal user)
    {
        return user.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}