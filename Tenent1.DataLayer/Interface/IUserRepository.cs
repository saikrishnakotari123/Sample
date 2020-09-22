using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tenent1.BusniessLayer.Entites;

namespace Tenent1.DataLayer
{
    public interface IUserRepository
    {
        //IEnumerable<User> GetALL();
        //User GetByID(int id);
        //bool Save(User model);
        Task<IList<User>> GetAllAsync();
        Task<User> GetByIdAsyn(int id);
        Task SaveAsync(User item);
    }
}
