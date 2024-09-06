using System;

Console.WriteLine("Skriv in textsträng, exempelvis: 29535123p48723487597645723645");

string input = Console.ReadLine();

Console.WriteLine();


// Loopar genom varje tecken i strängen
for (int i = 0; i < input.Length; i++)
{
    // Kontrollera om den aktuella positionen är en siffra
    if (char.IsDigit(input[i]))
    {
        // Leta efter en matchande slutsiffra längre fram i strängen
        for (int j = i + 1; j < input.Length; j++)
        {

            if (input[j] == input[i])
            {
                // Skapa en potentiell delsträng
                string number = input.Substring(i, j - i + 1);

                // Kontrollera om alla tecken i delsträngen är siffror
                bool allDigits = true;
                for (int k = 0; k < number.Length; k++)
                {
                    if (!char.IsDigit(number[k]))
                    {
                        allDigits = false;
                        break;
                    }

                }

                // Om delsträngen bara innehåller siffror, skriv ut den med färg
                if (allDigits)
                {
                    // Skriver ut strängen med den matchande delsträngen i röd färg
                    Console.Write(input.Substring(0, i)); // Delen innan den röda texten

                    // Ändrar färgen till röd
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(number);

                    // Återställ färgen till standard
                    Console.ResetColor();

                    // Delen efter den röda texten
                    Console.WriteLine(input.Substring(j + 1));
                    break;
                }

            }

        }
    
    }

}
