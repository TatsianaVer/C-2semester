using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ApplicationSettings
    {
        private int _currentYear;
        private int _minAgeForRedColor;
        private int _excellentGrade;
        private int _minAgeForWorkloadCheck;
        private string _studentStatus;
        private string _teacherStatus;
        private char _dataSeparator;
        private string _dataFilePath;
        private ConsoleColor _warningColor;
        private string _tableSeparator;
        private string _columnSeparator;
        private string _headerSeparator;
        private int _columnWidth;
        private string _fileNotFoundMessage;
        private string _fileReadErrorMessage;
        private string _studentsWithExcellentGradesHeader;
        private string _noExcellentStudentsMessage;
        private string _excellentGradesFormat;
        private string _initialDataHeader;
        private string _sortedDataHeader;
        private string _maxWorkloadMessage;
        private string _ageInfoFormat;
        private string _averageGradeFormat;
        private string _workloadInfoFormat;
        private string _lastNameHeader;
        private string _statusHeader;
        private string _additionalInfoHeader;
    private string _nullGradesArray;

        public ApplicationSettings()
        {
            _currentYear = 2025;
            _minAgeForRedColor = 19;
            _excellentGrade = 9;
            _minAgeForWorkloadCheck = 40;
            _studentStatus = "Student";
            _teacherStatus = "Teacher";
            _dataSeparator = ' ';
            _dataFilePath = @"C:\Users\tatan\Documents\GitHub\C-2semester\Teacher or student (6)\TeacherOrStudent\university_data.txt";
            _warningColor = ConsoleColor.Red;
            _tableSeparator = "|";
            _columnSeparator = " | ";
            _headerSeparator = "|---|---|---|";
            _columnWidth = 15;
            _fileNotFoundMessage = "Error: Data file not found";
            _fileReadErrorMessage = "Students with multiple excellent grades:";
            _noExcellentStudentsMessage = "No students with multiple excellent grades found";
            _excellentGradesFormat = "{0} - {1} excellent grades";
            _initialDataHeader = "Initial data:";
            _sortedDataHeader = "Sorted by last name:";
            _maxWorkloadMessage = "Max workload for teachers over 40: {0} hours";
            _ageInfoFormat = "{0} years";
            _averageGradeFormat = "Average grade: {0:F1}";
            _workloadInfoFormat = "Total workload: {0} hours";
            _lastNameHeader = "Last Name";
            _statusHeader = "Status";
            _additionalInfoHeader = "Additional Info";
        _nullGradesArray = "Grades array cannot be null.";
        }

        public int CurrentYear
        {
            get
            { 
                return _currentYear;
            }
        }

        public int MinAgeForRedColor
        {
            get
            {
                return _minAgeForRedColor;
            }
        }
        
        public int ExcellentGrade
        {
            get
            {
                return _excellentGrade;
            }
        }

        public int MinAgeWorkloadCheck
        {
            get
            {
                return _minAgeForWorkloadCheck;
            }
        }

        public string StudentStatus
        {
            get
            {
                return _studentStatus;
            }
        }

        public string TeacherStatus
        {
            get
            {
                return _teacherStatus;
            }
        }

        public char DataSeparator
        {
            get
            {
                return _dataSeparator;
            }
        }

        public string DataFilePath
        {
            get
            {
                return _dataFilePath;
            }
        }

        public ConsoleColor WarningColor
        {
            get
            {
                return _warningColor;
            }
        }

        public string TableSeparator
        {
            get
            {
                return _tableSeparator;
            }
        }

        public string ColumnSeparator
        {
            get
            {
                return _columnSeparator;
            }
        }

        public string HeaderSeparator
        {
            get
            {
                return _headerSeparator;
            }
        }

        public int ColumnWidth
        {
            get
            {
                return _columnWidth;
            }
        }

        public string FileNotFoundMessage
        {
            get
            {
                return _fileNotFoundMessage;
            }
        }

        public string FileReadErrorMessage
        {
            get
            {
                return _fileReadErrorMessage;
            }
        }

        public string StudentsWithExcellentGradesHeader
        {
            get
            {
                return _studentsWithExcellentGradesHeader;
            }
        }

        public string NoExcellentStudentsMessage
        {
            get 
            { 
                return _noExcellentStudentsMessage; 
            }
        }

        public string ExcellentGradesFormat
        {
            get 
            { 
                return _excellentGradesFormat; 
            }
        }

        public string InitialDataHeader
        {
            get 
            { 
                return _initialDataHeader; 
            }
        }

        public string SortedDataHeader
        {
            get 
            { 
                return _sortedDataHeader; 
            }
        }

        public string MaxWorkloadMessage
        {
            get 
            { 
                return _maxWorkloadMessage; 
            }
        }

        public string AgeInfoFormat
        {
            get 
            { 
                return _ageInfoFormat; 
            }
        }

        public string AverageGradeFormat
        {
            get 
            { 
                return _averageGradeFormat; 
            }
        }

        public string WorkloadInfoFormat
        {
            get 
            { 
                return _workloadInfoFormat; 
            }
        }

        public string LastNameHeader
        {
            get 
            { 
                return _lastNameHeader; 
            }
        }

        public string StatusHeader
        {
            get 
            { 
                return _statusHeader; 
            }
        }

        public string AdditionalInfoHeader
        {
            get 
            { 
                return _additionalInfoHeader; 
            }
        }
    public string NullGradesArray
    {
        get
        {
            return _nullGradesArray;
        }
    }
    }