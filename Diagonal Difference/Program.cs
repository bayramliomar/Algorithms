/*
Given a square matrix, calculate the absolute difference between the sums of its diagonals.
For example, the square  matrix arr is shown below:
1 2 3
4 5 6
9 8 9  
The left-to-right diagonal = 1+5+9=15
The right to left diagonal =3+5+9=17
Their absolute difference is |17-15|=2.
 */

DiagonalDifference(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 9, 8, 9 } });


Console.ReadLine();
static int DiagonalDifference(List<List<int>> arr)
{
    int right2Left = 0;
    int left2Right = 0;
    int length = arr.Count - 1;
    for (int i = 0; i < arr.Count; i++)
    {
        left2Right += arr[i][i];
        right2Left += arr[i][length--];
    }
    return Math.Abs(right2Left - left2Right);
}