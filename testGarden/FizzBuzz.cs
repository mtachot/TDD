namespace testGarden
{
    public class FizzBuzz
    {
        Printer printer;

        public FizzBuzz(Printer _printer)
        {
            printer = _printer;
        }

        public string FizzBuzzMe(int number)
        {
            string result = "";
            if (number % 3 == 0) { result = "Fizz"; }
            if (number % 5 == 0) { result += "Buzz"; }
            if (string.IsNullOrEmpty(result)) result = number.ToString();
            return result;
        }

        public void FizzBuzzMeConsole(int number)
        {
            string result = "";
            if (number % 3 == 0) { result = "Fizz"; }
            if (number % 5 == 0) { result += "Buzz"; }
            if (string.IsNullOrEmpty(result)) result = number.ToString();
            printer.Print(result);
        }
    }
}