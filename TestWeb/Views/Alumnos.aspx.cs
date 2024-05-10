using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestController.DAO;
using TestController.MYSQL;
using TestModels;

namespace TestWeb.Views
{
    public partial class Alumnos : System.Web.UI.Page
    {       
        private AlumnoMySQL alumnoDao;        
        protected void Page_Load(object sender, EventArgs e)
        {
            alumnoDao = new AlumnoMySQL();
            CargarTabla();
        }
        private void CargarTabla()
        {
            GridAlumnos.DataSource = alumnoDao.listar();
            GridAlumnos.DataBind();
        }
        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/AlumnosForm.aspx?op=new");
        }
        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            string sId = ((LinkButton)sender).CommandArgument;
            Response.Redirect("/Views/AlumnosForm.aspx?op=upd&id="+ sId);
        }
        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string sid = ((LinkButton)sender).CommandArgument;
            int id = int.Parse(sid);
            alumnoDao.eliminar(id);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        protected void GridAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridAlumnos.PageIndex = e.NewPageIndex;
            GridAlumnos.DataBind();
        }
    }
}