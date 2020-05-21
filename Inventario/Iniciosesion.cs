using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Inventario
{
    public partial class Iniciosesion : Form
    {
        public Iniciosesion()
        {
            InitializeComponent();
        }

        string MyConnection2 = "server = 127.0.0.1; user id = root; password = 1234; persistsecurityinfo = True; database = inventarioprograma";
        private int[] contarregistros()
        {
            int[] registros = new int[2];
            try
            {
                
                string Query = "SELECT COUNT(*),idusuario FROM usuario where usuario = '" + txtusuario.Text + "' and contraseña = md5('" + txtcontra.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                var cmd = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    registros[0] = rdr.GetInt32(0);
                    registros[1] = rdr.GetInt32(1);

                }
                MyConn2.Close();
            }
            catch
            {
                registros[0] = 0;
                registros[1] = 0;
            }
            return registros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] verificacion = contarregistros();
            if (verificacion[0] == 1)
            {
                Form1 forma = new Form1();
                string usuario = txtusuario.Text;
                txtusuario.Clear();
                txtcontra.Clear();
                int idiniciado = verificacion[1];
                forma.ShowDialog(ref idiniciado,usuario);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectas","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
