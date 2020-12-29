using System;
using System.IO;

namespace ReadInput
{
    public class ReadInput
    {        

        public  StreamReader ReadInputFile()
        {
            var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\ReadInput\input.txt");
            reader.ReadToEnd();
            return reader;
        }

        // usage
        /*
        var readerIn = new ReadInput.ReadInput();
        var reader = readerIn.ReadInputFile();
        */
    }
}
