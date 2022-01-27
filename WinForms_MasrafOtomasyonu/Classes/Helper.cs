using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_MasrafOtomasyonu.Classes
{
    public static class Helper
    {
        public static void ClearControls(FlowLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = -1;
                }
                else if (control is NumericUpDown)
                {
                    (control as NumericUpDown).Value = 0;
                }
                else if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
            }
        }

    }
}
