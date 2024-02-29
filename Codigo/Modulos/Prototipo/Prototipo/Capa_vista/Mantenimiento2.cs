using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
namespace Vista_PrototipoMenu
{
    public partial class Mantenimiento2 : Form
    {

        

        public Mantenimiento2()
        {
            
            InitializeComponent();
            this.navegador1.cong("carrera", this, "");
            this.navegador1._initSeguridad();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
