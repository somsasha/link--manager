﻿using System.Security.Claims;

namespace LinkManager.Angular.Services.Extensions
{
    public static class UserExtensions
    {
        public static string GetUserId(this ClaimsPrincipal claims)
        {
            return claims.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
