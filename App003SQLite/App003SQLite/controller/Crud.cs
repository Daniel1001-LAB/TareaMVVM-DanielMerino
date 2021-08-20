using App003SQLite.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App003SQLite.controller
{
    public class Crud
    {
        Coneccion conn = new Coneccion();

     

        public Task<List<Pago>> GetReadPago()
        { 
            return conn.GetConnectionAsync().Table<Pago>().ToListAsync();
        }

        public Task<Pago> getPersonasId(int id)
        {
            return conn
                .GetConnectionAsync()
                .Table<Pago>()
                .Where(item => item.id_pago == id)
                .FirstOrDefaultAsync(); 
        }

        public Task<int> getPersonasUpdateId(Pago pago)
        {
            return conn
                .GetConnectionAsync()
                .UpdateAsync(pago);
              
        }

        public Task<int> Delete(Pago pago)
        {
            return conn
                .GetConnectionAsync()
                .DeleteAsync(pago);
        }


    }
}
