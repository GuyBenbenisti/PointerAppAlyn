using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public static class Extensions
    {
        public static IEnumerable<Control> DescendentsFromPoint(this Control control, Point pt)
        {
            var ctrl = control.GetChildAtPoint(pt);
            if (ctrl != null)
            {
                yield return ctrl;

                var screenPt = control.PointToScreen(pt);
                pt = ctrl.PointToScreen(screenPt);

                foreach (var item in DescendentsFromPoint(ctrl, pt))
                {
                    yield return item;
                }
            }
        }
    }
}
