using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interept_Handler 
{
    public partial class Form1 : Form
    {
        private List<Process> softIntProcess;
        internal List<Process> Processes;
        private int noOfProcess;
        private List<Process> hardIntStatus;
        private int quantumSize;
        private List<TextBox> textBoxes;
        private TextBox tempTextBox;
        private List<Label> labels;
        private bool initializeStatus;
        public Form1()
        {
            InitializeComponent();
            softIntProcess = new List<Process>();
            hardIntStatus = new List<Process>();
            Processes = new List<Process>();
            quantumSize = 0;
            textBoxes = new List<TextBox>();
            labels = new List<Label>();
            initializeStatus = false;
        }
        private void CreateProcessExcutionBox(int startPosition)
        {
            Label lb;
            TextBox tb;
            int LabelsStartPosition = 190;
            for (int i = startPosition; i < noOfProcess; i++)
            {
                //Adding label
                lb = new Label();
                lb.AutoSize = true;
                lb.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.ForeColor = SystemColors.ButtonHighlight;
                lb.Location = new Point(1, LabelsStartPosition + (i * 40));
                lb.Name = "processNo" + i;
                lb.Text = "Process# " + (i + 1);
                lb.Size = new Size(128, 24);
                //Adding Text Boxes
                tb = new TextBox();
                tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tb.Location = new Point(132, LabelsStartPosition + (i * 40));
                tb.Size = new Size(554, 26);
                textBoxes.Add(tb);
                labels.Add(lb);
                Controls.Add(lb);
                Controls.Add(tb);
            }
            Size = new Size(717, 280 + ((noOfProcess) * 40));
        }
        public void ExcutionInitializer(bool InitializeByDefault)
        {
            if (textBox5.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Value of required");
                return;
            }
            noOfProcess = int.Parse(textBox1.Text);
            quantumSize = int.Parse(textBox5.Text);
            if (InitializeByDefault)
            {
                for (int i = 0; i < noOfProcess; i++)
                {
                    Processes.Add(new Process(i));
                    Processes.ElementAt(i).initialDefault();
                }
            }
            else
            {
                for (int i = 0; i < noOfProcess; i++)
                {
                    Processes.Add(new Process(i));
                }
            }
            ReadyQueueTextBoxUpdater();
        }
        private void ReadyQueueTextBoxUpdater()
        {
            readyQueBox.Text = "";
            int count = Processes.Count();
            for (int i = 1; i <= count; i++)
                readyQueBox.Text += "P" + (Processes.ElementAt(i-1).ID+1) + ", ";
        }
        private void Exe_Click(object sender, EventArgs e)
        {
            if(!initializeStatus)
                ExcutionInitializer(true);
            CreateProcessExcutionBox(0);
            ProcessCompletionTime.Start();
        }

        private void HardInt_Click(object sender, EventArgs e)
        {
            try
            {
                Process temp = Processes.ElementAt(0);
                textBox3.Text = "Hardware Interept Occurred";
                hardIntStatus.Add(temp);
                textBox4.Text = temp.Data[temp.QuantumRunned];
                Processes.RemoveAt(0);
                ReadyQueueTextBoxUpdater();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There are No currently running process to interrupt");
            }
            //Processes.Add(temp);
        }
        private void SoftInt_Click(object sender, EventArgs e)
        {
            try
            {
                softIntProcess.Add(Processes.ElementAt(0));
                textBox4.Text = Processes.ElementAt(0).Data[Processes.ElementAt(0).QuantumRunned].ToString();
                Processes.RemoveAt(0);
                softIntTimer.Start();
                textBox3.Text = "Software Interept Occurred";
                ReadyQueueTextBoxUpdater();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There are No currently running process to interrupt");
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "E")
                exeTime_Click(sender, e);
            else if (e.KeyCode.ToString() == "H")
                HardInt_Click(sender, e);
            else if (e.KeyCode.ToString() == "S")
                SoftInt_Click(sender, e);
            else if (e.KeyCode.ToString() == "R")
                Exe_Click(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProcessCompletionTime_Tick(object sender, EventArgs e)
        {
            if (Processes.Count == 0)
            {
                if (hardIntStatus.Count!=0)
                {
                    textBox4.Text = string.Format("{0}", hardIntStatus.ElementAt(0).Data[hardIntStatus.ElementAt(0).QuantumRunned]);
                    do
                    {
                        Processes.Add(hardIntStatus.ElementAt(0));
                        hardIntStatus.RemoveAt(0);
                    }
                    while (hardIntStatus.Count!=0);
                    ReadyQueueTextBoxUpdater();
                    textBox3.Text = "HardWare interrupt Handled";
                }
                else ProcessCompletionTime.Stop();
            }
            else
            {
                Process temp = Processes.ElementAt(0);
                    if (processExecuter(temp))
                    {
                        Processes.RemoveAt(0);
                        Processes.Add(temp);
                    }
                    else
                    {
                        Processes.RemoveAt(0);
                        ReadyQueueTextBoxUpdater();
                }
            }
        }
        private bool processExecuter(Process value)
        {
            int startAddress = value.QuantumRunned;
            /*if (startAddress >= 9)
            {
                return;
            }*/
            int temp = startAddress + quantumSize;
            int processExeTime = value.ExeTime;
            for (int i = startAddress; i < temp; i++)
            {
                if (i > processExeTime)
                {
                    return false;
                }
                else
                {
                    tempTextBox = textBoxes.ElementAt(value.ID);
                    tempTextBox.Text += string.Format("{0}    ", value.Data[i]);
                }
            }
            value.QuantumRunned = temp;
            return true;
        }
        private void softIntTimer_Tick(object sender, EventArgs e)
        {
            textBox4.Text = softIntProcess.ElementAt(0).Data[softIntProcess.ElementAt(0).QuantumRunned].ToString();
            Processes.Add(softIntProcess.ElementAt(0));
            softIntProcess.RemoveAt(0);
            ReadyQueueTextBoxUpdater();
            textBox3.Text = "Software Interrupt Handled";
            if (softIntProcess.Count == 0)
            {
                softIntTimer.Stop();
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessCompletionTime.Stop();
            initializeStatus = false;
            for (int i = 0; i < noOfProcess; i++)
            {
                this.Controls.Remove(labels.ElementAt(0));
                this.Controls.Remove(textBoxes.ElementAt(0));
                textBoxes.RemoveAt(0);
                labels.RemoveAt(0);
            }
            textBox1.Text = "";
            textBox3.Text = "";
            //textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            readyQueBox.Text = "";
            hardIntStatus.Clear();
            softIntProcess.Clear();
            Size = new Size(717, 262);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "C")
                button1_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 58 || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 58 || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void exeTime_Click(object sender, EventArgs e)
        {
            ExcutionInitializer(false);
            initializeStatus = true;
            ProcessExeTimeSetter pets = new ProcessExeTimeSetter(Processes, noOfProcess);
            pets.Show();
        }
    }
}
