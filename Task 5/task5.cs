using System;

class Student
{
    static int counter = 1;

    public int Id;
    public string Name;
    public double GPA;
    public string Faculty;

    public Student(string name, double gpa, string faculty)
    {
        Id = counter++;
        Name = name;

        if (gpa >= 0 && gpa <= 4)
            GPA = gpa;
        else
            GPA = 0;

        Faculty = faculty;
    }

    public void Print()
    {
        Console.WriteLine($"{Id} | {Name} | {GPA} | {Faculty}");
    }
}

class Registry
{
    Student[] students = new Student[100];
    int count = 0;

    public void Add(Student s)
    {
        if (count < 100)
        {
            students[count] = s;
            count++;
        }
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < count; i++)
            if (students[i].Id == id)
                return students[i];

        return null;
    }

    public void FindByName(string name)
    {
        for (int i = 0; i < count; i++)
            if (students[i].Name == name)
                students[i].Print();
    }

    public void GetTopStudents(int n)
    {
        Student[] copy = new Student[count];

        for (int i = 0; i < count; i++)
            copy[i] = students[i];

        for (int i = 0; i < count - 1; i++)
            for (int j = i + 1; j < count; j++)
                if (copy[i].GPA < copy[j].GPA)
                {
                    var temp = copy[i];
                    copy[i] = copy[j];
                    copy[j] = temp;
                }

        for (int i = 0; i < n && i < count; i++)
            copy[i].Print();
    }

    public void PrintAll()
    {
        for (int i = 0; i < count; i++)
            students[i].Print();
    }
}

class Program
{
    static void Main()
    {
        Registry reg = new Registry();

        while (true)
        {
            Console.WriteLine("\n1.Add 2.FindId 3.FindName 4.Top 5.All 0.Exit");
            string c = Console.ReadLine();

            if (c == "1")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("GPA: ");
                double gpa = double.Parse(Console.ReadLine());

                Console.Write("Faculty: ");
                string f = Console.ReadLine();

                reg.Add(new Student(name, gpa, f));
            }
            else if (c == "2")
            {
                int id = int.Parse(Console.ReadLine());
                var s = reg.FindById(id);
                if (s != null) s.Print();
            }
            else if (c == "3")
            {
                string name = Console.ReadLine();
                reg.FindByName(name);
            }
            else if (c == "4")
            {
                int n = int.Parse(Console.ReadLine());
                reg.GetTopStudents(n);
            }
            else if (c == "5")
            {
                reg.PrintAll();
            }
            else if (c == "0")
                break;
        }
    }
}