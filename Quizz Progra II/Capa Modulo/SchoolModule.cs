using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CapaModulo
{
    public class SchoolModule
    {
        private readonly DatabaseHelper dbHelper;

        public SchoolModule()
        {
            dbHelper = new DatabaseHelper();
        }

        public DataTable GetAllSchools()
        {
            return dbHelper.ExecuteStoredProcedure("ConsultarSchool");
        }

        public void InsertSchool(string schoolName, string description, string address, string phone, string postCode, string postAddress)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SchoolName", schoolName),
                new SqlParameter("@Description", description),
                new SqlParameter("@Address", address ?? (object)DBNull.Value),
                new SqlParameter("@Phone", phone ?? (object)DBNull.Value),
                new SqlParameter("@PostCode", postCode ?? (object)DBNull.Value),
                new SqlParameter("@PostAddress", postAddress ?? (object)DBNull.Value)
            };

            dbHelper.ExecuteStoredProcedure("InsertarSchool", parameters);
        }
    }
}