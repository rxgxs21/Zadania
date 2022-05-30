using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Wielowatkowosc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Restarts forms and calls function which starts new thread.
        /// Restarts forms and calls function which starts new thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGen_Click(object sender, EventArgs e)
        {
            buttonGen.Enabled = false;
            textBox1.Text = "";
            labelProgressBar.Text = "Permutacja: " + (0 / Math.Pow(9, int.Parse(numericUpDownPerLength.Value.ToString()))).ToString();
            calculateAllPermutations();
        }

        /// <summary>
        /// Starts new thread, which is calculating permutations. 
        /// </summary>
        private void calculateAllPermutations()
        {
            Thread newThread = new Thread(() => permutation());
            newThread.Start();
        }

        /// <summary>
        /// Starts calculations all permutations.
        /// </summary>
        private void permutation()
        {
            double total = calculateTotal(int.Parse(numericUpDownPerLength.Value.ToString()));
            double counter = 0;
            int[] permutation = new int[int.Parse(numericUpDownPerLength.Value.ToString())];
            while (!permutation.All(n => n == 9))
            {
                nextPermutation(permutation, int.Parse(numericUpDownPerLength.Value.ToString()));
                counter++;
                callBackLog(showPermutation(permutation), counter, total);
                Thread.Sleep(1);
            }
            MethodInvoker invoker = new MethodInvoker(delegate { buttonGen.Enabled = true; });
            buttonGen.Invoke(invoker);
        }

        /// <summary>
        /// Finds next permutation.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayLvl"></param>
        private void nextPermutation(int[] array, int arrayLvl)
        {
            if (array[arrayLvl - 1] != 9)
            {
                array[arrayLvl - 1] += 1;
            }
            else if (arrayLvl != 1)
            {
                array[arrayLvl - 1] = 0;
                nextPermutation(array, arrayLvl - 1);
            }
            else if (arrayLvl == 1 && array[0] == 9)
            {
                nextPermutation(array, int.Parse(numericUpDownPerLength.Value.ToString()) - 1);
            }
        }

        /// <summary>
        /// Generates string with permutation.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>(string)permutation</returns>
        private string showPermutation(int[] array)
        {
            string permutation = "";
            for (int i = 0; i < array.Length; i++)
            {
                permutation += array[i].ToString();
            }
            return permutation;
        }

        /// <summary>
        /// Edits forms from main thread.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="counter"></param>
        /// <param name="total"></param>
        private void callBackLog(string text, double counter, double total)
        {
            MethodInvoker invoker0 = new MethodInvoker(delegate { textBox1.AppendText(text); textBox1.AppendText(Environment.NewLine); });
            textBox1.Invoke(invoker0);
            MethodInvoker invoker1 = new MethodInvoker(delegate { labelProgressBar.Text = "Permutacja: " + counter + "/" + total; });
            labelProgressBar.Invoke(invoker1);
            MethodInvoker invoker2 = new MethodInvoker(delegate { progressBar1.Value = ((int)(counter / total * 100)); progressBar1.Update(); });
            progressBar1.Invoke(invoker2);
        }

        /// <summary>
        /// Calculates total quantity of permutations.
        /// </summary>
        /// <param name="howManyDigits"></param>
        /// <returns>(int)quantity of permutations</returns>
        private int calculateTotal(int howManyDigits)
        {
            string total = "";
            for (int i = 0; i < howManyDigits; i++)
            {
                total += "9";
            }
            return int.Parse(total);
        }
    }
}
