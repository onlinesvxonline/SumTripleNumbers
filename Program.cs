namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] numbers = { 2, 7, 5, 1, 3, 8, 6, 4 };
                int targetSum = 10;

                List<List<int>> result = FindThreeSum(numbers, targetSum);

                Console.WriteLine("Три чисел, сумма которых равна " + targetSum + ":");
                Console.WriteLine();
                foreach (var triplet in result)
                {
                    Console.WriteLine(string.Join(" + ", triplet));
                }
            }

            static List<List<int>> FindThreeSum(int[] numbers, int targetSum)
            {
                Array.Sort(numbers);
                List<List<int>> result = new List<List<int>>();

                for (int i = 0; i < numbers.Length - 2; i++)
                {
                    int left = i + 1;
                    int right = numbers.Length - 1;

                    while (left < right)
                    {
                        int currentSum = numbers[i] + numbers[left] + numbers[right];

                        if (currentSum == targetSum)
                        {
                            result.Add(new List<int> { numbers[i], numbers[left], numbers[right] });
                            left++;
                            right--;
                        }
                        else if (currentSum < targetSum)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }

                return result;
            }
        }
    }
}
