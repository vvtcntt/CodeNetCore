﻿using CodeNetCore.Data.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CodeNetCore.Helpers
{
    public class CustomClaimsPrincipalFactory:UserClaimsPrincipalFactory<AppUser,AppRole>
    {
        UserManager<AppUser> _userManager;
        public CustomClaimsPrincipalFactory(UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager,IOptions<IdentityOptions> options):base(userManager,roleManager,options)
        {
            _userManager = userManager;
        }
        public async override Task<ClaimsPrincipal>  CreateAsync(AppUser user)
        {
            var principal = await base.CreateAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
                new Claim("Email",user.Email),
                new Claim("FullName",user.FullName),
                 new Claim("UserName",user.FullName),
                new Claim("Avatar",user.Avatar??string.Empty),
                new Claim("Role",string.Join(";",roles))
            });
            return principal;

        }
    }
}
