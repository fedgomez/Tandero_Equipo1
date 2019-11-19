﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Proyecto
{

    public partial class CalificarOrganizador : Form
    {
        private string calif = "Calificar a ";
        private string AssignRating = "Rating Orgnanizador asignado";
        private string nombreOrganizador;
        private int IdOrganizador;
        public CalificarOrganizador(string nombre, int idOrg)
        {
            InitializeComponent();
            nombreOrganizador = nombre;
            IdOrganizador = idOrg;
        }

        private void CalificarOrganizador_Load(object sender, EventArgs e)
        {
            tbCalificar.Text = calif + nombreOrganizador;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalificarOrg_Click(object sender, EventArgs e)
        {
            if (tbCalificar.Text != "")
            {
                TandaModel rating = new TandaModel();
                var validRating = rating.UserRating(tbCalificar.Text, false, IdOrganizador);
                if (validRating == true)
                {
                    MessageBox.Show(AssignRating);
                    this.Hide();
                }
            }
            this.Close();
            this.Close();
        }
    }
}
