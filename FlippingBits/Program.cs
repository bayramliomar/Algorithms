long a = FlippingBits(2);

Console.ReadLine();

static long FlippingBits(long n)
{
    string binaryNumber = DecimalToBinary(n);
    long invertedNumber = ~n;
    string reversedBinary = DecimalToBinary(invertedNumber);
    long result = BinaryToDecimal(reversedBinary);
    return result;
}

static string DecimalToBinary(long binaryNumber)
{
    int numBits = 32;
    long[] binaryArray = new long[numBits];
    if (binaryNumber > 0)
    {
        for (int i = numBits - 1; i >= 0; i--)
        {
            binaryArray[i] = binaryNumber % 2;
            binaryNumber /= 2;
        }
    }
    else
    {
        long absoluteValue = Math.Abs(binaryNumber);
        for (int i = numBits - 1; i >= 0; i--)
        {
            binaryArray[i] = absoluteValue % 2;
            absoluteValue /= 2;
        }
        binaryArray = InvertBits(binaryArray, numBits);
        Increase(binaryArray, numBits);
    }
    // Convert binary array back to string
    string binaryString = string.Join("", binaryArray);
    return binaryString;
}

static long BinaryToDecimal(string binaryNumber)
{
    long result = 0;
    for (int i = binaryNumber.Length - 1, count = 0; i >= 0; i--, count++)
    {
        if (binaryNumber[i] == '1')
            result += (long)Math.Pow(2, count);
    }

    return result;
}

static long[] InvertBits(long[] binaryArray, int numBits)
{
    for (int i = 0; i < numBits; i++)
    {
        binaryArray[i] = binaryArray[i] == 0 ? 1 : 0;
    }
    return binaryArray;
}

static void Increase(long[] binaryArray, int numBits)
{
    long carry = 1;
    for (int i = numBits - 1; i >= 0; i--)
    {
        long sum = binaryArray[i] + carry;
        binaryArray[i] = sum % 2;
        carry = sum / 2;
    }
}