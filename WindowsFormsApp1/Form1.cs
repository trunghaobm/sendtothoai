using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // khai bao
        Main main;
        Sub sub;

        int level;
        //
        public Form1()
        {
            InitializeComponent();
            FormLoad();
        }

        public void FormLoad()
        {
            main = new Main();
            sub = new Sub();
            level = 0;
        }
        private void pn_parent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllFunctions.OpenChildForm(main, pn_parent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllFunctions.OpenChildForm(main, pn_parent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllFunctions.OpenChildForm(sub, pn_parent);

        }
    }
}
