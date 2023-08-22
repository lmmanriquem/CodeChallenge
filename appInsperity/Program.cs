using static System.Runtime.InteropServices.JavaScript.JSType;

namespace appInsperity
{
    public class Program
    {
        private static void Main()
        {
            string? answer = "S";

            while (answer.ToUpper().Equals("S"))
            {
                answer = UserInteraction();
            }
        }

        private static string UserInteraction()
        {
            int number;
            List<string?> stringInputsByUser = new();
            

            Console.WriteLine("---- Code Challenge ----");

            while (true)
            {
                Console.Write("Please enter a number: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out number))
                    break;
                else
                    Console.Write("Invalid input. Please enter a valid number.");
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter Input String N° {i + 1} : ");
                stringInputsByUser.Add(Console.ReadLine());
            }

            Console.WriteLine("---- PerfomOperations ----");

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"N° {i + 1} : Input : {stringInputsByUser[i]?.PadRight(20)} - Output : {SortingOperations(stringInputsByUser[i]),-20}");
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Console.Write("Press S to perform another Action or Press Any Other Key to Exit : ");
            string? answer = Console.ReadLine();

            return answer ?? string.Empty;

        }

        public static List<string> PerfomOperations(List<string> stringInputs)
        {
            List<string> stringOutputs = new();
            foreach (string input in stringInputs)
            {
                stringOutputs.Add(SortingOperations(input));
            }
            return stringOutputs;
        }

        public static string SortingOperations(string? inputString)
        {
            string outputString = string.Empty;
            Dictionary<char, int> frequencyDictionary = new();

            for (int i = 0; i < inputString?.Length; i++)
            {
                if (frequencyDictionary.ContainsKey(inputString[i]))
                {
                    frequencyDictionary[inputString[i]]++;
                }
                else
                {
                    frequencyDictionary[inputString[i]] = 1;
                }
            }

            var sortedDict = frequencyDictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in sortedDict)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    outputString += kvp.Key;
                }
            }

            return outputString;
        }
    }
}