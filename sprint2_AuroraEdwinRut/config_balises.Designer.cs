
namespace sprint2_AuroraEdwinRut
{
    partial class config_balises
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_ports = new System.Windows.Forms.Label();
            this.lbl_grups = new System.Windows.Forms.Label();
            this.lbl_divisor = new System.Windows.Forms.Label();
            this.pnl_config = new System.Windows.Forms.Panel();
            this.lbl_avisdivisor = new System.Windows.Forms.Label();
            this.lbl_aviscicles = new System.Windows.Forms.Label();
            this.txt_divisor = new System.Windows.Forms.TextBox();
            this.txt_cicles = new System.Windows.Forms.TextBox();
            this.btn_config = new System.Windows.Forms.Button();
            this.cmb_ports = new System.Windows.Forms.ComboBox();
            this.btn_connectar = new System.Windows.Forms.Button();
            this.chrt_resultats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_prova = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_dades = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intensitat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_resultats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dades)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ports
            // 
            this.lbl_ports.AutoSize = true;
            this.lbl_ports.Location = new System.Drawing.Point(48, 25);
            this.lbl_ports.Name = "lbl_ports";
            this.lbl_ports.Size = new System.Drawing.Size(86, 13);
            this.lbl_ports.TabIndex = 0;
            this.lbl_ports.Text = "Ports disponibles";
            // 
            // lbl_grups
            // 
            this.lbl_grups.AutoSize = true;
            this.lbl_grups.Location = new System.Drawing.Point(62, 22);
            this.lbl_grups.Name = "lbl_grups";
            this.lbl_grups.Size = new System.Drawing.Size(60, 13);
            this.lbl_grups.TabIndex = 1;
            this.lbl_grups.Text = "Grups cicle";
            // 
            // lbl_divisor
            // 
            this.lbl_divisor.AutoSize = true;
            this.lbl_divisor.Location = new System.Drawing.Point(71, 73);
            this.lbl_divisor.Name = "lbl_divisor";
            this.lbl_divisor.Size = new System.Drawing.Size(39, 13);
            this.lbl_divisor.TabIndex = 2;
            this.lbl_divisor.Text = "Divisor";
            // 
            // pnl_config
            // 
            this.pnl_config.Controls.Add(this.lbl_avisdivisor);
            this.pnl_config.Controls.Add(this.lbl_aviscicles);
            this.pnl_config.Controls.Add(this.txt_divisor);
            this.pnl_config.Controls.Add(this.txt_cicles);
            this.pnl_config.Controls.Add(this.btn_config);
            this.pnl_config.Controls.Add(this.lbl_grups);
            this.pnl_config.Controls.Add(this.lbl_divisor);
            this.pnl_config.Location = new System.Drawing.Point(24, 71);
            this.pnl_config.Name = "pnl_config";
            this.pnl_config.Size = new System.Drawing.Size(472, 122);
            this.pnl_config.TabIndex = 3;
            // 
            // lbl_avisdivisor
            // 
            this.lbl_avisdivisor.AutoSize = true;
            this.lbl_avisdivisor.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisdivisor.Location = new System.Drawing.Point(141, 91);
            this.lbl_avisdivisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avisdivisor.Name = "lbl_avisdivisor";
            this.lbl_avisdivisor.Size = new System.Drawing.Size(0, 13);
            this.lbl_avisdivisor.TabIndex = 10;
            // 
            // lbl_aviscicles
            // 
            this.lbl_aviscicles.AutoSize = true;
            this.lbl_aviscicles.ForeColor = System.Drawing.Color.Red;
            this.lbl_aviscicles.Location = new System.Drawing.Point(141, 43);
            this.lbl_aviscicles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_aviscicles.Name = "lbl_aviscicles";
            this.lbl_aviscicles.Size = new System.Drawing.Size(0, 13);
            this.lbl_aviscicles.TabIndex = 9;
            // 
            // txt_divisor
            // 
            this.txt_divisor.Location = new System.Drawing.Point(141, 70);
            this.txt_divisor.MaxLength = 1;
            this.txt_divisor.Name = "txt_divisor";
            this.txt_divisor.Size = new System.Drawing.Size(100, 20);
            this.txt_divisor.TabIndex = 8;
            this.txt_divisor.Validating += new System.ComponentModel.CancelEventHandler(this.txt_divisor_Validating);
            // 
            // txt_cicles
            // 
            this.txt_cicles.Location = new System.Drawing.Point(141, 19);
            this.txt_cicles.MaxLength = 2;
            this.txt_cicles.Name = "txt_cicles";
            this.txt_cicles.Size = new System.Drawing.Size(100, 20);
            this.txt_cicles.TabIndex = 7;
            this.txt_cicles.Validating += new System.ComponentModel.CancelEventHandler(this.txt_validating);
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(295, 17);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(75, 23);
            this.btn_config.TabIndex = 6;
            this.btn_config.Text = "Configurar";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // cmb_ports
            // 
            this.cmb_ports.FormattingEnabled = true;
            this.cmb_ports.Location = new System.Drawing.Point(140, 22);
            this.cmb_ports.Name = "cmb_ports";
            this.cmb_ports.Size = new System.Drawing.Size(121, 21);
            this.cmb_ports.TabIndex = 4;
            this.cmb_ports.Enter += new System.EventHandler(this.cmb_ports_Enter);
            // 
            // btn_connectar
            // 
            this.btn_connectar.Location = new System.Drawing.Point(319, 19);
            this.btn_connectar.Name = "btn_connectar";
            this.btn_connectar.Size = new System.Drawing.Size(75, 23);
            this.btn_connectar.TabIndex = 5;
            this.btn_connectar.Text = "Connectar";
            this.btn_connectar.UseVisualStyleBackColor = true;
            this.btn_connectar.Click += new System.EventHandler(this.btn_connectar_Click);
            // 
            // chrt_resultats
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_resultats.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_resultats.Legends.Add(legend1);
            this.chrt_resultats.Location = new System.Drawing.Point(24, 213);
            this.chrt_resultats.Margin = new System.Windows.Forms.Padding(2);
            this.chrt_resultats.Name = "chrt_resultats";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chrt_resultats.Series.Add(series1);
            this.chrt_resultats.Size = new System.Drawing.Size(574, 305);
            this.chrt_resultats.TabIndex = 6;
            this.chrt_resultats.Text = "chart1";
            // 
            // txt_prova
            // 
            this.txt_prova.Location = new System.Drawing.Point(634, 25);
            this.txt_prova.Multiline = true;
            this.txt_prova.Name = "txt_prova";
            this.txt_prova.Size = new System.Drawing.Size(194, 88);
            this.txt_prova.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Finito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_dades
            // 
            this.dtg_dades.AllowUserToAddRows = false;
            this.dtg_dades.AllowUserToDeleteRows = false;
            this.dtg_dades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Intensitat});
            this.dtg_dades.Location = new System.Drawing.Point(618, 213);
            this.dtg_dades.Name = "dtg_dades";
            this.dtg_dades.ReadOnly = true;
            this.dtg_dades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_dades.Size = new System.Drawing.Size(246, 305);
            this.dtg_dades.TabIndex = 13;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Intensitat
            // 
            this.Intensitat.HeaderText = "Intensitat";
            this.Intensitat.Name = "Intensitat";
            this.Intensitat.ReadOnly = true;
            // 
            // config_balises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 749);
            this.Controls.Add(this.dtg_dades);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_prova);
            this.Controls.Add(this.chrt_resultats);
            this.Controls.Add(this.btn_connectar);
            this.Controls.Add(this.cmb_ports);
            this.Controls.Add(this.pnl_config);
            this.Controls.Add(this.lbl_ports);
            this.Name = "config_balises";
            this.Text = "Configuració de balises";
            this.pnl_config.ResumeLayout(false);
            this.pnl_config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_resultats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ports;
        private System.Windows.Forms.Label lbl_grups;
        private System.Windows.Forms.Label lbl_divisor;
        private System.Windows.Forms.Panel pnl_config;
        private System.Windows.Forms.TextBox txt_divisor;
        private System.Windows.Forms.TextBox txt_cicles;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.ComboBox cmb_ports;
        private System.Windows.Forms.Button btn_connectar;
        private System.Windows.Forms.Label lbl_aviscicles;
        private System.Windows.Forms.Label lbl_avisdivisor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_resultats;
        private System.Windows.Forms.TextBox txt_prova;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_dades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intensitat;
    }
}

