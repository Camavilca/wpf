namespace Semana2
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
            this.table1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CboAnios = new System.Windows.Forms.ComboBox();
            this.table2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.neptunoDataSet = new Semana2.neptunoDataSet();
            this.neptunoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // table1
            // 
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.Location = new System.Drawing.Point(35, 83);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(925, 225);
            this.table1.TabIndex = 0;
            this.table1.DoubleClick += new System.EventHandler(this.DgPedidos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar el año del pedido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CboAnios
            // 
            this.CboAnios.FormattingEnabled = true;
            this.CboAnios.Location = new System.Drawing.Point(464, 25);
            this.CboAnios.Name = "CboAnios";
            this.CboAnios.Size = new System.Drawing.Size(121, 21);
            this.CboAnios.TabIndex = 2;
            this.CboAnios.SelectedIndexChanged += new System.EventHandler(this.CboAnios_SelectedIndexChanged);
            this.CboAnios.SelectionChangeCommitted += new System.EventHandler(this.CboAnios_SelectedChangeCommitted);
            // 
            // table2
            // 
            this.table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2.Location = new System.Drawing.Point(35, 335);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(925, 225);
            this.table2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista de Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de detalle";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nro de Pedidos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LblMonto
            // 
            this.LblMonto.Location = new System.Drawing.Point(860, 312);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(100, 20);
            this.LblMonto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto del Pedidos";
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(858, 563);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(100, 20);
            this.monto.TabIndex = 9;
            // 
            // neptunoDataSet
            // 
            this.neptunoDataSet.DataSetName = "neptunoDataSet";
            this.neptunoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // neptunoDataSetBindingSource
            // 
            this.neptunoDataSetBindingSource.DataSource = this.neptunoDataSet;
            this.neptunoDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 689);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.CboAnios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboAnios;
        private System.Windows.Forms.DataGridView table2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LblMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox monto;
        private neptunoDataSet neptunoDataSet;
        private System.Windows.Forms.BindingSource neptunoDataSetBindingSource;
    }
}

