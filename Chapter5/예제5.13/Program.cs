﻿
/* ================= 예제 5.12: try/catch 예약어 사용 ================= */

//class Program
//{
//    static void Main(string[] args)
//    {
//        int divisor = 0;

//        try
//        {
//            int quotient = 10 / divisor;
//        }
//        catch
//        {
//            try
//            {
//                // …… [사용자 코드] ……
//            }
//            catch { }
//        }
//    }
//}


/* ================= 5.3.2 예외 처리기 ================= */

class Program
{
    static void Main(string[] args)
    {
        {
            int divisor = 0;
            try
            {
                int quotient = 10 / divisor;
            }
            catch (System.DivideByZeroException)
            {
            }
        }

        //{
        //    int divisor = 0;
        //    string txt = null;
        //    try
        //    {
        //        Console.WriteLine(txt.ToUpper()); // System.NullReferenceException 예외 발생
        //        int quotient = 10 / divisor;
        //    }
        //    catch (System.DivideByZeroException) { }
        //}

        {
            int divisor = 0;
            string txt = null;
            try
            {
                Console.WriteLine(txt.ToUpper()); // System.NullReferenceException 예외 발생
                int quotient = 10 / divisor;
            }
            catch (System.NullReferenceException) { }
            catch (System.DivideByZeroException) { }
            catch (System.Exception) { }
        }
    }
}