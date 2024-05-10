using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestController.DAO;
using TestModels;

namespace TestController.MYSQL
{
    public class AlumnoMySQL : AlumnoDAO
    {
        public List<Alumno> listar()
        {
            List<Alumno> result = new List<Alumno>();
            MySqlConnection con = null;
            try
            {
                con = DBManager.Instance.Connection;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select id, nombre, apellidos, ciclo, mensualidad, activo from Alumno";
                MySqlDataReader cursor = cmd.ExecuteReader();
                while (cursor.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.Id = cursor.GetInt32("id");
                    alumno.Nombre = cursor.GetString("nombre");
                    alumno.Apellidos = cursor.GetString("apellidos");
                    alumno.Ciclo = cursor.GetInt32("ciclo");
                    alumno.Mensualidad = cursor.GetDouble("mensualidad");
                    alumno.Activo = cursor.GetBoolean("activo");
                    result.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public List<Alumno> listar(int id)
        {
            List<Alumno> result = new List<Alumno>();
            MySqlConnection con = null;
            try
            {
                con = DBManager.Instance.Connection;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select id, nombre, apellidos, ciclo, mensualidad, activo from Alumno where id=@id_alumno";
                cmd.Parameters.AddWithValue("@id_alumno", id);
                MySqlDataReader cursor = cmd.ExecuteReader();
                while (cursor.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.Id = cursor.GetInt32("id");
                    alumno.Nombre = cursor.GetString("nombre");
                    alumno.Apellidos = cursor.GetString("apellidos");
                    alumno.Ciclo = cursor.GetInt32("ciclo");
                    alumno.Mensualidad = cursor.GetDouble("mensualidad");
                    alumno.Activo = cursor.GetBoolean("activo");
                    result.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public int insertar(Alumno alumno)
        {
            MySqlConnection con = null;
            int result = 0;
            try
            {
                con = DBManager.Instance.Connection;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into Alumno (nombre, apellidos, ciclo, mensualidad, activo) " +
                    "values (@nombre, @apellidos, @ciclo, @mensualidad, @activo)";
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", alumno.Apellidos);
                cmd.Parameters.AddWithValue("@ciclo", alumno.Ciclo);
                cmd.Parameters.AddWithValue("@mensualidad", alumno.Mensualidad);
                cmd.Parameters.AddWithValue("@activo", alumno.Activo);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public int modificar(Alumno alumno)
        {
            MySqlConnection con = null;
            int result = 0;
            try
            {
                con = DBManager.Instance.Connection;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update Alumno set " +
                    "nombre = @nombre, " +
                    "apellidos = @apellidos, " +
                    "ciclo = @ciclo, " +
                    "mensualidad = @mensualidad, " +
                    "activo = @activo " +
                    "where id = @id_alumno";
                cmd.Parameters.AddWithValue("@id_alumno", alumno.Id);
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", alumno.Apellidos);
                cmd.Parameters.AddWithValue("@ciclo", alumno.Ciclo);
                cmd.Parameters.AddWithValue("@mensualidad", alumno.Mensualidad);
                cmd.Parameters.AddWithValue("@activo", alumno.Activo);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public int eliminar(int id)
        {
            MySqlConnection con = null;
            int result = 0;
            try
            {
                con = DBManager.Instance.Connection;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete from Alumno where id = @id_alumno";
                cmd.Parameters.AddWithValue("@id_alumno", id);                
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}

