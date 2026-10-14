namespace RetoDataTable
{
    partial class Form1
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
            DgvClientes = new DataGridView();
            TxtCantClientes = new TextBox();
            BtnProcesar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).BeginInit();
            SuspendLayout();
            // 
            // DgvClientes
            // 
            DgvClientes.AllowUserToAddRows = false;
            DgvClientes.AllowUserToDeleteRows = false;
            DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClientes.Location = new Point(22, 91);
            DgvClientes.Name = "DgvClientes";
            DgvClientes.ReadOnly = true;
            DgvClientes.RowHeadersWidth = 62;
            DgvClientes.Size = new Size(729, 347);
            DgvClientes.TabIndex = 0;
            // 
            // TxtCantClientes
            // 
            TxtCantClientes.Location = new Point(177, 33);
            TxtCantClientes.Name = "TxtCantClientes";
            TxtCantClientes.Size = new Size(213, 31);
            TxtCantClientes.TabIndex = 1;
            // 
            // BtnProcesar
            // 
            BtnProcesar.Location = new Point(572, 18);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(179, 55);
            BtnProcesar.TabIndex = 2;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 3;
            label1.Text = "Cantidad Clientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(label1);
            Controls.Add(BtnProcesar);
            Controls.Add(TxtCantClientes);
            Controls.Add(DgvClientes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvClientes;
        private TextBox TxtCantClientes;
        private Button BtnProcesar;
        private Label label1;
    }
}
