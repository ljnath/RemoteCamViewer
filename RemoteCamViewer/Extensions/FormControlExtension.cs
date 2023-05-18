using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RemoteCamViewer.Extensions
{
    internal static class FormControlExtension
    {
        internal static IEnumerable<Control> FindAll(this Control parentControl, Type controlType)
        {
            return GetAllControls(parentControl, controlType);
        }

        internal static IEnumerable<Control> FindAll(this Control parentControl, Type[] controlTypes)
        {
            return GetAllControls(parentControl, controlTypes);
        }



        private static IEnumerable<Control> GetAllControls(Control parentControl, Type controlType)
        {
            var controls = parentControl.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl, controlType))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == controlType);
        }

        private static IEnumerable<Control> GetAllControls(Control parentControl, Type[] controlTypes)
        {
            List<Control> validControls = new List<Control>();
            foreach (var controlType in controlTypes)
            {
                validControls.AddRange(GetAllControls(parentControl, controlType));
            }
            return validControls;
        }
    }


}
