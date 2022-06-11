namespace Diagram
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.fiveTB = new System.Windows.Forms.TextBox();
            this.fourTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.twoTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.threeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chartMy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDiagram = new System.Windows.Forms.Button();
            this.btnGisto = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество пятёрок";
            // 
            // fiveTB
            // 
            this.fiveTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveTB.Location = new System.Drawing.Point(12, 32);
            this.fiveTB.Name = "fiveTB";
            this.fiveTB.Size = new System.Drawing.Size(100, 26);
            this.fiveTB.TabIndex = 1;
            // 
            // fourTB
            // 
            this.fourTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourTB.Location = new System.Drawing.Point(12, 92);
            this.fourTB.Name = "fourTB";
            this.fourTB.Size = new System.Drawing.Size(100, 26);
            this.fourTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество четвёрок";
            // 
            // twoTB
            // 
            this.twoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoTB.Location = new System.Drawing.Point(12, 205);
            this.twoTB.Name = "twoTB";
            this.twoTB.Size = new System.Drawing.Size(100, 26);
            this.twoTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество двоек";
            // 
            // threeTB
            // 
            this.threeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeTB.Location = new System.Drawing.Point(12, 145);
            this.threeTB.Name = "threeTB";
            this.threeTB.Size = new System.Drawing.Size(100, 26);
            this.threeTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество троек";
            // 
            // chartMy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMy.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chartMy.Legends.Add(legend1);
            this.chartMy.Location = new System.Drawing.Point(202, 9);
            this.chartMy.Name = "chartMy";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMy.Series.Add(series1);
            this.chartMy.Size = new System.Drawing.Size(180, 287);
            this.chartMy.TabIndex = 8;
            this.chartMy.Text = "chart1";
            // 
            // btnDiagram
            // 
            this.btnDiagram.Location = new System.Drawing.Point(12, 273);
            this.btnDiagram.Name = "btnDiagram";
            this.btnDiagram.Size = new System.Drawing.Size(75, 23);
            this.btnDiagram.TabIndex = 9;
            this.btnDiagram.Text = "Диаграмма";
            this.btnDiagram.UseVisualStyleBackColor = true;
            this.btnDiagram.Click += new System.EventHandler(this.btnDiagram_Click);
            // 
            // btnGisto
            // 
            this.btnGisto.Location = new System.Drawing.Point(93, 273);
            this.btnGisto.Name = "btnGisto";
            this.btnGisto.Size = new System.Drawing.Size(90, 23);
            this.btnGisto.TabIndex = 10;
            this.btnGisto.Text = "Гистограмма";
            this.btnGisto.UseVisualStyleBackColor = true;
            this.btnGisto.Click += new System.EventHandler(this.btnGisto_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(202, 9);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(180, 287);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 307);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnGisto);
            this.Controls.Add(this.btnDiagram);
            this.Controls.Add(this.chartMy);
            this.Controls.Add(this.twoTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.threeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fourTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fiveTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Диаграмма";
            ((System.ComponentModel.ISupportInitialize)(this.chartMy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fiveTB;
        private System.Windows.Forms.TextBox fourTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox twoTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox threeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMy;
        private System.Windows.Forms.Button btnDiagram;
        private System.Windows.Forms.Button btnGisto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

