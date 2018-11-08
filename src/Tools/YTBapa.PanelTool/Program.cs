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

            #region 银行系统
            //银行系统
            //Bank bank = new Bank();
            //bank.registered();
            //bank.According();
            //bank.options(); 
            #endregion
            #region 第三章
            //例子1
            //example.Inputpay();
            //例子2
            //example.reference(); 
            #endregion
            #region 第四章
            //例子1
            //example.GetUserName(); 
            //上机1
            //example.InputData();
            //例子2
            //example.Segmentation();
            //上机2
            //example.Conversion();
            //例子3
            //example.TotalScore();

            #endregion

            //学生管理系统
            Student_management sm = new Student_management();
            sm.Query_one();


            Console.ReadLine();
        }
       
    }
}