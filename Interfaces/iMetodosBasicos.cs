using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface iMetodosBasicos
    {
        //metodos
        void Alta(iEntidad entidad);
        void Baja(iEntidad entidad);
        void Modificacion(iEntidad entidad);
        iEntidad buscaPorId(int id);
        List<iEntidad> Todo();
    }
}
