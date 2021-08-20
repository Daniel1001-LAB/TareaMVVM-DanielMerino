using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App003SQLite.model
{
    class Pago
    {
        [PrimaryKey, AutoIncrement]
        public int id_pago { get; set; }
        [MaxLength(250)]
        public string Descripcion { get; set; }
        [MaxLength(250)]
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        
        public byte[] Photo_recibo { get; set; }
        
    }
}
