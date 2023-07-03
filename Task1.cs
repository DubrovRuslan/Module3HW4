using System;
using System.Collections.Generic;

namespace Module3HW4
{
    public class Task1
    {
        private List<double> _results = new List<double>();
        public event Func<double, double, double> MyEvent;

        public double SumResult
        {
            get
            {
                var sumResult = 0.0;
                foreach (var item in _results)
                {
                    sumResult += item;
                }

                return sumResult;
            }
        }

        public void Subscribe()
        {
            MyEvent += Sum;
            MyEvent += Sum;
        }

        public void Run()
        {
            TryMethod(() => MyEvent(3, 5));
        }

        public static void TryMethod(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private double Sum(double x, double y)
        {
            var result = x + y;
            _results.Add(result);
            return result;
        }
    }
}
