using System;

class Assignment6
{
    public void ConvertPasswordToString()
    {
      string pass = Console.ReadLine();
      int size = pass.Length;
      char [] arr = new char[size];
      for(int i = 0; i<size; i++){
        arr[i] = pass[i];
      }
      Console.Write("Password : ");
      for(int i = 0; i<arr.Length; i++){
        Console.Write(arr[i]);
      }
    }
}