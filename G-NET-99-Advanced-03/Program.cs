namespace G_NET_99_Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1: Student Grade Manager
            List<int> grades01 = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine($"Grades Count:{grades01.Count}");
            //Console.WriteLine($"First Grade:{grades01[0]}");
            //Console.WriteLine($"Last Grade:{grades01[grades01.Count - 1]}");

            //grades01.Sort(); 
            //foreach (var grade in grades01)
            //{
            //    Console.WriteLine($"Grade: {grade}");
            //}

            //Console.WriteLine(grades01.Find(x=>x>90));
            //var failingGrades = grades01.FindAll(x => x < 75);
            //Console.WriteLine("Failing Grades:");
            //foreach (var grade in failingGrades)
            //{
            //    Console.WriteLine($"Grade: {grade}");
            //}

            //grades01.RemoveAll(x => x < 75);

            //foreach (var grade in grades01)
            //{
            //    Console.WriteLine($"Grade: {grade}");
            //}

            //Console.WriteLine(grades01.Contains(100));

            //List<string> grades02 = new List<string>(8);
            //foreach(var grade in grades01)
            //{
            //    grades02.Add($"Grade: {grade}");
            //}


            #endregion

            #region Exercise 2: Leaderboard

            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //{
            //    { 500, "Ahmed" },
            //    { 200, "Sara" },
            //    { 800, "Ali" },
            //    { 350, "Mona" }
            //};

            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}

            //Console.WriteLine($"First Key:{leaderboard[200]}");

            //Console.WriteLine(leaderboard.ContainsKey(500));
            //Console.WriteLine(leaderboard.TryGetValue(999, out string player));
            //leaderboard.Remove(200);
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}
            #endregion

            #region Exercise 3: Phone Book

            //Dictionary<string, string> contacts = new Dictionary<string, string>()
            //{
            //    { "omar", "011194842" },
            //    { "sara", "0105487654" },
            //    { "hazem", "015987845" },
            //    { "mohamed", "01265989" }
            //};


            //contacts["yasser"] = "0121982286";

            //try
            //{
            //    contacts.Add("omar", "011194842");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine(contacts.TryAdd("omar", "011194842"));

            //Console.WriteLine(contacts["ahmed"]);

            //Console.WriteLine(contacts.GetValueOrDefault("ahmed","Contact not found"));
            //Console.WriteLine(string.Join(", ", contacts.Keys));
            //Console.WriteLine(string.Join(", ", contacts.Values));
            #endregion


            #region Exercise 4: Unique Email Validator

            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com", 
            //    "Sara@Test.Com"
            //};


            //Console.WriteLine($"Count: {emails.Count}"); // Output: 2 beacause HashSet ignores case and duplicates.

            //HashSet<int> A = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //HashSet<int> B= new HashSet<int>() { 4, 5, 6, 7, 8 };
            //HashSet<int> C = new HashSet<int> { 1, 2 };


            //Console.WriteLine(string.Join(", ", A.Union(B)));
            //Console.WriteLine(string.Join(", ", A.Intersect(B)));
            //Console.WriteLine(string.Join(", ", A.Except(B)));
            //Console.WriteLine(C.IsSubsetOf(A));

            #endregion







        }
    }
}
