using System.Text;

namespace CipherTextLibrary
{
    public class Translator
    {
        // dictionary our morse text as key, value
        public static Dictionary<string, char> Morse = new Dictionary<string, char>()
        {
            { ".-",'A' },
            { "-...", 'B' },
            { "-.-.", 'C' },
            { "-..", 'D' },
            { ".", 'E' },
            { "..-.", 'F' },
            { "--.", 'G' },
            { "....", 'H' },
            { "..", 'I' },
            { ".---", 'J' },
            { "-.-", 'K' },
            { ".-..", 'L' },
            { "--", 'M' },
            { "-.", 'N' },
            { "---", 'O' },
            { ".--.", 'P' },
            { "--.-", 'Q' },
            { ".-.", 'R' },
            { "...", 'S' },
            { "-", 'T' },
            { "..-", 'U' },
            { "...-", 'V' },
            { ".--", 'W' },
            { "-..-", 'X' },
            { "-.--", 'Y' },
            { "--..", 'Z' },
            { "  ", ' ' }
        };

        // get our decihper text
        public static string GetDecipherText(string cipherText, Dictionary<string, char> cipherDict)
    {

        string space = "  ";
        StringBuilder sb = new StringBuilder();
        List<string> vs = new List<string>();

        for (int i = 0; i < cipherText.Length; i++)
        {
            if (cipherText[i] != ' ')
            {
                sb.Append(cipherText[i]);
            }
            else if (cipherText[i] == ' ')
            {
                vs.Add(sb.ToString());
                sb.Clear();
                if (i + 1 < cipherText.Length)
                {
                    if (cipherText[i] == cipherText[i + 1])
                    {
                        vs.Add(space);
                    }
                }
            }
            if (i == cipherText.Length - 1)
            {
                vs.Add(sb.ToString());
            }
        }
        sb.Clear();

        foreach (var item in vs)
        {
            foreach (var cipher in cipherDict)
            {
                if (item == cipher.Key)
                {
                    sb.Append(cipher.Value);
                }
            }
        }

        return sb.ToString();
    }

        // get our cipher text
        public static string GetCipherText(string cipherText, Dictionary<string, char> cipherDict)
    {
        List<char> chars = new List<char>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < cipherText.Length; i++)
        {
            chars.Add(cipherText[i]);
        }

        foreach (var item in chars)
        {
            foreach (var key in cipherDict)
            {
                if (item == key.Value)
                {
                    if (item == ' ')
                    {
                        sb.Append(" ");
                    }
                    else
                    {
                        sb.Append(key.Key + " ");
                    }

                }
            }
        }

        return sb.ToString();
    }
    }
}