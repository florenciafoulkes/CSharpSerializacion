namespace TP_Promocion
{
    partial class Registros
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializaciónXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializaciónJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.exportacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem,
            this.modificarRegistroToolStripMenuItem,
            this.eliminarRegistroToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            this.nuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem_Click);
            // 
            // modificarRegistroToolStripMenuItem
            // 
            this.modificarRegistroToolStripMenuItem.Name = "modificarRegistroToolStripMenuItem";
            this.modificarRegistroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarRegistroToolStripMenuItem.Text = "Modificar Registro";
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            // 
            // exportacionesToolStripMenuItem
            // 
            this.exportacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializaciónXMLToolStripMenuItem,
            this.serializaciónJSONToolStripMenuItem});
            this.exportacionesToolStripMenuItem.Name = "exportacionesToolStripMenuItem";
            this.exportacionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.exportacionesToolStripMenuItem.Text = "Exportaciones";
            // 
            // serializaciónXMLToolStripMenuItem
            // 
            this.serializaciónXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.cToolStripMenuItem1,
            this.javaScriptToolStripMenuItem});
            this.serializaciónXMLToolStripMenuItem.Name = "serializaciónXMLToolStripMenuItem";
            this.serializaciónXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serializaciónXMLToolStripMenuItem.Text = "Serialización XML";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem.Text = "C#";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem1.Text = "C++";
            this.cToolStripMenuItem1.Click += new System.EventHandler(this.cToolStripMenuItem1_Click);
            // 
            // javaScriptToolStripMenuItem
            // 
            this.javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
            this.javaScriptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.javaScriptToolStripMenuItem.Text = "JavaScript";
            this.javaScriptToolStripMenuItem.Click += new System.EventHandler(this.javaScriptToolStripMenuItem_Click);
            // 
            // serializaciónJSONToolStripMenuItem
            // 
            this.serializaciónJSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem2,
            this.cToolStripMenuItem3,
            this.javaScriptToolStripMenuItem1});
            this.serializaciónJSONToolStripMenuItem.Name = "serializaciónJSONToolStripMenuItem";
            this.serializaciónJSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serializaciónJSONToolStripMenuItem.Text = "Serialización JSON";
            // 
            // cToolStripMenuItem2
            // 
            this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            this.cToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem2.Text = "C#";
            this.cToolStripMenuItem2.Click += new System.EventHandler(this.cToolStripMenuItem2_Click);
            // 
            // cToolStripMenuItem3
            // 
            this.cToolStripMenuItem3.Name = "cToolStripMenuItem3";
            this.cToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem3.Text = "C++";
            this.cToolStripMenuItem3.Click += new System.EventHandler(this.cToolStripMenuItem3_Click);
            // 
            // javaScriptToolStripMenuItem1
            // 
            this.javaScriptToolStripMenuItem1.Name = "javaScriptToolStripMenuItem1";
            this.javaScriptToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.javaScriptToolStripMenuItem1.Text = "JavaScript";
            this.javaScriptToolStripMenuItem1.Click += new System.EventHandler(this.javaScriptToolStripMenuItem1_Click);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 283);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Registros";
            this.Text = "Registros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializaciónXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem javaScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializaciónJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem javaScriptToolStripMenuItem1;
    }
}

