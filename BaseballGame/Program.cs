int result=CalPoints(new string[] {"5","2","C","D","+" });
int result2=CalPoints2(new string[] {"5","2","C","D","+" });

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

int CalPoints2(string[] ops)
{
    Stack<int> record = new Stack<int>();

    foreach (string op in ops)
    {
        if (op == "C")
        {
            record.Pop();
        }
        else if (op == "D")
        {
            record.Push(2 * record.Peek());
        }
        else if (op == "+")
        {
            int top = record.Pop();
            int newTop = top + record.Peek();
            record.Push(top);           // Push the first popped back
            record.Push(newTop);        // Push the new sum
        }
        else
        {
            record.Push(int.Parse(op));
        }
    }

    int total = 0;
    foreach (int score in record)
    {
        total += score;
    }

    return total;
}