using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Interfaces
{
    public interface IbdMetodos
    {
        int Ejecutar(String sql);
        DataTable Consultar(String sql);
    }
}
