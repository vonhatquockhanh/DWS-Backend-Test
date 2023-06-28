using System.Collections.Generic;
using System.Threading.Tasks;
using APIDWS.Models;

namespace APIDWS.IRepositories {
    public interface IAuthRepository {
        bool SaveChanges ();

        Task<User> Register (User user);
        Task<User> Login (User user);
    }
}