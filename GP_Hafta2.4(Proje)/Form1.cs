using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Hafta2._4_Proje_
{
    public partial class Form1 : Form
    {

        bool surukleme = false;
        Point kaymanoktasi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Left)
            {
                surukleme = true;
                kaymanoktasi = e.Location;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                surukleme = false;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if(surukleme)
            {
                Point mousekonum = this.PointToClient(Cursor.Position);

                button1.Left = mousekonum.X - kaymanoktasi.X;
                button1.Top = mousekonum.Y - kaymanoktasi.Y;

            }
        }
    }
}
