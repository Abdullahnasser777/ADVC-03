namespace ADVC__03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentGradeManager();
            Leaderboard();
            PhoneBook();
            UniqueEmailValidator();

            #region Student Grade Manager 
            static void StudentGradeManager()
            {
                Console.WriteLine(" Student Grade Manager ");
                List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
                Console.WriteLine($"Grade : {string.Join(",", grades)}");
                Console.WriteLine($"Count : {grades.Count}");
                Console.WriteLine($"First grade : {grades.First()}");
                Console.WriteLine($"Last grade : {grades.Last()}");

                grades.Sort();
                Console.WriteLine($"\n Sorted (Ascending) : {string.Join(",", grades)}");

                int firstAbove90 = grades.First(g => g > 90);
                Console.WriteLine($"\n First Grade Above 90 : {firstAbove90}");

                List<int> failngGrade = grades.Where(g => g < 75).ToList();
                Console.WriteLine($"Failng Grade (Balow 75 : {string.Join(",", failngGrade)}");

                grades.RemoveAll(g => g < 75);
                Console.WriteLine($"Grades After Removing Failing Ones : {string.Join(",", grades)}");

                bool hasPerfectScoer = grades.Any(g => g == 100);
                Console.WriteLine($"\nContains A Grade Of 100 ? {hasPerfectScoer}");

                List<string> gradeLabels = grades.Select(g => $"Grade : {g}").ToList();
                Console.WriteLine("\n Grade Labels : ");
                foreach (var lable in gradeLabels)
                    Console.WriteLine(lable);
            }
            #endregion

            #region Leaderboard
            static void Leaderboard()
            {
                Console.WriteLine("Leaderboard");
                SortedDictionary<int, string> Leaderboard = new SortedDictionary<int, string>
                {
                {500,"Ahmed"},
                {200,"Sara"},
                {800,"Ali"},
                {350,"Mona"}
                };
                Console.WriteLine("Leaderboard (Sorted By Score) : ");
                foreach (var entry in Leaderboard)
                    Console.WriteLine($"{entry.Key} => {entry.Value}");
                Console.WriteLine($"\n First Key {Leaderboard.Keys.First()}");
                Console.WriteLine($" First Value {Leaderboard.Values.First()}");

                Console.WriteLine($"\n Score 500 Exists ? {Leaderboard.ContainsKey(500)}");
                if (Leaderboard.TryGetValue(999, out string Player999))
                    Console.WriteLine($"Player With Score 999 {Player999}");
                else
                    Console.WriteLine("NO Player Fount With Score 999.");

                Leaderboard.Remove(200);
                Console.WriteLine("\n Leaderboard After Removing Score 200 : ");
                foreach (var entry in Leaderboard)
                    Console.WriteLine($"{entry.Key} => {entry.Value}");
            }
            #endregion

            #region Phone Book
            static void PhoneBook()
            {
                Console.WriteLine(" Phone Book ");
                Dictionary<string, string> PhoneBook = new Dictionary<string, string>()
                {
                    {"Omar","01011111111"},
                    {"Laila","01022222222"},
                    {"Youssef","01033333333"},
                    {"Nour","01044444444"}
                };
                PhoneBook["Hana"] = "01055555555";
                Console.WriteLine("Added Hana Using [] Syntax");
                try
                {
                    PhoneBook.Add("Omar", "01099999999");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($" Error Adding Duplicate With .Add() : {ex.Message}");
                }

                bool added = PhoneBook.TryAdd("Omar", "01088888888");
                Console.WriteLine($"TryAdd() For Existing 'Omar' Succeede? {added}");

                bool found = PhoneBook.ContainsKey("Khaled");
                Console.WriteLine($"\n Does 'Khaled Exist? {found}'");


                string num = PhoneBook.GetValueOrDefault("Khaled", "Not Found");
                Console.WriteLine($"Khaled' S Number {num}");


                Console.WriteLine($"\n All Names : {string.Join(", ", PhoneBook.Keys)}");
                Console.WriteLine($"All Number : {string.Join(", ", PhoneBook.Values)}");
            }
            #endregion

            #region Unique Email Validator
            static void UniqueEmailValidator()
            {
                Console.WriteLine(" Unique Email Validator ");
                HashSet<string> Emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                Emails.Add("ahmed@test.com");
                Emails.Add("AHMED@test.com");
                Emails.Add("sara@test.com");
                Emails.Add("SARA@test.com");

                Console.WriteLine($"Emails Count : {Emails.Count}");
                Console.WriteLine("Explanation : The Hachset Uses A Case -insensitive Comparer (StringComparer.OrdinalIgnoreCase)");
                Console.WriteLine("So 'ahmed@test.com' And 'AHMED@test.com' Are Treated As The Same Email (Duplicate, Not Added)");
                Console.WriteLine("Same For 'sara@test.com' And 'SARA@test.com' . That' S Why Count = 2, Not 4.");

                Console.WriteLine();

                HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
                HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

                HashSet<int> union = new HashSet<int>(setA);
                union.UnionWith(setB);
                Console.WriteLine($"UnionWith (A U B ) : {string.Join(", ", union.OrderBy(z => z))}");

                HashSet<int> intersect = new HashSet<int>(setA);
                intersect.IntersectWith(setB);
                Console.WriteLine($"intersectWith (A ^ B ) : {string.Join(", ", intersect.OrderBy(z => z))}");

                HashSet<int> except = new HashSet<int>(setA);
                except.ExceptWith(setB);
                Console.WriteLine($"ExceptWith (A - B ) : {string.Join(", ", except.OrderBy(z => z))}");

                HashSet<int> SudsetCheck = new HashSet<int> { 1, 2 };
                bool isSubset = SudsetCheck.IsSubsetOf(setA);
                Console.WriteLine($"\n Is {{1,2}} A Sudset Of Set A? {isSubset}");

            }
            #endregion

            #region Search Session
            #region Span
            //Span = A way to handle a portion of existing data without creating a new copy of it.
            #endregion

            #region SortedList
            //SortedList = A collection that stores Key-Value pairs and keeps the Keys sorted.
            #endregion

            #region SortedDictionary
            //SortedDictionary = A dictionary that automatically sorts its keys
            #endregion

            #endregion
        }

    }
}
