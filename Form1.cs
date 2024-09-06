using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsWeather
{
    public partial class Form1 : Form
    {
       





        List<int> PositionTemp = new List<int>(); // список добавления координат

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // вывод формы по центру экрана

        }
        private int _countSecond = 1; // Пременная за сколько секунд обновиться
        int limitTemp = 35; // Ограничения по температуре
        private int _countSecond2 = 1; // Пременная за сколько секунд обновиться
        int limitTemp2 = 35; // Ограничения по температуре

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true; // старт таймера
            timer2.Enabled = true; // старт таймера


            numeric.Maximum = 40; // ограничения по набору температуры
            numeric.Minimum = -40;

           chart.ChartAreas[0].AxisX.Title = "День";               // Подпись графика
           chart.ChartAreas[0].AxisY.Title = "Значение";

            chart.ChartAreas[0].AxisY.Maximum = 110;  // Максимум и минимум для оси y
            chart.ChartAreas[0].AxisY.Minimum = 0; // Настройка оси Y
            chart.ChartAreas[0].AxisX.Maximum = 32;  // Максимум и минимум для оси y
            chart.ChartAreas[0].AxisX.Minimum = 0; // Настройка оси Y
            chart.Series[0].Points.Clear();   // очищение графика
            chart.Series[1].Points.Clear();
            
            chart.ChartAreas[0].AxisX.Interval = 5; // интервал  графику x


            chart1.ChartAreas[0].AxisX.Title = "День";               // Подпись графика
            chart1.ChartAreas[0].AxisY.Title = "Значение";

            chart1.ChartAreas[0].AxisY.Maximum = 50;  // Максимум и минимум для оси y
            chart1.ChartAreas[0].AxisY.Minimum = -45; // Настройка оси Y
            chart1.ChartAreas[0].AxisX.Maximum = 32;  // Максимум и минимум для оси y
            chart1.ChartAreas[0].AxisX.Minimum = 0; // Настройка оси Y
            chart1.Series[0].Points.Clear();   // очищение графика
            chart1.Series[1].Points.Clear();

            chart1.ChartAreas[0].AxisX.Interval = 5; // интервал  графику x

        }

        int summtemp = 0;
        int summtemp2 = 0;
        int schet=0;
        int b=1;
        int summtemp3 = 0;
        int summtemp4 = 0;
        int schet2 = 0;
        int b2 = 1;

        private void timer1_Tick(object sender, EventArgs e) // период работы таймера
        {   
            //Random random = new Random(DateTime.Now.Millisecond); //рандом зависящий от милисекунд
            //double ranTemp = random.Next(-10, 35); // минимальная и максимальная температура


            /////////////////
            Presenter db = new Presenter();    // новый экземпляр класса


            db.openConnection(); //  открытие базы

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT  `indexP` FROM `dolargraf`  WHERE `id` = N'{_countSecond}' ", db.getConnection());
            
            string temper = command.ExecuteScalar().ToString();
            int temper2 = Int32.Parse(temper);                       //преобразование в int
            


            db.closeConnection();// закрытие базы

            ///////////////////////////////
            ///высчитывание среднего
             
                summtemp = summtemp + temper2;
                schet++;
                if (schet == 2)
            {
                summtemp2 = summtemp / 2;
                summtemp = 0;
                schet = 0;

            }



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            int value = Convert.ToInt32(numeric.Value);
            int robo = _countSecond;

            chart.Series[0].Points.AddXY(robo, temper2);   // оранжевый график по оси x время текущее по оси y значение
            chart.Series[1].Points.AddXY(robo, summtemp2); // красный график
            
            PositionTemp.Add(temper2); //Добавление в список координат

            _countSecond++;

            if ( _countSecond == 30) //цикл при достижение 30 секунд
            {
                _countSecond=1; // таймер обнуляем
                chart.Series[0].Points.Clear();   // очищение графика
                chart.Series[1].Points.Clear();
                chart.ChartAreas[0].AxisX.Minimum = 0;               // перерисовываем ось x
                chart.ChartAreas[0].AxisX.Maximum = 45;

               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)   // таблица
        {

        }

        private void button1_Click(object sender, EventArgs e)     // ПРИ НАЖАТИИ КНОПКИ ЗАГРУЖАЕМ таблицу валюта
        {
            Presenter db = new Presenter();    // новый экземпляр класса


            db.openConnection(); //  открытие базы

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `dolargraf` ", db.getConnection());


            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {


                dataGridView1.DataSource = table;

            }
            else
            {
                MessageBox.Show("No");
            }

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

       

       

        private void button4_Click(object sender, EventArgs e)     //Кнопка загрузки таблицы погода
        {
            Presenter db = new Presenter();    // новый экземпляр класса


            db.openConnection(); //  открытие базы

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `grafikpogoda` ", db.getConnection());


            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {


                dataGridView1.DataSource = table;

            }
            else
            {
                MessageBox.Show("No");
            }
        }

      /// постройка второго графика .............................................................................................
     

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /////////////////
            Presenter db2 = new Presenter();    // новый экземпляр класса


            db2.openConnection(); //  открытие базы

            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();

            MySqlCommand command2 = new MySqlCommand($"SELECT  `temper` FROM `grafikpogoda`  WHERE `id` = N'{_countSecond2}' ", db2.getConnection());

            string temper3 = command2.ExecuteScalar().ToString();
            int temper4 = Int32.Parse(temper3);                       //преобразование в int



            db2.closeConnection();// закрытие базы

            ///////////////////////////////
            ///
            ///высчитывание среднего

            summtemp3 = summtemp3 + temper4;
            schet2++;
            if (schet2 == 2)
            {
                summtemp4 = summtemp3 / 2;
                summtemp3 = 0;
                schet2 = 0;

            }



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int robo2 = _countSecond2;

            chart1.Series[0].Points.AddXY(robo2, temper4);   // оранжевый график по оси x время текущее по оси y значение
            chart1.Series[1].Points.AddXY(robo2, summtemp4); // красный график

            PositionTemp.Add(temper4); //Добавление в список координат

            _countSecond2++;

            if (_countSecond2 == 30) //цикл при достижение 30 секунд
            {
                _countSecond2 = 1; // таймер обнуляем
                chart1.Series[0].Points.Clear();   // очищение графика
                chart1.Series[1].Points.Clear();
                chart1.ChartAreas[0].AxisX.Minimum = 0;               // перерисовываем ось x
                chart1.ChartAreas[0].AxisX.Maximum = 45;


            }

        }
    }   
    
}
