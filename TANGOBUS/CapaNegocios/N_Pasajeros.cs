using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Pasajeros
    {
        readonly D_Pasajeros objpasajeros = new D_Pasajeros();


        public static DataTable MostrarRegistros()
        {
            return new D_Pasajeros().Mostrartegistros();
        }


        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_Pasajeros().BuscarRegistros(textobuscar);
        }


        public void InsertarRegistros(E_Pasajeros pasajeros)
        {
            objpasajeros.InsertarRegistros(pasajeros);
        }


        public void EditarRegistros(E_Pasajeros pasajeros)
        {
            objpasajeros.EditarRegistros(pasajeros);
        }

        public void EliminarRegistros(E_Pasajeros pasajeros)
        {
            objpasajeros.EliminarRegistros(pasajeros);
        }
    }
}

