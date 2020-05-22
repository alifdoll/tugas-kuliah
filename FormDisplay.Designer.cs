namespace Alif3DShapes
{
    partial class FormDisplay
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
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSphere = new System.Windows.Forms.RadioButton();
            this.radioButtonCuboid = new System.Windows.Forms.RadioButton();
            this.radioButtonCylinder = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 20;
            this.listBoxInfo.Location = new System.Drawing.Point(12, 60);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(776, 384);
            this.listBoxInfo.TabIndex = 0;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(12, 12);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(95, 24);
            this.radioButtonAll.TabIndex = 1;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Show All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonSphere
            // 
            this.radioButtonSphere.AutoSize = true;
            this.radioButtonSphere.Location = new System.Drawing.Point(321, 12);
            this.radioButtonSphere.Name = "radioButtonSphere";
            this.radioButtonSphere.Size = new System.Drawing.Size(86, 24);
            this.radioButtonSphere.TabIndex = 2;
            this.radioButtonSphere.TabStop = true;
            this.radioButtonSphere.Text = "Sphere";
            this.radioButtonSphere.UseVisualStyleBackColor = true;
            this.radioButtonSphere.CheckedChanged += new System.EventHandler(this.radioButtonSphere_CheckedChanged);
            // 
            // radioButtonCuboid
            // 
            this.radioButtonCuboid.AutoSize = true;
            this.radioButtonCuboid.Location = new System.Drawing.Point(468, 12);
            this.radioButtonCuboid.Name = "radioButtonCuboid";
            this.radioButtonCuboid.Size = new System.Drawing.Size(84, 24);
            this.radioButtonCuboid.TabIndex = 3;
            this.radioButtonCuboid.TabStop = true;
            this.radioButtonCuboid.Text = "Cuboid";
            this.radioButtonCuboid.UseVisualStyleBackColor = true;
            this.radioButtonCuboid.CheckedChanged += new System.EventHandler(this.radioButtonCuboid_CheckedChanged);
            // 
            // radioButtonCylinder
            // 
            this.radioButtonCylinder.AutoSize = true;
            this.radioButtonCylinder.Location = new System.Drawing.Point(611, 12);
            this.radioButtonCylinder.Name = "radioButtonCylinder";
            this.radioButtonCylinder.Size = new System.Drawing.Size(90, 24);
            this.radioButtonCylinder.TabIndex = 4;
            this.radioButtonCylinder.TabStop = true;
            this.radioButtonCylinder.Text = "Cylinder";
            this.radioButtonCylinder.UseVisualStyleBackColor = true;
            this.radioButtonCylinder.CheckedChanged += new System.EventHandler(this.radioButtonCylinder_CheckedChanged);
            // 
            // FormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonCylinder);
            this.Controls.Add(this.radioButtonCuboid);
            this.Controls.Add(this.radioButtonSphere);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.listBoxInfo);
            this.Name = "FormDisplay";
            this.Text = "FormDisplay";
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonSphere;
        private System.Windows.Forms.RadioButton radioButtonCuboid;
        private System.Windows.Forms.RadioButton radioButtonCylinder;
    }
}