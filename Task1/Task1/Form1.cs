using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                // Disable the button while the calculation is in progress
                button1.Enabled = false;

                // Clear the listbox before displaying new results
                listBox1.Items.Clear();

                Task.Run(() =>
                {
                    List<int> primes = CalculatePrimes(number);

                    // Update the UI on the main thread
                    this.Invoke((MethodInvoker)delegate
                    {
                        foreach (int prime in primes)
                        {
                            listBox1.Items.Add(prime);
                        }

                        // Show a message when the calculation is complete
                        MessageBox.Show($"Calculation completed. Found {primes.Count} prime numbers.");

                        // Re-enable the button
                        button1.Enabled = true;
                    });
                });
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private List<int> CalculatePrimes(int number)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the listbox
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int number))
            {
                // Disable the button while the calculation is in progress
                button2.Enabled = false;

                // Clear the listbox before displaying new results
                listBox1.Items.Clear();

                Task.Run(() =>
                {
                    List<int> primes = CalculatePrimes(number);

                    // Update the UI on the main thread
                    this.Invoke((MethodInvoker)delegate
                    {
                        foreach (int prime in primes)
                        {
                            listBox1.Items.Add(prime);
                        }

                        // Show a message when the calculation is complete
                        MessageBox.Show($"Calculation completed. Found {primes.Count} prime numbers.");

                        // Re-enable the button
                        button2.Enabled = true;
                    });
                });
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }


}