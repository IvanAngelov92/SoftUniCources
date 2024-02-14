char letter = char.Parse(Console.ReadLine());

switch (letter)
{
    case 'a':
    case 'A':
    case 'e':
    case 'E':
    case 'i':
    case 'I':
    case 'o':
    case 'O':
    case 'u':
    case 'U':
        Console.WriteLine("Vowel");
        break;
    case 'b':
    case 'B':
    case 'c':
    case 'C':
    case 'd':
    case 'D':
    case 'f':
    case 'F':
    case 'g':
    case 'G':
    case 'h':
    case 'H':
    case 'j':
    case 'J':
    case 'k':
    case 'K':
    case 'r':
    case 'R':
        Console.WriteLine("Consonant");
        break;
}
