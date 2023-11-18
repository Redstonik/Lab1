using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Contracts.DTO.Authentications;

namespace Lab1.Contracts.Services
{
    public interface IAuthenticationService
    {
        Task RegistrationAsync(UserRegistrationDTO model);
        Task<UserAutorizationDTO> LoginAsync(UserLoginDTO model);
        Task<UserAutorizationDTO> RefreshTokenAsync(UserAutorizationDTO userTokensDTO);
        Task LogoutAsync(UserAutorizationDTO userTokensDTO);
    }
}
