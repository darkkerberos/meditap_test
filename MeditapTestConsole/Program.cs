namespace MeditapTestConsole;

using CommandLine;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(opts =>
            {
                switch (opts.TaskNumber)
                {
                    case 1:
                        // String Reverser
                        Console.WriteLine("Task 1 - String Reverser, input: {0}", opts.InputText);
                        if (opts.InputText == null) {
                            Console.WriteLine("input harus di isi");
                            return;
                        }
                        result = DM_Solution.StringReverser.ReverseString(opts.InputText);
                        Console.WriteLine("hasil: {0}", result);
                        break;
                    case 2:
                        // Palindrome Checker
                        Console.WriteLine("Task 2 - Palindrome Checker, input: {0}", opts.InputText);
                        if (opts.InputText == null) {
                            Console.WriteLine("input harus di isi");
                            return;
                        }
                        result = DM_Solution.PalindromeChecker.IsPalindrome(opts.InputText).ToString();
                        Console.WriteLine("hasil: {0}", result);
                        break;
                    case 3:
                        // PrimeNumber Generator
                        Console.WriteLine("Task 3 - Prime Number Generator, limit: {0}", opts.Limit);
                        if (opts.Limit == 0) {
                            Console.WriteLine("limit harus di isi");
                            return;
                        }
                        List<int> primeNum = DM_Solution.PrimeNumberGenerator.GeneratePrimes(opts.Limit);
                        foreach (var x in primeNum){
                            Console.WriteLine("{0} ",x);
                        }
                        break;
                    default:
                        Console.WriteLine("Task {0} tidak ada", opts.TaskNumber);
                        break;
                }
            });
        return;
    }
}

class Options
{
    [Option('t', "task-number", Required = true, HelpText = "Task Number 1, 2 atau 3")]
    public int TaskNumber { get; set; }

    [Option('i', "input", Required = false, HelpText = "Input text")]
    public string? InputText { get; set; }

    [Option('l', "limit", Required = false, HelpText = "Limit generate prime number")]
    public int Limit { get; set; }

}