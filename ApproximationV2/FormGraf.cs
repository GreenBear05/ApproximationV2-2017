using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApproximationV2
{
    public partial class FormGraf : Form
    {
         static float  Y1, Y2, maxX, minX;

        static List<DotInfo> points1 = new List<DotInfo>();
      
        public FormGraf()
        {
            
           
            
            InitializeComponent();


           


          //

            // Mathematics.Matdata(maxX,minX);

            //foreach (var item in Mathematics.Matdata())
            //{

            //chartGraf.Series["Syr"].Points.AddXY(Convert.ToString(item.Key), item.Value);

            //}

            chartGraf.Series["Line"].Points.AddXY(Mathematics.Matdata_maxX(), Mathematics.Matdata_Y1());
             chartGraf.Series["Line"].Points.AddXY(Mathematics.Matdata_minX(), Mathematics.Matdata_Y2());

            // textBoxInfo1.Text = Convert.ToString(collecshion.CollecshionIformCollSimvols(boxchar));
            //textBoxInfo2.Text = Convert.ToString(collecshion.CollecshionIformCollLetters(boxchar));
            foreach (var item in points1)
            {
                chartGraf.Series["Tos"].Points.AddXY(item.X, item.Y);
            }
        }

        public FormGraf(List<DotInfo> points)
        {
            points1 = points;
        }




        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
