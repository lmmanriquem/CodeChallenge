namespace appInsperity
{
    public class Program
    {
        private static void Main()
        {
            List<string> stringInputs = new() { "abaccadcc" };

            foreach (string input in PerfomOperations(stringInputs))
            {
                Console.WriteLine(SortingOperations(input));
            }
            Console.Write("Done!");
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

        public static string SortingOperations(string inputString)
        {
            string outputString = string.Empty;
            Dictionary<char, int> frequencyDictionary = new();

            for (int i = 0; i < inputString.Length; i++)
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