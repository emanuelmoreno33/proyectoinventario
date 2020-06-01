using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario
{
    public partial class usuarios : Form
    {
        string MyConnection2 = "server = 127.0.0.1; user id = root; password = 1234; persistsecurityinfo = True; database = inventarioprograma";
        private int contarregistros()
        {
            int registros = 0;
            string Query = "SELECT COUNT(*) FROM usuario where usuario = '" + txtusuario.Text + "';";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                registros = rdr.GetInt32(0);

            }
            MyConn2.Close();
            return registros;
        }
        private void actualizar()
        {
            this.usuarioTableAdapter.Fill(this.inventarioprogramaDataSet1.usuario);
        }
        public usuarios()
        {
            InitializeComponent();
        }
        private void usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioprogramaDataSet1.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.inventarioprogramaDataSet1.usuario);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int otros = contarregistros();
                if (otros == 0)
                {
                    string Query = "insert into usuario(usuario,contraseña) values('" + txtusuario.Text + "',md5('" + txtcontra.Text + "'));";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Usuario creado","Aviso",MessageBoxButtons.OK);
                    actualizar();
                    MyConn2.Close();
                }
                else
                {
                    MessageBox.Show("Usuario con el mismo nombre creado, elija otro nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
