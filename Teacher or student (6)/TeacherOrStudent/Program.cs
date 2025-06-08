using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
    static void Main(string[] args)
    {
        ApplicationSettings settings = new ApplicationSettings();
        UniversityDataManager dataManager = new UniversityDataManager(settings);

        bool dataLoaded = dataManager.LoadDataFromFile();

        if (dataLoaded == false)
        {
            return;
        }

        dataManager.PrintPeopleData(settings.InitialDataHeader);

        dataManager.SortPeopleByLastName();

        dataManager.PrintPeopleData(settings.SortedDataHeader);

        dataManager.PrintStudentsWithMultipleExcellentGrades();

        dataManager.PrintMaxWorkloadForTeachersOverAge();
    }
    }

