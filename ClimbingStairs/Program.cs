Console.WriteLine(ClimbStairs(6));

int ClimbStairs(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 2;

    // Initialize variables to store the ways to climb the last two steps
    int oneStepBefore = 2; // Ways to climb 2 stairs
    int twoStepsBefore = 1; // Ways to climb 1 stair
    int allWays = 0;

    // Calculate ways for all stairs from 3 to n
    for (int i = 3; i <= n; i++)
    {
        allWays = oneStepBefore + twoStepsBefore;
        twoStepsBefore = oneStepBefore;
        oneStepBefore = allWays;
    }

    return allWays;
}


Console.ReadLine();