using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            LearnStringCollection();
            LearnStringDictionary();
            LearnTraditonalArray();
            LearnArrayList();
            LearnHashTable();
            LearnListDictionary();
            LearnGenericDictionary();
            LearnSortedDictionary();
            LearnQueueCollection();
            LearnStackCollection();
            LearnGenericList();
            LearnLinkedList();
            LearnSortedDictionaryGeneric();
            LearnNameValueCollection();
            LearnSortedListGeneric();
        }

        #region Stroing strings only
        public static void LearnStringCollection()
        {
            Console.WriteLine("From LearnStringCollection Method");
            System.Collections.Specialized.StringCollection strCollection
                = new System.Collections.Specialized.StringCollection();
            String[] arString = new String[] { "ATUL", "THERAN" };
            strCollection.AddRange(arString);
            strCollection.Add("atul");      //Adding same in another case
            strCollection.Add("THERAN");    //Adding duplicate

            foreach (var item in strCollection)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < strCollection.Count; i++)
            {
                Console.WriteLine($"Value at index # {i} is {strCollection[i]}");
            }

        }

        public static void LearnStringDictionary()
        {
            Console.WriteLine("From LearnStringDictionary Method");
            System.Collections.Specialized.StringDictionary strDict = new System.Collections.Specialized.StringDictionary();
            strDict.Add("Title Case", "Atul");
            strDict.Add("Lower Case", "atul");
            strDict.Add(string.Empty, "ATUL");
           
            foreach (System.Collections.DictionaryEntry item in strDict)
                Console.WriteLine("   {0,-25} {1}", item.Key, item.Value);
        }
        #endregion

        #region Index based access
        static void LearnTraditonalArray()
        {
            Console.WriteLine("from LearnTraditonalArray  Method");
            string[] writers = new string[5] { "Atul", "Tuba", "Anonymous", "Theran", "Jay" };
            for (int i = 0; i < writers.Length; i++)
            {
                Console.WriteLine($"{writers[i]} joined at number # {i + 1}");
            }
        }
        static void LearnArrayList()
        {
            Console.WriteLine("from LearnArrayList  Method");
            ArrayList arInfo = new ArrayList();
            arInfo.Add("Till now, Atul has written "); // Adding string
            arInfo.Add(10);                             //Adding integer
            arInfo.Add(" Articles");
            Console.WriteLine($"Currently, It has {arInfo.Count} items and it has Capacity of {arInfo.Capacity}"); //Adding string
            for (int i = 0; i < arInfo.Count; i++)
            {
                Console.Write(arInfo[i].ToString());
            }
            Console.WriteLine();
        }
        static void LearnGenericList()
        {
            Console.WriteLine("from LearnGenericList Method");
            List<int> iCounts = new List<int>();
            iCounts.Add(1);
            iCounts.Add(12);
            iCounts.Add(13);
            Console.WriteLine($"Capacity {iCounts.Capacity}"  );
            for (int i = 0; i < iCounts.Count; i++)
            {
                Console.WriteLine(iCounts[i]);
            }
        }
        #endregion

        #region Access by Key
        static void LearnHashTable()
        {
            Console.WriteLine("from LearnHashTable  Method");
            Hashtable htData = new Hashtable();
            htData.Add("Name", "Atul");            //Inserting string
            htData.Add("Age", 100);                // inserting integer
            htData.Add("IsSeniorCitizen", true);   // Inserting boolean
            htData["Country"] = "USA";             //Another way to inserting the data 

            foreach (DictionaryEntry item in htData)
            {
                Console.WriteLine($"Value for Key {item.Key} is {item.Value}");
            }
        }
        static void LearnListDictionary()
        {
            Console.WriteLine("from LearnListDictionary  Method");
            System.Collections.Specialized.ListDictionary lstData = new System.Collections.Specialized.ListDictionary();
            lstData.Add("Name", "Atul");            //Inserting string
            lstData.Add("Age", 100);                // inserting integer
            lstData.Add("IsSeniorCitizen", true);   // Inserting boolean
            lstData["Country"] = "USA";             //Another way to inserting the data 
            foreach (DictionaryEntry item in lstData)
            {
                Console.WriteLine($"Value for Key {item.Key} is {item.Value}");
            }

        }
        static void LearnGenericDictionary()
        {
            Console.WriteLine("from LearnGenericDictionary  Method");
            Dictionary<string, int> dictExperiences = new Dictionary<string, int>();
            dictExperiences.Add("Atul", 12);
            dictExperiences.Add("Theran", 16);
            dictExperiences.Add("Tuba", 8);
            dictExperiences.Add("tuba", 5); //Keys are Case sensitive So it will be OK 
            foreach (var item in dictExperiences)
            {
                Console.WriteLine($"{item.Key} has {item.Value} years on experience");
            }
        }

        static void LearnSortedDictionary()
        {
            Console.WriteLine("from LearnSortedDictionary  Method");
            SortedDictionary<int, string> srtMembers =
           new SortedDictionary<int, string>();
            srtMembers.Add(1, "Theran");
            srtMembers.Add(4, "Tuba");
            srtMembers.Add(2, "Jay");
            srtMembers.Add(3, "Atul");
            //Items are inserted in different order (1,4,2,3) but sorted in 1,2,3,4 
            foreach (var item in srtMembers)
            {
                Console.WriteLine($"Member # {item.Key} is {item.Value}");
            }

        }
        #endregion

        #region Access by Key or Index or Both 
        static void LearnSortedListGeneric()
        {
            Console.WriteLine("from LearnSortedListGeneric Method");
            SortedDictionary<int, string> classRoll =
            new SortedDictionary<int, string>();
            classRoll.Add(1, "Atul");
            classRoll.Add(4, "Jay");
            classRoll.Add(3, "Theran");
            classRoll.Add(2, "Tuba");
            //By default it sorts
            foreach (var item in classRoll)
            {
                Console.WriteLine(item.Value);
            }
            //Access by Index
            Console.WriteLine(classRoll[2]);
            //Access by Key
            foreach (KeyValuePair<int, string> kvp in classRoll)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
        }

        static void LearnNameValueCollection()
        {
            Console.WriteLine("from LearnNameValueCollection Method");
            NameValueCollection nvCityCountry = new NameValueCollection();
            nvCityCountry.Add("IND", "Mumbai");
            nvCityCountry.Add("USA", "New York");
            nvCityCountry.Add("USA", "Chicago"); //Duplicate key and see the output
            nvCityCountry.Add("USA", "Chicago"); // Duplicate key and value both
            Console.WriteLine("Access By index"); 
            for (int i = 0; i < nvCityCountry.Count; i++)
            {
                Console.WriteLine("   [{0}]     {1,-10} {2}", i, nvCityCountry.GetKey(i), nvCityCountry.Get(i));
            }
            Console.WriteLine("Access By Key");
            foreach (string item in nvCityCountry.AllKeys)
            {
                Console.WriteLine("   {0,-10} {1}", item, nvCityCountry[item]);
            }
        }

        static void LearnSortedDictionaryGeneric()
        {
            Console.WriteLine("from LearnSortedDictionaryGeneric Method");
            SortedDictionary<int, string> classRoll =
            new SortedDictionary<int, string>();
            classRoll.Add(1, "Atul");
            classRoll.Add(4, "Jay");
            classRoll.Add(3, "Theran");
            classRoll.Add(2, "Tuba");
            //By default it sorts
            foreach (var item in classRoll)
            {
                Console.WriteLine(item.Value);
            }
            //Access by Index
            Console.WriteLine(classRoll[2]);
            //Access by Key
            foreach (KeyValuePair<int, string> kvp in classRoll)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
        }
        #endregion

        #region Sequential Access
        static void LearnQueueCollection()
        {
            Console.WriteLine("from LearnQueueCollection Method");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Atul");      // Adding first item
            queue.Enqueue("Kumar");     //Adding second item
            queue.Enqueue("Sharma");    //Adding third item
            queue.Dequeue();            // Dequeue and delete from the collection
            Console.WriteLine($"Peek value ={queue.Peek()}");  //returns the old item but doesn't delete it
            foreach (var item in queue)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void LearnStackCollection()
        {
            Console.WriteLine("from LearnStackCollection Method");
            Stack<string> stack = new Stack<string>();
            stack.Push("Atul");         // Adding first item
            stack.Push("Kumar");        // Adding second item
            stack.Push("Sharma");       // Adding third item
            stack.Pop();                // Pop 
            Console.WriteLine($"Peek value ={stack.Peek()}");  //top most item but no delete
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void LearnLinkedList()
        {
            Console.WriteLine("from LearnLinkedList Method");
            //NOTE - No Knowledge to Tom Cruise Mission Impossible Series wont affect your learning
            List<string> movies = new List<string>() {"MI-1", "MI-2","MI-3","MI-Rougue Nation",};
            LinkedList<string> movieSeries = new LinkedList<string>(movies);
            Console.WriteLine("Initial List");
            foreach (var item in movieSeries)
            {
                Console.WriteLine(item);
            }
            // Tasks to do - I have missed Ghost Protocol at # 4 and So far the last movie # 6 Fallout in the series
            LinkedListNode<string> currentMovie = movieSeries.FindLast("MI-Rougue Nation");
            movieSeries.AddBefore(currentMovie, "MI-Ghost Protocol");
            movieSeries.AddAfter(currentMovie, "MI-Fallout");
            Console.WriteLine("Corrected List");
            foreach (var item in movieSeries)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

       

    }
}
