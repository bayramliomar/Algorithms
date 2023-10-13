GradingStudents(new List<int> { 73, 67, 38, 33 });

Console.ReadLine();

static List<int> GradingStudents(List<int> grades)
{
    int length = grades.Count;
    if (!(length >= 1 && length <= 60)) return null;
    for (int i = 0; i < length; i++)
    {
        if (grades[i] >= 0 && grades[i] <= 100 && grades[i] >= 38)
        {
            int difference = 5 - (grades[i] % 5);
            if (difference < 3) grades[i] += difference;

        }
    }
    return grades;
}