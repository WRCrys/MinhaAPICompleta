using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;

namespace DevCA.Business.Interfaces
{
    public interface IUser
    {
        string Name { get; }

        Guid GetUserId();

        string GetUserEmail();

        bool IsAuthenticated();

        bool IsInsRole(string role);

        IEnumerable<Claim> GetClaimsIdentity();
    }
}
