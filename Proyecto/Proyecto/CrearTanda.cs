using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CrearTanda : Form
    {
        public CrearTanda()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=CLEOPATRA;Initial Catalog=Tandero;Integrated Security=True");


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //TO DO: Crear una nueva tanda en la base de datos
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            /*cmd.CommandText = "Insert into Tanda values(5,1, '"+ dateTimePicker1.Value.Date+ "'," + textBox1.Text +
                              "," + textBox2.Text + "," + textBox3.Text + ",'" + textBox4.Text + "','" +textBox5.Text + "')";
            */

            int date3 = dateTimePicker1.Value.Day;
            int date2 = dateTimePicker1.Value.Month;
            int date = dateTimePicker1.Value.Year;

            String fecha = (date + "-" + date2 + "-" + date3);
            MessageBox.Show(fecha);

            cmd.CommandText = "insert into tanda Values (8,1,'"+fecha+"',15,20,150,'dsasd','sdasa')";
            //MessageBox.Show(dateTimePicker1.Value.ToShortDateString());

                cmd.ExecuteNonQuery();
                con.Close();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}