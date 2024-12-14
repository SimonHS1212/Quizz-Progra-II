using System;
using System.Data;
using System.Web.UI;
using CapaLogica;

namespace Quizz_Progra_II
{
    public partial class School : Page
    {
        private readonly SchoolLogic schoolLogic;

        public School()
        {
            schoolLogic = new SchoolLogic();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEscuelas();
            }
        }

        private void CargarEscuelas()
        {
            DataTable escuelas = schoolLogic.ObtenerEscuelas();
            gvSchools.DataSource = escuelas;
            gvSchools.DataBind();
        }
    }
}
