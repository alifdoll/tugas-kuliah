namespace Alif3DShapes
{
    partial class FormAdd
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonCuboid = new System.Windows.Forms.RadioButton();
            this.radioButtonSphere = new System.Windows.Forms.RadioButton();
            this.groupBoxCuboid = new System.Windows.Forms.GroupBox();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSphere = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownDiamet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxShape = new System.Windows.Forms.GroupBox();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonCylinder = new System.Windows.Forms.RadioButton();
            this.groupBoxCylinder = new System.Windows.Forms.GroupBox();
            this.numericUpDownHeightCy = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownDiamCylin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.groupBoxCuboid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.groupBoxSphere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiamet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.groupBoxShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            this.groupBoxCylinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeightCy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiamCylin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(648, 539);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(91, 34);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(648, 367);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(91, 34);
            this.buttonRemove.TabIndex = 15;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(551, 367);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 34);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonCuboid
            // 
            this.radioButtonCuboid.AutoSize = true;
            this.radioButtonCuboid.Location = new System.Drawing.Point(257, 166);
            this.radioButtonCuboid.Name = "radioButtonCuboid";
            this.radioButtonCuboid.Size = new System.Drawing.Size(84, 24);
            this.radioButtonCuboid.TabIndex = 13;
            this.radioButtonCuboid.TabStop = true;
            this.radioButtonCuboid.Text = "Cuboid";
            this.radioButtonCuboid.UseVisualStyleBackColor = true;
            this.radioButtonCuboid.CheckedChanged += new System.EventHandler(this.radioButtonCuboid_CheckedChanged);
            // 
            // radioButtonSphere
            // 
            this.radioButtonSphere.AutoSize = true;
            this.radioButtonSphere.Location = new System.Drawing.Point(13, 166);
            this.radioButtonSphere.Name = "radioButtonSphere";
            this.radioButtonSphere.Size = new System.Drawing.Size(86, 24);
            this.radioButtonSphere.TabIndex = 12;
            this.radioButtonSphere.TabStop = true;
            this.radioButtonSphere.Text = "Sphere";
            this.radioButtonSphere.UseVisualStyleBackColor = true;
            this.radioButtonSphere.CheckedChanged += new System.EventHandler(this.radioButtonSphere_CheckedChanged);
            // 
            // groupBoxCuboid
            // 
            this.groupBoxCuboid.Controls.Add(this.numericUpDownLength);
            this.groupBoxCuboid.Controls.Add(this.label9);
            this.groupBoxCuboid.Controls.Add(this.numericUpDownHeight);
            this.groupBoxCuboid.Controls.Add(this.label4);
            this.groupBoxCuboid.Controls.Add(this.numericUpDownWidth);
            this.groupBoxCuboid.Controls.Add(this.label3);
            this.groupBoxCuboid.Location = new System.Drawing.Point(257, 196);
            this.groupBoxCuboid.Name = "groupBoxCuboid";
            this.groupBoxCuboid.Size = new System.Drawing.Size(238, 154);
            this.groupBoxCuboid.TabIndex = 11;
            this.groupBoxCuboid.TabStop = false;
            this.groupBoxCuboid.Text = "Cuboid Data";
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(66, 115);
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(147, 26);
            this.numericUpDownLength.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Length:";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(66, 69);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(147, 26);
            this.numericUpDownHeight.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height:";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(66, 25);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(147, 26);
            this.numericUpDownWidth.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width:";
            // 
            // groupBoxSphere
            // 
            this.groupBoxSphere.Controls.Add(this.label10);
            this.groupBoxSphere.Controls.Add(this.numericUpDownDiamet);
            this.groupBoxSphere.Location = new System.Drawing.Point(13, 196);
            this.groupBoxSphere.Name = "groupBoxSphere";
            this.groupBoxSphere.Size = new System.Drawing.Size(238, 99);
            this.groupBoxSphere.TabIndex = 10;
            this.groupBoxSphere.TabStop = false;
            this.groupBoxSphere.Text = "Sphere Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Diameter:";
            // 
            // numericUpDownDiamet
            // 
            this.numericUpDownDiamet.Location = new System.Drawing.Point(102, 40);
            this.numericUpDownDiamet.Name = "numericUpDownDiamet";
            this.numericUpDownDiamet.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownDiamet.TabIndex = 7;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(351, 35);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(121, 26);
            this.numericUpDownY.TabIndex = 8;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(103, 35);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(121, 26);
            this.numericUpDownX.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "StartY : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "StartX : ";
            // 
            // groupBoxShape
            // 
            this.groupBoxShape.Controls.Add(this.numericUpDownZ);
            this.groupBoxShape.Controls.Add(this.label8);
            this.groupBoxShape.Controls.Add(this.numericUpDownY);
            this.groupBoxShape.Controls.Add(this.numericUpDownX);
            this.groupBoxShape.Controls.Add(this.label2);
            this.groupBoxShape.Controls.Add(this.label1);
            this.groupBoxShape.Location = new System.Drawing.Point(12, 12);
            this.groupBoxShape.Name = "groupBoxShape";
            this.groupBoxShape.Size = new System.Drawing.Size(727, 141);
            this.groupBoxShape.TabIndex = 9;
            this.groupBoxShape.TabStop = false;
            this.groupBoxShape.Text = "Shape:";
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Location = new System.Drawing.Point(590, 35);
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(121, 26);
            this.numericUpDownZ.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "StartZ : ";
            // 
            // radioButtonCylinder
            // 
            this.radioButtonCylinder.AutoSize = true;
            this.radioButtonCylinder.Location = new System.Drawing.Point(501, 166);
            this.radioButtonCylinder.Name = "radioButtonCylinder";
            this.radioButtonCylinder.Size = new System.Drawing.Size(90, 24);
            this.radioButtonCylinder.TabIndex = 19;
            this.radioButtonCylinder.TabStop = true;
            this.radioButtonCylinder.Text = "Cylinder";
            this.radioButtonCylinder.UseVisualStyleBackColor = true;
            this.radioButtonCylinder.CheckedChanged += new System.EventHandler(this.radioButtonCylinder_CheckedChanged);
            // 
            // groupBoxCylinder
            // 
            this.groupBoxCylinder.Controls.Add(this.numericUpDownHeightCy);
            this.groupBoxCylinder.Controls.Add(this.label6);
            this.groupBoxCylinder.Controls.Add(this.numericUpDownDiamCylin);
            this.groupBoxCylinder.Controls.Add(this.label7);
            this.groupBoxCylinder.Location = new System.Drawing.Point(501, 196);
            this.groupBoxCylinder.Name = "groupBoxCylinder";
            this.groupBoxCylinder.Size = new System.Drawing.Size(238, 141);
            this.groupBoxCylinder.TabIndex = 18;
            this.groupBoxCylinder.TabStop = false;
            this.groupBoxCylinder.Text = "Cylinder Data";
            // 
            // numericUpDownHeightCy
            // 
            this.numericUpDownHeightCy.Location = new System.Drawing.Point(101, 93);
            this.numericUpDownHeightCy.Name = "numericUpDownHeightCy";
            this.numericUpDownHeightCy.Size = new System.Drawing.Size(121, 26);
            this.numericUpDownHeightCy.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Height:";
            // 
            // numericUpDownDiamCylin
            // 
            this.numericUpDownDiamCylin.Location = new System.Drawing.Point(100, 40);
            this.numericUpDownDiamCylin.Name = "numericUpDownDiamCylin";
            this.numericUpDownDiamCylin.Size = new System.Drawing.Size(122, 26);
            this.numericUpDownDiamCylin.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Diameter:";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 20;
            this.listBoxInfo.Location = new System.Drawing.Point(12, 428);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(727, 104);
            this.listBoxInfo.TabIndex = 20;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 585);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.radioButtonCylinder);
            this.Controls.Add(this.groupBoxCylinder);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.radioButtonCuboid);
            this.Controls.Add(this.radioButtonSphere);
            this.Controls.Add(this.groupBoxCuboid);
            this.Controls.Add(this.groupBoxSphere);
            this.Controls.Add(this.groupBoxShape);
            this.Name = "FormAdd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCuboid.ResumeLayout(false);
            this.groupBoxCuboid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.groupBoxSphere.ResumeLayout(false);
            this.groupBoxSphere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiamet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.groupBoxShape.ResumeLayout(false);
            this.groupBoxShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            this.groupBoxCylinder.ResumeLayout(false);
            this.groupBoxCylinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeightCy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiamCylin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonCuboid;
        private System.Windows.Forms.RadioButton radioButtonSphere;
        private System.Windows.Forms.GroupBox groupBoxCuboid;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxSphere;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxShape;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonCylinder;
        private System.Windows.Forms.GroupBox groupBoxCylinder;
        private System.Windows.Forms.NumericUpDown numericUpDownHeightCy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownDiamCylin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDiamet;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxInfo;
    }
}

