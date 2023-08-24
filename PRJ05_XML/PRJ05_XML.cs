using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Xml;

namespace PRJ05_XML
{
    public partial class PRJ05_XML : Form
    {
        int item_listview;

        XmlDocument doc;
        TechnicalInformation InformacionTecnica;
        PDF_VIEWER PdfViewer;

        Dictionary<string, string> Colores;
        Dictionary<string, string> hijos_root;
        Dictionary<string, List<string>> FotosNave, Datos;
        Dictionary<string, string> Descripcion, VideoGeneral;

        List<string> Stats = new List<string>();
        string root = "GeneralInfo";

        public PRJ05_XML()
        {
            InitializeComponent();
        }

        private void PRJ05_XML_Load(object sender, EventArgs e)
        {
            vid_ship.Visible = false;
            btn_pdf.Enabled  = false;
            cargarXML();
            listaNodos();
            listaInformacionTecnica();
            fotosVideosDescripcionNaves();
            listaNaves();
            datosNaves();
        }

        private void lv_ships_SelectedIndexChanged(object sender, EventArgs e)
        {
            vid_ship.Visible = false;
            pic_big.Visible  = true;
            btn_pdf.Enabled  = true;
            
            item_listview = lv_ships.FocusedItem.Index;
            lbl_description.Text = Descripcion[item_listview.ToString()];
            lbl_class.Text  = lv_ships.FocusedItem.Text;        

            anadirImagenes(item_listview);
            anaditDatos(item_listview);
        }

        private void clickImagen(object sender, EventArgs e)
        {
            vid_ship.Visible = false;
            pic_big.Visible = true;
            PictureBox PictureBox = (PictureBox)sender;
            Image Image = PictureBox.Image;
            pic_big.Image = Image;
        }

        private void clickVideo(object sender, EventArgs e)
        {
            string ruta_video;

            pic_big.Visible = false;
            vid_ship.Visible = true;
            ruta_video = string.Format("{0}/{1}", ImportacionDatos.ListaInformacionTecnica[item_listview].text_option, VideoGeneral[item_listview.ToString()]);
            vid_ship.URL = ruta_video;
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            PdfViewer = new PDF_VIEWER();

            ImportacionDatos.importar_nombre = lv_ships.FocusedItem.Text;
            ImportacionDatos.importar_id = lv_ships.FocusedItem.Index.ToString();
            PdfViewer.Show();
        }

        private void cargarXML()
        {
            doc = new XmlDocument();
            doc.Load("info.xml");
        }

        private void listaNodos()
        {
            hijos_root = new Dictionary<string, string>();
            hijos_root.Add("Blueprints", string.Format("Blueprints", root));
            hijos_root.Add("TechnicalInfo", string.Format("TechnicalInfo", root));
        }

        private void anadirImagenes(int id)
        {
            PictureBox[] vistas_nave;
            string imagen;

            vistas_nave = new PictureBox[6] { 
                pic_big, 
                pic_small_one, 
                pic_small_two, 
                pic_small_three, 
                pic_small_four, 
                pic_small_five 
            };
            
            for (int i = 0; i < vistas_nave.Length; i++)
            {
                imagen = FotosNave[id.ToString()][i];
                vistas_nave[i].ImageLocation = string.Format("{0}/{1}", ImportacionDatos.ListaInformacionTecnica[id].text_option, imagen);
            }
        }

        private void anaditDatos(int id)
        {
            dtg_stats.Rows.Clear();
            
            dtg_stats.DefaultCellStyle.Font = new Font("Yu Gothic", 13);
            dtg_stats.ColumnHeadersDefaultCellStyle.Font = new Font("Yu Gothic", 13);

            dtg_stats.RowTemplate.Height = 30;
            
            for (int i = 0; i < Stats.Count; i++)
            {                
                dtg_stats.Rows.Add(Stats[i]);
                dtg_stats.Rows[i].Cells[1].Value = Datos[id.ToString()][i];

                if (i == 3)
                {
                    dtg_stats.Rows[i].Cells[1].Style.ForeColor = (Color)ColorTranslator.FromHtml(Colores[id.ToString()]);
                    dtg_stats.Rows[i].Cells[1].Style.Font = new Font("Yu Gothic", 13, FontStyle.Bold);
                }
            }   
        }

        private void listaInformacionTecnica()
        {
            int longitud_info_options;
            XmlNodeList id_options, text_options, icons;
            ImportacionDatos.ListaInformacionTecnica = new List<TechnicalInformation>();

            longitud_info_options = doc.GetElementsByTagName("InfoOption").Count;
            id_options = doc.GetElementsByTagName("idOption");
            text_options = doc.GetElementsByTagName("textOption");
            icons = doc.GetElementsByTagName("icon");

            for (int i = 0; i < longitud_info_options; i++)
            {
                InformacionTecnica = new TechnicalInformation();

                InformacionTecnica.id_option = id_options[i].InnerText;
                InformacionTecnica.text_option = text_options[i].InnerText;
                InformacionTecnica.icon = icons[i].InnerText;

                ImportacionDatos.ListaInformacionTecnica.Add(InformacionTecnica);
            }
        }

        private void fotosVideosDescripcionNaves()
        {
            int longitud_info_details;
            XmlNodeList
                description, blueprint, id_info_detail, general_view,
                front_view, side_view, top_view, rear_view, full_view;

            VideoGeneral = new Dictionary<string, string>();
            FotosNave    = new Dictionary<string, List<string>>();
            Descripcion  = new Dictionary<string, string>();
            ImportacionDatos.PdfFichero = new Dictionary<string, string>();

            longitud_info_details = doc.GetElementsByTagName("InfoDetail").Count;
            description = doc.GetElementsByTagName("textInfoDetail");
            blueprint = doc.GetElementsByTagName("Blueprint");
            id_info_detail = doc.GetElementsByTagName("idInfoDetail");
            general_view = doc.GetElementsByTagName("GeneralView");
            front_view = doc.GetElementsByTagName("FrontView");
            side_view = doc.GetElementsByTagName("SideView");
            top_view = doc.GetElementsByTagName("TopView");
            rear_view = doc.GetElementsByTagName("RearView");
            full_view = doc.GetElementsByTagName("View360");

            for (int i = 0; i < longitud_info_details; i++)
            {
                FotosNave.Add(id_info_detail[i].InnerText, new List<string>()
                {
                    blueprint  [i].InnerText,
                    front_view [i].InnerText,
                    side_view  [i].InnerText,
                    top_view   [i].InnerText,
                    rear_view  [i].InnerText,
                    full_view  [i].InnerText
                });

                Descripcion.Add(id_info_detail[i].InnerText, description[i].InnerText.Trim());
                VideoGeneral.Add(id_info_detail[i].InnerText, general_view[i].InnerText);
            }
        }

        private void datosNaves()
        {
            int longitud_data_details;
            XmlNodeList id_info_detail, manufacturer, length, speed, hyperdrive, shielding, armament, pdf_file;
            
            Datos   = new Dictionary<string, List<string>>();
            Colores = new Dictionary<string, string>();

            longitud_data_details = doc.GetElementsByTagName("InfoDetail").Count;
            id_info_detail = doc.GetElementsByTagName("idInfoDetail");
            manufacturer = doc.GetElementsByTagName("Manufacturer");
            length = doc.GetElementsByTagName("Length");
            speed = doc.GetElementsByTagName("Speed");
            hyperdrive = doc.GetElementsByTagName("Hyperdrive");
            shielding = doc.GetElementsByTagName("Shielding");
            armament = doc.GetElementsByTagName("Armament");
            pdf_file = doc.GetElementsByTagName("pdfFile");

            for (int i = 0; i < longitud_data_details; i++)
            {
                Datos.Add(id_info_detail[i].InnerText, new List<string>()
                {
                    manufacturer[i].InnerText,
                    length      [i].InnerText,
                    speed       [i].InnerText,
                    hyperdrive  [i].InnerText,
                    shielding   [i].InnerText,
                    armament    [i].InnerText
                });

                Colores.Add(id_info_detail[i].InnerText, hyperdrive[i].Attributes["color"].Value);
                ImportacionDatos.PdfFichero.Add(id_info_detail[i].InnerText, pdf_file[i].InnerText);
            }

            Stats.Add(manufacturer[0].Name);
            Stats.Add(length[0].Name);
            Stats.Add(speed[0].Name);
            Stats.Add(hyperdrive[0].Name);
            Stats.Add(shielding[0].Name);
            Stats.Add("Weaponry");
        }

        private void listaNaves()
        {
            string nombre_nave;

            for (int i = 0; i < ImportacionDatos.ListaInformacionTecnica.Count; i++)
            {
                nombre_nave = ImportacionDatos.ListaInformacionTecnica[i].text_option;
                lv_ships.Items.Add(nombre_nave);
            }
        }
    }

    public class ImportacionDatos
    {        
        public static string importar_id, importar_nombre;
        public static Dictionary<string, string> PdfFichero;
        public static List<TechnicalInformation> ListaInformacionTecnica;
    }

    public class TechnicalInformation
    {
        public string id_option;
        public string text_option;
        public string icon;
    }
}
