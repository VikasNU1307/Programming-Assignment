using System;

class Assignment41
{
    public void ReverseStringWithoutReverseFunction()
    {
         Console.WriteLine("Enter A String:");
         string str = Console.ReadLine();
         string reverse = "";
         for(int i = str.Length - 1; i>=0; i--){
             reverse = reverse + str[i];
         }
        
         Console.WriteLine("Reverse Name:"+ reverse);

    }
}
