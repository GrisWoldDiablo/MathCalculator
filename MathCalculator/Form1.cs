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
        double vectorX3, vectorY3, vectorZ3;
        double vectRotAngle;
        double scaleValue;

        double AM00, AM01, AM10, AM11;
        double D00, D01, D02, D10, D11, D12, D20, D21, D22;
        double UX, UY, UZ;

        double vRadian, vTheta, vPhi, fCyl, rCyl;
        double reverseRay, reverseTheta;

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

            AM00 = 0;
            AM01 = 0;
            AM10 = 0;
            AM11 = 0;

            D00 = 0; D01 = 0; D02 = 0; //D00 = 0; D01 = 0;
            D10 = 0; D11 = 0; D12 = 0; //D10 = 0; D11 = 0;
            D20 = 0; D21 = 0; D22 = 0; //D20 = 0; D21 = 0;

            UX = 0;
            UY = 0;
            UZ = 0;

            vRadian = 0;
            vTheta = 0;
            vPhi = 0; ;

            fCyl = 0;
            rCyl = 0;

            reverseRay = 0;
            reverseTheta = 0;
        }

        private void Btn_det_Click(object sender, EventArgs e)
        {
            double det2x2, det3x3;

            det2x2 = D00 * D11 - D01 * D10;
            det3x3 = (D00 * D11 * D22) + (D01 * D12 * D20) + (D02 * D10 * D21) - (D02 * D11 * D20) - (D00 * D12 * D21) - (D01 * D10 * D22);

            Text2det.Text = det2x2.ToString();
            Text3det.Text = det3x3.ToString();
        }

        private void TextD00_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD00.Text, out D00);
        }

        private void TextD01_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD01.Text, out D01);
        }

        private void TextD02_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD02.Text, out D02);
        }

        private void TextD10_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD10.Text, out D10);
        }

        private void TextD11_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD11.Text, out D11);
        }

        private void TextD12_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD12.Text, out D12);
        }

        private void TextD20_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD20.Text, out D20);
        }

        private void TextD21_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD21.Text, out D21);
        }

        private void LblSpherical_MouseHover(object sender, EventArgs e)
        {
            PictBoxSpherical.Visible = true;
            PictBoxSpherical.Location = new Point(MousePosition.X - ActiveForm.Location.X, MousePosition.Y - ActiveForm.Location.Y);
        }

        private void LblSpherical_MouseLeave(object sender, EventArgs e)
        {
            PictBoxSpherical.Visible = false;
        }

        private void LblCylindrical_MouseHover(object sender, EventArgs e)
        {
            PictBoxCyl.Visible = true;
            PictBoxCyl.Location = new Point(MousePosition.X - ActiveForm.Location.X, MousePosition.Y - ActiveForm.Location.Y);
        }

        private void LblCylindrical_MouseLeave(object sender, EventArgs e)
        {
            PictBoxCyl.Visible = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                MessageBox.Show("Closing");
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Btn_VectL_MouseHover(object sender, EventArgs e)
        {
            PictBoxVL.Visible = true;
            PictBoxVL.Location = new Point(MousePosition.X - ActiveForm.Location.X, MousePosition.Y - ActiveForm.Location.Y);
        }

        private void Btn_VectL_MouseLeave(object sender, EventArgs e)
        {
            PictBoxVL.Visible = false;
        }

        private void Lbl2DPolar_MouseHover(object sender, EventArgs e)
        {
            PictBox2DPolar.Visible = true;
            PictBox2DPolar.Location = new Point(MousePosition.X - ActiveForm.Location.X, MousePosition.Y - ActiveForm.Location.Y);

        }

        private void TextRRay_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextRRay.Text, out reverseRay);
        }

        private void TextRTheta_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextRTheta.Text, out reverseTheta);
        }

        private void TextVectY3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectY3.Text, out vectorY3);
        }

        private void TextVectZ3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectZ3.Text, out vectorZ3);
        }

        private void Btn_Area_Click(object sender, EventArgs e)
        {
            Vector4f fa = new Vector4f((float)vectorX1, (float)vectorY1, (float)vectorZ1, 1);
            Vector4f fb = new Vector4f((float)vectorX2, (float)vectorY2, (float)vectorZ2, 1);
            Vector4f fc = new Vector4f((float)vectorX3, (float)vectorY3, (float)vectorZ3, 1);
            Vector4f fv = fa - fc;
            Vector4f fw = fb - fc;
            Vector4f crossVW = Vector4f.Cross(fv, fw);
            float thearea = crossVW.GetLength() / 2;
            TextBoxArea.Text = thearea.ToString();
        }

        private void BtnRPolar_Click(object sender, EventArgs e)
        {
            double x = reverseRay * Math.Cos(ToRadian(reverseTheta));
            double y = reverseRay * Math.Sin(ToRadian(reverseTheta));
            TextReversePolar.Text = $"({reverseRay:F2},{reverseTheta:F2}) : ({x:F2},{y:F2})";
        }

        private void TextVectX3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextVectX3.Text, out vectorX3);
        }

        private void Lbl2DPolar_MouseLeave(object sender, EventArgs e)
        {
            PictBox2DPolar.Visible = false;
        }

        private void TextD22_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextD22.Text, out D22);
        }

        private void BtnPolar_Click(object sender, EventArgs e)
        {
            double v2DLenght = GetVectorLenght(vectorX, vectorY, 0);
            double v2DAngle = GetVectorsAngle(1, 0, vectorX, vectorY);
            if (vectorY < 0)
            {
                v2DAngle = -v2DAngle;
            }
            double x = v2DLenght * Math.Cos(ToRadian(v2DAngle)); 
            double y = v2DLenght * Math.Sin(ToRadian(v2DAngle));
            Text2DPolar.Text = $"({v2DLenght:F2},{v2DAngle:F2}) : ({x:F2},{y:F2})";
           
            SphericalCoordinate
                (vectorX, vectorY, vectorZ);
            CylindricalCoordinate(vectorX, vectorY, vectorZ);
            TextrCyl.Text = rCyl.ToString();
            TextfCyl.Text = fCyl.ToString();
            TextZCyl.Text = vectorZ.ToString();
        }
        private void CylindricalCoordinate(double x, double y, double z)
        {
            fCyl = GetVectorsAngle(1, 0, x, y);
            if (y < 0)
            {
                fCyl = -fCyl;
            }
            rCyl = GetVectorLenght(x, y, 0);
        }

        private void SphericalCoordinate(double x, double y, double z)
        {
            //vRadian = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            //vTheta = Math.Acos(z / vRadian);
            //vPhi = Math.Atan(ToRadian(y / x));

            vRadian = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            vTheta = Math.Atan(y / x);
            vPhi = Math.Atan(z / Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            //double xx = Math.Round(vRadian * Math.Sin(vTheta) * Math.Cos(vPhi), 10);
            //double yy = Math.Round(vRadian * Math.Sin(vTheta) * Math.Sin(vPhi), 10);
            //double zz = Math.Round(vRadian * Math.Cos(vTheta), 10);

            double xx = Math.Round(vRadian * Math.Cos(vTheta) * Math.Cos(vPhi), 10);
            double yy = Math.Round(vRadian * Math.Sin(vTheta) * Math.Cos(vPhi), 10);
            double zz = Math.Round(vRadian * Math.Sin(vPhi), 10);

            TextRadian.Text = vRadian.ToString();
            TextTheta.Text = ToDegree(vTheta).ToString();
            TextPhi.Text = ToDegree(vPhi).ToString();
        }

        

        private void BtnUnit_Click(object sender, EventArgs e)
        {
            GetUnitVector(vectorX,vectorY,vectorZ,GetVectorLenght(vectorX, vectorY, vectorZ));
            TextUX.Text = UX.ToString();
            TextUY.Text = UY.ToString();
            TextUZ.Text = UZ.ToString();
        }
        private void GetUnitVector(double x, double y, double z, double length)
        {
            UX = x / length;
            UY = y / length;
            UZ = z / length;
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
            TextCompL.Text = (Math.Round(GetComparedLenght(vectorX1, vectorY1, vectorZ1, vectorX2, vectorY2, vectorZ2),4)).ToString();
        }

        private void BtnAM_Click(object sender, EventArgs e)
        {
            TextAMRX.Text = (vectorX * AM00 + vectorY * AM01).ToString();
            TextAMRY.Text = (vectorX * AM10 + vectorY * AM11).ToString();
        }

        private void TextAM00_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextAM00.Text, out AM00);
        }

        private void TextAM01_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextAM01.Text, out AM01);
        }

        private void TextAM10_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextAM10.Text, out AM10);
        }

        private void TextAM11_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TextAM11.Text, out AM11);
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
                TextM00.Text = Math.Round(matrixX[0, 0], 10).ToString();
                TextM01.Text = Math.Round(matrixX[0, 1], 10).ToString();
                TextM02.Text = Math.Round(matrixX[0, 2], 10).ToString();
                TextM10.Text = Math.Round(matrixX[1, 0], 10).ToString();
                TextM11.Text = Math.Round(matrixX[1, 1], 10).ToString();
                TextM12.Text = Math.Round(matrixX[1, 2], 10).ToString();
                TextM20.Text = Math.Round(matrixX[2, 0], 10).ToString();
                TextM21.Text = Math.Round(matrixX[2, 1], 10).ToString();
                TextM22.Text = Math.Round(matrixX[2, 2], 10).ToString();

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
