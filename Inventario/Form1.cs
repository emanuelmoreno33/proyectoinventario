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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioprogramaDataSet1.material' Puede moverla o quitarla según sea necesario.
            this.materialTableAdapter.Fill(this.inventarioprogramaDataSet1.material);
            // TODO: esta línea de código carga datos en la tabla 'inventarioprogramaDataSet.material' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'inventarioprogramaDataSet.material' Puede moverla o quitarla según sea necesario.
            Inventario.Visible = true;
            Material.Visible = false;
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

        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();

        }

        private void materialBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();

        }

        private void materialBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventarioprogramaDataSet1);

        }

        string MyConnection2 = "server = 127.0.0.1; user id = root; password = 1234; persistsecurityinfo = True; database = inventarioprograma";
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into material(nombre,cantidad_inicial,stock_alert,cant_speed,cant_flex,cant_360,usuario_registrado) values('" + matnuenom.Text + "','" + matnuevocant.Value + "','" + matnuevoalerta.Value + "','" + matnuevospeed.Value + "','" + matflexnuevo.Value + "','"+matnuevo360.Value+"',1);";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
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
            MessageBox.Show("Data Updated");
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
                string Query = "update material set nombre="+matmodnombrenuevo.Text+",cantidad_inicial=" + matmodcantidad.Value + ", stock_alert="+matmodalerta.Value+",cant_speed="+modspeed.Value+",cant_flex="+modflex.Value+",cant_360="+mod360.Value+"  where idmaterial =" + modmaterialnombre.SelectedValue + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
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
           try
            {
            string Query = "select * from student.studentinfo;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class.  
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            }  
           catch (Exception ex)  
            {   
                MessageBox.Show(ex.Message);  
            }
}  
        }
    }
