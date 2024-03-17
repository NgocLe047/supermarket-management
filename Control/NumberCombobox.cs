using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace TKControl
{
    public class NumberCombobox :ComboBox
    {
        
        public NumberCombobox()
        {
            this.KeyPress += NumberComboBox_KeyPress;
            
        }
        private void NumberComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
