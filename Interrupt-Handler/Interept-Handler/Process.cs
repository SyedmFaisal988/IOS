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
        public int QuantumRunned;
        internal int ExeTime;
        public Process(int id)
        {
            ID = id;
            Data = new string[15];
            QuantumRunned = 0;
        }
        internal void initialSetter(int exeTime)
        {
            for(int i = 0; i < exeTime; i++)
            {
                Data[i] = string.Format("P{0}[{1}]",(ID+1) , (i+1));
                ExeTime = exeTime;
            }
        }
        internal void initialDefault()
        {
            for (int i = 0; i < 10; i++)
            {
                Data[i] = string.Format("P{0}[{1}]", (ID + 1), (i + 1));
                ExeTime = 10;
            }
        }

    }
}
