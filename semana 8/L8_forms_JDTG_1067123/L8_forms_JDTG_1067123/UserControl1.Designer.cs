namespace L8_forms_JDTG_1067123
{
    partial class Form
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Laboratorio8 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.ListBox();
            this.CMB1 = new System.Windows.Forms.ComboBox();
            this.BTN = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TXT_resul_sum = new System.Windows.Forms.TextBox();
            this.Info_sumatoria = new System.Windows.Forms.Label();
            this.BTN_suma = new System.Windows.Forms.Button();
            this.LBLResultadoTotal = new System.Windows.Forms.Label();
            this.TXT_suma = new System.Windows.Forms.TextBox();
            this.LBL_resul_suma = new System.Windows.Forms.Label();
            this.LBL1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TXT_resul_tabla = new System.Windows.Forms.TextBox();
            this.BTN_tabla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_tabla = new System.Windows.Forms.TextBox();
            this.LBL_resul_tabla = new System.Windows.Forms.Label();
            this.LBL_tabla = new System.Windows.Forms.Label();
            this.Info_tabla = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TXT_resul_nper = new System.Windows.Forms.TextBox();
            this.Info_nper = new System.Windows.Forms.Label();
            this.BTN_nper = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_nper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_seleccion_programa = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Laboratorio8
            // 
            this.Laboratorio8.AutoSize = true;
            this.Laboratorio8.Location = new System.Drawing.Point(362, 38);
            this.Laboratorio8.Name = "Laboratorio8";
            this.Laboratorio8.Size = new System.Drawing.Size(86, 16);
            this.Laboratorio8.TabIndex = 0;
            this.Laboratorio8.Text = "Laboratorio 8";
            this.Laboratorio8.Click += new System.EventHandler(this.label1_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.FormattingEnabled = true;
            this.Seleccionar.ItemHeight = 16;
            this.Seleccionar.Location = new System.Drawing.Point(57, 103);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(295, 196);
            this.Seleccionar.TabIndex = 1;
            this.Seleccionar.SelectedIndexChanged += new System.EventHandler(this.Seleccionar_SelectedIndexChanged);
            // 
            // CMB1
            // 
            this.CMB1.FormattingEnabled = true;
            this.CMB1.Items.AddRange(new object[] {
            "SUMATORIA",
            "TABLAS",
            "NÚMERO PERFECTO"});
            this.CMB1.Location = new System.Drawing.Point(57, 176);
            this.CMB1.Name = "CMB1";
            this.CMB1.Size = new System.Drawing.Size(295, 24);
            this.CMB1.TabIndex = 3;
            this.CMB1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(75, 316);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(234, 47);
            this.BTN.TabIndex = 4;
            this.BTN.Text = "Seleccionar";
            this.BTN.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(468, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 375);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TXT_resul_sum);
            this.tabPage1.Controls.Add(this.Info_sumatoria);
            this.tabPage1.Controls.Add(this.BTN_suma);
            this.tabPage1.Controls.Add(this.LBLResultadoTotal);
            this.tabPage1.Controls.Add(this.TXT_suma);
            this.tabPage1.Controls.Add(this.LBL_resul_suma);
            this.tabPage1.Controls.Add(this.LBL1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sumatoria";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TXT_resul_sum
            // 
            this.TXT_resul_sum.Location = new System.Drawing.Point(27, 168);
            this.TXT_resul_sum.Multiline = true;
            this.TXT_resul_sum.Name = "TXT_resul_sum";
            this.TXT_resul_sum.ReadOnly = true;
            this.TXT_resul_sum.Size = new System.Drawing.Size(257, 36);
            this.TXT_resul_sum.TabIndex = 13;
            // 
            // Info_sumatoria
            // 
            this.Info_sumatoria.AutoSize = true;
            this.Info_sumatoria.Location = new System.Drawing.Point(32, 17);
            this.Info_sumatoria.Name = "Info_sumatoria";
            this.Info_sumatoria.Size = new System.Drawing.Size(0, 16);
            this.Info_sumatoria.TabIndex = 5;
            // 
            // BTN_suma
            // 
            this.BTN_suma.Location = new System.Drawing.Point(197, 97);
            this.BTN_suma.Name = "BTN_suma";
            this.BTN_suma.Size = new System.Drawing.Size(75, 23);
            this.BTN_suma.TabIndex = 4;
            this.BTN_suma.Text = "Ingresar";
            this.BTN_suma.UseVisualStyleBackColor = true;
            this.BTN_suma.Click += new System.EventHandler(this.BTN_suma_Click);
            // 
            // LBLResultadoTotal
            // 
            this.LBLResultadoTotal.AutoSize = true;
            this.LBLResultadoTotal.Location = new System.Drawing.Point(194, 97);
            this.LBLResultadoTotal.Name = "LBLResultadoTotal";
            this.LBLResultadoTotal.Size = new System.Drawing.Size(0, 16);
            this.LBLResultadoTotal.TabIndex = 3;
            // 
            // TXT_suma
            // 
            this.TXT_suma.Location = new System.Drawing.Point(184, 69);
            this.TXT_suma.Name = "TXT_suma";
            this.TXT_suma.Size = new System.Drawing.Size(100, 22);
            this.TXT_suma.TabIndex = 2;
            this.TXT_suma.TextChanged += new System.EventHandler(this.TXT_TextChanged);
            // 
            // LBL_resul_suma
            // 
            this.LBL_resul_suma.AutoSize = true;
            this.LBL_resul_suma.Location = new System.Drawing.Point(29, 145);
            this.LBL_resul_suma.Name = "LBL_resul_suma";
            this.LBL_resul_suma.Size = new System.Drawing.Size(69, 16);
            this.LBL_resul_suma.TabIndex = 1;
            this.LBL_resul_suma.Text = "Resultado";
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(29, 71);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(117, 16);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Ingrese un número";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TXT_resul_tabla);
            this.tabPage2.Controls.Add(this.BTN_tabla);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.TXT_tabla);
            this.tabPage2.Controls.Add(this.LBL_resul_tabla);
            this.tabPage2.Controls.Add(this.LBL_tabla);
            this.tabPage2.Controls.Add(this.Info_tabla);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(314, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabla";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // TXT_resul_tabla
            // 
            this.TXT_resul_tabla.Location = new System.Drawing.Point(32, 120);
            this.TXT_resul_tabla.Multiline = true;
            this.TXT_resul_tabla.Name = "TXT_resul_tabla";
            this.TXT_resul_tabla.ReadOnly = true;
            this.TXT_resul_tabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_resul_tabla.Size = new System.Drawing.Size(100, 220);
            this.TXT_resul_tabla.TabIndex = 12;
            this.TXT_resul_tabla.TextChanged += new System.EventHandler(this.TXT_resul_tabla_TextChanged);
            // 
            // BTN_tabla
            // 
            this.BTN_tabla.Location = new System.Drawing.Point(197, 89);
            this.BTN_tabla.Name = "BTN_tabla";
            this.BTN_tabla.Size = new System.Drawing.Size(75, 23);
            this.BTN_tabla.TabIndex = 11;
            this.BTN_tabla.Text = "Ingresar";
            this.BTN_tabla.UseVisualStyleBackColor = true;
            this.BTN_tabla.Click += new System.EventHandler(this.BTN_tabla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // TXT_tabla
            // 
            this.TXT_tabla.Location = new System.Drawing.Point(184, 61);
            this.TXT_tabla.Name = "TXT_tabla";
            this.TXT_tabla.Size = new System.Drawing.Size(100, 22);
            this.TXT_tabla.TabIndex = 9;
            // 
            // LBL_resul_tabla
            // 
            this.LBL_resul_tabla.AutoSize = true;
            this.LBL_resul_tabla.Location = new System.Drawing.Point(29, 101);
            this.LBL_resul_tabla.Name = "LBL_resul_tabla";
            this.LBL_resul_tabla.Size = new System.Drawing.Size(69, 16);
            this.LBL_resul_tabla.TabIndex = 8;
            this.LBL_resul_tabla.Text = "Resultado";
            // 
            // LBL_tabla
            // 
            this.LBL_tabla.AutoSize = true;
            this.LBL_tabla.Location = new System.Drawing.Point(29, 63);
            this.LBL_tabla.Name = "LBL_tabla";
            this.LBL_tabla.Size = new System.Drawing.Size(117, 16);
            this.LBL_tabla.TabIndex = 7;
            this.LBL_tabla.Text = "Ingrese un número";
            // 
            // Info_tabla
            // 
            this.Info_tabla.AutoSize = true;
            this.Info_tabla.Location = new System.Drawing.Point(18, 19);
            this.Info_tabla.Name = "Info_tabla";
            this.Info_tabla.Size = new System.Drawing.Size(0, 16);
            this.Info_tabla.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TXT_resul_nper);
            this.tabPage3.Controls.Add(this.Info_nper);
            this.tabPage3.Controls.Add(this.BTN_nper);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.TXT_nper);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(314, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Número perfecto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TXT_resul_nper
            // 
            this.TXT_resul_nper.Location = new System.Drawing.Point(35, 174);
            this.TXT_resul_nper.Multiline = true;
            this.TXT_resul_nper.Name = "TXT_resul_nper";
            this.TXT_resul_nper.ReadOnly = true;
            this.TXT_resul_nper.Size = new System.Drawing.Size(240, 42);
            this.TXT_resul_nper.TabIndex = 13;
            // 
            // Info_nper
            // 
            this.Info_nper.AutoSize = true;
            this.Info_nper.Location = new System.Drawing.Point(21, 19);
            this.Info_nper.Name = "Info_nper";
            this.Info_nper.Size = new System.Drawing.Size(0, 16);
            this.Info_nper.TabIndex = 10;
            // 
            // BTN_nper
            // 
            this.BTN_nper.Location = new System.Drawing.Point(200, 114);
            this.BTN_nper.Name = "BTN_nper";
            this.BTN_nper.Size = new System.Drawing.Size(75, 23);
            this.BTN_nper.TabIndex = 9;
            this.BTN_nper.Text = "Ingresar";
            this.BTN_nper.UseVisualStyleBackColor = true;
            this.BTN_nper.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 8;
            // 
            // TXT_nper
            // 
            this.TXT_nper.Location = new System.Drawing.Point(187, 86);
            this.TXT_nper.Name = "TXT_nper";
            this.TXT_nper.Size = new System.Drawing.Size(100, 22);
            this.TXT_nper.TabIndex = 7;
            this.TXT_nper.TextChanged += new System.EventHandler(this.TXT_nper_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese un número";
            // 
            // LBL_seleccion_programa
            // 
            this.LBL_seleccion_programa.AutoSize = true;
            this.LBL_seleccion_programa.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_seleccion_programa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_seleccion_programa.Location = new System.Drawing.Point(72, 137);
            this.LBL_seleccion_programa.Name = "LBL_seleccion_programa";
            this.LBL_seleccion_programa.Size = new System.Drawing.Size(236, 18);
            this.LBL_seleccion_programa.TabIndex = 6;
            this.LBL_seleccion_programa.Text = "Seleccione el programa que desee";
            this.LBL_seleccion_programa.Click += new System.EventHandler(this.LBL_seleccion_programa_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_seleccion_programa);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.CMB1);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.Laboratorio8);
            this.Name = "Form";
            this.Size = new System.Drawing.Size(832, 463);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Laboratorio8;
        private System.Windows.Forms.ListBox Seleccionar;
        private System.Windows.Forms.ComboBox CMB1;
        private System.Windows.Forms.Button BTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LBLResultadoTotal;
        private System.Windows.Forms.TextBox TXT_suma;
        private System.Windows.Forms.Label LBL_resul_suma;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BTN_suma;
        private System.Windows.Forms.Label Info_sumatoria;
        private System.Windows.Forms.Button BTN_tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_tabla;
        private System.Windows.Forms.Label LBL_resul_tabla;
        private System.Windows.Forms.Label LBL_tabla;
        private System.Windows.Forms.Label Info_tabla;
        private System.Windows.Forms.TextBox TXT_resul_tabla;
        private System.Windows.Forms.Label Info_nper;
        private System.Windows.Forms.Button BTN_nper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_nper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_resul_nper;
        private System.Windows.Forms.TextBox TXT_resul_sum;
        private System.Windows.Forms.Label LBL_seleccion_programa;
    }
}
