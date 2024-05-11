//1st Question Answer
int[,] Barray = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
int firstSum = 0;
int secondSum = 0;
for (int row = 0; row < 5; row++)
{
    for (int column = 0; column < 5; column++)
    {
        if ((row == 0 && column == 0) || (row == 1 && column == 1) || (row == 2 && column == 2) || (row == 3 && column == 3) || (row == 4 && column == 4))
        {
            firstSum = firstSum + Barray[row, column];
        }
        if ((row == 0 && column == 4) || (row == 1 && column == 3) || (row == 2 && column == 2) || (row == 3 && column == 1) || (row == 4 && column == 0))
        {
            secondSum = secondSum + Barray[row, column];
        }
    }
}
Console.WriteLine("1st Diagonal Sum: " + firstSum);
Console.WriteLine("2nd Diagonal Sum: " + secondSum);





//2nd Question Answer
int[] arr = { 73, 57, 49, 99, 133, 20, 1 };
int temp;
string output = "";
for (int j = 0; j <= arr.Length - 2; j++)
{
    for (int i = 0; i <= arr.Length - 2; i++)
    {
        if (arr[i] < arr[i + 1])
        {
            temp = arr[i + 1];
            arr[i + 1] = arr[i];
            arr[i] = temp;
        }
         output = output + arr [i].ToString() + ",";
    }
}

Console.WriteLine("Numbers in Decending Order:" + output);








//3rd Question Answer
int[] sarray = { 73, 57, 49, 99, 133, 20, 5, 1 };

int biggest = 0, secondBiggest = 0;
for (int i = 0; i < sarray.Length; ++i)
{
    int sarrayItem = sarray[i];
    if (sarrayItem > biggest)
    {
        secondBiggest = biggest;
        biggest = sarrayItem;
    }

    else if (sarrayItem > secondBiggest && sarrayItem < biggest)
    {
        secondBiggest = sarrayItem;
    }

}

Console.WriteLine($"Biggest Number:{biggest}, Second Biggest Number: {secondBiggest}");







//4th Question Answer
Console.WriteLine("Enter a number");
FindPrimeNumber();
void FindPrimeNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    bool isPrime = IsPrime(number);
    if (isPrime)
    {
        Console.WriteLine("Yes");
        FindPrimeNumber ();
    }
    else
    {
        Console.WriteLine("No");
        FindPrimeNumber ();
    }
    Console.Read();
}

 bool IsPrime(int number)
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}