using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using TestModels;

namespace TestWeb.Views
{
    public partial class Areas : System.Web.UI.Page
    {
        //=========== DATOS SINTETICOS ===============
        public static List<Area> ListaDatos;
        public static int SequenciaIds;
        static Areas()
        {
            ListaDatos = new List<Area>();
            ListaDatos.Add(new Area() { Id = 1, Nombre = "RRHH", Ubicacion = "Sede Principal" });
            ListaDatos.Add(new Area() { Id = 2, Nombre = "Contable", Ubicacion = "Sede Principal" });
            ListaDatos.Add(new Area() { Id = 3, Nombre = "Almacen", Ubicacion = "Sede Almacen" });
            SequenciaIds = ListaDatos.Count;
        }
        //=============================================

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        private void CargarTabla()
        {
            GridAreas.DataSource = ListaDatos;
            GridAreas.DataBind();
        }
        protected void EditRow_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            Area area = ListaDatos.Find((obj)=> obj.Id == id);
            TxtId.Text = ""+ area.Id;
            TxtNombre.Text = area.Nombre;
            TxtUbicacion.Text = area.Ubicacion;
            CallJavascritp("showModalForm()");
        }
        protected void DelRow_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            ListaDatos.RemoveAt(ListaDatos.FindIndex((obj) => obj.Id == id));
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        protected void ButGuardar_Click(object sender, EventArgs e)
        {
            Area area = null;
            if (string.IsNullOrEmpty(TxtId.Text)) // crear
            {
                area = new Area();
                area.Id = ++SequenciaIds;
                area.Nombre = TxtNombre.Text;
                area.Ubicacion = TxtUbicacion.Text;
                ListaDatos.Add(area);
            }
            else //actualizar
            {
                int id = int.Parse(TxtId.Text);
                area = ListaDatos.Find((obj) => obj.Id == id);
                area.Nombre = TxtNombre.Text;
                area.Ubicacion = TxtUbicacion.Text;
            }
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtNombre.Text = "";
            TxtUbicacion.Text = "";
            CallJavascritp("showModalForm()");
        }
        private void CallJavascritp(string function)
        {
            string script = "window.onload = function() {" + function + "; };";
            ClientScript.RegisterStartupScript(GetType(), "", script, true);
        }         
    }
}