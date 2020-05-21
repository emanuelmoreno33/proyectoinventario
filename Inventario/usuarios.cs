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

        public usuarios()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventarioprogramaDataSet1);

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
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into usuario(usuario,contraseña) values('" + txtusuario.Text + "',md5('" + txtcontra.Text + "'));";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Usuario creado");
                    while (MyReader2.Read())
                    {
                    }
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
