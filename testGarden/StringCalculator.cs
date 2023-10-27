namespace testGarden
{
    public class StringCalculator
    {
        public int Add(string args)
        {
            if(!string.IsNullOrEmpty(args))
            {
                string delimiter = ParseDelimiter(args);
                List<string> argsStringList = SplitArgs(args, delimiter);
                List<int> intArgs = ParseList(argsStringList);
                return intArgs.Sum();
            }
            return 0;
        }

        public List<int> ParseList(List<string> argsList)
        {
            List<int> resultList = new List<int>();
            foreach (string arg in argsList)
            {
                resultList.Add(int.Parse(arg));
            }
            return resultList;
        }

        public List<string> SplitArgs(string args, string delimiter)
        {
            if (!string.IsNullOrEmpty(delimiter))
            {
                args = args.Replace("//" + delimiter + "\n", "");
                return args.Split(new[] { delimiter }, StringSplitOptions.None).ToList<string>();
            }
            return args.Split(new char[] { ',', '\n' }).ToList<string>();
        }

        public string ParseDelimiter(string args)
        {
            if (!args.StartsWith("//")) return "";

            string delimiter = args.Split('\n')[0];
            return delimiter.Replace("//", "");
        }
    }
}
