using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AllFunctions
    {
        public static void OpenChildForm(Form child, Panel parent)
        {
            parent.Controls.Clear();
            child.TopLevel = false;
            child.Parent = parent;
            child.Show();
        }
    }
}
