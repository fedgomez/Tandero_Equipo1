﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;


namespace Proyecto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LoadUserData();
        }


        private void LoadUserData()
        {
            nombreLabel.Text = UserLoginCache.Nombre;
            label2.Text = (UserLoginCache.sumRatingP / UserLoginCache.numVotosP).ToString();
        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginTandero l = new LoginTandero();
            l.Show();
            //TO DO: Cerrar la sesión activa con base de datos
        }

        private void btnTandas_Click(object sender, EventArgs e)
        {
            //Tandas t = new Tandas();
            //t.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil();
            p.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}