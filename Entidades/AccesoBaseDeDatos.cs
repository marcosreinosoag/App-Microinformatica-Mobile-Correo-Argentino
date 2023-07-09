using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoBaseDeDatos
    {
        static string connectionString;
        static SqlConnection connection;
        static SqlCommand command;

        static AccesoBaseDeDatos()
        {
            connectionString = @"Server = .\MSSQLSERVER01; Database = MicroinformaticaMobile_DB; Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
        }
        public Dispositivo ObtenerDispositivo(string auxSerie)
        {
            Dispositivo auxDispositivo = null;
            try
            {
                connection.Open();
                command.CommandText = "select * from Dispositivos where Serie = @Serie";
                command.Parameters.AddWithValue("@Serie", auxSerie);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string numero = reader.GetString(1);
                    string imei = reader.GetString(2);
                    string serie = reader.GetString(3);
                    string marca = reader.GetString(4);
                    string modelo = reader.GetString(5);
                    string estado = reader.GetString(6);

                    AccesoBaseDeDatos accesoBaseDeDatos = new AccesoBaseDeDatos();
                    if (numero != null)
                    {
                        auxDispositivo = new Dispositivo(id, numero, imei, serie, marca, modelo, estado);//sobrecargaaaa
                        return auxDispositivo;
                    }
                    else
                    {
                        auxDispositivo = new Dispositivo(id, numero, imei, serie, marca, modelo, estado);//sobrecargaaaa
                        return auxDispositivo;
                    }
                }
            }
            catch (Exception)
            {
                throw new DBConcurrencyException();
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return auxDispositivo;
        }

        public LineaTelefonica ObtenerLinea(string numero)
        {
            try
            {
                connection.Open();
                command.CommandText = "select * from Lineas where NumeroDeLinea = @NumeroDeLinea";
                command.Parameters.AddWithValue("@NumeroDeLinea", numero);
                SqlDataReader reader = command.ExecuteReader();
                LineaTelefonica auxlinea = null;
                while (reader.Read())
                {
                    string auxNumero = reader.GetString(0);
                    string icId = reader.GetString(1);
                    string compania = reader.GetString(2);

                    auxlinea = new LineaTelefonica(auxNumero, icId, compania);
                }
                return auxlinea;
            }
            catch (Exception)
            {
                throw new DBConcurrencyException();
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public Ubicacion ObtenerUbicacion(string codPlanta)
        {
            try
            {
                connection.Open();
                command.CommandText = "select * from Ubicaciones where CodPLanta = @CodPlanta";
                command.Parameters.AddWithValue("@CodPlanta", codPlanta);
                SqlDataReader reader = command.ExecuteReader();
                Ubicacion auxUbicacion = null;
                while (reader.Read())
                {
                    string nombreSuc = reader.GetString(2);
                    string direccion = reader.GetString(3);
                    string provincia = reader.GetString(5);
                    string codPostal = reader.GetString(7);
                    string zona = reader.GetString(10);

                    auxUbicacion = new Ubicacion(nombreSuc, codPlanta, direccion, provincia, codPostal, zona);
                }
                return auxUbicacion;
            }
            catch (Exception)
            {
                throw new DBConcurrencyException();
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public Usuario ObtenerUsuario(string auxUsuario, string auxClave)
        {
            Usuario usuarioCreado = null;
            try
            {
                connection.Open();
                command.CommandText = "select * from Usuarios where Usuario = @Usuario AND Clave = @Clave";
                command.Parameters.AddWithValue("@Usuario", auxUsuario);
                command.Parameters.AddWithValue("@Clave", auxClave);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string usuario = reader.GetString(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string permiso = reader.GetString(4);

                    usuarioCreado = new Usuario(usuario,nombre,apellido,permiso);
                    return usuarioCreado;

                }
            }
            catch (Exception)
            {
                throw new DBConcurrencyException();
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return usuarioCreado;
        }

        public void AgregarAPlanillaRotoRobado(Dispositivo auxEquipo, LineaTelefonica linea, Ubicacion ubicacion, Ticket auxTicket, DateTime fechaActual, Usuario auxUsuario)
        {
            if (connection is not null)
            {
                try
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO RotoRobado VALUES (@IdEquipo, @Linea,@CodPlanta,@Ticket,@Situacion,@Garantia,@FechaActual,@Usuario)";
                    command.Parameters.AddWithValue("@IdEquipo", auxEquipo.Id);
                    command.Parameters.AddWithValue("@Linea", linea.Numero);
                    command.Parameters.AddWithValue("@CodPlanta", ubicacion.CodPlanta);
                    command.Parameters.AddWithValue("@Ticket", auxTicket.Im);
                    command.Parameters.AddWithValue("@Situacion", auxTicket.Situacion);
                    command.Parameters.AddWithValue("@FechaActual", fechaActual);
                    /////////////
                    command.Parameters.AddWithValue("@Garantia", "SI");
                    ///
                    command.Parameters.AddWithValue("@Usuario", auxUsuario.NombreUsuario);

                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new DBConcurrencyException();
                }
                finally
                {
                    command.Parameters.Clear();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void AgregarTicket(Ticket ticket,Ubicacion ubicacion, Dispositivo equipoUno, Dispositivo equipoDos,LineaTelefonica lineaUno, LineaTelefonica lineaDos, Usuario auxUsuario)
        {
            if (connection is not null)
            {
                try
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO Tickets VALUES (@Im, @CodPlanta,@EquipoUno,@EquipoDos,@LineaUno,@LineaDos,@PiezaDeEnvio,@Destinatario,@Fecha,@Usuario)";
                    command.Parameters.AddWithValue("@Im", ticket.Im);
                    command.Parameters.AddWithValue("@CodPlanta", ubicacion.CodPlanta);
                    command.Parameters.AddWithValue("@EquipoUno", equipoUno.Id);
                    command.Parameters.AddWithValue("@EquipoDos", equipoDos.Id);
                    command.Parameters.AddWithValue("@LineaUno", lineaUno.Numero);
                    command.Parameters.AddWithValue("@LineaDos", lineaDos.Numero);
                    command.Parameters.AddWithValue("@PiezaDeEnvio", ticket.PiezaDeEnvio);
                    command.Parameters.AddWithValue("@Destinatario", ticket.Destinatario);
                    command.Parameters.AddWithValue("@Fecha", DateTime.Now.Date);
                    command.Parameters.AddWithValue("@Usuario", auxUsuario.NombreUsuario);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new DBConcurrencyException();
                }
                finally
                {
                    command.Parameters.Clear();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void AgregarGarantia(Ticket ticket,Dispositivo equipoUno,string falla,DateTime fecha, Usuario auxUsuario)
        {
            if (connection is not null)
            {
                try
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO Garantia VALUES (@ID, @Falla,@Fecha,@Ticket,@Usuario)";
                    command.Parameters.AddWithValue("@ID", equipoUno.Id);
                    command.Parameters.AddWithValue("@Falla", falla);
                    command.Parameters.AddWithValue("@Fecha", fecha.Date);
                    command.Parameters.AddWithValue("@Ticket", ticket.Im);
                    command.Parameters.AddWithValue("@Usuario", auxUsuario.NombreUsuario);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new DBConcurrencyException();
                }
                finally
                {
                    command.Parameters.Clear();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void ModificarEquipo(Dispositivo equipo)
        {
            try
            {
                connection.Open();
                command.CommandText = "UPDATE Dispositivos Set Estado = @Estado, NumeroTelefonico = @NumeroTelefonico, Imei = @Imei WHERE Serie = @Serie";
                command.Parameters.AddWithValue("@Serie", equipo.Serie);
                command.Parameters.AddWithValue("@Imei", equipo.Imei);
                command.Parameters.AddWithValue("@NumeroTelefonico", equipo.Numero);
                command.Parameters.AddWithValue("@Estado", equipo.Estado);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new DBConcurrencyException();
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        //public void AgregarSala(Sala sala)
        //{
        //    if (connection is not null)
        //    {
        //        try
        //        {
        //            connection.Open();
        //            command.CommandText = "INSERT INTO Salas VALUES (@Numero, @Descripcion)";
        //            command.Parameters.AddWithValue("@Numero", sala.NumeroDeSala);
        //            command.Parameters.AddWithValue("@Descripcion", sala.Descripcion);
        //            command.ExecuteNonQuery();
        //        }
        //        catch (Exception)
        //        {
        //            throw new DBConcurrencyException();
        //        }
        //        finally
        //        {
        //            command.Parameters.Clear();
        //            if (connection.State == ConnectionState.Open)
        //            {
        //                connection.Close();
        //            }
        //        }
        //    }
        //}
        //public void AgregarPartida(Sala sala)
        //{
        //    if (connection is not null)
        //    {
        //        try
        //        {
        //            Jugador? jugadorGanador = sala.JugadorGanador;
        //            int? idJGanador = jugadorGanador.Id;
        //            connection.Open();
        //            command.CommandText = "INSERT INTO Partidas VALUES (@NumeroDeSala,@IdJugadorUno,@IdJugadorDos,@IdGanador,@Descripcion)";
        //            command.Parameters.AddWithValue("@NumeroDeSala", sala.NumeroDeSala);
        //            command.Parameters.AddWithValue("@IdJugadorUno", sala.IdJugadorUno);
        //            command.Parameters.AddWithValue("@IdJugadorDos", sala.IdJugadorDos);
        //            command.Parameters.AddWithValue("@IdGanador", idJGanador);
        //            command.Parameters.AddWithValue("@Descripcion", sala.Descripcion);
        //            command.ExecuteNonQuery();
        //        }
        //        catch (Exception)
        //        {
        //            throw new DBConcurrencyException();
        //        }
        //        finally
        //        {
        //            command.Parameters.Clear();
        //            if (connection.State == ConnectionState.Open)
        //            {
        //                connection.Close();
        //            }
        //        }
        //    }
        //}
        //public List<string> ObtenerPartidas()
        //{
        //    try
        //    {
        //        List<string> jugadores = new List<string>();
        //        connection.Open();
        //        command.CommandText = "SELECT NumeroDeSala, Descripcion, Nombre, Apellido FROM Partidas JOIN Jugadores ON Jugadores.Id = Partidas.IdGanador";
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int numeroSala = reader.GetInt32(0);
        //            string descripcion = reader.GetString(1);
        //            string nombre = reader.GetString(2);
        //            string apellido = reader.GetString(3);

        //            string auxPartida = $"N° Sala: {numeroSala}  {descripcion}\t Ganador: {nombre} {apellido}";
        //            jugadores.Add(auxPartida);
        //        }
        //        return jugadores;
        //    }
        //    catch
        //    {
        //        throw new DBConcurrencyException();
        //    }
        //    finally
        //    {
        //        command.Parameters.Clear();
        //        if (connection.State == ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}
    }
}
