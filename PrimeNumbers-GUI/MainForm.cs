using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace PrimeNumbers_GUI
{
    public partial class MainForm : Form
    {

  


        public MainForm()
        {
            InitializeComponent();
        }
        
        private void startButton_Click(object sender, EventArgs e) {



            // Поиск простых чисел в заданном диапазоне
            uint firstNum = 0;
            uint lastNum = 0;
            uint ChunkSize = 0;
            try {
                firstNum = Convert.ToUInt32(startNumTextBox.Text);
                lastNum = Convert.ToUInt32(endNumTextBox.Text);
                ChunkSize = Convert.ToUInt32(ChunkTextBox.Text);
            } catch (Exception) {
                MessageBox.Show("Invalid input. Expected integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            numbersTextBox.Clear();

            // Блокируем/разблокируем нужные кнопки
            startButton.Enabled = false;
            startNumTextBox.Enabled = false;
            endNumTextBox.Enabled = false;

            //вызываем функцию параллельного поиска
            IEnumerable<uint> primes=PrimesInRange(firstNum, lastNum, ChunkSize);

            //Выводим простые числа
            foreach (uint item in primes) AddNumberToTextBox(item);
        

                //В случае если простых чисел нет - выводим сообщение
            if (numbersTextBox.TextLength == 0)
            {
                numbersTextBox.Text = "None.";
            }

            // Разблокируем кнопки
            startNumTextBox.Enabled = true;
            endNumTextBox.Enabled = true;
            startButton.Enabled = true;
        }

     

        //Параллельный поиск простых чисел в заданном диапазоне
        public IEnumerable<uint> PrimesInRange(uint start, uint end, uint ChunkSize)
        {
            // Список для простых чисел
            List<uint> primes = new List<uint>();
            // Счетчик завершенных потоков
            int completed = 0;

            ManualResetEvent allDone = new ManualResetEvent(initialState: false);

            // Разделить диапазон на равные фрагменты
            uint chunks = (end - start) / ChunkSize;

            for (uint i = 0; i < chunks; ++i)
            {
                uint chunkStart = start + i * ChunkSize;
                uint chunkEnd = chunkStart + ChunkSize;

                // Пул потоков
                ThreadPool.QueueUserWorkItem(_ =>
                {
                    for (uint number = chunkStart; number < chunkEnd; ++number)
                    {
                        if (IsPrime(number))
                        {
                            lock (primes)
                            {
                                primes.Add(number);
                            }
                        }
                    }
                    if (Interlocked.Increment(ref completed) == chunks)  // Увеличиваем счетчик звершенных потоков
                    {
                        allDone.Set();
                    }
                });
            }

            allDone.WaitOne();
            return primes;
        }




        // Вывод в текстбокс
        private  void AddNumberToTextBox(uint num) {
            try {
                Invoke((Action)delegate () {
                    numbersTextBox.AppendText(num + "\r\n");
                });
            } catch (ObjectDisposedException) {
                
            }
        }

        // Ставим выполнение на паузу
        private  void pauseButton_Click(object sender, EventArgs e) {
         
        }

        // Поиск простого числа 
        public static bool IsPrime(uint num)
        {
            if (num < 2)
                return false;


            for (int i = 2; i <= num / 2; i++)
                if (num % i == 0)
                    return false;


            return true;
        }
        private  void cancelButton_Click(object sender, EventArgs e) {

        }

        private  void label2_Click(object sender, EventArgs e)
        {

        }

        private  void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private  void MainForm_Load(object sender, EventArgs e)
        {

        }

        private  void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
