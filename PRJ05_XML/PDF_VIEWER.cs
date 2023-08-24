using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ05_XML
{
    public partial class PDF_VIEWER : Form
    {
        public PDF_VIEWER()
        {
            InitializeComponent();
        }

        private void PDF_VIEWER_Load(object sender, EventArgs e)
        {
            OpenFileDialog CargarFichero = new OpenFileDialog();

            CargarFichero.FileName = string.Format("{0}/{1}",
                ImportacionDatos.ListaInformacionTecnica[Convert.ToInt32(ImportacionDatos.importar_id)].text_option,
                ImportacionDatos.PdfFichero[ImportacionDatos.importar_id]
            );

            lbl_ship_name.Text = string.Format("-> {0}", ImportacionDatos.importar_nombre);
            pdf_ship.LoadFile(CargarFichero.FileName);
        }
    }
}
