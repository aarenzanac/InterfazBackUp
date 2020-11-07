namespace InterfazBackUp
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
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonCompleta = new System.Windows.Forms.RadioButton();
            this.radioButtonIncremental = new System.Windows.Forms.RadioButton();
            this.radioButtonDiferencial = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuscarUbicacion = new System.Windows.Forms.Button();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNobreCopia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
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
            this.treeView1.Location = new System.Drawing.Point(16, 157);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(255, 320);
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
            this.listViewSeleccion.Location = new System.Drawing.Point(277, 157);
            this.listViewSeleccion.Name = "listViewSeleccion";
            this.listViewSeleccion.Size = new System.Drawing.Size(616, 320);
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
            this.buttonExpandir.Location = new System.Drawing.Point(15, 483);
            this.buttonExpandir.Name = "buttonExpandir";
            this.buttonExpandir.Size = new System.Drawing.Size(109, 28);
            this.buttonExpandir.TabIndex = 3;
            this.buttonExpandir.Text = "Expandir Todo";
            this.buttonExpandir.UseVisualStyleBackColor = true;
            this.buttonExpandir.Click += new System.EventHandler(this.buttonExpandir_Click);
            // 
            // buttonContraer
            // 
            this.buttonContraer.Location = new System.Drawing.Point(129, 483);
            this.buttonContraer.Name = "buttonContraer";
            this.buttonContraer.Size = new System.Drawing.Size(109, 28);
            this.buttonContraer.TabIndex = 4;
            this.buttonContraer.Text = "Contraer Todo";
            this.buttonContraer.UseVisualStyleBackColor = true;
            this.buttonContraer.Click += new System.EventHandler(this.buttonContraer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione tipo de copia:";
            // 
            // radioButtonCompleta
            // 
            this.radioButtonCompleta.AutoSize = true;
            this.radioButtonCompleta.Location = new System.Drawing.Point(540, 37);
            this.radioButtonCompleta.Name = "radioButtonCompleta";
            this.radioButtonCompleta.Size = new System.Drawing.Size(88, 21);
            this.radioButtonCompleta.TabIndex = 6;
            this.radioButtonCompleta.TabStop = true;
            this.radioButtonCompleta.Text = "Completa";
            this.radioButtonCompleta.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncremental
            // 
            this.radioButtonIncremental.AutoSize = true;
            this.radioButtonIncremental.Location = new System.Drawing.Point(540, 64);
            this.radioButtonIncremental.Name = "radioButtonIncremental";
            this.radioButtonIncremental.Size = new System.Drawing.Size(102, 21);
            this.radioButtonIncremental.TabIndex = 7;
            this.radioButtonIncremental.TabStop = true;
            this.radioButtonIncremental.Text = "Incremental";
            this.radioButtonIncremental.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiferencial
            // 
            this.radioButtonDiferencial.AutoSize = true;
            this.radioButtonDiferencial.Location = new System.Drawing.Point(540, 96);
            this.radioButtonDiferencial.Name = "radioButtonDiferencial";
            this.radioButtonDiferencial.Size = new System.Drawing.Size(96, 21);
            this.radioButtonDiferencial.TabIndex = 8;
            this.radioButtonDiferencial.TabStop = true;
            this.radioButtonDiferencial.Text = "Diferencial";
            this.radioButtonDiferencial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione ubicación:";
            // 
            // buttonBuscarUbicacion
            // 
            this.buttonBuscarUbicacion.Location = new System.Drawing.Point(15, 33);
            this.buttonBuscarUbicacion.Name = "buttonBuscarUbicacion";
            this.buttonBuscarUbicacion.Size = new System.Drawing.Size(84, 30);
            this.buttonBuscarUbicacion.TabIndex = 10;
            this.buttonBuscarUbicacion.Text = "Buscar";
            this.buttonBuscarUbicacion.UseVisualStyleBackColor = true;
            this.buttonBuscarUbicacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Location = new System.Drawing.Point(105, 37);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(393, 22);
            this.textBoxRuta.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Introduzca un nombre para la copia:";
            // 
            // textBoxNobreCopia
            // 
            this.textBoxNobreCopia.Location = new System.Drawing.Point(16, 95);
            this.textBoxNobreCopia.Name = "textBoxNobreCopia";
            this.textBoxNobreCopia.Size = new System.Drawing.Size(393, 22);
            this.textBoxNobreCopia.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Archivos seleccionados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Planificación de copia:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(698, 483);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(195, 55);
            this.buttonAceptar.TabIndex = 17;
            this.buttonAceptar.Text = "Realizar Copia";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 541);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNobreCopia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.buttonBuscarUbicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonDiferencial);
            this.Controls.Add(this.radioButtonIncremental);
            this.Controls.Add(this.radioButtonCompleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonContraer);
            this.Controls.Add(this.buttonExpandir);
            this.Controls.Add(this.listViewSeleccion);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonCompleta;
        private System.Windows.Forms.RadioButton radioButtonIncremental;
        private System.Windows.Forms.RadioButton radioButtonDiferencial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscarUbicacion;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNobreCopia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAceptar;
    }
}

