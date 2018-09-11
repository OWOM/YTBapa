using System;
using YTBapa.Library;
using YTBapa.Services;

namespace YTbapa.PanelTool
{
   public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Registered();
            bank.Options();


        }

       

    }
}