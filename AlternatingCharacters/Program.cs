using System;

class Solution
{

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s)
    {
        var count = 0;
        var currentChar = s[0];

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (currentChar == 'A')
            {
                if (s[i + 1] == 'A')
                {
                    count++;
                }
                else
                {
                    currentChar = 'B';
                }
            }

            else if (currentChar == 'B')
            {
                if (s[i + 1] == 'B')
                {
                    count++;
                }
                else
                {
                    currentChar = 'A';
                }
            }


        }

        return count;

    }

    static void Main(string[] args)
    {
        var reader = BasicApp.Program.ReadFile();

        int q = Convert.ToInt32(reader.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = reader.ReadLine();

            int result = alternatingCharacters(s);

            Console.WriteLine($"{result}");

        }       
    }
}

