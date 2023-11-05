using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.Interfaces
{
    internal interface ICRUD
    {
        object obtener();
        void crear(object modelo);
        void actualizar(object modelo, int id);
        void eliminar(int id);
    }
}
