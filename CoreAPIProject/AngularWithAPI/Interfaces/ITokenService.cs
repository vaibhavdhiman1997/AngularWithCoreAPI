using AngularWithAPI.Models;

namespace AngularWithAPI.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(User user);
    }
}
