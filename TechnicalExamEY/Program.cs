string? input;   

Console.WriteLine("Enter a phrase: ");
input = Console.ReadLine();

while (input != "")
{
    string? inputTrimmed = input.Replace(" ", "");
    double root = Math.Round(Math.Sqrt(inputTrimmed.Length), 0);

    Console.WriteLine();
    Console.WriteLine("The phrase entered was: {0}"
        ,input);
    Console.WriteLine(); 

    double columns = root;
    double rows = (root * root < inputTrimmed.Length) ? columns+1 : columns;

    char[,] table = new char[(int)columns, (int)rows];

    for (int i = 0; i < columns; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            if (inputTrimmed.Length > 0)
            {
                table[i, j] = inputTrimmed[0];
                inputTrimmed = inputTrimmed.Remove(0, 1);
            }
        }
    }

    string result = string.Empty;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        for (int j = 0; j < table.GetLength(0); j++)
        {
            result = result + table[j, i];
        }
        result = result + ' ';
    }
    
    Console.WriteLine("Table of {0}x{1} generated, rows*columns: {2}, with trimmed length of {3} and square root {4}",
        columns,rows, (columns*rows), input.Replace(" ", "").Length, root);
    Console.WriteLine();
    Console.WriteLine(result);
    Console.WriteLine();
    Console.WriteLine("Insert another phrase or press enter to finish.");

    input = Console.ReadLine();
}

