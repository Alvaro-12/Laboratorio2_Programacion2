using Laboratorio2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Service
{
    public interface IPersona
    {
        void Insertar(persona P);

        ICollection<persona> ListarPersonas();


    }
}
