using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_MoviesLibrary.Repositories
{
    public interface IPrivelegedUserRepository
    {
        PrivelegedUser? Authenticate(int userId, string password);
    }

}
