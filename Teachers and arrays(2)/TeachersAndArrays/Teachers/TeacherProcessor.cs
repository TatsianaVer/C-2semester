using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace Teacher 
{
    public class TeacherProcessor
    {
        private readonly string _lastName;
        private readonly string _department;
        private readonly int[] _monthlyWorkload;

        public TeacherProcessor(string lastName, string department, int[] monthlyWorkload)
        {
            if (monthlyWorkload.Length != 10)
            {
                throw new ArgumentException(AppConstants.WorkloadError);
            }

            _lastName = lastName 
                ?? throw new ArgumentNullException(nameof(lastName));
            _department = department
                ?? throw new ArgumentNullException(nameof(department));
            _monthlyWorkload = monthlyWorkload;
        }

        public string LastName => _lastName;
        public string Department => _department;
        public int AnnualWorkload => _monthlyWorkload.Sum();

        public int this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException(AppConstants.MonthIndexError);
                }

                return _monthlyWorkload[index];
            }
        }

        public IEnumerable<int> MonthlyWorkload => _monthlyWorkload;
    }
}
