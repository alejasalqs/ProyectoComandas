namespace ProyectoComandas
{
    partial class InicioAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdministrador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMeserosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarClientesToolStripMenuItem,
            this.administrarMesasToolStripMenuItem,
            this.administrarMeserosToolStripMenuItem,
            this.administrarOrdenesToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarClientesToolStripMenuItem
            // 
            this.administrarClientesToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarClientesToolStripMenuItem.Name = "administrarClientesToolStripMenuItem";
            this.administrarClientesToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.administrarClientesToolStripMenuItem.Text = "Administrar Clientes";
            this.administrarClientesToolStripMenuItem.Click += new System.EventHandler(this.administrarClientesToolStripMenuItem_Click);
            // 
            // administrarMesasToolStripMenuItem
            // 
            this.administrarMesasToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarMesasToolStripMenuItem.Name = "administrarMesasToolStripMenuItem";
            this.administrarMesasToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.administrarMesasToolStripMenuItem.Text = "Administrar Mesas";
            // 
            // administrarMeserosToolStripMenuItem
            // 
            this.administrarMeserosToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarMeserosToolStripMenuItem.Name = "administrarMeserosToolStripMenuItem";
            this.administrarMeserosToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.administrarMeserosToolStripMenuItem.Text = "Administrar Meseros ";
            this.administrarMeserosToolStripMenuItem.Click += new System.EventHandler(this.administrarMeserosToolStripMenuItem_Click);
            // 
            // administrarOrdenesToolStripMenuItem
            // 
            this.administrarOrdenesToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarOrdenesToolStripMenuItem.Name = "administrarOrdenesToolStripMenuItem";
            this.administrarOrdenesToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.administrarOrdenesToolStripMenuItem.Text = "Administrar Ordenes";
            this.administrarOrdenesToolStripMenuItem.Click += new System.EventHandler(this.administrarOrdenesToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // InicioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 504);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InicioAdministrador";
            this.Text = "InicioAdministrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMeserosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}