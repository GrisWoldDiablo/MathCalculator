using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalculator
{
    public partial class Form1 : Form
    {
        double vectorX, vectorY, vectorZ;
        double vectorX1, vectorY1, vectorZ1;
        double vectorX2, vectorY2, vectorZ2;
        double vectRotAngle;
        double scaleValue;

        private void TextVectX_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectX.Text, out vectorX);
        }

        private void TextVectY_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectY.Text, out vectorY);
        }

        private void TextVectX1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectX1.Text, out vectorX1);
        }

        private void TextVectY1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectY1.Text, out vectorY1);
        }

        private void TextVectZ1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectZ1.Text, out vectorZ1);
        }

        private void TextVectX2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectX2.Text, out vectorX2);
        }

        private void TextVectY2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectY2.Text, out vectorY2);
        }

        private void TextVectZ2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectZ2.Text, out vectorZ2);
        }

        private void Btn_VectAngle_Click(object sender, EventArgs e)
        {
            TextVectA2D.Text = GetVectorsAngle(vectorX1, vectorY1, vectorX2, vectorY2).ToString();
            TextVectA3D.Text = GetVectorsAngle(vectorX1, vectorY1,vectorZ1, vectorX2, vectorY2, vectorZ2).ToString();

        }

        private void TextVectZ_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectZ.Text, out vectorZ);
        }

        private void ChkRotByX_Click(object sender, EventArgs e)
        {
            ChkRotByY.Checked = false;
            ChkRotByZ.Checked = false;
        }

        private void ChkRotByZ_Click(object sender, EventArgs e)
        {
            ChkRotByX.Checked = false;
            ChkRotByY.Checked = false;
        }

        private void ChkRotByY_Click(object sender, EventArgs e)
        {
            ChkRotByX.Checked = false;
            ChkRotByZ.Checked = false;
        }

        private void Btn_VectRot_Click(object sender, EventArgs e)
        {
            RotateVector(vectorX, vectorY, vectorZ);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vectorX  = 0;
            vectorY  = 0;
            vectorZ  = 0;

            vectorX1 = 0;
            vectorY1 = 0;
            vectorZ1 = 0;

            vectorX2 = 0;
            vectorY2 = 0;
            vectorZ2 = 0;

            vectRotAngle = 0;
            scaleValue = 1;
        }

        private void TextRotAngle_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextRotAngle.Text, out vectRotAngle);
        }

        private void TextScaleVal_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextScaleVal.Text, out scaleValue);
        }

        private void Btn_CompL_Click(object sender, EventArgs e)
        {
            TextCompL.Text = GetComparedLenght(vectorX1, vectorY1, vectorZ1, vectorX2, vectorY2, vectorZ2).ToString();
        }

        private void Btn_VectL_Click(object sender, EventArgs e)
        {
            TextVect2DL.Text = GetVectorLenght(vectorX, vectorY, 0).ToString();
            TextVect3DL.Text = GetVectorLenght(vectorX, vectorY, vectorZ).ToString();
            //MessageBox.Show((Math.Sqrt(Math.Pow(3, 2) + Math.Pow(5, 2) + Math.Pow(1, 2) + Math.Pow(2, 2) + Math.Pow(2, 2) + Math.Pow(4, 2) + Math.Pow(4, 2))).ToString());
        }

        public Form1()
        {
            InitializeComponent();
        }

        public double GetVectorLenght(double x, double y, double z)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public double GetVectorsAngle(double x1, double y1, double x2, double y2)
        {
            double vector1L = GetVectorLenght(x1, y1, 0);
            double vector2L = GetVectorLenght(x2, y2, 0);
            double multi = vector1L * vector2L;
            double result = (x1 * x2) + (y1 * y2);
            return ToDegree(Math.Acos(result / multi));
        }

        public double GetVectorsAngle(double x1, double y1, double z1, double x2, double y2,  double z2)
        {
            double vector1L = GetVectorLenght(x1, y1, z1);
            double vector2L = GetVectorLenght(x2, y2, z2);
            double multi = vector1L * vector2L;
            double result = (x1 * x2) + (y1 * y2) + (z1 * z2);
            return ToDegree(Math.Acos(result / multi));
            //return (Math.Acos(result / multi) * 180 / Math.PI);
        }

        public void RotateVector(double x, double y, double z)
        {
            double rotValue = ToRadian(vectRotAngle);
            double[,] matrixX =
            {
                { 1 * scaleValue, 0              , 0                              }, // x
                { 0             , Math.Cos(rotValue) * scaleValue, -Math.Sin(rotValue) * scaleValue }, // y
                { 0             , Math.Sin(rotValue) * scaleValue,  Math.Cos(rotValue) * scaleValue }  // z
            };

            double[,] matrixY =
            {
                { Math.Cos(rotValue) * scaleValue, 0             , -Math.Sin(rotValue) * scaleValue }, // x
                { 0                              , 1 * scaleValue,  0                               }, // y
                { Math.Sin(rotValue) * scaleValue, 0             ,  Math.Cos(rotValue) * scaleValue }  // z
            };

            double[,] matrixZ =
            {
                { Math.Cos(rotValue) * scaleValue, -Math.Sin(rotValue) * scaleValue, 0              }, // x
                { Math.Sin(rotValue) * scaleValue,  Math.Cos(rotValue) * scaleValue, 0              }, // y
                { 0                              ,  0                              , 1 * scaleValue }  // z
            };

            double xN, yN, zN;
            if (ChkRotByX.Checked)
            {
                xN = ((matrixX[0, 0] * x) + (matrixX[0, 1] * y) + (matrixX[0, 2] * z));
                yN = ((matrixX[1, 0] * x) + (matrixX[1, 1] * y) + (matrixX[1, 2] * z));
                zN = ((matrixX[2, 0] * x) + (matrixX[2, 1] * y) + (matrixX[2, 2] * z));
                TextM00.Text = Math.Round(matrixX[0, 0], 15).ToString();
                TextM01.Text = Math.Round(matrixX[0, 1], 15).ToString();
                TextM02.Text = Math.Round(matrixX[0, 2], 15).ToString();
                TextM10.Text = Math.Round(matrixX[1, 0], 15).ToString();
                TextM11.Text = Math.Round(matrixX[1, 1], 15).ToString();
                TextM12.Text = Math.Round(matrixX[1, 2], 15).ToString();
                TextM20.Text = Math.Round(matrixX[2, 0], 15).ToString();
                TextM21.Text = Math.Round(matrixX[2, 1], 15).ToString();
                TextM22.Text = Math.Round(matrixX[2, 2], 15).ToString();

            }
            else if (ChkRotByY.Checked)
            {
                xN = ((matrixY[0, 0] * x) + (matrixY[0, 1] * y) + (matrixY[0, 2] * z));
                yN = ((matrixY[1, 0] * x) + (matrixY[1, 1] * y) + (matrixY[1, 2] * z));
                zN = ((matrixY[2, 0] * x) + (matrixY[2, 1] * y) + (matrixY[2, 2] * z));
                TextM00.Text = Math.Round(matrixY[0, 0], 15).ToString();
                TextM01.Text = Math.Round(matrixY[0, 1], 15).ToString();
                TextM02.Text = Math.Round(matrixY[0, 2], 15).ToString();
                TextM10.Text = Math.Round(matrixY[1, 0], 15).ToString();
                TextM11.Text = Math.Round(matrixY[1, 1], 15).ToString();
                TextM12.Text = Math.Round(matrixY[1, 2], 15).ToString();
                TextM20.Text = Math.Round(matrixY[2, 0], 15).ToString();
                TextM21.Text = Math.Round(matrixY[2, 1], 15).ToString();
                TextM22.Text = Math.Round(matrixY[2, 2], 15).ToString();
            }
            else
            {
                xN = ((matrixZ[0, 0] * x) + (matrixZ[0, 1] * y) + (matrixZ[0, 2] * z));
                yN = ((matrixZ[1, 0] * x) + (matrixZ[1, 1] * y) + (matrixZ[1, 2] * z));
                zN = ((matrixZ[2, 0] * x) + (matrixZ[2, 1] * y) + (matrixZ[2, 2] * z));
                TextM00.Text = Math.Round(matrixZ[0, 0], 15).ToString();
                TextM01.Text = Math.Round(matrixZ[0, 1], 15).ToString();
                TextM02.Text = Math.Round(matrixZ[0, 2], 15).ToString();
                TextM10.Text = Math.Round(matrixZ[1, 0], 15).ToString();
                TextM11.Text = Math.Round(matrixZ[1, 1], 15).ToString();
                TextM12.Text = Math.Round(matrixZ[1, 2], 15).ToString();
                TextM20.Text = Math.Round(matrixZ[2, 0], 15).ToString();
                TextM21.Text = Math.Round(matrixZ[2, 1], 15).ToString();
                TextM22.Text = Math.Round(matrixZ[2, 2], 15).ToString();
            }
            TextVectRotX.Text = Math.Round(xN, 15).ToString();
            TextVectRotY.Text = Math.Round(yN, 15).ToString();
            TextVectRotZ.Text = Math.Round(zN, 15).ToString();
        }

        public double GetComparedLenght(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
        }

        public double ToRadian(double angle)
        {
            return (Math.PI * angle) / 180;
        }

        public double ToDegree(double radian)
        {
            return radian * (180 / Math.PI);
        }
    }
}
