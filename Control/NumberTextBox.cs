using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TKControl
{
      public class NumberTextBox : TextBox
    {
 
          public NumberTextBox ()
          {
       
              this.KeyPress += NumberTextBox_KeyPress;
          }
          private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
          {
              if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
              {
                  e.Handled = true;
              }
          }
    }
}
