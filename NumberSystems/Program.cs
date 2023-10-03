// See https://aka.ms/new-console-template for more information
using System.Text;
using System;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, Welcome to Number System Converter!");

bool run = true;
string currentValue = "";
int currentsystem = 0;
while (run)
{
    //convert to
    if(currentValue != "")
    {   
        int inputnum = 0;
        Console.WriteLine("Continue to choose the number system to convert to: 1. deci 2. binary 3. octa 4. hexa 5. stop the program");
        int ConvertTO = Convert.ToInt32(Console.ReadLine());
        inputnum = Convert.ToInt32(currentValue);
        switch (ConvertTO)
        {
            case 1: //decimal
                switch (currentsystem)
                {
                    case 1:
                        currentValue = currentValue;
                        break;
                    case 2:
                        currentValue = Convert.ToString(BinaryToDecimal(currentValue));
                        break;
                    case 3:
                        currentValue = Convert.ToString(OctalToDecimal(currentValue));
                        break;
                    case 4:
                        currentValue = Convert.ToString(BinaryToDecimal(currentValue));
                        break;
                    default:
                        Console.WriteLine("not available");
                        break;
                }
                Console.WriteLine("Decimal: " + currentValue);
                break;
            case 2: //binary
                switch (currentsystem)
                {
                    case 1:
                        currentValue = DecimalToBinary(inputnum);
                        break;
                    case 2:
                        currentValue = currentValue;
                        break;
                    case 3:
                        currentValue = OctalToBinary(currentValue);
                        break;
                    case 4:
                        currentValue = HexadecimalToBinary(currentValue);
                        break;
                    default:
                        Console.WriteLine("not available");
                        break;
                }
                Console.WriteLine("Binary: " + currentValue);
                break;
            case 3: //octal
                switch (currentsystem)
                {
                    case 1:
                        currentValue = DecimalToOctal(inputnum);
                        break;
                    case 2:
                        currentValue = BinaryToOctal(currentValue);
                        break;
                    case 3:
                        currentValue = currentValue;
                        break;
                    case 4:
                        currentValue = HexadecimalToOctal(currentValue);
                        break;
                    default:
                        Console.WriteLine("not available");
                        break;
                }
                Console.WriteLine("Octal: " + currentValue);
                break;
            case 4: //hexadecimal
                switch (currentsystem)
                {
                    case 1:
                        currentValue = DecimalToHexadecimal(inputnum);
                        break;
                    case 2:
                        currentValue = BinaryToHexadecimal(currentValue);
                        break;
                    case 3:
                        currentValue = OctalToHexadecimal(currentValue);
                        break;
                    case 4:
                        currentValue = currentValue;
                        break;
                    default:
                        Console.WriteLine("not available");
                        break;
                }
                Console.WriteLine("Hexadecimal: " + currentValue);
                break;
            case 5: // stop program
                run = false;
                break;
            default:
                break;

        }
        currentsystem = ConvertTO;
    }
    else
    {
        //declare number system of input
        Console.WriteLine("Choose the number system of your input! 1. deci 2. binary 3. octa 4. hexa 5. Exit");
        int firstSystem = Convert.ToInt32(Console.ReadLine()); //1. deci 2. binary 3. octa 4. hexa
        if(firstSystem == 5)
        {
            Console.Write("Terminating Program...");
            break;
        }
        currentsystem = firstSystem;
        Console.WriteLine("Enter your input:");
        string input = Console.ReadLine();
        int inputnum = 0;
        if (firstSystem == 1)
        {
            if (IsDecimal(input))
            {
                inputnum = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Enter a valid number!");
                continue;
            }
        }
        else if (firstSystem == 2)
        {
            if (IsBinary(input))
            {
                inputnum = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Enter a valid binary number!");
                continue;
            }
        }
        else if (firstSystem == 3)
        {
            if (IsOctal(input))
            {
                inputnum = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Enter a valid octal number!");
                continue;
            }
        }
        else if (firstSystem == 4)
        {
            if (IsHexadecimal(input))
            {
                inputnum = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Enter a valid hexadecimal number!");
                continue;
            }
        }
        else
        {
            Console.WriteLine("Not Available!");
            continue;
        }


        Console.WriteLine("Choose the number system to convert to: 1. deci 2. binary 3. octa 4. hexa ");
        int ConvertTO = Convert.ToInt32(Console.ReadLine());
        switch (ConvertTO)
        {
            case 1: //decimal
                switch (firstSystem)
                {
                    case 1:
                        currentValue = input;
                        Console.WriteLine("Decimal: " + currentValue);
                        break;
                    case 2:
                        currentValue = Convert.ToString(BinaryToDecimal(input));
                        Console.WriteLine("Decimal: " + currentValue);
                        break;
                    case 3:
                        currentValue = Convert.ToString(OctalToDecimal(input));
                        Console.WriteLine("Decimal: " + currentValue);
                        break;
                    case 4:
                        currentValue = Convert.ToString(BinaryToDecimal(input));
                        Console.WriteLine("Decimal: " + currentValue);
                        break;
                    default:
                        Console.WriteLine("not available");
                        break;
                }
                break;
            case 2: //binary
                switch (firstSystem)
                {
                    case 1:
                        currentValue = DecimalToBinary(inputnum);
                        Console.WriteLine("Binary: " + currentValue);
                        break;
                    case 2:
                        currentValue = input;
                        Console.WriteLine("Binary: " + currentValue);
                        break;
                    case 3:
                        currentValue = OctalToBinary(input);
                        Console.WriteLine("Binary: " + currentValue);
                        break;
                    case 4:
                        currentValue = HexadecimalToBinary(input);
                        Console.WriteLine("Binary: " + currentValue);
                        break;
                    default:
                        Console.WriteLine("not available");
                        break;
                }
                break;
            case 3: //octal
                switch (firstSystem)
                {
                    case 1:
                        currentValue = DecimalToOctal(inputnum);
                        Console.WriteLine("Octal: " + currentValue);
                        break;
                    case 2:
                        currentValue = BinaryToOctal(input);
                        Console.WriteLine("Octal: " + currentValue);
                        break;
                    case 3:
                        currentValue = input;
                        Console.WriteLine("Octal: " + currentValue);
                        break;
                    case 4:
                        currentValue = HexadecimalToOctal(input);
                        Console.WriteLine("Octal: " + currentValue);
                        break;
                    default:
                        Console.WriteLine("not available");
                        break;
                }
                break;
            case 4: //hexadecimal
                switch (firstSystem)
                {
                    case 1:
                        currentValue = DecimalToHexadecimal(inputnum);
                        Console.WriteLine("Hexadecimal: " + currentValue);
                        break;
                    case 2:
                        currentValue = BinaryToHexadecimal(input);
                        Console.WriteLine("Hexadecimal: " + currentValue);
                        break;
                    case 3:
                        currentValue = OctalToHexadecimal(input);
                        Console.WriteLine("Hexadecimal: " + currentValue);
                        break;
                    case 4:
                        currentValue = input;
                        Console.WriteLine("Hexadecimal: " + currentValue);
                        break;
                    default:
                        Console.WriteLine("not available");
                        break;
                }
                break;
            case 5: // stop program
                run = false;
                break;
            default:
                break;

        }
        currentsystem = ConvertTO;
    }  
}

static bool IsDecimal(string input)
{
    return Regex.IsMatch(input, @"^[0-9]+$");
}

static bool IsBinary(string input)
{
    return Regex.IsMatch(input, @"^[01]+$");
}

static bool IsOctal(string input)
{
    return Regex.IsMatch(input, "^[0-7]+$");
}

static bool IsHexadecimal(string input)
{
    return Regex.IsMatch(input, "^[0-9A-Fa-f]+$");
}

static string DecimalToBinary(int num)
{
    string binary = "";
    while (num > 0)
    {
        binary = (num % 2) + binary;
        num /= 2;
    }
    return binary;
}

static string DecimalToOctal(int num)
{
    string octal = "";
    while (num > 0)
    {
        octal = (num % 8) + octal;
        num /= 8;
    }
    return octal;
}

static string DecimalToHexadecimal(int num)
{
    string hex = "";
    while (num > 0)
    {
        int remainder = num % 16;
        if (remainder < 10)
            hex = remainder + hex;
        else
            hex = (char)('A' + remainder - 10) + hex;
        num /= 16;
    }
    return hex;
}

static int BinaryToDecimal(string num)
{
    int decimalNumber = 0;
    int power = 0;
    for (int i = num.Length - 1; i >= 0; i--)
    {
        if (num[i] == '1')
            decimalNumber += (int)Math.Pow(2, power);
        power++;
    }
    return decimalNumber;
}

static int OctalToDecimal(string num)
{
    int decimalNumber = 0;
    int power = 0;
    for (int i = num.Length - 1; i >= 0; i--)
    {
        int digit = num[i] - '0';
        decimalNumber += digit * (int)Math.Pow(8, power);
        power++;
    }
    return decimalNumber;
}

static int HexadecimalToDecimal(string num)
{
    int decimalNumber = 0;
    int power = 0;
    for (int i = num.Length - 1; i >= 0; i--)
    {
        int digit;
        if (Char.IsDigit(num[i]))
            digit = num[i] - '0';
        else
            digit = Char.ToUpper(num[i]) - 'A' + 10;
        decimalNumber += digit * (int)Math.Pow(16, power);
        power++;
    }
    return decimalNumber;
}

static string BinaryToOctal(string num)
{
    int decimalNumber = BinaryToDecimal(num);
    return DecimalToOctal(decimalNumber);
}

static string BinaryToHexadecimal(string num)
{
    int decimalNumber = BinaryToDecimal(num);
    return DecimalToHexadecimal(decimalNumber);
}

static string OctalToBinary(string num)
{
    int decimalNumber = OctalToDecimal(num);
    return DecimalToBinary(decimalNumber);
}

static string OctalToHexadecimal(string num)
{
    int decimalNumber = OctalToDecimal(num);
    return DecimalToHexadecimal(decimalNumber);
}

static string HexadecimalToBinary(string num)
{
    int decimalNumber = HexadecimalToDecimal(num);
    return DecimalToBinary(decimalNumber);
}

static string HexadecimalToOctal(string num)
{
    int decimalNumber = HexadecimalToDecimal(num);
    return DecimalToOctal(decimalNumber);
}