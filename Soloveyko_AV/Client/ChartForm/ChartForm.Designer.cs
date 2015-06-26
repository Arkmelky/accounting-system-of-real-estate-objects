namespace Client.ChartForm
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartOfProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Label_Mounth = new System.Windows.Forms.Label();
            this.Label_Profit = new System.Windows.Forms.Label();
            this.Button_GenerateChart = new System.Windows.Forms.Button();
            this.dateTimePicker_FROM = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_TO = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_House = new System.Windows.Forms.TextBox();
            this.textBox_Homestead = new System.Windows.Forms.TextBox();
            this.textBox_CommProp = new System.Windows.Forms.TextBox();
            this.textBox_Apartment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartOfProfit
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartOfProfit.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartOfProfit.Legends.Add(legend4);
            this.ChartOfProfit.Location = new System.Drawing.Point(12, 12);
            this.ChartOfProfit.Name = "ChartOfProfit";
            this.ChartOfProfit.Size = new System.Drawing.Size(593, 403);
            this.ChartOfProfit.TabIndex = 0;
            this.ChartOfProfit.Text = "ChartOfProfit";
            title4.BackColor = System.Drawing.Color.DeepSkyBlue;
            title4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            title4.BackSecondaryColor = System.Drawing.Color.SlateBlue;
            title4.BorderColor = System.Drawing.Color.Indigo;
            title4.ForeColor = System.Drawing.Color.Yellow;
            title4.Name = "Title1";
            title4.Text = "Chart of profit by objects of transactions";
            this.ChartOfProfit.Titles.Add(title4);
            // 
            // Label_Mounth
            // 
            this.Label_Mounth.AutoSize = true;
            this.Label_Mounth.BackColor = System.Drawing.SystemColors.Window;
            this.Label_Mounth.Location = new System.Drawing.Point(429, 381);
            this.Label_Mounth.Name = "Label_Mounth";
            this.Label_Mounth.Size = new System.Drawing.Size(37, 13);
            this.Label_Mounth.TabIndex = 1;
            this.Label_Mounth.Text = "Period";
            // 
            // Label_Profit
            // 
            this.Label_Profit.AutoSize = true;
            this.Label_Profit.BackColor = System.Drawing.SystemColors.Window;
            this.Label_Profit.Location = new System.Drawing.Point(12, 57);
            this.Label_Profit.Name = "Label_Profit";
            this.Label_Profit.Size = new System.Drawing.Size(31, 13);
            this.Label_Profit.TabIndex = 2;
            this.Label_Profit.Text = "Profit";
            // 
            // Button_GenerateChart
            // 
            this.Button_GenerateChart.Location = new System.Drawing.Point(621, 120);
            this.Button_GenerateChart.Name = "Button_GenerateChart";
            this.Button_GenerateChart.Size = new System.Drawing.Size(75, 23);
            this.Button_GenerateChart.TabIndex = 3;
            this.Button_GenerateChart.Text = "Generate";
            this.Button_GenerateChart.UseVisualStyleBackColor = true;
            this.Button_GenerateChart.Click += new System.EventHandler(this.Button_GenerateChart_Click);
            // 
            // dateTimePicker_FROM
            // 
            this.dateTimePicker_FROM.Location = new System.Drawing.Point(611, 28);
            this.dateTimePicker_FROM.Name = "dateTimePicker_FROM";
            this.dateTimePicker_FROM.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FROM.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // dateTimePicker_TO
            // 
            this.dateTimePicker_TO.Location = new System.Drawing.Point(611, 71);
            this.dateTimePicker_TO.Name = "dateTimePicker_TO";
            this.dateTimePicker_TO.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_TO.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "House";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Homestead";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CommProp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Apartment";
            // 
            // textBox_House
            // 
            this.textBox_House.Location = new System.Drawing.Point(675, 180);
            this.textBox_House.Name = "textBox_House";
            this.textBox_House.Size = new System.Drawing.Size(100, 20);
            this.textBox_House.TabIndex = 13;
            // 
            // textBox_Homestead
            // 
            this.textBox_Homestead.Location = new System.Drawing.Point(675, 206);
            this.textBox_Homestead.Name = "textBox_Homestead";
            this.textBox_Homestead.Size = new System.Drawing.Size(100, 20);
            this.textBox_Homestead.TabIndex = 14;
            // 
            // textBox_CommProp
            // 
            this.textBox_CommProp.Location = new System.Drawing.Point(675, 232);
            this.textBox_CommProp.Name = "textBox_CommProp";
            this.textBox_CommProp.Size = new System.Drawing.Size(100, 20);
            this.textBox_CommProp.TabIndex = 15;
            // 
            // textBox_Apartment
            // 
            this.textBox_Apartment.Location = new System.Drawing.Point(675, 258);
            this.textBox_Apartment.Name = "textBox_Apartment";
            this.textBox_Apartment.Size = new System.Drawing.Size(100, 20);
            this.textBox_Apartment.TabIndex = 16;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(817, 427);
            this.Controls.Add(this.textBox_Apartment);
            this.Controls.Add(this.textBox_CommProp);
            this.Controls.Add(this.textBox_Homestead);
            this.Controls.Add(this.textBox_House);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_TO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_FROM);
            this.Controls.Add(this.Button_GenerateChart);
            this.Controls.Add(this.Label_Profit);
            this.Controls.Add(this.Label_Mounth);
            this.Controls.Add(this.ChartOfProfit);
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartOfProfit;
        private System.Windows.Forms.Label Label_Mounth;
        private System.Windows.Forms.Label Label_Profit;
        private System.Windows.Forms.Button Button_GenerateChart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FROM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_House;
        private System.Windows.Forms.TextBox textBox_Homestead;
        private System.Windows.Forms.TextBox textBox_CommProp;
        private System.Windows.Forms.TextBox textBox_Apartment;


    }
}