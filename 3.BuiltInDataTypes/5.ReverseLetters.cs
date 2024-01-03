using System;

class Assignment35
{
    public void ReverseLetters()
    {   string letter = "", Reverse = "" ;
        for(int i = 0; i<3; i++){
            Console.WriteLine("Enter Letter");
            letter += Console.ReadLine();
        }
        for(int j =2; j>=0; j--){
            Reverse += letter[j];
        }
        Console.WriteLine(Reverse);
    }
}