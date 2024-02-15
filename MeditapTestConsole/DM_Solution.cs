namespace MeditapTestConsole;

public class DM_Solution
{
    public class StringReverser
    {
        public static string ReverseString(string inputStr)
        {
            string reversedString;
            // manipulasi string menjadi array char
            char[] charArray = inputStr.ToCharArray();
            // array input dibalik menggunakan fungsi bawaan
            Array.Reverse(charArray);
            // array yang sudah dibalik di tampung dalam string lalu di return
            reversedString = new string(charArray);
            return reversedString;
        }
    }

    public class PalindromeChecker
    {
        public static bool IsPalindrome(string inputStr)
        {
            // rubah input  string menjadi huruf kecil
            inputStr = inputStr.ToLower();
            // hapus spasi dan karakter symbol menggunakan regex
            inputStr = System.Text.RegularExpressions.Regex.Replace(inputStr, "[^a-z0-9]", "");
            // balik kata menggunakan fungsi reverseString()
            string revStr = StringReverser.ReverseString(inputStr);
            // jika hasilnya sama maka palindromenya adalah TRUE
            if (inputStr == revStr)
            {
                return true;
            }
            return false;
        }
    }

    public class PrimeNumberGenerator
    {
        public static List<int> GeneratePrimes(int limit)
        {
            // karena 1 bukan bilangan prima, maka return kosong
            if (limit < 2)
                return new List<int>();

            List<int> primesList = new List<int>();
            
            // default bil. prima pertama adalah 2
            // looping sesuai limit
            for (int x = 2; x <= limit; x++)
            {
                bool isPrima = true;
                // cek setiap x mod y = 0
                for (int y = 2; y < x; y++)
                {
                    if ((x % y) == 0)
                    {
                        // jika 0 maka di set false
                        isPrima = false;
                        break;
                    }                    
                }
                if (isPrima) 
                    // jika true maka tambahkan kedalam array
                    primesList.Add(x);
            }

            return primesList;
        }
    }
}
