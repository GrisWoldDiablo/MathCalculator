namespace MathCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextVectX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextVectY = new System.Windows.Forms.TextBox();
            this.TextVectZ = new System.Windows.Forms.TextBox();
            this.TextVect2DL = new System.Windows.Forms.TextBox();
            this.TextVect3DL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_VectL = new System.Windows.Forms.Button();
            this.TextVectX1 = new System.Windows.Forms.TextBox();
            this.TextVectY1 = new System.Windows.Forms.TextBox();
            this.TextVectZ1 = new System.Windows.Forms.TextBox();
            this.TextVectX2 = new System.Windows.Forms.TextBox();
            this.TextVectY2 = new System.Windows.Forms.TextBox();
            this.TextVectZ2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TextVectA2D = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Btn_VectAngle = new System.Windows.Forms.Button();
            this.TextVectA3D = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TextVectRotX = new System.Windows.Forms.TextBox();
            this.TextVectRotY = new System.Windows.Forms.TextBox();
            this.TextVectRotZ = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TextRotAngle = new System.Windows.Forms.TextBox();
            this.Btn_VectRot = new System.Windows.Forms.Button();
            this.TextM00 = new System.Windows.Forms.TextBox();
            this.TextM10 = new System.Windows.Forms.TextBox();
            this.TextM01 = new System.Windows.Forms.TextBox();
            this.TextM11 = new System.Windows.Forms.TextBox();
            this.ChkRotByX = new System.Windows.Forms.CheckBox();
            this.ChkRotByY = new System.Windows.Forms.CheckBox();
            this.ChkRotByZ = new System.Windows.Forms.CheckBox();
            this.TextM20 = new System.Windows.Forms.TextBox();
            this.TextM21 = new System.Windows.Forms.TextBox();
            this.TextM02 = new System.Windows.Forms.TextBox();
            this.TextM12 = new System.Windows.Forms.TextBox();
            this.TextM22 = new System.Windows.Forms.TextBox();
            this.TextScaleVal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TextCompL = new System.Windows.Forms.TextBox();
            this.Btn_CompL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextVectX
            // 
            this.TextVectX.Location = new System.Drawing.Point(51, 197);
            this.TextVectX.Name = "TextVectX";
            this.TextVectX.Size = new System.Drawing.Size(100, 20);
            this.TextVectX.TabIndex = 0;
            this.TextVectX.Text = "0";
            this.TextVectX.TextChanged += new System.EventHandler(this.TextVectX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Z";
            // 
            // TextVectY
            // 
            this.TextVectY.Location = new System.Drawing.Point(51, 229);
            this.TextVectY.Name = "TextVectY";
            this.TextVectY.Size = new System.Drawing.Size(100, 20);
            this.TextVectY.TabIndex = 0;
            this.TextVectY.Text = "0";
            this.TextVectY.TextChanged += new System.EventHandler(this.TextVectY_TextChanged);
            // 
            // TextVectZ
            // 
            this.TextVectZ.Location = new System.Drawing.Point(51, 261);
            this.TextVectZ.Name = "TextVectZ";
            this.TextVectZ.Size = new System.Drawing.Size(100, 20);
            this.TextVectZ.TabIndex = 0;
            this.TextVectZ.Text = "0";
            this.TextVectZ.TextChanged += new System.EventHandler(this.TextVectZ_TextChanged);
            // 
            // TextVect2DL
            // 
            this.TextVect2DL.Location = new System.Drawing.Point(223, 197);
            this.TextVect2DL.Name = "TextVect2DL";
            this.TextVect2DL.ReadOnly = true;
            this.TextVect2DL.Size = new System.Drawing.Size(100, 20);
            this.TextVect2DL.TabIndex = 0;
            this.TextVect2DL.Text = "0";
            // 
            // TextVect3DL
            // 
            this.TextVect3DL.Location = new System.Drawing.Point(223, 261);
            this.TextVect3DL.Name = "TextVect3DL";
            this.TextVect3DL.ReadOnly = true;
            this.TextVect3DL.Size = new System.Drawing.Size(100, 20);
            this.TextVect3DL.TabIndex = 0;
            this.TextVect3DL.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "2D Lenght";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "3D Lenght";
            // 
            // Btn_VectL
            // 
            this.Btn_VectL.Location = new System.Drawing.Point(163, 227);
            this.Btn_VectL.Name = "Btn_VectL";
            this.Btn_VectL.Size = new System.Drawing.Size(100, 23);
            this.Btn_VectL.TabIndex = 2;
            this.Btn_VectL.Text = "Calculate Lenght";
            this.Btn_VectL.UseVisualStyleBackColor = true;
            this.Btn_VectL.Click += new System.EventHandler(this.Btn_VectL_Click);
            // 
            // TextVectX1
            // 
            this.TextVectX1.Location = new System.Drawing.Point(51, 364);
            this.TextVectX1.Name = "TextVectX1";
            this.TextVectX1.Size = new System.Drawing.Size(100, 20);
            this.TextVectX1.TabIndex = 3;
            this.TextVectX1.Text = "0";
            this.TextVectX1.TextChanged += new System.EventHandler(this.TextVectX1_TextChanged);
            // 
            // TextVectY1
            // 
            this.TextVectY1.Location = new System.Drawing.Point(51, 390);
            this.TextVectY1.Name = "TextVectY1";
            this.TextVectY1.Size = new System.Drawing.Size(100, 20);
            this.TextVectY1.TabIndex = 3;
            this.TextVectY1.Text = "0";
            this.TextVectY1.TextChanged += new System.EventHandler(this.TextVectY1_TextChanged);
            // 
            // TextVectZ1
            // 
            this.TextVectZ1.Location = new System.Drawing.Point(51, 416);
            this.TextVectZ1.Name = "TextVectZ1";
            this.TextVectZ1.Size = new System.Drawing.Size(100, 20);
            this.TextVectZ1.TabIndex = 3;
            this.TextVectZ1.Text = "0";
            this.TextVectZ1.TextChanged += new System.EventHandler(this.TextVectZ1_TextChanged);
            // 
            // TextVectX2
            // 
            this.TextVectX2.Location = new System.Drawing.Point(223, 364);
            this.TextVectX2.Name = "TextVectX2";
            this.TextVectX2.Size = new System.Drawing.Size(100, 20);
            this.TextVectX2.TabIndex = 3;
            this.TextVectX2.Text = "0";
            this.TextVectX2.TextChanged += new System.EventHandler(this.TextVectX2_TextChanged);
            // 
            // TextVectY2
            // 
            this.TextVectY2.Location = new System.Drawing.Point(223, 390);
            this.TextVectY2.Name = "TextVectY2";
            this.TextVectY2.Size = new System.Drawing.Size(100, 20);
            this.TextVectY2.TabIndex = 3;
            this.TextVectY2.Text = "0";
            this.TextVectY2.TextChanged += new System.EventHandler(this.TextVectY2_TextChanged);
            // 
            // TextVectZ2
            // 
            this.TextVectZ2.Location = new System.Drawing.Point(223, 416);
            this.TextVectZ2.Name = "TextVectZ2";
            this.TextVectZ2.Size = new System.Drawing.Size(100, 20);
            this.TextVectZ2.TabIndex = 3;
            this.TextVectZ2.Text = "0";
            this.TextVectZ2.TextChanged += new System.EventHandler(this.TextVectZ2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Z";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Vector 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Vector 1";
            // 
            // TextVectA2D
            // 
            this.TextVectA2D.Location = new System.Drawing.Point(377, 390);
            this.TextVectA2D.Name = "TextVectA2D";
            this.TextVectA2D.ReadOnly = true;
            this.TextVectA2D.Size = new System.Drawing.Size(100, 20);
            this.TextVectA2D.TabIndex = 3;
            this.TextVectA2D.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 393);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Angle 2D";
            // 
            // Btn_VectAngle
            // 
            this.Btn_VectAngle.Location = new System.Drawing.Point(377, 364);
            this.Btn_VectAngle.Name = "Btn_VectAngle";
            this.Btn_VectAngle.Size = new System.Drawing.Size(100, 23);
            this.Btn_VectAngle.TabIndex = 4;
            this.Btn_VectAngle.Text = "Calculate Angle";
            this.Btn_VectAngle.UseVisualStyleBackColor = true;
            this.Btn_VectAngle.Click += new System.EventHandler(this.Btn_VectAngle_Click);
            // 
            // TextVectA3D
            // 
            this.TextVectA3D.Location = new System.Drawing.Point(377, 416);
            this.TextVectA3D.Name = "TextVectA3D";
            this.TextVectA3D.ReadOnly = true;
            this.TextVectA3D.Size = new System.Drawing.Size(100, 20);
            this.TextVectA3D.TabIndex = 3;
            this.TextVectA3D.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(329, 419);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Angle 3D";
            // 
            // TextVectRotX
            // 
            this.TextVectRotX.Location = new System.Drawing.Point(514, 200);
            this.TextVectRotX.Name = "TextVectRotX";
            this.TextVectRotX.ReadOnly = true;
            this.TextVectRotX.Size = new System.Drawing.Size(100, 20);
            this.TextVectRotX.TabIndex = 0;
            this.TextVectRotX.Text = "0";
            // 
            // TextVectRotY
            // 
            this.TextVectRotY.Location = new System.Drawing.Point(514, 232);
            this.TextVectRotY.Name = "TextVectRotY";
            this.TextVectRotY.ReadOnly = true;
            this.TextVectRotY.Size = new System.Drawing.Size(100, 20);
            this.TextVectRotY.TabIndex = 0;
            this.TextVectRotY.Text = "0";
            // 
            // TextVectRotZ
            // 
            this.TextVectRotZ.Location = new System.Drawing.Point(514, 264);
            this.TextVectRotZ.Name = "TextVectRotZ";
            this.TextVectRotZ.ReadOnly = true;
            this.TextVectRotZ.Size = new System.Drawing.Size(100, 20);
            this.TextVectRotZ.TabIndex = 0;
            this.TextVectRotZ.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(494, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "X";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(494, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Y";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(494, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Z";
            // 
            // TextRotAngle
            // 
            this.TextRotAngle.Location = new System.Drawing.Point(407, 232);
            this.TextRotAngle.Name = "TextRotAngle";
            this.TextRotAngle.Size = new System.Drawing.Size(43, 20);
            this.TextRotAngle.TabIndex = 0;
            this.TextRotAngle.Text = "0";
            this.TextRotAngle.TextChanged += new System.EventHandler(this.TextRotAngle_TextChanged);
            // 
            // Btn_VectRot
            // 
            this.Btn_VectRot.Location = new System.Drawing.Point(394, 198);
            this.Btn_VectRot.Name = "Btn_VectRot";
            this.Btn_VectRot.Size = new System.Drawing.Size(65, 23);
            this.Btn_VectRot.TabIndex = 2;
            this.Btn_VectRot.Text = "Rotate";
            this.Btn_VectRot.UseVisualStyleBackColor = true;
            this.Btn_VectRot.Click += new System.EventHandler(this.Btn_VectRot_Click);
            // 
            // TextM00
            // 
            this.TextM00.Location = new System.Drawing.Point(379, 101);
            this.TextM00.Name = "TextM00";
            this.TextM00.ReadOnly = true;
            this.TextM00.Size = new System.Drawing.Size(100, 20);
            this.TextM00.TabIndex = 0;
            this.TextM00.Text = "0";
            // 
            // TextM10
            // 
            this.TextM10.Location = new System.Drawing.Point(379, 127);
            this.TextM10.Name = "TextM10";
            this.TextM10.ReadOnly = true;
            this.TextM10.Size = new System.Drawing.Size(100, 20);
            this.TextM10.TabIndex = 0;
            this.TextM10.Text = "0";
            // 
            // TextM01
            // 
            this.TextM01.Location = new System.Drawing.Point(485, 101);
            this.TextM01.Name = "TextM01";
            this.TextM01.ReadOnly = true;
            this.TextM01.Size = new System.Drawing.Size(100, 20);
            this.TextM01.TabIndex = 0;
            this.TextM01.Text = "0";
            // 
            // TextM11
            // 
            this.TextM11.Location = new System.Drawing.Point(485, 127);
            this.TextM11.Name = "TextM11";
            this.TextM11.ReadOnly = true;
            this.TextM11.Size = new System.Drawing.Size(100, 20);
            this.TextM11.TabIndex = 0;
            this.TextM11.Text = "0";
            // 
            // ChkRotByX
            // 
            this.ChkRotByX.AutoSize = true;
            this.ChkRotByX.Location = new System.Drawing.Point(473, 203);
            this.ChkRotByX.Name = "ChkRotByX";
            this.ChkRotByX.Size = new System.Drawing.Size(15, 14);
            this.ChkRotByX.TabIndex = 5;
            this.ChkRotByX.UseVisualStyleBackColor = true;
            this.ChkRotByX.Click += new System.EventHandler(this.ChkRotByX_Click);
            // 
            // ChkRotByY
            // 
            this.ChkRotByY.AutoSize = true;
            this.ChkRotByY.Location = new System.Drawing.Point(473, 234);
            this.ChkRotByY.Name = "ChkRotByY";
            this.ChkRotByY.Size = new System.Drawing.Size(15, 14);
            this.ChkRotByY.TabIndex = 5;
            this.ChkRotByY.UseVisualStyleBackColor = true;
            this.ChkRotByY.Click += new System.EventHandler(this.ChkRotByY_Click);
            // 
            // ChkRotByZ
            // 
            this.ChkRotByZ.AutoSize = true;
            this.ChkRotByZ.Checked = true;
            this.ChkRotByZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRotByZ.Location = new System.Drawing.Point(473, 266);
            this.ChkRotByZ.Name = "ChkRotByZ";
            this.ChkRotByZ.Size = new System.Drawing.Size(15, 14);
            this.ChkRotByZ.TabIndex = 5;
            this.ChkRotByZ.UseVisualStyleBackColor = true;
            this.ChkRotByZ.Click += new System.EventHandler(this.ChkRotByZ_Click);
            // 
            // TextM20
            // 
            this.TextM20.Location = new System.Drawing.Point(379, 153);
            this.TextM20.Name = "TextM20";
            this.TextM20.ReadOnly = true;
            this.TextM20.Size = new System.Drawing.Size(100, 20);
            this.TextM20.TabIndex = 0;
            this.TextM20.Text = "0";
            // 
            // TextM21
            // 
            this.TextM21.Location = new System.Drawing.Point(485, 153);
            this.TextM21.Name = "TextM21";
            this.TextM21.ReadOnly = true;
            this.TextM21.Size = new System.Drawing.Size(100, 20);
            this.TextM21.TabIndex = 0;
            this.TextM21.Text = "0";
            // 
            // TextM02
            // 
            this.TextM02.Location = new System.Drawing.Point(591, 101);
            this.TextM02.Name = "TextM02";
            this.TextM02.ReadOnly = true;
            this.TextM02.Size = new System.Drawing.Size(100, 20);
            this.TextM02.TabIndex = 0;
            this.TextM02.Text = "0";
            // 
            // TextM12
            // 
            this.TextM12.Location = new System.Drawing.Point(591, 127);
            this.TextM12.Name = "TextM12";
            this.TextM12.ReadOnly = true;
            this.TextM12.Size = new System.Drawing.Size(100, 20);
            this.TextM12.TabIndex = 0;
            this.TextM12.Text = "0";
            // 
            // TextM22
            // 
            this.TextM22.Location = new System.Drawing.Point(591, 153);
            this.TextM22.Name = "TextM22";
            this.TextM22.ReadOnly = true;
            this.TextM22.Size = new System.Drawing.Size(100, 20);
            this.TextM22.TabIndex = 0;
            this.TextM22.Text = "0";
            // 
            // TextScaleVal
            // 
            this.TextScaleVal.Location = new System.Drawing.Point(407, 264);
            this.TextScaleVal.Name = "TextScaleVal";
            this.TextScaleVal.Size = new System.Drawing.Size(43, 20);
            this.TextScaleVal.TabIndex = 0;
            this.TextScaleVal.Text = "1";
            this.TextScaleVal.TextChanged += new System.EventHandler(this.TextScaleVal_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(367, 267);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Scale";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(367, 235);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Angle";
            // 
            // TextCompL
            // 
            this.TextCompL.Location = new System.Drawing.Point(132, 444);
            this.TextCompL.Name = "TextCompL";
            this.TextCompL.ReadOnly = true;
            this.TextCompL.Size = new System.Drawing.Size(100, 20);
            this.TextCompL.TabIndex = 6;
            this.TextCompL.Text = "0";
            // 
            // Btn_CompL
            // 
            this.Btn_CompL.Location = new System.Drawing.Point(51, 442);
            this.Btn_CompL.Name = "Btn_CompL";
            this.Btn_CompL.Size = new System.Drawing.Size(75, 23);
            this.Btn_CompL.TabIndex = 7;
            this.Btn_CompL.Text = "Length";
            this.Btn_CompL.UseVisualStyleBackColor = true;
            this.Btn_CompL.Click += new System.EventHandler(this.Btn_CompL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 666);
            this.Controls.Add(this.Btn_CompL);
            this.Controls.Add(this.TextCompL);
            this.Controls.Add(this.ChkRotByZ);
            this.Controls.Add(this.ChkRotByY);
            this.Controls.Add(this.ChkRotByX);
            this.Controls.Add(this.Btn_VectAngle);
            this.Controls.Add(this.TextVectZ2);
            this.Controls.Add(this.TextVectA3D);
            this.Controls.Add(this.TextVectA2D);
            this.Controls.Add(this.TextVectZ1);
            this.Controls.Add(this.TextVectY2);
            this.Controls.Add(this.TextVectY1);
            this.Controls.Add(this.TextVectX2);
            this.Controls.Add(this.TextVectX1);
            this.Controls.Add(this.Btn_VectRot);
            this.Controls.Add(this.Btn_VectL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextVect3DL);
            this.Controls.Add(this.TextVect2DL);
            this.Controls.Add(this.TextM22);
            this.Controls.Add(this.TextM21);
            this.Controls.Add(this.TextM12);
            this.Controls.Add(this.TextM11);
            this.Controls.Add(this.TextM02);
            this.Controls.Add(this.TextM01);
            this.Controls.Add(this.TextVectRotZ);
            this.Controls.Add(this.TextVectZ);
            this.Controls.Add(this.TextM20);
            this.Controls.Add(this.TextM10);
            this.Controls.Add(this.TextVectRotY);
            this.Controls.Add(this.TextVectY);
            this.Controls.Add(this.TextScaleVal);
            this.Controls.Add(this.TextRotAngle);
            this.Controls.Add(this.TextM00);
            this.Controls.Add(this.TextVectRotX);
            this.Controls.Add(this.TextVectX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextVectX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextVectY;
        private System.Windows.Forms.TextBox TextVectZ;
        private System.Windows.Forms.TextBox TextVect2DL;
        private System.Windows.Forms.TextBox TextVect3DL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_VectL;
        private System.Windows.Forms.TextBox TextVectX1;
        private System.Windows.Forms.TextBox TextVectY1;
        private System.Windows.Forms.TextBox TextVectZ1;
        private System.Windows.Forms.TextBox TextVectX2;
        private System.Windows.Forms.TextBox TextVectY2;
        private System.Windows.Forms.TextBox TextVectZ2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextVectA2D;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Btn_VectAngle;
        private System.Windows.Forms.TextBox TextVectA3D;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TextVectRotX;
        private System.Windows.Forms.TextBox TextVectRotY;
        private System.Windows.Forms.TextBox TextVectRotZ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TextRotAngle;
        private System.Windows.Forms.Button Btn_VectRot;
        private System.Windows.Forms.TextBox TextM00;
        private System.Windows.Forms.TextBox TextM10;
        private System.Windows.Forms.TextBox TextM01;
        private System.Windows.Forms.TextBox TextM11;
        private System.Windows.Forms.CheckBox ChkRotByX;
        private System.Windows.Forms.CheckBox ChkRotByY;
        private System.Windows.Forms.CheckBox ChkRotByZ;
        private System.Windows.Forms.TextBox TextM20;
        private System.Windows.Forms.TextBox TextM21;
        private System.Windows.Forms.TextBox TextM02;
        private System.Windows.Forms.TextBox TextM12;
        private System.Windows.Forms.TextBox TextM22;
        private System.Windows.Forms.TextBox TextScaleVal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TextCompL;
        private System.Windows.Forms.Button Btn_CompL;
    }
}

