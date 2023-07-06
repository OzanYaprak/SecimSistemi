namespace SecimSistemi
{
    partial class Grafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLAriPartisi = new System.Windows.Forms.Label();
            this.LBLBüyükParti = new System.Windows.Forms.Label();
            this.LBLCabukParti = new System.Windows.Forms.Label();
            this.LBLDegisimPartisi = new System.Windows.Forms.Label();
            this.LBLEmekPartisi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1173, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 30);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1167, 491);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBLEmekPartisi);
            this.groupBox2.Controls.Add(this.LBLDegisimPartisi);
            this.groupBox2.Controls.Add(this.LBLCabukParti);
            this.groupBox2.Controls.Add(this.LBLBüyükParti);
            this.groupBox2.Controls.Add(this.LBLAriPartisi);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 560);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(722, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Bazında Değerler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçiniz:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ARI PARTİSİ:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(187, 103);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(461, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(187, 142);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(461, 23);
            this.progressBar2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "BÜYÜK PARTİ:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(187, 180);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(461, 23);
            this.progressBar3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "ÇABUK PARTİ:";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(187, 220);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(461, 23);
            this.progressBar4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "DEĞİŞİM PARTİSİ:";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(187, 258);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(461, 23);
            this.progressBar5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "EMEK PARTİSİ:";
            // 
            // LBLAriPartisi
            // 
            this.LBLAriPartisi.AutoSize = true;
            this.LBLAriPartisi.BackColor = System.Drawing.Color.Snow;
            this.LBLAriPartisi.Location = new System.Drawing.Point(654, 103);
            this.LBLAriPartisi.Name = "LBLAriPartisi";
            this.LBLAriPartisi.Size = new System.Drawing.Size(19, 21);
            this.LBLAriPartisi.TabIndex = 12;
            this.LBLAriPartisi.Text = "0";
            // 
            // LBLBüyükParti
            // 
            this.LBLBüyükParti.AutoSize = true;
            this.LBLBüyükParti.BackColor = System.Drawing.Color.Snow;
            this.LBLBüyükParti.Location = new System.Drawing.Point(654, 144);
            this.LBLBüyükParti.Name = "LBLBüyükParti";
            this.LBLBüyükParti.Size = new System.Drawing.Size(19, 21);
            this.LBLBüyükParti.TabIndex = 13;
            this.LBLBüyükParti.Text = "0";
            // 
            // LBLCabukParti
            // 
            this.LBLCabukParti.AutoSize = true;
            this.LBLCabukParti.BackColor = System.Drawing.Color.Snow;
            this.LBLCabukParti.Location = new System.Drawing.Point(654, 182);
            this.LBLCabukParti.Name = "LBLCabukParti";
            this.LBLCabukParti.Size = new System.Drawing.Size(19, 21);
            this.LBLCabukParti.TabIndex = 14;
            this.LBLCabukParti.Text = "0";
            // 
            // LBLDegisimPartisi
            // 
            this.LBLDegisimPartisi.AutoSize = true;
            this.LBLDegisimPartisi.BackColor = System.Drawing.Color.Snow;
            this.LBLDegisimPartisi.Location = new System.Drawing.Point(654, 220);
            this.LBLDegisimPartisi.Name = "LBLDegisimPartisi";
            this.LBLDegisimPartisi.Size = new System.Drawing.Size(19, 21);
            this.LBLDegisimPartisi.TabIndex = 15;
            this.LBLDegisimPartisi.Text = "0";
            // 
            // LBLEmekPartisi
            // 
            this.LBLEmekPartisi.AutoSize = true;
            this.LBLEmekPartisi.BackColor = System.Drawing.Color.Snow;
            this.LBLEmekPartisi.Location = new System.Drawing.Point(654, 258);
            this.LBLEmekPartisi.Name = "LBLEmekPartisi";
            this.LBLEmekPartisi.Size = new System.Drawing.Size(19, 21);
            this.LBLEmekPartisi.TabIndex = 16;
            this.LBLEmekPartisi.Text = "0";
            // 
            // Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1200, 883);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Grafikler";
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLEmekPartisi;
        private System.Windows.Forms.Label LBLDegisimPartisi;
        private System.Windows.Forms.Label LBLCabukParti;
        private System.Windows.Forms.Label LBLBüyükParti;
        private System.Windows.Forms.Label LBLAriPartisi;
    }
}