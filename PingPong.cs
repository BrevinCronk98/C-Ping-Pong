using System;
using System.Collections.Generic;
// using System.Text.RegularExpressions;

class Program
{
public static List<string> inputArray = new List<string> ();
static void Main()
  { 
     Console.WriteLine("Enter a number"); 
    
    string stringUserInput = Console.ReadLine(); 
    int intUserInput = int.Parse(stringUserInput);
    inputArray.Add(stringUserInput);
    // inputArray.ForEach(Console.WriteLine);
    // Console.WriteLine(inputArray.Count);


   

      for(int i = 0; i <= intUserInput; i++){
          if ( i % 15 == 0){
            inputArray.Add("Ping Pong");
          }else if (  i % 5 == 0){
              inputArray.Add("Pong");
          }else if ( i % 3 == 0){
             inputArray.Add("Ping");
          } else 
            inputArray.Add(i.ToString()); 
          }
        //   Console.Write(inputArray); 
        inputArray.ForEach(Console.WriteLine);
      }    
}
