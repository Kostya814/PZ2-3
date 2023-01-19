using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2_3
{
    class Product
    {
        private int _first;
        private double _second;
        public Product(int first, double second) 
        {
            _first = first;
            _second = second;
        }
        public Product()
        { 
        
        }
       
        public int First 
        { 
            get 
            { 
                return _first; 
            } 
            set 
            { 
                if (value>0)
                    _first = value;
            } 
        }
        
        public double Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value > 0)
                    _second = value;
            }
        }
        public void power()
        {
            double sum = (_second*10) * _first; 
            Console.WriteLine(sum);
        }
        public void Read() 
        {
            _first = Convert.ToInt32(Console.ReadLine());
            _second = Convert.ToDouble(Console.ReadLine());
        }

        public void Display() 
        {
            Console.WriteLine($"Калорийность продукта на 100 г {_first} килокаллорий \n Масса продукта {_second}" );
        }

    }
}
