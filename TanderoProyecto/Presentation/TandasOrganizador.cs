﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using DataAccess;

namespace Proyecto
{
    public partial class TandasOrganizador : Form
    {
        private DataTable dtTandasActuales;
        private DataTable dtTandasPasadas;
        private string query;
        string tanda;
        string idTanda;
        string tandaPasada;
        string idTandaPasada;
        string tandaTerminada;
        String nombreOrganizador;
        static SqlConnection connection;
        public TandasOrganizador()
        {
            InitializeComponent();
        }

        private void TandasOrganizador_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM Tanda WHERE IdOrganizador = " + UserLoginCache.IdUsuario + "AND TandaTerminada = 0";
            dtTandasActuales = GetData(query);
            lbTandasOrganizador.DataSource = GetData(query);
            lbTandasOrganizador.DisplayMember = "NombreTanda";

            query = "SELECT * FROM Tanda WHERE IdOrganizador = " + UserLoginCache.IdUsuario + "AND TandaTerminada = 1";
            dtTandasPasadas = GetData(query);
            lbTandasPasadas.DataSource = GetData(query);
            lbTandasPasadas.DisplayMember = "NombreTanda";

        }

        private void lbTandasOrganizador_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasOrganizador.SelectedItem != null)
            {
                tanda = dtTandasActuales.Rows[lbTandasOrganizador.SelectedIndex]["NombreTanda"].ToString();
                idTanda = dtTandasActuales.Rows[lbTandasOrganizador.SelectedIndex]["IdTanda"].ToString();

                DetalleTandaOrganizador dto = new DetalleTandaOrganizador(idTanda, tanda);
                dto.Show();
            }

        }   
        
        private DataTable GetData(string query)
        {
            DataTable dtTandas = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtTandas.Load(reader);
                }
            }

            return dtTandas;

        }

        private void lbTandasPasadas_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasPasadas.SelectedItem != null)
            {
                tandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["NombreTanda"].ToString();
                idTandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["IdTanda"].ToString();

                DetalleTandaOrganizador dto = new DetalleTandaOrganizador(idTandaPasada, tandaPasada);
                dto.Show();
            }
        }
    }
}

