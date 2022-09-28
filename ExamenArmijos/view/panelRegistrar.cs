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
    public partial class panelRegistrar : UserControl
    {
        metodos met = new metodos();
        public panelRegistrar()
        {
            InitializeComponent();
        }

        private void panelRegistrar_Load(object sender, EventArgs e)
        {
            met.fillCombox(cmbsexo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            met.registerClient(txtid.Text, txtcedula.Text, txtnombre.Text, txtapellido.Text, cmbsexo.SelectedIndex.ToString(), txtfecha.Text);
        }
    }
}
