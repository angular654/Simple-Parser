using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\Users\vivah\source\repos\Parser\Parser/data.doc";
            // your filepath to write 
            Console.WriteLine("Ready to Parsing!");
            IWebDriver driver = new ChromeDriver();
            driver.Url = @"https://tproger.ru/";
            string data = driver.FindElement(By.Id("main_columns")).Text;
            File.WriteAllText(Filepath, string.Empty);
            // clear old data
            data = "https://tproger.ru/ \r\n" + data;
            try
            {
                File.WriteAllText(Filepath, data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Check "+ Filepath);
            driver.Close();
            Console.WriteLine("Press Esc to exit");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
