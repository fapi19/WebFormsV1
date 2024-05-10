using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestController.DAO
{
    public interface GenericoDao<TV, TK>
    {
        int insertar(TV model);
        int modificar(TV model);
        int eliminar(TK key);
        List<TV> listar();
        List<TV> listar(TK key);
    }
}
