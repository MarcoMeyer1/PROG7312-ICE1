using System;

namespace IndexProgram
{
    public class Index
    {
        private int[] data;
        public int this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        public Index(int size)
        {
            data = new int[size];
        }

        public void Display()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
