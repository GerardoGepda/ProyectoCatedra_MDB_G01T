using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Horario
    {
        //Elementos para conexión y queries
        private static Connection connection = new Connection();
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;

        //Variables
        private string idHorario;
        private string idGrupo;
        private string dia;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;

        //Propiedades
        public string IdHorario { get => idHorario; set => idHorario = value; }
        public string IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string Dia { get => dia; set => dia = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }

        //Métodos
        public static List<Horario> ExtraerHorariosGrupo(string idGrupo)
        {
            List<Horario> horarios = new List<Horario>();
            string sqlSelect = "SELECT * FROM Horarios WHERE IDGrupo = @idGrupo";
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@idGrupo", idGrupo);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Horario horario = new Horario
                        {
                            IdHorario = dataReader["IDHorario"].ToString(),
                            IdGrupo = dataReader["IDGrupo"].ToString(),
                            Dia = dataReader["Dia"].ToString(),
                            HoraInicio = Convert.ToDateTime(dataReader["HoraInicio"].ToString()).TimeOfDay,
                            HoraFin = Convert.ToDateTime(dataReader["HoraFIn"].ToString()).TimeOfDay
                        };
                        horarios.Add(horario);
                        horario = null;
                    }
                }
                else
                {
                    MessageBox.Show("Debe agregar horarios a este grupo para que este disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer horarios desde la BD: " + err.Message, "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return horarios;
        }

        public void ActualizarHorario()
        {
            int filasAfectadas = 0;
            string sqlUpdate = "UPDATE Horarios SET Dia = @dia, HoraInicio = @horaInicio, HoraFin = @horaFin WHERE IDHorario = @idHorario";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlUpdate, connection.Conn);
                command.Parameters.AddWithValue("@dia", Dia);
                command.Parameters.AddWithValue("@horaInicio", HoraInicio);
                command.Parameters.AddWithValue("@horaFin", HoraFin);
                command.Parameters.AddWithValue("@idHorario", IdHorario);
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al actualizar el horario: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }

            if (filasAfectadas != 0)
            {
                MessageBox.Show("Se actualizó el horario satisfactoriamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el horario, contacte con el administrador para asegurar la integridad de los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void BorrarHorario(string idHorario)
        {
            int filasAfectadas = 0;
            string sqlDelete = "DELETE FROM Horarios WHERE IDHorario = @idHorario";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlDelete, connection.Conn);
                command.Parameters.AddWithValue("@idHorario", idHorario);
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al borrar horario de la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (filasAfectadas != 0)
                MessageBox.Show("Se borró el horario satisfactoriamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hubo un error al borrar datos del horario en la BD, por favor consulte con el administrador para asegurar la integridad de los datos",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
