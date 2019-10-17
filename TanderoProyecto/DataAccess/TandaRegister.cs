﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// Actualizar Base de datos para autoincrementar ID de las Tandas y del Usuario
/// </summary>
namespace DataAccess
{
    public class TandaRegister : ConnectionToSql
    {
        public bool RegistrarTanda(int IdOrganizador, String FechaInicio, int DiaPago, int NoParticipantes, int Monto, String Codigo, String NombreTanda)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Tanda where codigo = @codigo or NombreTanda = @NombreTanda";
                    command.Parameters.AddWithValue("@codigo", Codigo);
                    command.Parameters.AddWithValue("@NombreTanda", NombreTanda);
                    
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Datos duplicados");
                        return false;
                    }
                }

            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "Insert into Tanda values (@IdOrganizador, @FechaInicio, @DiaPago, @NoParticipantes, @Monto, @Codigo, @NombreTanda, @TandaTerminada)";
                    command.Parameters.AddWithValue("@IdOrganizador", IdOrganizador);
                    command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                    command.Parameters.AddWithValue("@DiaPago", DiaPago);
                    command.Parameters.AddWithValue("@NoParticipantes", NoParticipantes);
                    command.Parameters.AddWithValue("@Monto", Monto);
                    command.Parameters.AddWithValue("@Codigo", Codigo);
                    command.Parameters.AddWithValue("@NombreTanda", NombreTanda);
                    command.Parameters.AddWithValue("@TandaTerminada", 0);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;

                }
            }




        }

        public bool UserRating(string Rating, bool Tipo, int IdUsuario)
        {
            int reg = Int32.Parse(Rating);
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Rate", reg);
                    command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    if (Tipo == true)
                    {
                        command.CommandText = "Update Usuario set sumRatingP = sumRatingP + @Rate, numVotosP = numVotosP + 1 where IdUsuario = @IdUsuario";
                    }
                    else 
                    {
                        command.CommandText = "Update Usuario set sumVotosO = sumVotosO + @Rate, numVotosO = numVotosO + 1 where IdUsuario = @IdUsuario";
                    }
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;
                }
            }
        }
        public bool GetUserRating(int IdUsuario, bool Type)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    if (Type == true)
                    {
                        command.CommandText = "Select u.numVotosP, u.sumRatingP from Usuario u where IdUsuario = @IdUsuario";
                    }
                    else
                    {
                        command.CommandText = "Select u.numVotosO, u.sumVotosO from Usuario u where IdUsuario = @IdUsuario";
                    }
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;
                }
            }
        }

    }
}
