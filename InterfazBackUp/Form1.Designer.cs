﻿namespace InterfazBackUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewSeleccion = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ruta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExpandir = new System.Windows.Forms.Button();
            this.buttonContraer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione los archivos a guardar:";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(16, 42);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(223, 367);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "documents_folder.ico");
            this.imageList1.Images.SetKeyName(1, "fileinterfaces.ico");
            // 
            // listViewSeleccion
            // 
            this.listViewSeleccion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Ruta});
            this.listViewSeleccion.HideSelection = false;
            this.listViewSeleccion.Location = new System.Drawing.Point(245, 42);
            this.listViewSeleccion.Name = "listViewSeleccion";
            this.listViewSeleccion.Size = new System.Drawing.Size(587, 367);
            this.listViewSeleccion.SmallImageList = this.imageList1;
            this.listViewSeleccion.TabIndex = 2;
            this.listViewSeleccion.UseCompatibleStateImageBehavior = false;
            this.listViewSeleccion.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Tag = "";
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 104;
            // 
            // Ruta
            // 
            this.Ruta.Text = "Ruta";
            this.Ruta.Width = 258;
            // 
            // buttonExpandir
            // 
            this.buttonExpandir.Location = new System.Drawing.Point(16, 432);
            this.buttonExpandir.Name = "buttonExpandir";
            this.buttonExpandir.Size = new System.Drawing.Size(109, 34);
            this.buttonExpandir.TabIndex = 3;
            this.buttonExpandir.Text = "Expandir Todo";
            this.buttonExpandir.UseVisualStyleBackColor = true;
            this.buttonExpandir.Click += new System.EventHandler(this.buttonExpandir_Click);
            // 
            // buttonContraer
            // 
            this.buttonContraer.Location = new System.Drawing.Point(131, 432);
            this.buttonContraer.Name = "buttonContraer";
            this.buttonContraer.Size = new System.Drawing.Size(109, 34);
            this.buttonContraer.TabIndex = 4;
            this.buttonContraer.Text = "Contraer Todo";
            this.buttonContraer.UseVisualStyleBackColor = true;
            this.buttonContraer.Click += new System.EventHandler(this.buttonContraer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 487);
            this.Controls.Add(this.buttonContraer);
            this.Controls.Add(this.buttonExpandir);
            this.Controls.Add(this.listViewSeleccion);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Copia de Seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listViewSeleccion;
        private System.Windows.Forms.Button buttonExpandir;
        private System.Windows.Forms.Button buttonContraer;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Ruta;
        private System.Windows.Forms.ImageList imageList1;
    }
}

