using System;

string test = "eUternjUHBJ<CBMN<SNCSOFJkdfvlkjdioutoeuweo;mczkxncjbxxl;vmx";
test=Kata.Disemvowel(test);
Console.WriteLine(test);

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
        for (int i = 0; i < vowels.Length; i++)
        {
            str = str.Replace(vowels[i], "");
        }
        return str;
    }
}