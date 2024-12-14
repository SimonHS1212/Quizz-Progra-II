using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CapaModulo;



namespace CapaLogica
{
    public class SchoolLogic
    {
        private readonly SchoolModule schoolModule;

        public SchoolLogic()
        {
            schoolModule = new SchoolModule();
        }

        public DataTable ObtenerEscuelas()
        {
            return schoolModule.GetAllSchools();
        }

        public void AgregarEscuela(string nombre, string descripcion, string direccion, string telefono, string codigoPostal, string direccionPostal)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre de la escuela no puede estar vacío.");
            }

            schoolModule.InsertSchool(nombre, descripcion, direccion, telefono, codigoPostal, direccionPostal);
        }
    }
}