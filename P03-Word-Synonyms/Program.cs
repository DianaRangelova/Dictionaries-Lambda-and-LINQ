int count = int.Parse(Console.ReadLine());

Dictionary<string, string> synonymsWords = new Dictionary<string, string>();

for (int i = 0; i < count; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (synonymsWords.ContainsKey(word))
    {
        synonymsWords[word] += ", " + synonym;
    }
    else
    {
        synonymsWords.Add(word, synonym);
    }
}

foreach (var wordPair in synonymsWords)
{
    Console.WriteLine($"{wordPair.Key} - {wordPair.Value}");
}
