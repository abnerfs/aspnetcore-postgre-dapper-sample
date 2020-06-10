using Dapper;
using PostgreDapperSample.Database;
using PostgreDapperSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreDapperSample.Repositories
{

    public class ClientRepository : IClientRepository
    {
        private IDBHelper dBHelper;

        public ClientRepository(IDBHelper dBHelper)
        {
            this.dBHelper = dBHelper;
            this.CreateTables();
        }

        public void CreateTables()
        {
            var scripts = new string[]
            {
                "CREATE TABLE IF NOT EXISTS Clients(Id SERIAL PRIMARY KEY, Name VARCHAR(100) NOT NULL)"
            };

            using (var cn = dBHelper.OpenConnection())
                foreach (var script in scripts)
                    cn.Execute(script);
        }

        public void Create(Client client)
        {
            try
            {
                using (var cn = dBHelper.OpenConnection())
                {
                    cn.Execute("INSERT INTO Clients (Name) VALUES(@Name)", client);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> List()
        {
            try
            {
                using (var cn = dBHelper.OpenConnection())
                {
                    return cn.Query<Client>("SELECT * FROM Clients");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
