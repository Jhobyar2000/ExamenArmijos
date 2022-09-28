using ExamenArmijos.control;
using ExamenArmijos.view;

namespace ExamenArmijos
{
    public partial class Form1 : Form
    {
        handlerpanel hand = new handlerpanel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRegistrar px = new panelRegistrar();
            hand.addUserControl(px, mypanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelConsultar px = new panelConsultar();
            hand.addUserControl(px, mypanel);
        }
    }
}