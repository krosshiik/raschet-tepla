namespace raschet_tepla
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
            this.Teploemk = new System.Windows.Forms.TextBox();
            this.massa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tnach = new System.Windows.Forms.TextBox();
            this.tokr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stela = new System.Windows.Forms.TextBox();
            this.summkoef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tTay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.choice_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tolshina = new System.Windows.Forms.TextBox();
            this.kefftepl = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.tiskom = new System.Windows.Forms.TextBox();
            this.Go_Btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.time_result = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.temp_result = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Tip_comboBox = new System.Windows.Forms.ComboBox();
            this.Bi_Btn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.progrev_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Teploemk
            // 
            this.Teploemk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teploemk.Location = new System.Drawing.Point(25, 147);
            this.Teploemk.Name = "Teploemk";
            this.Teploemk.Size = new System.Drawing.Size(243, 30);
            this.Teploemk.TabIndex = 0;
            // 
            // massa
            // 
            this.massa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massa.Location = new System.Drawing.Point(25, 214);
            this.massa.Name = "massa";
            this.massa.Size = new System.Drawing.Size(243, 30);
            this.massa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Теплоемкость С, Дж/(кг∙К)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Масса тела, кг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Начальная температура тела, tнач, °C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Температура окружающей среды, t₀, °C";
            // 
            // tnach
            // 
            this.tnach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tnach.Location = new System.Drawing.Point(25, 355);
            this.tnach.Name = "tnach";
            this.tnach.Size = new System.Drawing.Size(243, 30);
            this.tnach.TabIndex = 5;
            // 
            // tokr
            // 
            this.tokr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tokr.Location = new System.Drawing.Point(25, 289);
            this.tokr.Name = "tokr";
            this.tokr.Size = new System.Drawing.Size(243, 30);
            this.tokr.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Площадь поверхности, F, м²";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(536, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Суммарный коэффициент ";
            // 
            // stela
            // 
            this.stela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stela.Location = new System.Drawing.Point(25, 433);
            this.stela.Name = "stela";
            this.stela.Size = new System.Drawing.Size(243, 30);
            this.stela.TabIndex = 9;
            // 
            // summkoef
            // 
            this.summkoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summkoef.Location = new System.Drawing.Point(541, 214);
            this.summkoef.Name = "summkoef";
            this.summkoef.Size = new System.Drawing.Size(168, 30);
            this.summkoef.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Время, τ, сек";
            // 
            // tTay
            // 
            this.tTay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tTay.Location = new System.Drawing.Point(25, 503);
            this.tTay.Name = "tTay";
            this.tTay.Size = new System.Drawing.Size(243, 30);
            this.tTay.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Введите ваши данные:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(20, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Выберите вариант расчета:";
            // 
            // choice_comboBox
            // 
            this.choice_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choice_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choice_comboBox.FormattingEnabled = true;
            this.choice_comboBox.Location = new System.Drawing.Point(25, 35);
            this.choice_comboBox.Name = "choice_comboBox";
            this.choice_comboBox.Size = new System.Drawing.Size(277, 33);
            this.choice_comboBox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(536, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Расчет числа Bi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(536, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "теплоотдачи, αΣ, Вт/(м²∙К)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(536, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Толщина тела, S, м";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(536, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(363, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "k теплопроводности тела, λ, Вт/(м∙К)";
            // 
            // tolshina
            // 
            this.tolshina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tolshina.Location = new System.Drawing.Point(541, 127);
            this.tolshina.Name = "tolshina";
            this.tolshina.Size = new System.Drawing.Size(168, 30);
            this.tolshina.TabIndex = 21;
            // 
            // kefftepl
            // 
            this.kefftepl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kefftepl.Location = new System.Drawing.Point(541, 65);
            this.kefftepl.Name = "kefftepl";
            this.kefftepl.Size = new System.Drawing.Size(168, 30);
            this.kefftepl.TabIndex = 22;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(337, 250);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(556, 373);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(20, 547);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(321, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "Температура тела искомое, t, °C";
            // 
            // tiskom
            // 
            this.tiskom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tiskom.Location = new System.Drawing.Point(25, 575);
            this.tiskom.Name = "tiskom";
            this.tiskom.Size = new System.Drawing.Size(243, 30);
            this.tiskom.TabIndex = 24;
            // 
            // Go_Btn
            // 
            this.Go_Btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Go_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Go_Btn.Location = new System.Drawing.Point(924, 272);
            this.Go_Btn.Name = "Go_Btn";
            this.Go_Btn.Size = new System.Drawing.Size(221, 136);
            this.Go_Btn.TabIndex = 26;
            this.Go_Btn.Text = "Расчет";
            this.Go_Btn.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(905, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 29);
            this.label15.TabIndex = 27;
            this.label15.Text = "Результат расчёта:";
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.BackColor = System.Drawing.Color.LightCoral;
            this.Reset_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset_Btn.Location = new System.Drawing.Point(924, 433);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(221, 135);
            this.Reset_Btn.TabIndex = 28;
            this.Reset_Btn.Text = "Сброс";
            this.Reset_Btn.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(902, 44);
            this.label16.MaximumSize = new System.Drawing.Size(280, 1000);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(243, 75);
            this.label16.TabIndex = 29;
            this.label16.Text = "Время, за которое тело дойдет до заданной температуры:";
            // 
            // time_result
            // 
            this.time_result.Enabled = false;
            this.time_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_result.Location = new System.Drawing.Point(907, 96);
            this.time_result.Name = "time_result";
            this.time_result.ReadOnly = true;
            this.time_result.Size = new System.Drawing.Size(244, 38);
            this.time_result.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(905, 150);
            this.label17.MaximumSize = new System.Drawing.Size(300, 1000);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(252, 50);
            this.label17.TabIndex = 31;
            this.label17.Text = "Температура тела через заданное время:";
            // 
            // temp_result
            // 
            this.temp_result.Enabled = false;
            this.temp_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temp_result.Location = new System.Drawing.Point(907, 198);
            this.temp_result.Name = "temp_result";
            this.temp_result.ReadOnly = true;
            this.temp_result.Size = new System.Drawing.Size(244, 38);
            this.temp_result.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(332, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 25);
            this.label18.TabIndex = 33;
            this.label18.Text = "Тип тела:";
            // 
            // Tip_comboBox
            // 
            this.Tip_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tip_comboBox.FormattingEnabled = true;
            this.Tip_comboBox.Location = new System.Drawing.Point(337, 35);
            this.Tip_comboBox.Name = "Tip_comboBox";
            this.Tip_comboBox.Size = new System.Drawing.Size(164, 33);
            this.Tip_comboBox.TabIndex = 34;
            // 
            // Bi_Btn
            // 
            this.Bi_Btn.BackColor = System.Drawing.Color.PowderBlue;
            this.Bi_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bi_Btn.Location = new System.Drawing.Point(337, 147);
            this.Bi_Btn.Name = "Bi_Btn";
            this.Bi_Btn.Size = new System.Drawing.Size(164, 89);
            this.Bi_Btn.TabIndex = 35;
            this.Bi_Btn.Text = "Расчет Bi";
            this.Bi_Btn.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(332, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 25);
            this.label19.TabIndex = 36;
            this.label19.Text = "Прогрев:";
            // 
            // progrev_comboBox
            // 
            this.progrev_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.progrev_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progrev_comboBox.FormattingEnabled = true;
            this.progrev_comboBox.Location = new System.Drawing.Point(337, 101);
            this.progrev_comboBox.Name = "progrev_comboBox";
            this.progrev_comboBox.Size = new System.Drawing.Size(164, 33);
            this.progrev_comboBox.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1182, 633);
            this.Controls.Add(this.progrev_comboBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Bi_Btn);
            this.Controls.Add(this.Tip_comboBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.temp_result);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.time_result);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Go_Btn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tiskom);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.kefftepl);
            this.Controls.Add(this.tolshina);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.choice_comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tTay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stela);
            this.Controls.Add(this.summkoef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tnach);
            this.Controls.Add(this.tokr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.massa);
            this.Controls.Add(this.Teploemk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1200, 680);
            this.MinimumSize = new System.Drawing.Size(1200, 680);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет нагрева и охлаждения термически тонких тел";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Teploemk;
        private System.Windows.Forms.TextBox massa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tnach;
        private System.Windows.Forms.TextBox tokr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stela;
        private System.Windows.Forms.TextBox summkoef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tTay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox choice_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tolshina;
        private System.Windows.Forms.TextBox kefftepl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tiskom;
        private System.Windows.Forms.Button Go_Btn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox time_result;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox temp_result;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Tip_comboBox;
        private System.Windows.Forms.Button Bi_Btn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox progrev_comboBox;
    }
}

