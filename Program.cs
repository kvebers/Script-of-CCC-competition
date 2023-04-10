using System;

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\karli\\source\\repos\\Test\\Test\\txt.txt";
        string outputFilePath = "C:\\Users\\karli\\source\\repos\\Test\\Test\\output.txt";
        if (File.Exists(filePath))
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    using (StreamWriter sw = new StreamWriter(outputFilePath))
                    {
                        string line;
                        string outputLine = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            string inputLine = line;
                            int i = 0;
                            while (i < 2)
                            {
                                if (i > 0)
                                {
                                    inputLine = outputLine;
                                    outputLine = "";
                                }
                                else
                                {
                                    inputLine = line;
                                    outputLine = "";
                                }
                                for (int j = 0; j < inputLine.Length; j += 2)
                                {
                                    string currentChars = inputLine.Substring(j, 2);

                                    if (currentChars == "RR")
                                    {
                                        outputLine += "R";
                                    }
                                    else if (currentChars == "PP")
                                    {
                                        outputLine += "P";
                                    }
                                    else if (currentChars == "SS")
                                    {
                                        outputLine += "S";
                                    }
                                    else if (currentChars == "SP")
                                    {
                                        outputLine += "S";
                                    }
                                    else if (currentChars == "PS")
                                    {
                                        outputLine += "S";
                                    }
                                    else if (currentChars == "RS")
                                    {
                                        outputLine += "R";
                                    }
                                    else if (currentChars == "SR")
                                    {
                                        outputLine += "R";
                                    }
                                    else if (currentChars == "RP")
                                    {
                                        outputLine += "P";
                                    }
                                    else if (currentChars == "PR")
                                    {
                                        outputLine += "P";
                                    }
                                }
                                i++;
                            }
                            sw.WriteLine(outputLine);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        else
        {
            Console.WriteLine($"File {filePath} does not exist.");
        }
    }
}