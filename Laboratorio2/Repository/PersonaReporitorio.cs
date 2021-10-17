using Laboratorio2.Data;
using Laboratorio2.Dominio;
using Laboratorio2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Repository
{
    public class PersonaReporitorio : IPersona
    {
        private ApplicationDbContext app;

        public PersonaReporitorio(ApplicationDbContext app)
        {
            this.app = app;
        }

        public void Insertar(persona P)
        {
            app.Add(P);
            app.SaveChanges();
        }

        public ICollection<persona> ListarPersonas()
        {
            return app.Persona.ToList();
        }
    }
}
