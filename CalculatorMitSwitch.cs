/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                           
 *------------------------------------------------------------------------------
 *                      Jan Ritt                                                
 *------------------------------------------------------------------------------
 *  Description:  The program reads in two Numbers and a calculation Operation, 
 *                and outputs the result, it does this via a switch, not an     
 *                if - else chain.
 *------------------------------------------------------------------------------
*/
using System;
using System.Text;

namespace CalculatorMitSwitch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double leftOperand, rightOperand, result;
      string formattedResult;

      char calculationOperator;
      // Eingabe      (E)
      Console.WriteLine("Einfacher Rechner mit Switch");
      Console.WriteLine("============================\n");
      Console.Write("Linker Operand [double]: ");
      leftOperand = Convert.ToDouble(Console.ReadLine());
      Console.Write("Operation [+ - * /]: ");
      calculationOperator = Console.ReadKey().KeyChar;
      Console.Write("\nRechter Operand [double]: ");
      rightOperand = Convert.ToDouble(Console.ReadLine());
      // Verarbeitung (V)
      result = 0.000;

      switch (calculationOperator)
      {
        case '+':
          result = leftOperand + rightOperand;
          break;
        case '-':
          result = leftOperand - rightOperand;
          break;
        case '*':
          result = leftOperand * rightOperand;
          break;
        case '/':
          if (rightOperand != 0)
          {
            result = leftOperand / rightOperand;
          }
          else
          {
            Console.WriteLine("Division durch 0 ist nicht erlaubt/definiert!");
            Console.Write("\n Weiter mit beliebiger Taste ...\n");
            Console.ReadKey();
            return;
          }
          break;
        default:
          Console.WriteLine($"\nFalsche Rechenart: {calculationOperator}");
          Console.Write("\n Weiter mit beliebiger Taste ...\n");
          Console.ReadKey();
          return;
      }
      // Ausgabe      (A)  --  Output
      formattedResult = result.ToString("0.000");
      Console.WriteLine($"Ergebnis von {leftOperand} {calculationOperator} {rightOperand} = {formattedResult} ");

      // Ausgabe      (A)  --  End
      Console.Write("\n Weiter mit beliebiger Taste ...\n");
      Console.ReadKey();
      Console.Clear();
    }
  }
}

