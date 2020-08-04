using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IJWTTokenService
    {
        string CreateToken(User user);
        string CreateRefreshToken(User user);
     //   Task<TokensDTO> RefreshAuthToken(string oldAuthToken, string refreshToken);
    }
}
