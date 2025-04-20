using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Teacher
    {
        private string _name;
        private string _dept;
        private double[] _load = new double[10];

        public Teacher(string name, string dept, double[] load)
        {
            _name = name;
            _dept = dept;
            _load = load ?? throw new ArgumentNullException(nameof(load));
        }

        public string Name => _name;
        public string Dept => _dept;

        public double this[int i]
        {
            get => _load[i];
            set => _load[i] = value;
        }

        public double YearLoad => _load.Sum();
        public double AvgLoad => _load.Average();
        public double First2Avg => _load.Take(2).Average();
        public bool HasAbove(double threshold) => _load.Any(x => x > threshold);
    }
}
