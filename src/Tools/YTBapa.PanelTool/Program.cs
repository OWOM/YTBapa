using System;
using YTBapa.Library;
using YTBapa.Services;

namespace YTbapa.PanelTool
{
   public class Program
    {
        
       static void Main(string[] args)
        {
            Example example = new Example();

            //Bank bank = new Bank();
            //bank.Registered();
            //bank.Options();

            //例子1
            //example.Inputpay();
            //例子2
            example.reference();

            Console.ReadLine();
        }
       
    }
}