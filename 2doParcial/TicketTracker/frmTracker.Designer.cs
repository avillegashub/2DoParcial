namespace TicketTracker
{
    partial class FrmTracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWait = new System.Windows.Forms.DataGridView();
            this.btGenerar = new System.Windows.Forms.Button();
            this.rtMostrar = new System.Windows.Forms.RichTextBox();
            this.dgvReady = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPreparando = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReady)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWait
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvWait.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvWait.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvWait.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWait.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvWait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWait.ColumnHeadersVisible = false;
            this.dgvWait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orden});
            this.dgvWait.Location = new System.Drawing.Point(14, 53);
            this.dgvWait.Name = "dgvWait";
            this.dgvWait.ReadOnly = true;
            this.dgvWait.RowHeadersVisible = false;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvWait.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvWait.RowTemplate.Height = 40;
            this.dgvWait.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvWait.Size = new System.Drawing.Size(150, 439);
            this.dgvWait.TabIndex = 1;
            // 
            // btGenerar
            // 
            this.btGenerar.BackColor = System.Drawing.Color.DarkOrange;
            this.btGenerar.Font = new System.Drawing.Font("Permanent Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerar.Location = new System.Drawing.Point(492, 455);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(112, 38);
            this.btGenerar.TabIndex = 3;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = false;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // rtMostrar
            // 
            this.rtMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtMostrar.Location = new System.Drawing.Point(186, 53);
            this.rtMostrar.Name = "rtMostrar";
            this.rtMostrar.Size = new System.Drawing.Size(283, 439);
            this.rtMostrar.TabIndex = 4;
            this.rtMostrar.Text = "";
            // 
            // dgvReady
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.dgvReady.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvReady.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReady.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReady.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReady.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReady.ColumnHeadersVisible = false;
            this.dgvReady.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Estado});
            this.dgvReady.Location = new System.Drawing.Point(492, 53);
            this.dgvReady.Name = "dgvReady";
            this.dgvReady.RowHeadersVisible = false;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReady.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvReady.RowTemplate.Height = 40;
            this.dgvReady.RowTemplate.ReadOnly = true;
            this.dgvReady.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReady.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvReady.ShowCellErrors = false;
            this.dgvReady.ShowCellToolTips = false;
            this.dgvReady.ShowEditingIcon = false;
            this.dgvReady.ShowRowErrors = false;
            this.dgvReady.Size = new System.Drawing.Size(250, 384);
            this.dgvReady.StandardTab = true;
            this.dgvReady.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle19;
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Column1";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle20;
            this.Estado.Frozen = true;
            this.Estado.HeaderText = "Column1";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 150;
            // 
            // Orden
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.Orden.DefaultCellStyle = dataGridViewCellStyle16;
            this.Orden.HeaderText = "Column1";
            this.Orden.Name = "Orden";
            this.Orden.ReadOnly = true;
            this.Orden.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Orden.Width = 150;
            // 
            // lbPreparando
            // 
            this.lbPreparando.AutoSize = true;
            this.lbPreparando.Font = new System.Drawing.Font("Permanent Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreparando.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbPreparando.Location = new System.Drawing.Point(28, 11);
            this.lbPreparando.Name = "lbPreparando";
            this.lbPreparando.Size = new System.Drawing.Size(118, 27);
            this.lbPreparando.TabIndex = 6;
            this.lbPreparando.Text = "Preparando";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Permanent Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(585, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Retirar";
            // 
            // FrmTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(758, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPreparando);
            this.Controls.Add(this.dgvReady);
            this.Controls.Add(this.rtMostrar);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.dgvWait);
            this.MaximumSize = new System.Drawing.Size(774, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 550);
            this.Name = "FrmTracker";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTracker_FormClosing);
            this.Load += new System.EventHandler(this.FrmTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReady)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvWait;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.RichTextBox rtMostrar;
        private System.Windows.Forms.DataGridView dgvReady;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.Label lbPreparando;
        private System.Windows.Forms.Label label1;
    }
}

