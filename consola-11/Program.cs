﻿/*
 Este programa toma una cadena de texto, la invierte y cuenta cuántas veces
 aparece la letra 'o' en la cadena invertida. Luego, muestra la cadena
 invertida y la cantidad de veces que 'o' se repite en ella.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage)
{
  if (i == 'o')
  {
    x++;
  }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
