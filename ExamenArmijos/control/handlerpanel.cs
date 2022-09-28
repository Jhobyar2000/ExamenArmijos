using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenArmijos.control
{
    public class handlerpanel
    {
        public void addUserControl(UserControl userControl, Panel panelContainer)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            userControl.Focus();
            userControl.BringToFront();
            panelContainer.Controls.Add(userControl);
        }

    }
}
