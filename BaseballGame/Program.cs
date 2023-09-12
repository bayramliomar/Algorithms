int result=CalPoints(new string[] {"5","2","C","D","+" });

Console.ReadLine();

int CalPoints(string[] ops)
{
	int length=ops.Length;
	List<int> totalPoints = new();
	for (int i = 0; i < length; i++)
	{
		if (ops[i] == "C") totalPoints.Remove(totalPoints[totalPoints.Count - 1]);
		else if (ops[i] == "D") totalPoints.Add(totalPoints[totalPoints.Count-1] * 2);
		else if (ops[i] == "+") totalPoints.Add(totalPoints[totalPoints.Count - 1] + totalPoints[totalPoints.Count - 2]);
		else totalPoints.Add(int.Parse(ops[i]));

    }
    return totalPoints.Sum();
}