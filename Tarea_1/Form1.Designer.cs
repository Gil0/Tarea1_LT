namespace Tarea_1
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
            this.botonAbrirArchivo = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEjecutar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonNuevoArchivo = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.GroupBox();
            this.areaEditor = new System.Windows.Forms.RichTextBox();
            this.resultado = new System.Windows.Forms.GroupBox();
            this.errores = new System.Windows.Forms.GroupBox();
            this.areaErrores = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.editor.SuspendLayout();
            this.errores.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonAbrirArchivo
            // 
            this.botonAbrirArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.botonAbrirArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAbrirArchivo.Location = new System.Drawing.Point(154, 28);
            this.botonAbrirArchivo.Name = "botonAbrirArchivo";
            this.botonAbrirArchivo.Size = new System.Drawing.Size(126, 28);
            this.botonAbrirArchivo.TabIndex = 0;
            this.botonAbrirArchivo.Text = "Abrir Archivo";
            this.botonAbrirArchivo.UseVisualStyleBackColor = false;
            this.botonAbrirArchivo.Click += new System.EventHandler(this.botonAbrirArchivo_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.botonGuardar.Location = new System.Drawing.Point(284, 28);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(83, 28);
            this.botonGuardar.TabIndex = 1;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEjecutar
            // 
            this.botonEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.botonEjecutar.Location = new System.Drawing.Point(371, 28);
            this.botonEjecutar.Name = "botonEjecutar";
            this.botonEjecutar.Size = new System.Drawing.Size(87, 28);
            this.botonEjecutar.TabIndex = 2;
            this.botonEjecutar.Text = "Ejecutar";
            this.botonEjecutar.UseVisualStyleBackColor = false;
            this.botonEjecutar.Click += new System.EventHandler(this.botonEjecutar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonNuevoArchivo);
            this.groupBox1.Controls.Add(this.botonAbrirArchivo);
            this.groupBox1.Controls.Add(this.botonEjecutar);
            this.groupBox1.Controls.Add(this.botonGuardar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(51, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // botonNuevoArchivo
            // 
            this.botonNuevoArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.botonNuevoArchivo.Location = new System.Drawing.Point(12, 28);
            this.botonNuevoArchivo.Name = "botonNuevoArchivo";
            this.botonNuevoArchivo.Size = new System.Drawing.Size(138, 28);
            this.botonNuevoArchivo.TabIndex = 3;
            this.botonNuevoArchivo.Text = "Nuevo Archivo";
            this.botonNuevoArchivo.UseVisualStyleBackColor = false;
            this.botonNuevoArchivo.Click += new System.EventHandler(this.botonNuevoArchivo_Click);
            // 
            // editor
            // 
            this.editor.Controls.Add(this.areaEditor);
            this.editor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.ForeColor = System.Drawing.Color.White;
            this.editor.Location = new System.Drawing.Point(51, 98);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(421, 428);
            this.editor.TabIndex = 4;
            this.editor.TabStop = false;
            this.editor.Text = "Editor";
            // 
            // areaEditor
            // 
            this.areaEditor.Location = new System.Drawing.Point(25, 28);
            this.areaEditor.Name = "areaEditor";
            this.areaEditor.Size = new System.Drawing.Size(375, 380);
            this.areaEditor.TabIndex = 0;
            this.areaEditor.Text = "";
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.White;
            this.resultado.Location = new System.Drawing.Point(478, 98);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(448, 428);
            this.resultado.TabIndex = 5;
            this.resultado.TabStop = false;
            this.resultado.Text = "Resultado";
            // 
            // errores
            // 
            this.errores.Controls.Add(this.areaErrores);
            this.errores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errores.ForeColor = System.Drawing.Color.White;
            this.errores.Location = new System.Drawing.Point(51, 527);
            this.errores.Name = "errores";
            this.errores.Size = new System.Drawing.Size(875, 106);
            this.errores.TabIndex = 6;
            this.errores.TabStop = false;
            this.errores.Text = "Mensajes y Errores";
            // 
            // areaErrores
            // 
            this.areaErrores.Location = new System.Drawing.Point(25, 26);
            this.areaErrores.Name = "areaErrores";
            this.areaErrores.ReadOnly = true;
            this.areaErrores.Size = new System.Drawing.Size(827, 68);
            this.areaErrores.TabIndex = 0;
            this.areaErrores.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(984, 650);
            this.Controls.Add(this.errores);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sin Titulo - Interprete Mamalon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.editor.ResumeLayout(false);
            this.errores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAbrirArchivo;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEjecutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox editor;
        private System.Windows.Forms.GroupBox resultado;
        private System.Windows.Forms.GroupBox errores;
        private System.Windows.Forms.RichTextBox areaEditor;
        private System.Windows.Forms.RichTextBox areaErrores;
        private System.Windows.Forms.Button botonNuevoArchivo;
    }
}

