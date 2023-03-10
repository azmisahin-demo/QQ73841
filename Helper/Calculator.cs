
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

/// It contains the helper functions of the application
namespace Helper
{
  /// <summary>
  /// Calculator Operations
  /// </summary>
  public class Calculator
  {

    /// <summary>
    /// Function 1
    /// Addition and Multiplication
    /// This function returns the result of the sum of two numbers multiplied by the third number.
    /// </summary>
    /// <param name="number1"></param>
    /// <param name="number2"></param>
    /// <param name="number3"></param>
    /// <returns></returns>
    public decimal Fn1(decimal number1, decimal number2, decimal number3)
    {
      // Add the two numbers
      decimal total = new Math().Addition(number1, number2);
      // Multiply the two numbers and return    
      return new Math().Multiplication(total, number3);
    }



    /// <summary>
    /// Function 2
    /// Zigzag Numbers
    /// This function generates numbers from 1 to 200.
    /// If the number is a multiple of 3, 'zig' is written instead of the number.
    /// If the number is a multiple of 5, 'zag' is written instead of the number.
    /// If the number is a multiple of both 3 and 5, 'zigzag' is written.
    /// After 100, 'zagzig' is written instead of 'zigzag'.
    /// </summary>
    /// <returns></returns>
    public List<string> Fn2()
    {
      List<string> numbers = new List<string>();

      for (int i = 1; i <= 200; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          if (i <= 100)
            numbers.Add("zigzag");
          else
            numbers.Add("zagzig");
        }
        else if (i % 3 == 0)
        {
          numbers.Add("zig");
        }
        else if (i % 5 == 0)
        {
          numbers.Add("zag");
        }
        else
        {
          numbers.Add(i.ToString());
        }
      }

      return numbers;
    }

    /// <summary>
    /// Function 3
    /// The multiplication table.
    /// This function can take an integer value between 1 and 15.
    /// Creates the multiplication table up to the entered number.
    /// </summary>
    /// <param name="max"></param>
    /// <returns></returns>
    public int[,] Fn3(int max)
    {

      int n = max;
      int[,] table = new int[n + 1, n + 1];
      for (int i = 0; i <= n; i++)
      {
        for (int j = 0; j <= n; j++)
        {
          if (i == 0 && j == 0)
          {
            table[i, j] = 0;
          }
          else if (i == 0)
          {
            table[i, j] = j;
          }
          else if (j == 0)
          {
            table[i, j] = i;
          }
          else
          {
            table[i, j] = i * j;
          }
        }
      }

      return table;
    }

    /// <summary>
    /// Function 4
    /// Text File Sorting.
    /// This function sorts numbers in a text file from largest to smallest.
    /// Numbers in the file are separated by "space" characters and decimals are separated by commas.
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="sort"></param>
    /// <param name="reverse"></param>
    /// <returns></returns>
    public double[] Fn4(string filePath, bool sort = true, bool reverse = true)
    {
      string[] lines = File
          // get all lines
          .ReadAllLines(filePath);

      // numbers is diffirent
      List<double> numbers = new List<double>();
      foreach (string line in lines)
      {
        // clear space
        string[] tokens = line.Split(' ');
        foreach (string token in tokens)
        {
          string item = token.Trim();
          // Invariant Culture
          if (double.TryParse(item.Replace(",", "."), NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out double number))
          {
            numbers.Add(number);
          }
          else
          {
            // wrong number or empty or alternatif method for your text
          }
        }
      }

      //
      double[] data = numbers.ToArray();

      // parameter
      if (sort)
        Array.Sort(data);
      if (reverse)
        Array.Reverse(data);

      return data;
    }

    /// <summary>
    /// Function 5
    /// Fibonacci Numbers.
    /// This function displays the Fibonacci number corresponding to an entered number.
    /// </summary>
    /// <param name="limit"></param>
    /// <returns></returns>
    public long Fn5(int limit)
    {
      long n = limit;
      long a = 0, b = 1, c = 0;

      // standart fibonacci method
      if (n == 1)
      {
        c = 0;
      }
      else if (n == 2)
      {
        c = 1;
      }
      else
      {
        for (long i = 3; i <= n; i++)
        {
          c = a + b;
          a = b;
          b = c;
        }
      }

      return c;

    }
  }
}
