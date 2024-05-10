namespace Sustitución
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXY = new System.Windows.Forms.Button();
            this.btnXYZ = new System.Windows.Forms.Button();
            this.btnXYZW = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sustitución de variables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione la operación :";
            // 
            // btnXY
            // 
            this.btnXY.Location = new System.Drawing.Point(111, 175);
            this.btnXY.Name = "btnXY";
            this.btnXY.Size = new System.Drawing.Size(82, 35);
            this.btnXY.TabIndex = 2;
            this.btnXY.Text = "XY";
            this.btnXY.UseVisualStyleBackColor = true;
            this.btnXY.Click += new System.EventHandler(this.btnXY_Click);
            // 
            // btnXYZ
            // 
            this.btnXYZ.Location = new System.Drawing.Point(267, 175);
            this.btnXYZ.Name = "btnXYZ";
            this.btnXYZ.Size = new System.Drawing.Size(82, 35);
            this.btnXYZ.TabIndex = 3;
            this.btnXYZ.Text = "XYZ";
            this.btnXYZ.UseVisualStyleBackColor = true;
            this.btnXYZ.Click += new System.EventHandler(this.btnXYZ_Click);
            // 
            // btnXYZW
            // 
            this.btnXYZW.Location = new System.Drawing.Point(111, 247);
            this.btnXYZW.Name = "btnXYZW";
            this.btnXYZW.Size = new System.Drawing.Size(82, 35);
            this.btnXYZW.TabIndex = 4;
            this.btnXYZW.Text = "XYZW";
            this.btnXYZW.UseVisualStyleBackColor = true;
            this.btnXYZW.Click += new System.EventHandler(this.btnXYZW_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(270, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 39);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 457);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnXYZW);
            this.Controls.Add(this.btnXYZ);
            this.Controls.Add(this.btnXY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXY;
        private System.Windows.Forms.Button btnXYZ;
        private System.Windows.Forms.Button btnXYZW;
        private System.Windows.Forms.Button btnSalir;
    }
}

