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
    public partial class ProcessExeTimeSetter : Form
    {
        List<Process> Processes;
        int NoOfProcess;

        internal ProcessExeTimeSetter(List<Process> processes, int noOfProcess)
        {
            InitializeComponent();
            Processes = processes;
            NoOfProcess = noOfProcess;
            InitializerInputs(noOfProcess);
        }
        private void InitializerInputs(int noOfProcess)
        {
            Label lb;
            TextBox tb;
            int LabelsStartPosition = 10;
            this.Size = new Size(370, 20+((noOfProcess + 2) * 40));
            for (int i = 0; i < noOfProcess; i++)
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
                tb.Size = new Size(200, 26);
                tb.Name = "TextBox" + i;
                tb.TabIndex = i + 1;
                Controls.Add(lb);
                Controls.Add(tb);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i<NoOfProcess; i++)
            {
                string findKey = "TextBox" + i;
                TextBox tb = this.Controls.Find(findKey, true).FirstOrDefault() as TextBox;
                Processes.ElementAt(i).initialSetter(int.Parse(tb.Text));    
            }
            this.Close();
        }
    }
}
