
using System.Text;
using ObserverPattern;

var gamePublisher = new GamePublisher();

gamePublisher.Subscribe(new EmailSubscriber("mehedi.sun@gmail.com"));
gamePublisher.Subscribe(new EmailSubscriber("mehedimayall@gmail.com"));

gamePublisher.Subscribe(new EmailSubscriber("ibrahim@gmail.com"));
gamePublisher.UnSubcribe(new EmailSubscriber("ibrahimd@gmail.com"));


gamePublisher.ReleaseGame("Mobile Legend");


// string st = "mehedi hasan";
// var sb = new StringBuilder(st);
// int x = 0, y = sb.Length - 1;
// while (x < y)
// {
//     (sb[x], sb[y]) = (sb[y], sb[x]);
//     x++;
//     y--;
// }

// Console.WriteLine(sb.ToString());


List<string> TopKFrequentWords(List<string> words, int k)
{
    return words.GroupBy(t => t)
        .OrderByDescending(t => t.Count())
        .Take(2)
        .Select(g => g.Key)
        .ToList();
}

string[] animal = ["dog", "cat", "dog", "mouse", "cat", "dog", "cat", "cat"];
var result = TopKFrequentWords(animal.ToList(),3);
foreach(string st in result)
    Console.WriteLine(st);
