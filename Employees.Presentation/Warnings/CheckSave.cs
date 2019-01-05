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
                var ifExitLoop = false;
                foreach (var control in controls)
                {
                    switch (control)
                    {
                        case TextBox textBox:
                        {
                            isColor = textBox.BackColor == Color.LightGreen;
                            if (!isColor) ifExitLoop = true;
                            break;
                        }
                            
                        case ComboBox comboBox:
                            isColor = comboBox.BackColor == Color.LightGreen;
                            if (!isColor) ifExitLoop = true;
                            break;
                    }
                    if (ifExitLoop) break;
                }
            };
            function(formPassed.Controls);
            return isColor;
        }
    }
}
