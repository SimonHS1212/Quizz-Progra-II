using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaLogica;


namespace Quizz_Progra_II.Capa_Vistas
{
    public partial class Schools : System.Web.UI.Page
    {
        private readonly SchoolLogic schoolLogic;

        public Schools()
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