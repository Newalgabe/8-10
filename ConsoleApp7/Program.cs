// task 8
//class Student
//{
//    public string LastName { get; set; }
//    public string FirstName { get; set; }
//    public string MiddleName { get; set; }
//    public string Group { get; set; }
//    public int Age { get; set; }
//    public int[][] Grades { get; set; }

//    public Student(string lastName, string firstName, string middleName, string group, int age)
//    {
//        LastName = lastName;
//        FirstName = firstName;
//        MiddleName = middleName;
//        Group = group;
//        Age = age;

//        Grades = new int[3][];
//        for (int i = 0; i < 3; i++)
//        {
//            Grades[i] = new int[5];
//        }
//    }

//    public void SetGrade(int subjectIndex, int gradeIndex, int grade)
//    {
//        if (subjectIndex >= 0 && subjectIndex < 3 && gradeIndex >= 0 && gradeIndex < 5)
//        {
//            Grades[subjectIndex][gradeIndex] = grade;
//        }
//    }

//    public double GetAverageGrade(int subjectIndex)
//    {
//        if (subjectIndex >= 0 && subjectIndex < 3)
//        {
//            int[] subjectGrades = Grades[subjectIndex];
//            double sum = 0;
//            foreach (int grade in subjectGrades)
//            {
//                sum += grade;
//            }
//            return sum / subjectGrades.Length;
//        }
//        return 0;
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Last Name: {LastName}");
//        Console.WriteLine($"First Name: {FirstName}");
//        Console.WriteLine($"Middle Name: {MiddleName}");
//        Console.WriteLine($"Group: {Group}");
//        Console.WriteLine($"Age: {Age}");

//        for (int i = 0; i < 3; i++)
//        {
//            string subjectName;
//            switch (i)
//            {
//                case 0:
//                    subjectName = "Programming";
//                    break;
//                case 1:
//                    subjectName = "Administration";
//                    break;
//                case 2:
//                    subjectName = "Design";
//                    break;
//                default:
//                    subjectName = "Unknown Subject";
//                    break;
//            }
//            Console.WriteLine($"{subjectName}: Average Grade - {GetAverageGrade(i)}");
//        }
//    }

//    static void Main(string[] args)
//    {
//        Student student = new Student("Smith", "John", "Robert", "CS101", 20);

//        student.SetGrade(0, 0, 95);
//        student.SetGrade(0, 1, 88);
//        student.SetGrade(1, 0, 76);
//        student.SetGrade(1, 1, 89);
//        student.SetGrade(2, 0, 92);
//        student.SetGrade(2, 1, 85);

//        Console.WriteLine("Student Information:");
//        student.PrintInfo();
//    }
//}



// task 9
//class Wonder
//{
//    public string Name { get; set; }
//    public string Description { get; set; }

//    public Wonder(string name, string description)
//    {
//        Name = name;
//        Description = description;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Wonder Name: {Name}");
//        Console.WriteLine($"Description: {Description}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Wonder wonder1 = new Wonder("Great Pyramid of Giza", "Ancient structure in Egypt.");
//        Wonder wonder2 = new Wonder("Galápagos Islands", "Archipelago in the Pacific Ocean.");
//        Wonder wonder3 = new Wonder("Christ the Redeemer", "Statue in Rio de Janeiro, Brazil.");

//        Console.WriteLine("Information about the 7 Wonders of the World:");
//        wonder1.DisplayInfo();
//        wonder2.DisplayInfo();
//        wonder3.DisplayInfo();
//    }
//}


// task 10
//namespace CapitalPopulationComparison
//{
//    namespace Countries
//    {
//        class Country
//        {
//            public string Name { get; set; }
//            public Capital Capital { get; set; }
//        }

//        class Capital
//        {
//            public string Name { get; set; }
//            public long Population { get; set; }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Countries.Country country1 = new Countries.Country
//            {
//                Name = "Russia",
//                Capital = new Countries.Capital { Name = "Moscow", Population = 12692466 }
//            };

//            Countries.Country country2 = new Countries.Country
//            {
//                Name = "USA",
//                Capital = new Countries.Capital { Name = "Washington, D.C.", Population = 705749 }
//            };

//            Countries.Country country3 = new Countries.Country
//            {
//                Name = "France",
//                Capital = new Countries.Capital { Name = "Paris", Population = 2148271 }
//            };

//            Console.WriteLine("Capital Population Comparison:");
//            Console.WriteLine($"{country1.Capital.Name} ({country1.Name}): {country1.Capital.Population} people");
//            Console.WriteLine($"{country2.Capital.Name} ({country2.Name}): {country2.Capital.Population} people");
//            Console.WriteLine($"{country3.Capital.Name} ({country3.Name}): {country3.Capital.Population} people");
//        }
//    }
//}