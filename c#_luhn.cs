using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public static class Program {

  static bool validateCreditCardNumber(string cardNum)
  {
    int sum = 0;
    bool alternateNum = false;
    
    for (int i = cardNum.Length - 1; i >= 0; i--)
    {
      char[] test = cardNum.ToCharArray();
      int number = int.Parse(test[i].ToString());
      
      if (alternateNum == true)
      {
        number *= 2;
        
        if (number > 9)
        {
          number = (number - 9);
        }
      }
      
      sum += number;
      alternateNum = !alternateNum;
    }
    
    return (sum % 10 == 0);
  }
  
  static void Main() {
    using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
    while (!reader.EndOfStream) {
      string line = reader.ReadLine();
      
      if (validateCreditCardNumber(line))
      {
        Console.WriteLine("True");
      }
      else
      {
        Console.WriteLine("False");
      }
    }
  }
  
  
}