namespace PrefinalProgramacionPunto3D.Windows
{
    partial class frmPuntos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvDatos = new DataGridView();
            colX = new DataGridViewTextBoxColumn();
            colY = new DataGridViewTextBoxColumn();
            colZ = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colDistancia = new DataGridViewTextBoxColumn();
            panelCantidad = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            bordeToolStripMenuItem = new ToolStripMenuItem();
            tsCboContornos = new ToolStripComboBox();
            tsbOrdenar = new ToolStripDropDownButton();
            lado09ToolStripMenuItem = new ToolStripMenuItem();
            lado90ToolStripMenuItem = new ToolStripMenuItem();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panelCantidad.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colX, colY, colZ, colColor, colDistancia });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 75);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(914, 428);
            dgvDatos.TabIndex = 5;
            // 
            // colX
            // 
            colX.HeaderText = "X";
            colX.MinimumWidth = 6;
            colX.Name = "colX";
            colX.ReadOnly = true;
            colX.Width = 125;
            // 
            // colY
            // 
            colY.HeaderText = "Y";
            colY.MinimumWidth = 6;
            colY.Name = "colY";
            colY.ReadOnly = true;
            colY.Width = 125;
            // 
            // colZ
            // 
            colZ.HeaderText = "Z";
            colZ.MinimumWidth = 6;
            colZ.Name = "colZ";
            colZ.ReadOnly = true;
            colZ.Width = 397;
            // 
            // colColor
            // 
            colColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colColor.HeaderText = "Color";
            colColor.MinimumWidth = 6;
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            // 
            // colDistancia
            // 
            colDistancia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDistancia.HeaderText = "Dist. Origen";
            colDistancia.MinimumWidth = 6;
            colDistancia.Name = "colDistancia";
            colDistancia.ReadOnly = true;
            // 
            // panelCantidad
            // 
            panelCantidad.Controls.Add(txtCantidad);
            panelCantidad.Controls.Add(label1);
            panelCantidad.Dock = DockStyle.Bottom;
            panelCantidad.Location = new Point(0, 503);
            panelCantidad.Margin = new Padding(3, 4, 3, 4);
            panelCantidad.Name = "panelCantidad";
            panelCantidad.Size = new Size(914, 97);
            panelCantidad.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(146, 33);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbOrdenar, tsbActualizar, toolStripSeparator2, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 75);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.add_file_48px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(56, 72);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_48px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(54, 72);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_48px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 72);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 75);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { bordeToolStripMenuItem });
            tsbFiltrar.Image = Properties.Resources.filled_filter_48px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(62, 72);
            tsbFiltrar.Text = "Filtar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // bordeToolStripMenuItem
            // 
            bordeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsCboContornos });
            bordeToolStripMenuItem.Name = "bordeToolStripMenuItem";
            bordeToolStripMenuItem.Size = new Size(128, 26);
            bordeToolStripMenuItem.Text = "Color";
            // 
            // tsCboContornos
            // 
            tsCboContornos.Name = "tsCboContornos";
            tsCboContornos.Size = new Size(121, 28);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { lado09ToolStripMenuItem, lado90ToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.sorting_answers_48px;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(77, 72);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // lado09ToolStripMenuItem
            // 
            lado09ToolStripMenuItem.Image = Properties.Resources.numerical_sorting_12_48px;
            lado09ToolStripMenuItem.Name = "lado09ToolStripMenuItem";
            lado09ToolStripMenuItem.Size = new Size(189, 26);
            lado09ToolStripMenuItem.Text = "Distancia (0-9)";
            // 
            // lado90ToolStripMenuItem
            // 
            lado90ToolStripMenuItem.Image = Properties.Resources.numerical_sorting_21_48px;
            lado90ToolStripMenuItem.Name = "lado90ToolStripMenuItem";
            lado90ToolStripMenuItem.Size = new Size(189, 26);
            lado90ToolStripMenuItem.Text = "Distancia (9-0)";
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.restart_48px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(79, 72);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 75);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.exit_48px;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(52, 72);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // frmPuntos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvDatos);
            Controls.Add(panelCantidad);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPuntos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Puntos 3D";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panelCantidad.ResumeLayout(false);
            panelCantidad.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colX;
        private DataGridViewTextBoxColumn colY;
        private DataGridViewTextBoxColumn colZ;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colDistancia;
        private Panel panelCantidad;
        private TextBox txtCantidad;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem bordeToolStripMenuItem;
        private ToolStripComboBox tsCboContornos;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem lado09ToolStripMenuItem;
        private ToolStripMenuItem lado90ToolStripMenuItem;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
    }
}
