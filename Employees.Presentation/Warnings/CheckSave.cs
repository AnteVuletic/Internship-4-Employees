using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees.Presentation.Warnings
{
    public static class CheckSave
    {
        public static bool CheckForm(Form formPassed)   
        {
            var isColor = false;
            Action<Control.ControlCollection> function = null;
            function = (controls) =>
            {
                foreach (var control in controls)
                {
                    if (!(control is TextBox textBox)) continue;
                    isColor = textBox.BackColor == Color.LightGreen;
                }
            };
            function(formPassed.Controls);
            return isColor;
        }
    }
}
