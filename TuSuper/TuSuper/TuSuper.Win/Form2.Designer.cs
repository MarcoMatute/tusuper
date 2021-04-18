namespace TuSuper.Win
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.listadeVentasPorProdcutoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listadeVentasPorProdcutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProdcutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProdcutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listadeVentasPorProdcutoDataGridView
            // 
            this.listadeVentasPorProdcutoDataGridView.AutoGenerateColumns = false;
            this.listadeVentasPorProdcutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeVentasPorProdcutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.listadeVentasPorProdcutoDataGridView.DataSource = this.listadeVentasPorProdcutoBindingSource;
            this.listadeVentasPorProdcutoDataGridView.Location = new System.Drawing.Point(98, 128);
            this.listadeVentasPorProdcutoDataGridView.Name = "listadeVentasPorProdcutoDataGridView";
            this.listadeVentasPorProdcutoDataGridView.Size = new System.Drawing.Size(371, 181);
            this.listadeVentasPorProdcutoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // listadeVentasPorProdcutoBindingSource
            // 
            this.listadeVentasPorProdcutoBindingSource.DataSource = typeof(TuSuper.BL.ReporteVentasporProducto);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listadeVentasPorProdcutoDataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProdcutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProdcutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeVentasPorProdcutoBindingSource;
        private System.Windows.Forms.DataGridView listadeVentasPorProdcutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}