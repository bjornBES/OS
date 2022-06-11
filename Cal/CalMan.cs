using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.calculator
{
    public class calculatorMan
    {
        public int[] Cal;
        public string[] Op;
        public int Output;
        public void StartCal()
        {
            int NewCal = 0;
            for (int o = 0; o < Op.Length; o++)
            {
                if (Op[o] == "*")
                {
                    if(o == Op.Length - 1 && Cal.Length >= 3)
                        NewCal = NewCal * Cal[o + 1];
                    else if(o != Op.Length - 1)
                        NewCal = Cal[o] * Cal[o + 1];
                }
                if (Op[o] == "/")
                {
                    if (o == Op.Length - 1 && Cal.Length >= 3)
                        NewCal = NewCal / Cal[o + 1];
                    else if (o != Op.Length - 1)
                        NewCal = Cal[o] / Cal[o + 1];
                }
                if (Op[o] == "+")
                {
                    if (o == Op.Length - 1 && Cal.Length >= 3)
                        NewCal = NewCal + Cal[o + 1];
                    else if (o != Op.Length - 1)
                        NewCal = Cal[o] + Cal[o + 1];
                }
                if (Op[o] == "-")
                {
                    if (o == Op.Length - 1 && Cal.Length >= 3)
                        NewCal = NewCal - Cal[o + 1];
                    else if (o != Op.Length - 1)
                        NewCal = Cal[o] - Cal[o + 1];
                }
            }
            Output = NewCal ;
        }
        public void OutPut()
        {

        }
        string[] Nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void SetNumber(string Code)
        {
            string[] S_Code = Code.Split(' ');
            int OpIndex = 0;
            for (int i = 0; i < S_Code.Length; i++)
            {
                if (S_Code[i] == "+")
                {
                    OpIndex++;
                }    
                if (S_Code[i] == "-")
                {
                    OpIndex++;
                }
                if (S_Code[i] == "*")
                {
                    OpIndex++;
                }
                if (S_Code[i] == "/")
                {
                    OpIndex++;
                }
            }
            Cal = new int[OpIndex + 1];
            Op = new string[OpIndex];
            OpIndex = 0;
            for (int i = 0; i < S_Code.Length; i++)
            {
                if (S_Code[i] == "+")
                {
                    Op[OpIndex] = S_Code[i];
                    OpIndex++;
                }
                if (S_Code[i] == "-")
                {
                    Op[OpIndex] = S_Code[i];
                    OpIndex++;
                }
                if (S_Code[i] == "*")
                {
                    Op[OpIndex] = S_Code[i];
                    OpIndex++;
                }
                if (S_Code[i] == "/")
                {
                    Op[OpIndex] = S_Code[i];
                    OpIndex++;
                }
            }
            string[] Sop = { "*", "/", "-", "+" };
            Array.Sort(Op, Sop);
            Array.Sort(S_Code, Sop);
            int CalIndex = 0;
            for (int i = 0; i < S_Code.Length; i++)
            {
                if (S_Code[i] == "*")
                {
                    if (CalIndex == 0 && i == 0)
                    {
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i - 1]);
                        CalIndex++;
                    }
                    else if (i >= 1)
                    {
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i - 1]);
                        CalIndex++;
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i + 1]);
                        CalIndex++;
                    }
                }
            }
            for (int i = 0; i < S_Code.Length; i++)
            {
                if (S_Code[i] == "/")
                {
                    if (CalIndex == 0 && i == 0)
                    {
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i - 1]);
                        CalIndex++;
                    }
                    else if(i >= 1)
                    {
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i - 1]);
                        CalIndex++;
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i + 1]);
                        CalIndex++;
                    }
                }
            }
            for (int i = 0; i < S_Code.Length; i++)
            {
                if (S_Code[i] == "+")
                {
                    if (CalIndex == 0 || CalIndex == Cal.Length - 1)
                    {
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i - 1]);
                        CalIndex++;
                    }
                    else
                    {
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i - 1]);
                        CalIndex++;
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i + 1]);
                        CalIndex++;
                    }
                }
            }
            for (int i = 0; i < S_Code.Length; i++)
            {
                if (S_Code[i] == "-")
                {
                    if (CalIndex == 0 || CalIndex == Cal.Length - 2)
                    {
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i - 1]);
                        CalIndex++;
                    }
                    else
                    {
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i - 1]);
                        CalIndex++;
                        Cal[CalIndex] = Convert.ToInt32(S_Code[i + 1]);
                        CalIndex++;
                    }
                }
            }
        }
    }
}
