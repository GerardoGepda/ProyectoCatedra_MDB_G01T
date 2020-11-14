using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Grupo
    {
        //Elementos para conexión y queries
        private static Connection connection = new Connection();
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;

        //variables
        private string idGrupo;
        private int cupo;
        private string idCurso;
        private string idMaestro;
        private Curso cursoGrupo;
        private List<Horario> horarios;
        private Maestro maestroGrupo;

        //Propiedades
        public string IdGrupo { get => idGrupo; set => idGrupo = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public string IdCurso { get => idCurso; set => idCurso = value; }
        public string IdMaestro { get => idMaestro; set => idMaestro = value; }
        public Curso CursoGrupo { get => cursoGrupo; set => cursoGrupo = value; }
        public List<Horario> Horarios { get => horarios; set => horarios = value; }
        public Maestro MaestroGrupo { get => maestroGrupo; set => maestroGrupo = value; }

        //métodos
        public static List<Grupo> ExtraerGrupos(string idCurso)
        {
            List<Grupo> grupos = new List<Grupo>();
            string sqlSelect = "SELECT grp.IDGrupo, Cupo, IDCurso, IDMaestro FROM Grupos grp ";
            sqlSelect += "INNER JOIN Detalle_GruposMaestros dgrp ";
            sqlSelect += "ON grp.IDGrupo = dgrp.IDGrupo ";
            sqlSelect += "WHERE grp.IDCurso = @idCurso";
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@idCurso", idCurso);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Grupo grupo = new Grupo();
                        grupo.IdGrupo = dataReader[0].ToString();
                        grupo.Cupo = Convert.ToInt32(dataReader["Cupo"]);
                        grupo.idCurso = dataReader["IDCurso"].ToString();
                        grupo.IdMaestro = dataReader["IDMaestro"].ToString();
                        grupo.CursoGrupo = Curso.ExtraerCurso(grupo.IdCurso);
                        grupo.Horarios = Horario.ExtraerHorariosGrupo(grupo.IdGrupo);
                        grupo.MaestroGrupo = Maestro.ExtraerMaestro(grupo.IdMaestro);
                        grupos.Add(grupo);
                        grupo = null;
                    }
                }
                else
                {
                    MessageBox.Show("Todavía no hay ningún grupo para este curso, considere agregar alguno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer grupos desde la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return grupos;
        }

        public void ActualizarGrupo()
        {
            int filasAfectadas = 0;
            int filasAfectadas2 = 0;
            string sqlUpdate = "UPDATE Grupos SET Cupo = @cupo WHERE IDGrupo = @idGrupo";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlUpdate, connection.Conn);
                command.Parameters.AddWithValue("@cupo", Cupo);
                command.Parameters.AddWithValue("@idGrupo", IdGrupo);
                filasAfectadas = command.ExecuteNonQuery();
                filasAfectadas2 = ActualizarGrupoMaestro(IdMaestro);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al actualizar el grupo: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }

            if (filasAfectadas != 0 && filasAfectadas2 != 0)
            {
                MessageBox.Show("Se actualizó el grupo satisfactoriamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el grupo, contacte con el administrador para asegurar la integridad de los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int ActualizarGrupoMaestro(string idMaestro)
        {
            string sqlUpdate = "UPDATE Detalle_GruposMaestros SET IDMaestro = @idMaestro";

            command = new SqlCommand(sqlUpdate, connection.Conn);
            command.Parameters.AddWithValue("@idMaestro", idMaestro);

            return command.ExecuteNonQuery();
        }

        public void BorrarGrupo()
        {
            int filasAfectadas = 0;
            int filasAfectadas2 = 0;
            string sqlDelete = "DELETE FROM Grupos WHERE IDGrupo = @idGrupo";
            try
            {
                connection.Conectar();
                filasAfectadas2 = BorrarDetalles(IdGrupo);
                command = new SqlCommand(sqlDelete, connection.Conn);
                command.Parameters.AddWithValue("@idGrupo", IdGrupo);
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al borrar grupo de la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (filasAfectadas != 0 && filasAfectadas2 != 0)
                MessageBox.Show("Se borró el grupo satisfactoriamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hubo un error al borrar datos del grupo en la BD, por favor consulte con el administrador para asegurar la integridad de los datos", 
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private int BorrarDetalles(string idGrupo)
        {
            string sqlDelete = "DELETE FROM Detalle_GruposMaestros WHERE IDGrupo = @idGrupo";
            command = new SqlCommand(sqlDelete, connection.Conn);
            command.Parameters.AddWithValue("@idGrupo", idGrupo);
            return command.ExecuteNonQuery();
        }

    }
}
