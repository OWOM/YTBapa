using System;
using System.Collections.Generic;
using System.Text;

namespace YTBapa.Services
{
    public  class Example
    {


        #region 例子1（使用值传递）
        /// <summary>
        /// 例子1 算出税后工资
        /// </summary>
        /// <param name="pay"></param>
        /// <param name="taxRate"></param>
        /// <returns></returns>
        //public float GetPay(int pay, float taxRate)
        //{
        //    float afterTax;

        //    if (pay <= 3500)
        //    {
        //        afterTax = pay;
        //    }
        //    else
        //    {
        //        afterTax = pay - (pay - 3500) * taxRate;
        //    }
        //    return afterTax;

        //}
        //public void Inputpay()
        //{

        //    int pay; //税前工资
        //    float taxRate = 0.1f;  //税利
        //    float afterTax;  //税后工资

        //    Console.WriteLine("请输入税前工资(元)：");
        //    pay = int.Parse(Console.ReadLine());
        //    afterTax = GetPay(pay, taxRate);
        //    Console.WriteLine("税前工资：{0}，税后工资：{1}", pay, afterTax);
        //} 
        #endregion

        #region 例子2（使用引用传递）
        //public void reference()
        //{
        //    int num1, num2;
        //    Console.WriteLine("请输入两个数字：");
        //    num1 = int.Parse(Console.ReadLine());
        //    num2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("转换前：{0}，{1}", num1, num2);
        //    Sawp(ref num1, ref num2);
        //    Console.WriteLine("转换后：{0}，{1}", num1, num2);

        //}
        /// <summary>
        /// 使用引用传递转换数字
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        //public void Sawp(ref int num1, ref int num2)
        //{

        //    num1 = num1 - num2;
        //    num2 = num1 + num2;
        //    num1 = num2 - num1;
        //} 
        #endregion

    }

}
