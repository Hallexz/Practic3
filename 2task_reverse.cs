public string Reverse(string input)
{
    if (input == null || !(input is string))
    {
        return "Ошибка!";
    }
    else
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
