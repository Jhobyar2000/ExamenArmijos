namespace ExamenArmijos.view
{
    partial class panelRegistrar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Cliente";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(65, 83);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.PlaceholderText = "Ingrese Cedula";
            this.txtcedula.Size = new System.Drawing.Size(330, 27);
            this.txtcedula.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(65, 138);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PlaceholderText = "Ingrese Nombre";
            this.txtnombre.Size = new System.Drawing.Size(330, 27);
            this.txtnombre.TabIndex = 2;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(65, 196);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.PlaceholderText = "Ingrese apellido";
            this.txtapellido.Size = new System.Drawing.Size(328, 27);
            this.txtapellido.TabIndex = 3;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(65, 251);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.PlaceholderText = "Ingrese Fecha nacimiento AAAA-MM-DD";
            this.txtfecha.Size = new System.Drawing.Size(328, 27);
            this.txtfecha.TabIndex = 4;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Location = new System.Drawing.Point(510, 82);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(288, 28);
            this.cmbsexo.TabIndex = 5;
            this.cmbsexo.Text = "Escoja el sexo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(65, 318);
            this.txtid.Name = "txtid";
            this.txtid.PlaceholderText = "Ingrese ID (num)";
            this.txtid.Size = new System.Drawing.Size(328, 27);
            this.txtid.TabIndex = 8;
            // 
            // panelRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbsexo);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label1);
            this.Name = "panelRegistrar";
            this.Size = new System.Drawing.Size(1147, 489);
            this.Load += new System.EventHandler(this.panelRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtcedula;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtfecha;
        private ComboBox cmbsexo;
        private Button button1;
        private Button button2;
        private TextBox txtid;
    }
}
