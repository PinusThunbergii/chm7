namespace chm7
{
    partial class MainForm
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
            this.x0Lable = new System.Windows.Forms.Label();
            this.x0TextBox = new System.Windows.Forms.TextBox();
            this.y0TextBox = new System.Windows.Forms.TextBox();
            this.y0Label = new System.Windows.Forms.Label();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.hLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.Column_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // x0Lable
            // 
            this.x0Lable.AutoSize = true;
            this.x0Lable.Location = new System.Drawing.Point(24, 43);
            this.x0Lable.Name = "x0Lable";
            this.x0Lable.Size = new System.Drawing.Size(18, 13);
            this.x0Lable.TabIndex = 0;
            this.x0Lable.Text = "x0";
            // 
            // x0TextBox
            // 
            this.x0TextBox.Location = new System.Drawing.Point(57, 40);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(100, 20);
            this.x0TextBox.TabIndex = 1;
            this.x0TextBox.Text = "0";
            // 
            // y0TextBox
            // 
            this.y0TextBox.Location = new System.Drawing.Point(57, 66);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(100, 20);
            this.y0TextBox.TabIndex = 3;
            this.y0TextBox.Text = "0";
            // 
            // y0Label
            // 
            this.y0Label.AutoSize = true;
            this.y0Label.Location = new System.Drawing.Point(24, 69);
            this.y0Label.Name = "y0Label";
            this.y0Label.Size = new System.Drawing.Size(18, 13);
            this.y0Label.TabIndex = 2;
            this.y0Label.Text = "y0";
            // 
            // hTextBox
            // 
            this.hTextBox.Location = new System.Drawing.Point(57, 144);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.ReadOnly = true;
            this.hTextBox.Size = new System.Drawing.Size(100, 20);
            this.hTextBox.TabIndex = 5;
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(24, 147);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(13, 13);
            this.hLabel.TabIndex = 4;
            this.hLabel.Text = "h";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(57, 170);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 20);
            this.nTextBox.TabIndex = 7;
            this.nTextBox.Text = "70";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(24, 173);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(13, 13);
            this.nLabel.TabIndex = 6;
            this.nLabel.Text = "n";
            // 
            // CalculateButton
            // 
            this.CalculateButton.ForeColor = System.Drawing.Color.Green;
            this.CalculateButton.Location = new System.Drawing.Point(27, 217);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_OnClick);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_i,
            this.Column_xi,
            this.Column_yi});
            this.dataGridView.Location = new System.Drawing.Point(191, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(559, 381);
            this.dataGridView.TabIndex = 9;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(816, 40);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "runge-kutta";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(512, 381);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart1";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(57, 92);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 12;
            this.aTextBox.Text = "0";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(24, 95);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 11;
            this.aLabel.Text = "a";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(57, 118);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 14;
            this.bTextBox.Text = "3,5";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(24, 121);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(13, 13);
            this.bLabel.TabIndex = 13;
            this.bLabel.Text = "b";
            // 
            // Column_i
            // 
            this.Column_i.Frozen = true;
            this.Column_i.HeaderText = "i";
            this.Column_i.Name = "Column_i";
            this.Column_i.ReadOnly = true;
            // 
            // Column_xi
            // 
            this.Column_xi.Frozen = true;
            this.Column_xi.HeaderText = "xi";
            this.Column_xi.Name = "Column_xi";
            this.Column_xi.ReadOnly = true;
            // 
            // Column_yi
            // 
            this.Column_yi.Frozen = true;
            this.Column_yi.HeaderText = "yi_runge";
            this.Column_yi.Name = "Column_yi";
            this.Column_yi.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 463);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.y0TextBox);
            this.Controls.Add(this.y0Label);
            this.Controls.Add(this.x0TextBox);
            this.Controls.Add(this.x0Lable);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x0Lable;
        private System.Windows.Forms.TextBox x0TextBox;
        private System.Windows.Forms.Label y0Label;
        private System.Windows.Forms.TextBox y0TextBox;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_yi;
    }
}

