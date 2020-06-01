using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ayuda : Form
    {
        public ayuda()
        {
            InitializeComponent();
        }

        // Codigo del combobox que permite mostrar que ventana se desea obtener ayuda, en caso de lograr ingresar un valor nulo, mostrara la ventana de origen
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se obtiene el valor seleccionado del combobox
            string valor = comboBox1.SelectedItem.ToString();

            //con if anidados se comprueba que valor es el que solicito.
            //primero se obtiene la imagen de los recursos que se tienen, luego cambia el texto.
            if(valor == "inventario")
            {
                pictureBox1.Image = Properties.Resources.Anotación_2020_05_13_182905;
                label2.Text = "Inventario:\r\nMuestra en una tabla los productos sobrantes\r\n\r\nProduccion:\r\nGuarda cuanta produccion se hizo, para ello,\r\nse debe indicar cuanto fue en cada tipo de\r\nproduccion y dar en confirmar, se hará una\r\ndisminución indicando cuando hay poco stock\r\no no se realizara si no hay suficiente.";
            }
            else if(valor == "material")
            {
                pictureBox1.Image = Properties.Resources.Anotación_2020_05_13_182918;
                label2.Text = "Materiales Nuevos:\r\nEn este apartado se escriben los materiales que no estan registrados. \r\n\r\nMateriales existentes: \r\nEn este apartado se puede agregar mas recursos a los \r\nmateriales que existen. \r\n\r\nModificación:\r\n En este apartado se modifican los recursos ya existentes,\r\nmodificando su cantidad en produccion o de alerta de poco stock.";
            }
            else if(valor == "usuario")
            {
                pictureBox1.Image = Properties.Resources.Anotación_2020_05_13_183027;
                label2.Text = "En este apartado se miran los usuarios actuales.\r\n\r\nTambien se pueden agregar nuevos usuarios, dando\r\nusuario y contraseña.";
            }
            else if (valor == "reportes")
            {
                pictureBox1.Image = Properties.Resources.Anotación_2020_05_13_183009;
                label2.Text = "En este apartado se elige un reporte y se crea en PDF.\r\nSe debe indicar la ubicacion donde se guardara el archivo.";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Anotación_2020_05_13_182905;
                label2.Text = "Parte superior:\r\nEs el menu para acceder a varias funciones del programa.\r\n\r\nBarra inferior:\r\nesta barra muestra el status y el usuario con el que se accedio.\r\n\r\nStatus:\r\nMuestra una alerta si hay poco stock.";
            }

        }
    }
}
