using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace raschet_tepla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
            HideAllControls();
            chart1.Visible = false;

            choice_comboBox.SelectedIndexChanged += new EventHandler(choice_comboBox_SelectedIndexChanged);
            Tip_comboBox.SelectedIndexChanged += new EventHandler(Tip_comboBox_SelectedIndexChanged);
            Bi_Btn.Click += new EventHandler(Bi_Btn_Click);
            Go_Btn.Click += new EventHandler(Go_Btn_Click);
            Reset_Btn.Click += new EventHandler(Reset_Btn_Click);
            AttachTextChangedEvents();// Привязка обработчиков событий для ComboBox
        }

        private void InitializeComboBoxes()// Метод для инициализации ComboBox
        { 
            choice_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;// Установка DropDownStyle в DropDownList для запрета ввода текста
            Tip_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            choice_comboBox.Items.Add("Найти время");// Добавление вариантов в choice_comboBox
            choice_comboBox.Items.Add("Найти температуру");

            Tip_comboBox.Items.Add("Пластина");// Добавление вариантов в Tip_comboBox
            Tip_comboBox.Items.Add("Шар");
            Tip_comboBox.Items.Add("Цилиндр");

            // Добавление вариантов в progrev_comboBox
            progrev_comboBox.Items.Add("Односторонний");
            progrev_comboBox.Items.Add("Двухсторонний");
        }

        // Метод скрытия всех элементов интерфейса кроме label9 и choice_comboBox
        private void HideAllControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Name != "label9" && ctrl.Name != "choice_comboBox")
                {
                    ctrl.Visible = false;
                }
            }
        }

        // Обработчик события выбора в choice_comboBox
        private void choice_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choice_comboBox.SelectedItem == null)
                return;

            string selectedOption = choice_comboBox.SelectedItem.ToString();

            Tip_comboBox.Visible = true;
            label18.Visible = true;
        }

        // Событие при изменении выбора в Tip_comboBox (Пластина, Шар, Цилиндр)
        private void Tip_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTip = Tip_comboBox.SelectedItem?.ToString();

            if (selectedTip == "Пластина")
            {
                progrev_comboBox.Visible = true;
                label19.Visible = true;
                label12.Text = "Толщина тела, S, м";
            }
            else
            {
                progrev_comboBox.Visible = false;
                label19.Visible = false;
                label12.Text = "Прогреваемый радиус, R, м";
            }

            // Показываем общие элементы для всех типов
            label10.Visible = label13.Visible = label6.Visible = label11.Visible = label12.Visible = true;
            kefftepl.Visible = tolshina.Visible = summkoef.Visible = true;
            Bi_Btn.Visible = true;
        }

        // Проверка и расчет числа Bi при нажатии кнопки Bi_Btn
        private void Bi_Btn_Click(object sender, EventArgs e)
        {
            if (!ValidateBiFields())
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double keffteplValue, tolshinaValue, summkoefValue;

            // Проверка пустых полей
            if (string.IsNullOrWhiteSpace(kefftepl.Text) || string.IsNullOrWhiteSpace(tolshina.Text) || string.IsNullOrWhiteSpace(summkoef.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightEmptyFields();
                return;
            }

            // Проверка корректности числовых значений
            if (!double.TryParse(kefftepl.Text, out keffteplValue) || !double.TryParse(tolshina.Text, out tolshinaValue) || !double.TryParse(summkoef.Text, out summkoefValue))
            {
                MessageBox.Show("Введите корректные числовые значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на положительные значения
            if (keffteplValue <= 0 || tolshinaValue <= 0 || summkoefValue <= 0)
            {
                MessageBox.Show("Значения должны быть положительными!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double Bi = 0;

            // Выбор формулы в зависимости от типа объекта
            if (Tip_comboBox.SelectedItem.ToString() == "Пластина")
            {
                if (progrev_comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите тип прогрева (односторонний/двухсторонний)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (progrev_comboBox.SelectedItem.ToString() == "Односторонний")
                {
                    Bi = (summkoefValue * tolshinaValue) / keffteplValue;
                }
                else if (progrev_comboBox.SelectedItem.ToString() == "Двухсторонний")
                {
                    Bi = (summkoefValue * (tolshinaValue / 2)) / keffteplValue;
                }
            }
            else
            {
                Bi = (summkoefValue * tolshinaValue) / keffteplValue;
            }

            // Обработка результата расчета Bi
            if (Bi > 0.25)
            {
                MessageBox.Show($"Число Bi: {Math.Round(Bi, 2)}, так как значение больше 0,25 - тело считается термически массивным", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var message = $"Полученное число Bi: {Math.Round(Bi, 2)}, тело можно считать термически тонким";
                MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowNextElements();
            }
            // После нажатия Bi_Btn выбор в choice_comboBox блокируется
            choice_comboBox.Enabled = false;
        }

        // Проверка пустых полей при нажатии Bi_Btn
        private bool ValidateBiFields()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(kefftepl.Text))
            {
                kefftepl.BackColor = Color.Red;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(tolshina.Text))
            {
                tolshina.BackColor = Color.Red;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(summkoef.Text))
            {
                summkoef.BackColor = Color.Red;
                valid = false;
            }

            return valid;
        }

        // Подсветка незаполненных полей
        private void HighlightEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(kefftepl.Text))
                kefftepl.BackColor = Color.Red;
            if (string.IsNullOrWhiteSpace(tolshina.Text))
                tolshina.BackColor = Color.Red;
            if (string.IsNullOrWhiteSpace(summkoef.Text))
                summkoef.BackColor = Color.Red;
        }

        // Показ следующих элементов после успешного расчета Bi
        private void ShowNextElements()
        {
            label8.Visible = label1.Visible = label2.Visible = label4.Visible = true;
            label3.Visible = label5.Visible = label7.Visible = label14.Visible = true;
            Teploemk.Visible = massa.Visible = tokr.Visible = tnach.Visible = true;
            stela.Visible = tTay.Visible = tiskom.Visible = true;
            Go_Btn.Visible = Reset_Btn.Visible = true;

            // Скройте поля в зависимости от выбора в choice_comboBox
            if (choice_comboBox.SelectedItem.ToString() == "Найти время")
            {
                tTay.Visible = label7.Visible = false;
            }
            else if (choice_comboBox.SelectedItem.ToString() == "Найти температуру")
            {
                tiskom.Visible = label14.Visible = false;
            }
        }


        // Валидация и расчет времени или температуры
        private void Go_Btn_Click(object sender, EventArgs e)
        {
            // Валидация полей
            if (!ValidateGoFields())
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double TeploemkValue, massaValue, tokrValue, tnachValue, stelaValue, tTayValue = 0, tiskomValue = 0;
            double result = 0;  // Объявляем переменную result здесь

            // Проверка полей в зависимости от выбора в choice_comboBox
            if (choice_comboBox.SelectedItem.ToString() == "Найти время")
            {
                if (!double.TryParse(Teploemk.Text, out TeploemkValue) || !double.TryParse(massa.Text, out massaValue) ||
                    !double.TryParse(tokr.Text, out tokrValue) || !double.TryParse(tnach.Text, out tnachValue) ||
                    !double.TryParse(stela.Text, out stelaValue) || !double.TryParse(tiskom.Text, out tiskomValue))
                {
                    MessageBox.Show("Введите корректные числовые значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка на положительные значения
                if (TeploemkValue <= 0 || massaValue <= 0 || stelaValue <= 0)
                {
                    MessageBox.Show("Значения должны быть положительными!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка на равенство начальной температуры и температуры окружающей среды
                if (tnachValue == tokrValue)
                {
                    MessageBox.Show("Температура тела равна температуре окружающей среды. Расчет невозможен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка на корректность температурных значений при нагреве
                if (tokrValue > tnachValue)
                {
                    if (tnachValue > tiskomValue)
                    {
                        MessageBox.Show("Желаемая температура тела не может быть достигнута при нагреве, так как она меньше начальной температуры тела.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (tiskomValue > tokrValue)
                    {
                        MessageBox.Show("Тело не может нагреться до искомой температуры, так как температура окружающего воздуха меньше.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Если tiskom равно tokr, уменьшаем tiskom на 0.01 для предотвращения переполнения
                    if (tiskomValue == tokrValue)
                    {
                        tiskomValue = tokrValue - 0.01;
                    }
                }

                // Проверка на совпадение температур
                if (tiskomValue == tnachValue)
                {
                    MessageBox.Show("Начальная температура тела совпадает с искомой температурой, измените значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка на корректность температурных значений при охлаждении
                if (tnachValue > tokrValue && tnachValue < tiskomValue)
                {
                    MessageBox.Show("Неверные параметры температур! Начальная температура тела выше температуры окружающей среды, но меньше желаемой температуры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tnachValue > tokrValue && tiskomValue < tokrValue)
                {
                    MessageBox.Show("Тело не может охладиться ниже температуры окружающего воздуха.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tnachValue > tokrValue && tiskomValue == tokrValue)
                {
                    // Если tiskom равно tokr, уменьшаем tiskom на 0,01 для предотвращения переполнения
                    tiskomValue = tokrValue - 0.01;
                }

                // Расчет времени
                result = -(massaValue * TeploemkValue) / (double.Parse(summkoef.Text) * stelaValue) * Math.Log((tokrValue - tiskomValue) / (tokrValue - tnachValue));
                time_result.Text = Math.Round(result, 2).ToString() + " секунд";
                ShowTimeResult();
            }
            else if (choice_comboBox.SelectedItem.ToString() == "Найти температуру")
            {
                if (!double.TryParse(Teploemk.Text, out TeploemkValue) || !double.TryParse(massa.Text, out massaValue) ||
                    !double.TryParse(tokr.Text, out tokrValue) || !double.TryParse(tnach.Text, out tnachValue) ||
                    !double.TryParse(stela.Text, out stelaValue) || !double.TryParse(tTay.Text, out tTayValue))
                {
                    MessageBox.Show("Введите корректные числовые значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка на положительные значения
                if (TeploemkValue <= 0 || massaValue <= 0 || stelaValue <= 0 || tTayValue <= 0)
                {
                    MessageBox.Show("Значения должны быть положительными!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // В данном случае tiskom не отслеживается
                result = tokrValue - (tokrValue - tnachValue) * Math.Exp(-double.Parse(summkoef.Text) * stelaValue * tTayValue / (massaValue * TeploemkValue));
                temp_result.Text = Math.Round(result, 2).ToString() + "°C";
                ShowTempResult();
            }

            // Отрисовка графика после расчета
            PlotGraph(result);
        }


        // Проверка пустых полей при нажатии Go_Btn
        private bool ValidateGoFields()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(Teploemk.Text))
            {
                Teploemk.BackColor = Color.Red;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(massa.Text))
            {
                massa.BackColor = Color.Red;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(tokr.Text))
            {
                tokr.BackColor = Color.Red;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(tnach.Text))
            {
                tnach.BackColor = Color.Red;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(stela.Text))
            {
                stela.BackColor = Color.Red;
                valid = false;
            }
            if (choice_comboBox.SelectedItem.ToString() == "Найти время" && string.IsNullOrWhiteSpace(tiskom.Text))
            {
                tiskom.BackColor = Color.Red;
                valid = false;
            }
            if (choice_comboBox.SelectedItem.ToString() == "Найти температуру" && string.IsNullOrWhiteSpace(tTay.Text))
            {
                tTay.BackColor = Color.Red;
                valid = false;
            }

            return valid;
        }

        // Сброс выделения при вводе данных в поле
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.BackColor == Color.Red)
            {
                textBox.BackColor = Color.White;
            }
        }

        // Привязка событий TextChanged для всех текстовых полей
        private void AttachTextChangedEvents()
        {
            Teploemk.TextChanged += TextBox_TextChanged;
            massa.TextChanged += TextBox_TextChanged;
            tokr.TextChanged += TextBox_TextChanged;
            tnach.TextChanged += TextBox_TextChanged;
            stela.TextChanged += TextBox_TextChanged;
            tTay.TextChanged += TextBox_TextChanged;
            tiskom.TextChanged += TextBox_TextChanged;

            // Привязка событий TextChanged для полей kefftepl, tolshina, summkoef
            kefftepl.TextChanged += TextBox_TextChanged;
            tolshina.TextChanged += TextBox_TextChanged;
            summkoef.TextChanged += TextBox_TextChanged;
        }


        private bool ValidateInput(out double TeploemkValue, out double massaValue, out double tokrValue, out double tnachValue, out double stelaValue, out double tTayValue, out double tiskomValue)
        {
            TeploemkValue = massaValue = tokrValue = tnachValue = stelaValue = tTayValue = tiskomValue = 0;

            // Проверка на числа
            if (!double.TryParse(Teploemk.Text, out TeploemkValue) || !double.TryParse(massa.Text, out massaValue) ||
                !double.TryParse(tokr.Text, out tokrValue) || !double.TryParse(tnach.Text, out tnachValue) ||
                !double.TryParse(stela.Text, out stelaValue) || !double.TryParse(tTay.Text, out tTayValue) ||
                !double.TryParse(tiskom.Text, out tiskomValue))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения во все поля.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Дополнительная проверка на неотрицательные значения для конкретных полей
            if (TeploemkValue <= 0 || massaValue <= 0 || stelaValue <= 0 || tTayValue <= 0)
            {
                MessageBox.Show("Поля \"Теплоемкость\", \"Масса\", \"Степень прогрева\" и \"Время\" должны содержать положительные числа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Показ результата времени
        private void ShowTimeResult()
        {
            label15.Visible = label16.Visible = time_result.Visible = true;
        }

        // Показ результата температуры
        private void ShowTempResult()
        {
            label15.Visible = label17.Visible = temp_result.Visible = true;
        }

        private ToolTip tooltip = new ToolTip();

        // Построение графика
        private void PlotGraph(double result)
        {
            double tokrValue = double.Parse(tokr.Text);   // Температура окружающей среды
            double tnachValue = double.Parse(tnach.Text); // Начальная температура тела
            double TeploemkValue = double.Parse(Teploemk.Text);
            double massaValue = double.Parse(massa.Text);
            double stelaValue = double.Parse(stela.Text);
            double tiskomValue = 0; // Инициализация значения по умолчанию

            // Проверяем режим "Найти время" — только тогда используется tiskom
            if (choice_comboBox.SelectedItem.ToString() == "Найти время")
            {
                if (string.IsNullOrWhiteSpace(tiskom.Text))
                {
                    MessageBox.Show("Заполните поле 'tiskom' для режима 'Найти время'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tiskomValue = double.Parse(tiskom.Text); // Используем значение tiskom только в режиме "Найти время"
            }

            bool isFindingTime = choice_comboBox.SelectedItem.ToString() == "Найти время";  // Проверяем выбранный режим

            chart1.Series.Clear(); // Очищаем график перед построением нового
            chart1.Legends.Clear(); // Очищаем легенду

            // Добавляем легенду
            chart1.Legends.Add(new Legend("Legend1")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center
            });

            // Название графика
            string title = tokrValue > tnachValue ? "График нагрева тела" : "График охлаждения тела";
            chart1.Titles.Clear();
            chart1.Titles.Add(new Title(title, Docking.Top, new Font("Arial", 16, FontStyle.Bold), Color.Black));

            // Линия тренда
            Series trendLine = new Series
            {
                Name = "Линия тренда",
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderDashStyle = ChartDashStyle.Solid,
                BorderWidth = 2
            };
            chart1.Series.Add(trendLine);

            // Линия результатов
            Series series = new Series
            {
                Name = "Результаты",
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,
                Color = Color.Blue,
                MarkerStyle = MarkerStyle.Circle,  // Круглые маркеры
                MarkerSize = 8,
                MarkerColor = Color.Black
            };
            chart1.Series.Add(series);

            // Определяем шаг для оси X и максимальное значение с округлением
            double maxXValue = isFindingTime ? result : double.Parse(tTay.Text);

            // Округляем максимальное значение оси X до ближайшего числа, кратного 10
            maxXValue = Math.Ceiling(maxXValue / 10.0) * 10;

            // Вычисляем шаг, чтобы получить не более 5 делений на оси X
            double stepX = maxXValue / 5;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = maxXValue;  // Округленное значение
            chart1.ChartAreas[0].AxisX.Interval = stepX;     // Интервал для 5 делений

            // Добавляем точки и их подписи
            int pointCount = 5;
            double timeInterval = isFindingTime ? result / (pointCount - 1) : double.Parse(tTay.Text) / (pointCount - 1);

            for (int i = 0; i < pointCount; i++)
            {
                double timeValue = timeInterval * i;

                // Корректная формула для расчета температуры
                double tempValue = tnachValue + (tokrValue - tnachValue) * (1 - Math.Exp(-double.Parse(summkoef.Text) * stelaValue * timeValue / (massaValue * TeploemkValue)));

                // Добавляем точки
                series.Points.AddXY(timeValue, tempValue);

                // Подписи точек сдвинуты
                series.Points[i].Label = (i + 1).ToString();
                series.Points[i].LabelForeColor = Color.Black;

                // Добавляем точки в легенду без маркеров
                chart1.Legends[0].CustomItems.Add(Color.Black, $"Точка {i + 1}\n({Math.Round(tempValue, 2)}°C за {Math.Round(timeValue, 2)} секунд)\n");
            }

            // Линия тренда соединяет первую и последнюю точку, поднятую выше
            trendLine.Points.AddXY(0, tnachValue + 10); // Первая точка поднята
            trendLine.Points.AddXY(isFindingTime ? result : double.Parse(tTay.Text), series.Points[pointCount - 1].YValues[0] + 10); // Последняя точка поднята

            // Обновление оси Y
            UpdateYAxis(series.Points[pointCount - 1].YValues[0], tnachValue, tiskomValue, tokrValue);

            // Настройка осей X и Y
            chart1.ChartAreas[0].AxisX.Title = isFindingTime ? "Время (секунды)" : "Время (tTay)";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12);
            chart1.ChartAreas[0].AxisY.Title = isFindingTime ? "Температура тела (°C)" : "Температура (°C)";
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12);

            // Пунктирные линии к оси X и Y
            for (int i = 0; i < pointCount; i++)
            {
                Series dashedSeries = new Series
                {
                    Name = $"Пунктир {i}",
                    ChartType = SeriesChartType.Line,
                    BorderDashStyle = ChartDashStyle.Dash,
                    Color = Color.Gray,
                    IsVisibleInLegend = false, // Убираем пунктиры из легенды
                    BorderWidth = 1
                };
                double timeValue = timeInterval * i;
                double tempValue = tnachValue + (tokrValue - tnachValue) * (1 - Math.Exp(-double.Parse(summkoef.Text) * stelaValue * timeValue / (massaValue * TeploemkValue)));

                dashedSeries.Points.AddXY(timeValue, 0);  // Линия до оси X
                dashedSeries.Points.AddXY(timeValue, tempValue);  // Точка на графике
                dashedSeries.Points.AddXY(0, tempValue);  // Линия до оси Y
                chart1.Series.Add(dashedSeries);
            }

            // Отключаем сетку
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Обновление графика
            chart1.Visible = true;  // Делаем график видимым
            chart1.Invalidate();

            // Подключаем обработчик события MouseMove для интерактивности
            chart1.MouseMove += new MouseEventHandler(chart1_MouseMove);
        }


        // Обработчик события MouseMove для отображения всплывающих подсказок
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            var results = chart1.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var point = result.Object as DataPoint;
                    if (point != null)
                    {
                        // Округление значений X и Y до двух знаков после запятой
                        double xValueRounded = Math.Round(point.XValue, 2);
                        double yValueRounded = Math.Round(point.YValues[0], 2);

                        // Отображение всплывающей подсказки с округленными значениями
                        tooltip.SetToolTip(chart1, $"Время={xValueRounded}, Температура={yValueRounded}");
                        return;
                    }
                }
            }

            // Скрываем всплывающую подсказку, если не на точке
            tooltip.SetToolTip(chart1, string.Empty);
        }


        // Обновление оси Y для графика
        private void UpdateYAxis(double tempResult, double tnachValue, double tiskomValue, double tokrValue)
        {
            double maxY;

            // Проверка выбора в choice_comboBox
            if (choice_comboBox.SelectedItem.ToString() == "Найти время")
            {
                // Расчет для варианта "Найти время"
                maxY = Math.Ceiling(Math.Max(tnachValue, tiskomValue) / 10.0) * 10 + 5;
            }
            else if (choice_comboBox.SelectedItem.ToString() == "Найти температуру")
            {
                // Расчет для варианта "Найти температуру"
                maxY = Math.Ceiling(Math.Max(tnachValue, tokrValue) / 10.0) * 10 + 5;
            }
            else
            {
                // На случай, если выбор не соответствует ни одному из значений
                maxY = 100; // Значение по умолчанию, если не выбран режим
            }

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = maxY;
            chart1.ChartAreas[0].AxisY.Interval = Math.Floor((maxY - 0) / 4);
        }


        //расчет температуры (в зависимости от времени)
        private double CalculateTemperature(double time)
        {
            double TeploemkValue = double.Parse(Teploemk.Text);
            double massaValue = double.Parse(massa.Text);
            double tokrValue = double.Parse(tokr.Text);
            double tnachValue = double.Parse(tnach.Text);
            double summkoefValue = double.Parse(summkoef.Text);
            double stelaValue = double.Parse(stela.Text);

            return tnachValue - (tnachValue - tokrValue) * Math.Exp(-summkoefValue * stelaValue * time / (massaValue * TeploemkValue));
        }

        // Сброс выделения при нажатии Reset_Btn
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            choice_comboBox.SelectedIndex = -1;
            Tip_comboBox.SelectedIndex = -1;
            progrev_comboBox.SelectedIndex = -1;

            HideAllControls();

            kefftepl.Text = tolshina.Text = summkoef.Text =
            Teploemk.Text = massa.Text = tokr.Text = tnach.Text =
            stela.Text = tTay.Text = tiskom.Text = time_result.Text = temp_result.Text = string.Empty;

            kefftepl.BackColor = tolshina.BackColor = summkoef.BackColor = Color.White;
            Teploemk.BackColor = massa.BackColor = tokr.BackColor = tnach.BackColor = stela.BackColor = tTay.BackColor = tiskom.BackColor = Color.White;

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Visible = false;
            choice_comboBox.Enabled = true;
        } 
    }
}
