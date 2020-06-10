using PostgreDapperSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreDapperSample.Repositories
{
    public interface IClientRepository
    {
        void Create(Client client);
        void Update(Client client);
        void Delete(int Id);
        IEnumerable<Client> List();
    }
}
