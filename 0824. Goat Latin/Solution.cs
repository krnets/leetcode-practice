public class Solution
{
    public string ToGoatLatin(string sentence)
    {
        var words = sentence.Split();

        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];

            if ("aeiou".Contains(char.ToLower(word[0])))
            {
                words[i] += "ma" + new string('a', i + 1);
            }
            else
            {
                words[i] = word[1..] + word[0] + "ma" + new string('a', i + 1);
            }
        }

        return string.Join(" ", words);
    }
}