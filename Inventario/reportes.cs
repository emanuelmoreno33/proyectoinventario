using System;
using System.Windows.Forms;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Pdf;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Font; 
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Inventario
{
    public partial class reportes : Form
    {
        public reportes()
        {
            InitializeComponent();
        }

        string MyConnection2 = "server = 127.0.0.1; user id = root; password = 1234; persistsecurityinfo = True; database = inventarioprograma";

        private int contarregistros()
        {
            int registros = 0;
            string Query = "SELECT COUNT(*) FROM materialregistro;";
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

        private Table consultamaterial(int valor)
        {
            //estilo titulo tabla
            Style titulo = new Style();
            PdfFont f = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLDOBLIQUE);
            titulo.SetFont(f).SetFontSize(16).SetTextAlignment(TextAlignment.CENTER);
            
            //estilo encabezado
            Style encabezado = new Style();
            PdfFont f1 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            encabezado.SetFont(f1).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT);
            
            //estilo cuerpo general
            Style cuerpogeneral = new Style();
            PdfFont f2 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            cuerpogeneral.SetFont(f2).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT);
            
            //estilo totales
            Style cuerpototal = new Style();
            PdfFont f3 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            cuerpototal.SetFont(f3).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT);

            //creacion de la tabla
            Table table = new Table(new float[9]).UseAllAvailableWidth();
            table.SetMarginTop(0);
            table.SetMarginBottom(0);
            Cell cell = new Cell(1, 9);

            // first row
            if (valor == 1)
            {
                cell.Add(new Paragraph("Reporte del dia " + DateTime.Now.ToShortDateString()));
            }
            else if(valor == 2)
            {
                cell.Add(new Paragraph("Reporte del Mes de " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)));
            }
            else
            {
                cell.Add(new Paragraph("Reporte del año " + DateTime.Now.Year.ToString()));
            }
            
            cell.AddStyle(titulo);
            cell.SetTextAlignment(TextAlignment.CENTER);
            cell.SetPadding(3);
            cell.SetBackgroundColor(new DeviceRgb(140, 221, 8));
            table.AddCell(cell);

            table.AddCell("Material").AddStyle(encabezado);
            table.AddCell("Producccion en flex").AddStyle(encabezado);
            table.AddCell("Produccion en Speed").AddStyle(encabezado);
            table.AddCell("Produccion en 360").AddStyle(encabezado);
            table.AddCell("Usado en flex").AddStyle(encabezado);
            table.AddCell("Usado en speed").AddStyle(encabezado);
            table.AddCell("Usado en 360").AddStyle(encabezado);
            table.AddCell("Fecha de registro").AddStyle(encabezado);
            table.AddCell("Registrado por").AddStyle(encabezado);

            int anio = DateTime.Now.Year;
            string mes;
            if (DateTime.Now.Month < 10)
            {
                mes = "0" + DateTime.Now.Month.ToString();
            }
            else
            {
                mes = DateTime.Now.Month.ToString();
            }
            int dia = DateTime.Now.Day;
            string Query,Query2;
            //del dia
            if (valor == 1)
            {
                 Query = "SELECT nombre,prod_flex,prod_speed,prod_360,material_flex,material_speed,material_360,fecha_produccion,usuario FROM inventarioprograma.materialregistro where fecha_produccion >= ('" + anio + "-" + mes + "-" + dia + " 00:00:00') and fecha_produccion < ('" + anio + "-" + mes + "-" + (dia + 1) + " 00:00:00') order by fecha_produccion";
                 Query2 = "SELECT nombre,sum(prod_flex),sum(prod_speed),sum(prod_360),sum(material_flex),sum(material_speed),sum(material_360) FROM inventarioprograma.materialregistro where fecha_produccion >= ('" + anio + "-" + mes + "-" + dia + " 00:00:00') and fecha_produccion < ('" + anio + "-" + mes + "-" + (dia + 1) + " 00:00:00') group by nombre;";
            }
            //del mes
            else if(valor == 2)
            {
                
                Query = "SELECT nombre,prod_flex,prod_speed,prod_360,material_flex,material_speed,material_360,fecha_produccion,usuario FROM inventarioprograma.materialregistro where fecha_produccion like ('"+anio+"-"+mes+ "%') order by fecha_produccion";
                Query2 = "SELECT nombre,sum(prod_flex),sum(prod_speed),sum(prod_360),sum(material_flex),sum(material_speed),sum(material_360) FROM inventarioprograma.materialregistro where fecha_produccion like ('"+anio+"-"+mes+"%') group by nombre;";
            }
            //anual
            else
            {
                Query = "SELECT nombre,prod_flex,prod_speed,prod_360,material_flex,material_speed,material_360,fecha_produccion,usuario FROM inventarioprograma.materialregistro where fecha_produccion like ('" + DateTime.Now.Year + "%') order by fecha_produccion";
                Query2 = "SELECT nombre,sum(prod_flex),sum(prod_speed),sum(prod_360),sum(material_flex),sum(material_speed),sum(material_360) FROM inventarioprograma.materialregistro where fecha_produccion like ('" + DateTime.Now.Year + "%') group by nombre;";
            }

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                table.AddCell(new Paragraph(rdr.GetString(0)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(1)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(2)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(3)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(4)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(5)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(6)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(7)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(8)).AddStyle(cuerpogeneral));
            }
            MyConn2.Close();

            cell.AddStyle(cuerpototal);
            //totales
            var cmd2 = new MySqlCommand(Query2, MyConn2);
            MyConn2.Open();
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                table.AddCell(new Paragraph(rdr2.GetString(0)));
                table.AddCell(new Paragraph(rdr2.GetString(1)));
                table.AddCell(new Paragraph(rdr2.GetString(2)));
                table.AddCell(new Paragraph(rdr2.GetString(3)));
                table.AddCell(new Paragraph(rdr2.GetString(4)));
                table.AddCell(new Paragraph(rdr2.GetString(5)));
                table.AddCell(new Paragraph(rdr2.GetString(6)));
                table.AddCell(new Paragraph("----------"));
                table.AddCell(new Paragraph("----------"));
            }
            MyConn2.Close();

            return table;
        }

        private Table consultausado()
        {
            //estilo titulo tabla
            Style titulo = new Style();
            PdfFont f = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLDOBLIQUE);
            titulo.SetFont(f).SetFontSize(16).SetTextAlignment(TextAlignment.CENTER);

            //estilo encabezado
            Style encabezado = new Style();
            PdfFont f1 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            encabezado.SetFont(f1).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT);

            //estilo cuerpo general
            Style cuerpogeneral = new Style();
            PdfFont f2 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            cuerpogeneral.SetFont(f2).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT);

            //creacion de la tabla
            Table table = new Table(new float[5]).UseAllAvailableWidth();
            table.SetMarginTop(0);
            table.SetMarginBottom(0);
            Cell cell = new Cell(1, 5);
            cell.Add(new Paragraph("Reporte de materiales utilizados"));
            
            cell.AddStyle(titulo);
            cell.SetTextAlignment(TextAlignment.CENTER);
            cell.SetPadding(3);
            cell.SetBackgroundColor(new DeviceRgb(140, 221, 8));
            table.AddCell(cell);

            table.AddCell("Material").AddStyle(encabezado);
            table.AddCell("Cantidad usada en flex").AddStyle(encabezado);
            table.AddCell("Cantidad usada en speed").AddStyle(encabezado);
            table.AddCell("Cantidad usada en 360").AddStyle(encabezado);
            table.AddCell("Cantidad usada en total").AddStyle(encabezado);

            string Query = "SELECT nombre,sum(material_flex),sum(material_speed),sum(material_360) FROM inventarioprograma.materialregistro group by nombre;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                table.AddCell(new Paragraph(rdr.GetString(0)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(1)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(2)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(3)).AddStyle(cuerpogeneral));
                int total = rdr.GetInt32(1) + rdr.GetInt32(2) + rdr.GetInt32(3);
                table.AddCell(new Paragraph(total.ToString()).AddStyle(cuerpogeneral));

            }
            MyConn2.Close();
            return table;
        }

        private Table consultasobrante()
        {
            //estilo titulo tabla
            Style titulo = new Style();
            PdfFont f = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLDOBLIQUE);
            titulo.SetFont(f).SetFontSize(16).SetTextAlignment(TextAlignment.CENTER);

            //estilo encabezado
            Style encabezado = new Style();
            PdfFont f1 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            encabezado.SetFont(f1).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT);

            //estilo cuerpo general
            Style cuerpogeneral = new Style();
            PdfFont f2 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            cuerpogeneral.SetFont(f2).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT);

            //creacion de la tabla
            Table table = new Table(new float[7]).UseAllAvailableWidth();
            table.SetMarginTop(0);
            table.SetMarginBottom(0);
            Cell cell = new Cell(1, 7);
            cell.Add(new Paragraph("Reporte de materiales sobrantes"));

            cell.AddStyle(titulo);
            cell.SetTextAlignment(TextAlignment.CENTER);
            cell.SetPadding(3);
            cell.SetBackgroundColor(new DeviceRgb(140, 221, 8));
            table.AddCell(cell);

            table.AddCell("Material").AddStyle(encabezado);
            table.AddCell("Cantidad en existencia").AddStyle(encabezado);
            table.AddCell("Cantidad para alerta").AddStyle(encabezado);
            table.AddCell("Cantidad usada en speed").AddStyle(encabezado);
            table.AddCell("Cantidad usada en flex").AddStyle(encabezado);
            table.AddCell("Cantidad usada en 360").AddStyle(encabezado);
            table.AddCell("Usuario que registro").AddStyle(encabezado);

            string Query = "SELECT nombre,cantidad_inicial,stock_alert,cant_speed,cant_flex,cant_360,usuario FROM inventarioprograma.materialusario;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                table.AddCell(new Paragraph(rdr.GetString(0)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(1)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(2)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(3)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(4)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(5)).AddStyle(cuerpogeneral));
                table.AddCell(new Paragraph(rdr.GetString(6)).AddStyle(cuerpogeneral));
            }
            MyConn2.Close();
            return table;
        }

        public void crearpdf(int valor)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\\Users\\";
                saveFileDialog1.Title = "Indique donde guardar el pdf";
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "Archivo PDF(*.pdf)|*.pdf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Style titulo = new Style();
                    PdfFont f = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
                    titulo.SetFont(f).SetFontSize(20).SetTextAlignment(TextAlignment.CENTER);
                    Style subtitulo = new Style();
                    PdfFont f1 = PdfFontFactory.CreateFont(StandardFonts.TIMES_ITALIC);
                    subtitulo.SetFont(f1).SetFontSize(16).SetTextAlignment(TextAlignment.CENTER);
                    FileInfo file = new FileInfo(saveFileDialog1.FileName);
                    file.Directory.Create();
                    //Initialize PDF writer
                    PdfWriter writer = new PdfWriter(saveFileDialog1.FileName);
                    //Initialize PDF document
                    PdfDocument pdf = new PdfDocument(writer);
                    PageSize ps = PageSize.LETTER;

                    // Initialize document
                    Document document = new Document(pdf);

                    //Add paragraph to the document
                    Paragraph title = new Paragraph("Helmets & Stuff").AddStyle(titulo);
                    document.Add(title);
                    Paragraph tema;
                    if (valor >0 && valor < 4)
                    { 
                        tema = new Paragraph("Reporte de producciones").AddStyle(subtitulo);
                    }
                    else
                    {
                        tema = new Paragraph("Reporte de materiales").AddStyle(subtitulo);
                    }
                    document.Add(tema);

                    Table table = consultamaterial(valor);

                    if (valor > 0 && valor < 4)
                    {
                        table = consultamaterial(valor);
                    }
                    else if (valor == 4)
                    {
                        table = consultausado();
                    }
                    else
                    {
                        table = consultasobrante();
                    }
                    

                    document.Add(table);
                    //Close document
                    document.Close();

                    MessageBox.Show("Documento creado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha sucedido un error, compruebe que el archivo no este abierto "+ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbreporte.SelectedItem.ToString() == "Reporte del día")
                {
                    crearpdf(1);
                }
                else if(cmbreporte.SelectedItem.ToString() == "Reporte del mes")
                {
                    crearpdf(2);
                }
                else if (cmbreporte.SelectedItem.ToString() == "Reporte del año")
                {
                    crearpdf(3);
                }
                else if (cmbreporte.SelectedItem.ToString() == "Materiales Utilizados")
                {
                    crearpdf(4);
                }
                else
                {
                    crearpdf(5);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
