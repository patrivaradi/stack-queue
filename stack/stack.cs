﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class stack
    {
        int[] values;
        public stack()
        {
            values = new int[0];
        }
        public void Push(int ValueToAdd)
        {
            int[] temp = new int[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                temp[i + 1] = values[i];
            }
            temp[0] = ValueToAdd;
            values = temp;
        }
        public int Pop()
        {
            int toReturn = values[0];
            int[] temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length-1; i++)
            {
                temp[i] = values[i + 1];
            }
            values = temp;
            return toReturn;
        }
        public void View()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
        }
    }
}
