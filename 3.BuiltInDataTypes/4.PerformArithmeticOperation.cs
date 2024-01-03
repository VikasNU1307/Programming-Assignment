using System;

class Assignment34
{
    public void PerformArithmeticOperation()
    {
         int fnum , snum;
         Console.WriteLine("First Number");
         fnum = int.Parse(Console.ReadLine());
         Console.WriteLine("Second Number");
         snum = int.Parse(Console.ReadLine());
        
         Console.WriteLine(fnum+"+"+snum+"="+(fnum+snum));
         Console.WriteLine(fnum+"-"+snum+"="+(fnum-snum));

         Console.WriteLine(fnum+"*"+snum+"="+fnum*snum);

         Console.WriteLine(fnum+"/"+snum+"="+fnum/snum);





    }
}