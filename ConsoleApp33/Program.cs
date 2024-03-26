List<string> namesList = new List<string>
        {
            "Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Henry", "Ivy", "Jack",
            "Katherine", "Leo", "Mia", "Nathan", "Olivia", "Peter", "Quinn", "Rachel", "Samuel", "Tara",
            "Uma", "Victor", "Wendy", "Xavier", "Yara", "Zachary", "Abigail", "Benjamin", "Chloe", "Daniel",
            "Emily", "Finn", "Gabriella", "Harry", "Isabella", "Jacob", "Kylie", "Liam", "Madison", "Noah",
            "Sophia", "Ethan", "Ava", "Lucas", "Ella", "Mason", "Avery", "Logan", "Scarlett", "Elijah",
            "Luna", "James", "Hannah", "Alexander", "Mila", "Michael", "Natalie", "Owen", "Victoria", "William",
            "Penelope", "Ryan", "Aria", "Jayden", "Zoe", "Matthew", "Grace", "David", "Leah", "Nathan",
            "Brooklyn", "Jackson", "Addison", "Evan", "Layla", "Benjamin", "Riley", "Dylan", "Nora", "Gabriel",
            "Samantha", "Andrew", "Audrey", "Nicholas", "Claire", "Isaac", "Lily", "Luke", "Maya", "Connor",
            "Evelyn", "Henry", "Anna", "Isaiah", "Ellie"
        };

#region StartWithA
List<string> startWithA = namesList.Where(name => name.StartsWith("A")).ToList();
foreach (string name in startWithA)
{
    Console.WriteLine(name);
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region SortedList
List<string> sorted = namesList.OrderBy(name=>name).ToList();
foreach (string name in sorted)
{
    Console.WriteLine(name);
}

#endregion

Console.WriteLine("/////////////////////////////////");

#region lenght5
List<string> lenghtMoreThan5 = namesList.Where(name => name.Length>5).ToList();
foreach (string name in lenghtMoreThan5)
{
    Console.WriteLine(name);
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region mCount
int mCount = namesList.Count(name=>name.StartsWith("M"));
Console.WriteLine(mCount);
#endregion

Console.WriteLine("/////////////////////////////////");

#region John
bool isJohnExists = namesList.All(name => name == "John");

if (isJohnExists)
{
    Console.WriteLine(true);
}
else 
{
    Console.WriteLine(false); 
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region First3

List<string> firstThree = namesList.Take(3).ToList();
foreach (string name in firstThree)
{
    Console.WriteLine(name);
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region Last3
List<string> lastThree = namesList.TakeLast(3).ToList();
foreach (string name in lastThree)
{
    Console.WriteLine(name);
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region Longest
string longest=namesList.OrderByDescending(name => name.Length).First();
Console.WriteLine(longest);
#endregion

Console.WriteLine("/////////////////////////////////");

#region 4 6
List<string> lenghtfs = namesList.Where(name => name.Length>4 && name.Length>6).ToList();
foreach (string name in lenghtfs)
{
    Console.WriteLine(name);
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region StartA
bool allNamesStartWithA = namesList.All(name => name.StartsWith("A"));
if (allNamesStartWithA)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region HaveAn
List<string> haveAn = namesList.Where(name => name.Contains("an")).ToList();
foreach (string name in haveAn)
{
    Console.WriteLine(name);
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region odd

List<string> odd = namesList.OrderBy(name => name. Length%2==0).Take(10).ToList();
foreach (string name in odd)
{
    Console.WriteLine(name);
}
#endregion

Console.WriteLine("/////////////////////////////////");

#region Avg
double avg=namesList.Average(name => name.Length);
Console.WriteLine(avg);
#endregion


Console.WriteLine("/////////////////////////////////");

#region MyRegion
List<string> haveE = namesList.Where(name => name.Contains("e")).
    OrderByDescending(name=>name.Length)
    .Take(5)
    .ToList();
foreach (string name in haveE)
{
    Console.WriteLine(name);
}
#endregion


