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
            this.defaultListView = new System.Windows.Forms.ListView();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.modifiedListView = new System.Windows.Forms.ListView();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDeselect = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // defaultListView
            // 
            this.defaultListView.Location = new System.Drawing.Point(12, 12);
            this.defaultListView.Name = "defaultListView";
            this.defaultListView.Size = new System.Drawing.Size(318, 445);
            this.defaultListView.TabIndex = 1;
            this.defaultListView.UseCompatibleStateImageBehavior = false;
            this.defaultListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(348, 423);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(112, 34);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate Mp3 Files";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifiedListView
            // 
            this.modifiedListView.Location = new System.Drawing.Point(478, 12);
            this.modifiedListView.Name = "modifiedListView";
            this.modifiedListView.Size = new System.Drawing.Size(318, 445);
            this.modifiedListView.TabIndex = 3;
            this.modifiedListView.UseCompatibleStateImageBehavior = false;
            this.modifiedListView.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(348, 182);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(112, 34);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Mark as selected";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeselect
            // 
            this.buttonDeselect.Location = new System.Drawing.Point(348, 222);
            this.buttonDeselect.Name = "buttonDeselect";
            this.buttonDeselect.Size = new System.Drawing.Size(112, 34);
            this.buttonDeselect.TabIndex = 5;
            this.buttonDeselect.Text = "Mark as deselected";
            this.buttonDeselect.UseVisualStyleBackColor = true;
            this.buttonDeselect.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(348, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 469);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDeselect);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.modifiedListView);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.defaultListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "Osu! Mp3 Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView defaultListView;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ListView modifiedListView;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonDeselect;
        private System.Windows.Forms.Button buttonCancel;
    }
}

