namespace AppVector
{
    partial class frmvector
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
            this.lbValor = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.básicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDeParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDeImparesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarMenorAMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementPosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDeCapicuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDePrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(36, 90);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 0;
            this.lbValor.Text = "Valor";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(36, 126);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "Resultado";
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(215, 85);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(39, 170);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 3;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(89, 88);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.básicaToolStripMenuItem,
            this.avanzadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // básicaToolStripMenuItem
            // 
            this.básicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.básicaToolStripMenuItem.Name = "básicaToolStripMenuItem";
            this.básicaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.básicaToolStripMenuItem.Text = "Básica";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.adicionarToolStripMenuItem.Text = "adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mostrarToolStripMenuItem.Text = "mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirToolStripMenuItem,
            this.cantDeParesToolStripMenuItem,
            this.cantDeImparesToolStripMenuItem,
            this.ordenarMenorAMayorToolStripMenuItem,
            this.eliminarElementPosToolStripMenuItem,
            this.cantDeCapicuaToolStripMenuItem,
            this.cantDePrimosToolStripMenuItem});
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.invertirToolStripMenuItem.Text = "Invertir";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // cantDeParesToolStripMenuItem
            // 
            this.cantDeParesToolStripMenuItem.Name = "cantDeParesToolStripMenuItem";
            this.cantDeParesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cantDeParesToolStripMenuItem.Text = "Cant. de Pares";
            this.cantDeParesToolStripMenuItem.Click += new System.EventHandler(this.cantDeParesToolStripMenuItem_Click);
            // 
            // cantDeImparesToolStripMenuItem
            // 
            this.cantDeImparesToolStripMenuItem.Name = "cantDeImparesToolStripMenuItem";
            this.cantDeImparesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cantDeImparesToolStripMenuItem.Text = "Cant. de Impares";
            this.cantDeImparesToolStripMenuItem.Click += new System.EventHandler(this.cantDeImparesToolStripMenuItem_Click);
            // 
            // ordenarMenorAMayorToolStripMenuItem
            // 
            this.ordenarMenorAMayorToolStripMenuItem.Name = "ordenarMenorAMayorToolStripMenuItem";
            this.ordenarMenorAMayorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ordenarMenorAMayorToolStripMenuItem.Text = "Ordenar Menor a Mayor";
            this.ordenarMenorAMayorToolStripMenuItem.Click += new System.EventHandler(this.ordenarMenorAMayorToolStripMenuItem_Click);
            // 
            // eliminarElementPosToolStripMenuItem
            // 
            this.eliminarElementPosToolStripMenuItem.Name = "eliminarElementPosToolStripMenuItem";
            this.eliminarElementPosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.eliminarElementPosToolStripMenuItem.Text = "Eliminar Element. Pos";
            this.eliminarElementPosToolStripMenuItem.Click += new System.EventHandler(this.eliminarElementPosToolStripMenuItem_Click);
            // 
            // cantDeCapicuaToolStripMenuItem
            // 
            this.cantDeCapicuaToolStripMenuItem.Name = "cantDeCapicuaToolStripMenuItem";
            this.cantDeCapicuaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cantDeCapicuaToolStripMenuItem.Text = "Cant. de Capicúa";
            this.cantDeCapicuaToolStripMenuItem.Click += new System.EventHandler(this.cantDeCapicuaToolStripMenuItem_Click);
            // 
            // cantDePrimosToolStripMenuItem
            // 
            this.cantDePrimosToolStripMenuItem.Name = "cantDePrimosToolStripMenuItem";
            this.cantDePrimosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cantDePrimosToolStripMenuItem.Text = "Cant. de Primos";
            this.cantDePrimosToolStripMenuItem.Click += new System.EventHandler(this.cantDePrimosToolStripMenuItem_Click);
            // 
            // frmvector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 307);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmvector";
            this.Text = "Vector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem básicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantDeParesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarMenorAMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElementPosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantDeImparesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantDeCapicuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantDePrimosToolStripMenuItem;

    }
}

