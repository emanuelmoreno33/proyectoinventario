namespace Inventario
{
    partial class reportes
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
            this.cmbreporte = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbreporte
            // 
            this.cmbreporte.DisplayMember = "1";
            this.cmbreporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbreporte.FormattingEnabled = true;
            this.cmbreporte.Items.AddRange(new object[] {
            "Reporte del día",
            "Reporte del mes",
            "Reporte del año",
            "Materiales Utilizados",
            "Materiales Sobrantes"});
            this.cmbreporte.Location = new System.Drawing.Point(12, 31);
            this.cmbreporte.Name = "cmbreporte";
            this.cmbreporte.Size = new System.Drawing.Size(261, 33);
            this.cmbreporte.TabIndex = 0;
            this.cmbreporte.ValueMember = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(366, 123);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbreporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbreporte;
        private System.Windows.Forms.Button button1;
    }
}