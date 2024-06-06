namespace Weather_Application
{
    partial class WeatherApp
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
            this.lab_City = new System.Windows.Forms.Label();
            this.tB_City = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lab_Condition = new System.Windows.Forms.Label();
            this.lab_Details = new System.Windows.Forms.Label();
            this.la_Sunrise = new System.Windows.Forms.Label();
            this.lab_Sunrise = new System.Windows.Forms.Label();
            this.lab_Sunset = new System.Windows.Forms.Label();
            this._Sunset = new System.Windows.Forms.Label();
            this.lab_Pressure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_WindSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.roundedDataGridView1 = new Weather_Application.RoundedDataGridView();
            this.roundedDataGridView2 = new Weather_Application.RoundedDataGridView();
            this.roundedDataGridView3 = new Weather_Application.RoundedDataGridView();
            this.lab_temp = new System.Windows.Forms.Label();
            this.lb_tempZero = new System.Windows.Forms.Label();
            this.lb_tempC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_City
            // 
            this.lab_City.AutoSize = true;
            this.lab_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_City.ForeColor = System.Drawing.Color.Black;
            this.lab_City.Location = new System.Drawing.Point(113, 63);
            this.lab_City.Name = "lab_City";
            this.lab_City.Size = new System.Drawing.Size(66, 20);
            this.lab_City.TabIndex = 0;
            this.lab_City.Text = "Город:";
            // 
            // tB_City
            // 
            this.tB_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_City.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tB_City.Location = new System.Drawing.Point(178, 61);
            this.tB_City.Name = "tB_City";
            this.tB_City.Size = new System.Drawing.Size(301, 26);
            this.tB_City.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(519, 57);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(94, 32);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Поиск";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lab_Condition
            // 
            this.lab_Condition.AutoSize = true;
            this.lab_Condition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Condition.ForeColor = System.Drawing.Color.Black;
            this.lab_Condition.Location = new System.Drawing.Point(88, 225);
            this.lab_Condition.Name = "lab_Condition";
            this.lab_Condition.Size = new System.Drawing.Size(100, 20);
            this.lab_Condition.TabIndex = 3;
            this.lab_Condition.Text = "Состояние";
            // 
            // lab_Details
            // 
            this.lab_Details.AutoSize = true;
            this.lab_Details.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Details.ForeColor = System.Drawing.Color.Black;
            this.lab_Details.Location = new System.Drawing.Point(90, 261);
            this.lab_Details.Name = "lab_Details";
            this.lab_Details.Size = new System.Drawing.Size(72, 20);
            this.lab_Details.TabIndex = 4;
            this.lab_Details.Text = "Детали";
            // 
            // la_Sunrise
            // 
            this.la_Sunrise.AutoSize = true;
            this.la_Sunrise.BackColor = System.Drawing.Color.WhiteSmoke;
            this.la_Sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Sunrise.ForeColor = System.Drawing.Color.Black;
            this.la_Sunrise.Location = new System.Drawing.Point(517, 225);
            this.la_Sunrise.Name = "la_Sunrise";
            this.la_Sunrise.Size = new System.Drawing.Size(70, 20);
            this.la_Sunrise.TabIndex = 5;
            this.la_Sunrise.Text = "Восход";
            // 
            // lab_Sunrise
            // 
            this.lab_Sunrise.AutoSize = true;
            this.lab_Sunrise.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_Sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sunrise.ForeColor = System.Drawing.Color.Black;
            this.lab_Sunrise.Location = new System.Drawing.Point(602, 225);
            this.lab_Sunrise.Name = "lab_Sunrise";
            this.lab_Sunrise.Size = new System.Drawing.Size(37, 20);
            this.lab_Sunrise.TabIndex = 6;
            this.lab_Sunrise.Text = "N/A";
            // 
            // lab_Sunset
            // 
            this.lab_Sunset.AutoSize = true;
            this.lab_Sunset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_Sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sunset.ForeColor = System.Drawing.Color.Black;
            this.lab_Sunset.Location = new System.Drawing.Point(602, 262);
            this.lab_Sunset.Name = "lab_Sunset";
            this.lab_Sunset.Size = new System.Drawing.Size(37, 20);
            this.lab_Sunset.TabIndex = 8;
            this.lab_Sunset.Text = "N/A";
            // 
            // _Sunset
            // 
            this._Sunset.AutoSize = true;
            this._Sunset.BackColor = System.Drawing.Color.WhiteSmoke;
            this._Sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Sunset.ForeColor = System.Drawing.Color.Black;
            this._Sunset.Location = new System.Drawing.Point(520, 262);
            this._Sunset.Name = "_Sunset";
            this._Sunset.Size = new System.Drawing.Size(60, 20);
            this._Sunset.TabIndex = 7;
            this._Sunset.Text = "Закат";
            // 
            // lab_Pressure
            // 
            this.lab_Pressure.AutoSize = true;
            this.lab_Pressure.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Pressure.ForeColor = System.Drawing.Color.Black;
            this.lab_Pressure.Location = new System.Drawing.Point(404, 261);
            this.lab_Pressure.Name = "lab_Pressure";
            this.lab_Pressure.Size = new System.Drawing.Size(37, 20);
            this.lab_Pressure.TabIndex = 12;
            this.lab_Pressure.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(282, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Давление";
            // 
            // lab_WindSpeed
            // 
            this.lab_WindSpeed.AutoSize = true;
            this.lab_WindSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_WindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_WindSpeed.ForeColor = System.Drawing.Color.Black;
            this.lab_WindSpeed.Location = new System.Drawing.Point(404, 225);
            this.lab_WindSpeed.Name = "lab_WindSpeed";
            this.lab_WindSpeed.Size = new System.Drawing.Size(37, 20);
            this.lab_WindSpeed.TabIndex = 10;
            this.lab_WindSpeed.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(282, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ветер";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(261, 112);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(123, 69);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 15;
            this.picIcon.TabStop = false;
            // 
            // roundedDataGridView1
            // 
            this.roundedDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roundedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundedDataGridView1.Location = new System.Drawing.Point(37, 206);
            this.roundedDataGridView1.Name = "roundedDataGridView1";
            this.roundedDataGridView1.Size = new System.Drawing.Size(199, 89);
            this.roundedDataGridView1.TabIndex = 16;
            // 
            // roundedDataGridView2
            // 
            this.roundedDataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundedDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roundedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundedDataGridView2.Location = new System.Drawing.Point(260, 206);
            this.roundedDataGridView2.Name = "roundedDataGridView2";
            this.roundedDataGridView2.Size = new System.Drawing.Size(199, 89);
            this.roundedDataGridView2.TabIndex = 19;
            // 
            // roundedDataGridView3
            // 
            this.roundedDataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundedDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roundedDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundedDataGridView3.Location = new System.Drawing.Point(480, 206);
            this.roundedDataGridView3.Name = "roundedDataGridView3";
            this.roundedDataGridView3.Size = new System.Drawing.Size(199, 89);
            this.roundedDataGridView3.TabIndex = 20;
            // 
            // lab_temp
            // 
            this.lab_temp.AutoSize = true;
            this.lab_temp.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_temp.ForeColor = System.Drawing.Color.Black;
            this.lab_temp.Location = new System.Drawing.Point(359, 132);
            this.lab_temp.Name = "lab_temp";
            this.lab_temp.Size = new System.Drawing.Size(81, 29);
            this.lab_temp.TabIndex = 21;
            this.lab_temp.Text = "Temp";
            // 
            // lb_tempZero
            // 
            this.lb_tempZero.AutoSize = true;
            this.lb_tempZero.BackColor = System.Drawing.Color.Transparent;
            this.lb_tempZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempZero.ForeColor = System.Drawing.Color.Black;
            this.lb_tempZero.Location = new System.Drawing.Point(411, 122);
            this.lb_tempZero.Name = "lb_tempZero";
            this.lb_tempZero.Size = new System.Drawing.Size(16, 16);
            this.lb_tempZero.TabIndex = 22;
            this.lb_tempZero.Text = "o";
            // 
            // lb_tempC
            // 
            this.lb_tempC.AutoSize = true;
            this.lb_tempC.BackColor = System.Drawing.Color.Transparent;
            this.lb_tempC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempC.ForeColor = System.Drawing.Color.Black;
            this.lb_tempC.Location = new System.Drawing.Point(419, 136);
            this.lb_tempC.Name = "lb_tempC";
            this.lb_tempC.Size = new System.Drawing.Size(21, 20);
            this.lb_tempC.TabIndex = 23;
            this.lb_tempC.Text = "C";
            // 
            // WeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(716, 383);
            this.Controls.Add(this.lb_tempZero);
            this.Controls.Add(this.lb_tempC);
            this.Controls.Add(this.lab_Pressure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_WindSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_Sunset);
            this.Controls.Add(this._Sunset);
            this.Controls.Add(this.lab_Sunrise);
            this.Controls.Add(this.la_Sunrise);
            this.Controls.Add(this.lab_Details);
            this.Controls.Add(this.lab_Condition);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tB_City);
            this.Controls.Add(this.lab_City);
            this.Controls.Add(this.roundedDataGridView1);
            this.Controls.Add(this.roundedDataGridView2);
            this.Controls.Add(this.roundedDataGridView3);
            this.Controls.Add(this.lab_temp);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WeatherApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_City;
        private System.Windows.Forms.TextBox tB_City;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lab_Condition;
        private System.Windows.Forms.Label lab_Details;
        private System.Windows.Forms.Label la_Sunrise;
        private System.Windows.Forms.Label lab_Sunrise;
        private System.Windows.Forms.Label lab_Sunset;
        private System.Windows.Forms.Label _Sunset;
        private System.Windows.Forms.Label lab_Pressure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_WindSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picIcon;
        private RoundedDataGridView roundedDataGridView1;
        private RoundedDataGridView roundedDataGridView2;
        private RoundedDataGridView roundedDataGridView3;
        private System.Windows.Forms.Label lab_temp;
        private System.Windows.Forms.Label lb_tempZero;
        private System.Windows.Forms.Label lb_tempC;
    }
}

