using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interept_Handler
{
    class Process
    {
        public int ID;
        public string[] Data;
        public int proRunned;
        public Process(int id)
        {
            ID = id;
            Data = new string[10];
            proRunned = 0;
            initial();
        }
        void initial()
        {
            for(int i = 0; i < 10; i++)
            {
                Data[i] = string.Format("P{0}[{1}]",(ID+1) , (i+1));
            }
        }

    }
}
