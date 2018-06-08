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
            this.Browse1 = new System.Windows.Forms.Button();
            this.Browse2 = new System.Windows.Forms.Button();
            this.textBoxAfter = new System.Windows.Forms.TextBox();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.listViewFull = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderPortrait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(438, 256);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(172, 48);
            this.Confirmar.TabIndex = 0;
            this.Confirmar.Text = "Create Mp3\'s";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // textBoxBefore
            // 
            this.textBoxBefore.Location = new System.Drawing.Point(12, 26);
            this.textBoxBefore.Name = "textBoxBefore";
            this.textBoxBefore.ReadOnly = true;
            this.textBoxBefore.Size = new System.Drawing.Size(348, 20);
            this.textBoxBefore.TabIndex = 1;
            // 
            // Browse1
            // 
            this.Browse1.Location = new System.Drawing.Point(366, 27);
            this.Browse1.Name = "Browse1";
            this.Browse1.Size = new System.Drawing.Size(66, 19);
            this.Browse1.TabIndex = 2;
            this.Browse1.Text = "Browse...";
            this.Browse1.UseVisualStyleBackColor = true;
            this.Browse1.Click += new System.EventHandler(this.Browse1_Click);
            // 
            // Browse2
            // 
            this.Browse2.Location = new System.Drawing.Point(974, 26);
            this.Browse2.Name = "Browse2";
            this.Browse2.Size = new System.Drawing.Size(66, 19);
            this.Browse2.TabIndex = 4;
            this.Browse2.Text = "Browse...";
            this.Browse2.UseVisualStyleBackColor = true;
            this.Browse2.Click += new System.EventHandler(this.Browse2_Click);
            // 
            // textBoxAfter
            // 
            this.textBoxAfter.Location = new System.Drawing.Point(616, 26);
            this.textBoxAfter.Name = "textBoxAfter";
            this.textBoxAfter.ReadOnly = true;
            this.textBoxAfter.Size = new System.Drawing.Size(352, 20);
            this.textBoxAfter.TabIndex = 3;
            // 
            // buttonDebug
            // 
            this.buttonDebug.Location = new System.Drawing.Point(496, 310);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(54, 21);
            this.buttonDebug.TabIndex = 6;
            this.buttonDebug.Text = "DEBUG";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // listViewFull
            // 
            this.listViewFull.BackColor = System.Drawing.SystemColors.Window;
            this.listViewFull.CheckBoxes = true;
            this.listViewFull.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPortrait,
            this.columnHeaderName});
            this.listViewFull.Location = new System.Drawing.Point(12, 52);
            this.listViewFull.Name = "listViewFull";
            this.listViewFull.Size = new System.Drawing.Size(420, 486);
            this.listViewFull.TabIndex = 7;
            this.listViewFull.UseCompatibleStateImageBehavior = false;
            this.listViewFull.View = System.Windows.Forms.View.Details;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(616, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(424, 486);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeaderPortrait
            // 
            this.columnHeaderPortrait.Text = "Portrait";
            this.columnHeaderPortrait.Width = 100;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 500;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 550);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listViewFull);
            this.Controls.Add(this.buttonDebug);
            this.Controls.Add(this.Browse2);
            this.Controls.Add(this.textBoxAfter);
            this.Controls.Add(this.Browse1);
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
        private System.Windows.Forms.Button Browse1;
        private System.Windows.Forms.Button Browse2;
        private System.Windows.Forms.TextBox textBoxAfter;
        private System.Windows.Forms.Button buttonDebug;
        private System.Windows.Forms.ListView listViewFull;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderPortrait;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
    }
}

