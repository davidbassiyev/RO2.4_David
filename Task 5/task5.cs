Registry registry = new Registry();
bool running = true;

while (running)
{
    Console.WriteLine("\n1. Add student");
    Console.WriteLine("2. Find by ID");
    Console.WriteLine("3. Find by name");
    Console.WriteLine("4. Top N students");
    Console.WriteLine("5. Print all");
    Console.WriteLine("6. Exit");
    Console.Write("Choice: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Faculty: ");
        string faculty = Console.ReadLine();

        Console.Write("GPA (0.0 - 4.0): ");
        double gpa = double.Parse(Console.ReadLine());

        if (gpa < 0.0 || gpa > 4.0)
        {
            Console.WriteLine("Invalid GPA.");
        }
        else
        {
            registry.Add(new Student(name, faculty, gpa));
            Console.WriteLine("Student added.");
        }
    }
    else if (choice == "2")
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Student found = registry.FindById(id);
        if (found == null)
            Console.WriteLine("Not found.");
        else
            Console.WriteLine(found.GetInfo());
    }
    else if (choice == "3")
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Student[] results = registry.FindByName(name);
        if (results.Length == 0)
            Console.WriteLine("Not found.");
        else
            foreach (Student s in results)
                Console.WriteLine(s.GetInfo());
    }
    else if (choice == "4")
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Student[] top = registry.GetTopStudents(n);
        for (int i = 0; i < top.Length; i++)
            Console.WriteLine($"#{i + 1} {top[i].GetInfo()}");
    }
    else if (choice == "5")
    {
        registry.PrintAll();
    }
    else if (choice == "6")
    {
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }
}

class Student
{
    private static int _nextId = 1;
    private double _gpa;

    public int StudentId { get; }
    public string Name { get; set; }
    public string Faculty { get; set; }

    public double GPA
    {
        get => _gpa;
        set
        {
            if (value < 0.0 || value > 4.0)
                throw new ArgumentException("GPA must be 0.0 - 4.0");
            _gpa = value;
        }
    }

    public Student(string name, string faculty, double gpa)
    {
        StudentId = _nextId++;
        Name = name;
        Faculty = faculty;
        GPA = gpa;
    }

    public string GetInfo()
    {
        return $"ID: {StudentId} | {Name} | {Faculty} | GPA: {GPA:F2}";
    }
}

class Registry
{
    private Student[] _students = new Student[100];
    private int _count = 0;

    public void Add(Student student)
    {
        if (_count >= 100)
        {
            Console.WriteLine("Registry is full.");
            return;
        }
        _students[_count++] = student;
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < _count; i++)
            if (_students[i].StudentId == id)
                return _students[i];
        return null;
    }

    public Student[] FindByName(string name)
    {
        int count = 0;
        for (int i = 0; i < _count; i++)
            if (_students[i].Name.ToLower().Contains(name.ToLower()))
                count++;

        Student[] result = new Student[count];
        int idx = 0;
        for (int i = 0; i < _count; i++)
            if (_students[i].Name.ToLower().Contains(name.ToLower()))
                result[idx++] = _students[i];

        return result;
    }

    public Student[] GetTopStudents(int n)
    {
        Student[] sorted = new Student[_count];
        for (int i = 0; i < _count; i++)
            sorted[i] = _students[i];

        for (int i = 0; i < sorted.Length - 1; i++)
            for (int j = 0; j < sorted.Length - 1 - i; j++)
                if (sorted[j].GPA < sorted[j + 1].GPA)
                    (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);

        int take = Math.Min(n, _count);
        Student[] top = new Student[take];
        for (int i = 0; i < take; i++)
            top[i] = sorted[i];

        return top;
    }

    public void PrintAll()
    {
        if (_count == 0)
        {
            Console.WriteLine("No students.");
            return;
        }
        for (int i = 0; i < _count; i++)
            Console.WriteLine(_students[i].GetInfo());
    }
}
