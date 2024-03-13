List<double> numbers = Console.ReadLine()
                               .Split()
                               .Select(double.Parse)
                               .ToList();

SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

foreach (var number in numbers)
{
    if(counts.ContainsKey(number))
    {
        counts[number]++;
    }    
    else
    {
        counts.Add(number, 1);
    }
}

foreach (KeyValuePair<double, int> element in counts)
{
    Console.WriteLine($"{element.Key} -> {element.Value}");
}