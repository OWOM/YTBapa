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

            //银行系统
            Bank bank = new Bank();
            bank.registered();
            bank.According();
            bank.options();

            //例子1
            //example.Inputpay();
            //例子2
            //example.reference();
            //例子3
            //example.GetUserName();



            Console.ReadLine();
        }
       
    }
}