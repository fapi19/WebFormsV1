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
    public partial class AlumnosForm : System.Web.UI.Page
    {
        private AlumnoMySQL alumnoDao;
        public static string opcion = "";
        public static string sId = "-1";
        protected void Page_Load(object sender, EventArgs e)
        {
            alumnoDao = new AlumnoMySQL();
            if (!IsPostBack)
            {
                opcion = Request.QueryString["op"];
                sId = Request.QueryString["id"];
                if (opcion == "upd" && !string.IsNullOrEmpty(sId)) 
                    CargarDatos();
            }
        }

        private void CargarDatos()
        {
            int idUpd = int.Parse(sId);            
            Alumno alumno = alumnoDao.listar(idUpd).FirstOrDefault();
            TxtId.Text = "" + alumno.Id;
            TxtNombre.Text =  alumno.Nombre;
            TxtApellidos.Text = alumno.Apellidos;
            TxtCiclo.Text = ""+alumno.Ciclo;
            TxtMensualidad.Text = "" + alumno.Mensualidad;
            TxtActivo.Checked = alumno.Activo;
        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Alumno alumno = alumno = new Alumno()
            {
                Nombre = TxtNombre.Text,
                Apellidos = TxtApellidos.Text,
                Ciclo = int.Parse(TxtCiclo.Text),
                Mensualidad = double.Parse(TxtMensualidad.Text.Replace(".", ",")),
                Activo = TxtActivo.Checked
            }; 

            if (opcion == "new")
                alumnoDao.insertar(alumno);
            else if(opcion == "upd")
            {
                alumno.Id = int.Parse(sId);
                alumnoDao.modificar(alumno);
            }
            Response.Redirect("/Views/Alumnos.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Alumnos.aspx");
        }
    }
}