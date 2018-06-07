namespace Osu_Mp3_Creator
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.Confirmar = new System.Windows.Forms.Button();
            this.textBoxBefore = new System.Windows.Forms.TextBox();
            this.Examinar1 = new System.Windows.Forms.Button();
            this.Examinar2 = new System.Windows.Forms.Button();
            this.textBoxAfter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(438, 12);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(172, 48);
            this.Confirmar.TabIndex = 0;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // textBoxBefore
            // 
            this.textBoxBefore.Location = new System.Drawing.Point(12, 26);
            this.textBoxBefore.Name = "textBoxBefore";
            this.textBoxBefore.ReadOnly = true;
            this.textBoxBefore.Size = new System.Drawing.Size(331, 20);
            this.textBoxBefore.TabIndex = 1;
            // 
            // Examinar1
            // 
            this.Examinar1.Location = new System.Drawing.Point(358, 27);
            this.Examinar1.Name = "Examinar1";
            this.Examinar1.Size = new System.Drawing.Size(66, 19);
            this.Examinar1.TabIndex = 2;
            this.Examinar1.Text = "Examine";
            this.Examinar1.UseVisualStyleBackColor = true;
            this.Examinar1.Click += new System.EventHandler(this.Examinar1_Click);
            // 
            // Examinar2
            // 
            this.Examinar2.Location = new System.Drawing.Point(973, 26);
            this.Examinar2.Name = "Examinar2";
            this.Examinar2.Size = new System.Drawing.Size(66, 19);
            this.Examinar2.TabIndex = 4;
            this.Examinar2.Text = "Examinar";
            this.Examinar2.UseVisualStyleBackColor = true;
            this.Examinar2.Click += new System.EventHandler(this.Examinar2_Click);
            // 
            // textBoxAfter
            // 
            this.textBoxAfter.Location = new System.Drawing.Point(626, 27);
            this.textBoxAfter.Name = "textBoxAfter";
            this.textBoxAfter.ReadOnly = true;
            this.textBoxAfter.Size = new System.Drawing.Size(331, 20);
            this.textBoxAfter.TabIndex = 3;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 72);
            this.Controls.Add(this.Examinar2);
            this.Controls.Add(this.textBoxAfter);
            this.Controls.Add(this.Examinar1);
            this.Controls.Add(this.textBoxBefore);
            this.Controls.Add(this.Confirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "Osu! Mp3 Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox textBoxBefore;
        private System.Windows.Forms.Button Examinar1;
        private System.Windows.Forms.Button Examinar2;
        private System.Windows.Forms.TextBox textBoxAfter;
    }
}

