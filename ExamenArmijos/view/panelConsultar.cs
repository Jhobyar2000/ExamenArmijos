using ExamenArmijos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenArmijos.view
{
    public partial class panelConsultar : UserControl
    {
        metodos met = new metodos();
        public panelConsultar()
        {
            InitializeComponent();
            met.getListClient(dtcliente);
        }

        private void panelConsultar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
