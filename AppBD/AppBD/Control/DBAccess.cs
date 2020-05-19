using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppBD.Model;
using SQLite;

namespace AppBD.Control
{
    public class DBAccess
    {
        readonly SQLiteAsyncConnection _database;

        public DBAccess(string route)
        {
            _database = new SQLiteAsyncConnection(route); //conecta ao diretorio onde ficam as tabelas
            _database.CreateTableAsync<Customer>().Wait(); //solicita a criação da tabela de clientes
        }

        public Task <List<Customer>> ListCustomers()
        {
            //select * from Customer
            return _database.Table<Customer>().OrderBy(ct => ct.Name).ToListAsync();
        }

        public Task <int> SaveCustomer(Customer ct)
        {
            //insert into Customer (id, nome, idade) valuer (null, cl.nome, cl.idade)
            return _database.InsertAsync(ct);
        }
    }
}
