using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonalesApp
{
    public class PersonaRepositorio : RepositorioBase
    {
        public void InsertarPersona(Persona persona)
        {
            try
            {
                this.OpenConnection();

                SqlCommand guardar = new SqlCommand("insert into Persona(Nombre, Apellido, FechaNacimiento) values(@nombre, @apellido, @fechaNacimiento)", SqlConn);

                guardar.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                guardar.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                guardar.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime).Value = persona.FechaNaciciento;
                guardar.ExecuteReader();


            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear Persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Persona> GetAllPersonas()
        {
            try
            {
                this.OpenConnection();

                SqlCommand lista = new SqlCommand("select * from persona", SqlConn);



                SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();
    
                while (drAlumnos.Read())
                {
                    Alumnos pr = new Alumnos();
                    pr.idAlumno = (int)drAlumnos["idAlumno"];
                    pr.nombre = (string)drAlumnos["nombre"];
                    pr.legajo = (int)drAlumnos["legajo"];
                    pr.edad = (int)drAlumnos["edad"];
                    pr.fechanac = (DateTime)drAlumnos["fechanac"];
                    alumnos.Add(pr);
                }
                drAlumnos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Alumnos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnos;
        }
    
    }
}
