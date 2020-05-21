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
    public partial class Form1 : Form
    {
        int idusuario = 0;
        string MyConnection2 = "server = 127.0.0.1; user id = root; password = 1234; persistsecurityinfo = True; database = inventarioprograma";

        public Form1()
        {
            InitializeComponent();
        }

        private int contarregistros()
        {
            int registros = 0;
            string Query = "SELECT COUNT(*) FROM material;";
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

        private void actualizarforma()
        {
            this.materialusarioTableAdapter.Fill(this.inventarioprogramaDataSet1.materialusario);
            combomaterialact.BeginUpdate();
            this.materialTableAdapter.Fill(this.inventarioprogramaDataSet1.material);
            combomaterialact.EndUpdate();
        }

        private void obtenerdatosmod()
        {
            try
            {
                string Query = "select nombre,cantidad_inicial,stock_alert,cant_speed,cant_flex,cant_360 from material where idmaterial =" + modmaterialnombre.SelectedValue + ";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                var cmd = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    matmodnombrenuevo.Text = rdr.GetString(0);
                    matmodcantidad.Value = rdr.GetInt32(1);
                    matmodalerta.Value = rdr.GetInt32(2);
                    modspeed.Value = rdr.GetInt32(3);
                    modflex.Value = rdr.GetInt32(4);
                    mod360.Value = rdr.GetInt32(5);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioprogramaDataSet1.materialusario' Puede moverla o quitarla según sea necesario.
            this.materialusarioTableAdapter.Fill(this.inventarioprogramaDataSet1.materialusario);
            // TODO: esta línea de código carga datos en la tabla 'inventarioprogramaDataSet1.material' Puede moverla o quitarla según sea necesario.
            this.materialTableAdapter.Fill(this.inventarioprogramaDataSet1.material);
            // TODO: esta línea de código carga datos en la tabla 'inventarioprogramaDataSet.material' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'inventarioprogramaDataSet.material' Puede moverla o quitarla según sea necesario.
            Inventario.Visible = true;
            Material.Visible = false;
            obtenerdatosmod();
        }

        public void ShowDialog(ref int idiniciado,string nombre)
        {
            idusuario = idiniciado;
            toolStripStatusLabel2.Text = "Usuario:" + nombre;
            this.ShowDialog();
        }

        private void CmdInventario_Click_1(object sender, EventArgs e)
        {
            Inventario.Visible = true;
            Material.Visible = false;
        }

        private void CmdMaterial_Click(object sender, EventArgs e)
        {
            Inventario.Visible = false;
            Material.Visible = true;
        }

        private void cmdAyuda_Click(object sender, EventArgs e)
        {
            ayuda ay = new ayuda();
            ay.Show();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into material(nombre,cantidad_inicial,stock_alert,cant_speed,cant_flex,cant_360,usuario_registrado) values('" + matnuenom.Text + "','" + matnuevocant.Value + "','" + matnuevoalerta.Value + "','" + matnuevospeed.Value + "','" + matflexnuevo.Value + "','"+matnuevo360.Value+"',"+idusuario+");";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                actualizarforma();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
           try
            {
            //This is my update query in which i am taking input from the user through windows forms and update the record.  
            string Query = "update material set cantidad_inicial=cantidad_inicial+"+matactcant.Value+" where idmaterial =" + combomaterialact.SelectedValue + ";";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Datos actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
                actualizarforma();
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();//Connection closed here  
            }  
            catch (Exception ex)  
            {   
                MessageBox.Show(ex.Message);  
            }
}

        private void btnmodificacion_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update material set nombre='"+matmodnombrenuevo.Text+"',cantidad_inicial=" + matmodcantidad.Value + ", stock_alert="+matmodalerta.Value+",cant_speed="+modspeed.Value+",cant_flex="+modflex.Value+",cant_360="+mod360.Value+"  where idmaterial =" + modmaterialnombre.SelectedValue + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Datos actualizados","Aviso",MessageBoxButtons.OK,MessageBoxIcon.None);
                actualizarforma();
                obtenerdatosmod();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modmaterialnombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerdatosmod();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(prodspeed.Value);
            int flex = Convert.ToInt32(prodflex.Value);
            int v360 = Convert.ToInt32(prod360.Value);
            int index = 0;
            int registros = contarregistros();

            int[] id = new int[registros];
            string[] nombrematerial = new string[registros];
            int[] inicio = new int[registros];
            int[] speedguardado =new int[registros];
            int[] flexguardado = new int[registros];
            int[] v360guardado= new int[registros];
            int[] alerta = new int[registros];

            int[] calculo = new int[registros];

         
            string Query = "select nombre,cantidad_inicial,cant_speed,cant_flex,cant_360,idmaterial,stock_alert from material;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            var cmd = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                {
                nombrematerial[index] = rdr.GetString(0);
                inicio[index]=rdr.GetInt32(1);
                speedguardado[index]=rdr.GetInt32(2);
                flexguardado[index] = rdr.GetInt32(3);
                v360guardado[index]=rdr.GetInt32(4);
                id[index] = rdr.GetInt32(5);
                alerta[index] = rdr.GetInt32(6);

                index++;
                }
            MyConn2.Close();
            bool valido = true;
            for (int i=0;i<inicio.Length;i++)
            {
                calculo[i] = inicio[i] - (speedguardado[i] * speed) - (flexguardado[i] * flex) - (v360guardado[i] * v360);
                if(calculo[i] < 0)
                {
                    MessageBox.Show("No es posible, no hay stock suficiente de "+nombrematerial[i]+" para la demanda indicada","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    valido = false;
                    break;
                }
                else if(calculo[i]<=alerta[i])
                {
                    MessageBox.Show("¡Alerta de poco stock de" + nombrematerial[i] + "!", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    toolStripStatusLabel1.Text = "¡Alerta de stock!";
                }
                else
                {
                    MessageBox.Show("materiales sobrantes=" + calculo[i].ToString());
                }
            }
            if (valido == true)
            {
                for (int i = 0; i < inicio.Length; i++)
                {
                    //This is my update query in which i am taking input from the user through windows forms and update the record.  
                    string Query2 = "update material set cantidad_inicial=" + calculo[i] + "  where idmaterial ="+id[i]+";";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlCommand MyCommand = new MySqlCommand(Query2, MyConn2);
                    MySqlDataReader MyReader;
                    MyConn2.Open();
                    MyReader = MyCommand.ExecuteReader();
                    MessageBox.Show("Datos actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
                    while (MyReader.Read())
                    {
                    }
                    MyConn2.Close();//Connection closed here
                }
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query3 = "insert into registros_produccion(prod_flex,prod_speed,prod_360,fecha_produccion,usuario) values("+flex+","+speed+","+v360+",NOW(),"+idusuario+");";
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query3, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                actualizarforma();
            }     

        }

        private void cmdreportes_Click(object sender, EventArgs e)
        {
            reportes rp = new reportes();
            rp.ShowDialog();
        }

        private void cmdusuarios_Click(object sender, EventArgs e)
        {
            usuarios us = new usuarios();
            us.ShowDialog();
        }

    }
}