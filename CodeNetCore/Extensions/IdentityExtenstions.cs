using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CodeNetCore.Extensions
{
    public static class IdentityExtenstions
    {
        public static string GetspecificClaim(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var claim = claimsPrincipal.Claims.FirstOrDefault(x => x.Type == claimType);
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
