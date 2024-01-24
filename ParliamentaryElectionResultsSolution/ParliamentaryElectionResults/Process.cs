using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParliamentaryElectionResults
{
    public static class Process
    {
        #region Transferring the Data in the File to the List
        public static List<int> TransferDataToList()
        {
            string filePath = "C:\\Users\\taski\\OneDrive\\Belgeler\\C# Projeleri\\ParliamentaryElectionResultsSolution\\secim.txt";

            List<int> list = new List<int>();
            StreamReader reader = new StreamReader(filePath);
            
            
            while (!reader.EndOfStream)
            {
                String row = reader.ReadLine();
                if (row != "")
                {
                    list.Add(Convert.ToInt32(row));
                }
                else
                {
                    continue;
                }
            }

            return list;
        }
        #endregion

        #region Find Number Of Cities
        public static int NumberOfCities()
        {
            List<int> info = TransferDataToList();
            int result = (info.Count - 1) / (2 + NumberOfParties());
            return result;
        }
        #endregion

        #region Find Number Of Parties
        public static int NumberOfParties()
        {
            List<int> info = TransferDataToList();
            int result = info[0];
            return result;
        }
        #endregion

        #region Find Parliamentary Quota
        public static int NumberOfQuota()
        {
            List<int> info = TransferDataToList();
            info.Remove(info[0]);
            int quota = 0;
            int index = 1;

            for(int i = 0; i < NumberOfCities(); i++)
            {
                quota += info[index];
                index += 10;
            }
            return quota;
        }
        #endregion

        #region Saving The Number Of Valid Votes By Parties To The List
        public static List<int> NumberOfValidVotesByParties()
        {
            Dictionary<string, int> infos = GroupData();
            List<int> result = new List<int>();

            for(int i = 0; i < NumberOfParties(); i++)
            {
                int total = 0;
                foreach(var info in infos)
                {
                    if(info.Key.EndsWith((i + 1) + ". Parti Oy Sayısı"))
                    {
                        total += info.Value;
                    }
                }
                result.Add(total);
            }

            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            return result;
        }
        #endregion

        #region Saving The Number Of Valid Votes By City To The List
        public static List<int> NumberOfValidVotesByCities()
        {
            List<int> info = TransferDataToList();
            List<int> result = new List<int>();

            int index = 1;
            int total;

            for (int i = 0; i < Process.NumberOfCities(); i++)
            {
                index += 2;
                total = 0;

                for (int j = 0; j < Process.NumberOfParties(); j++)
                {
                    total += info[index];
                    index++;
                }
                result.Add(total);
            }
            return result;
        }
        #endregion

        #region Grouping the Data in the List By Cities
        public static Dictionary<string, int> GroupData()
        {
            int numberOfParties = NumberOfParties();
            int numberOfCities = NumberOfCities();
            int numberOfValidVotes;
            int index = 0;

            List<int> info = TransferDataToList();
            Dictionary<string, int> result = new Dictionary<string, int>();

            info.Remove(info[0]);

            for (int y = 0; y < numberOfCities; y++)
            {
                if (y != 0) { index += 2; }

                result.Add((y + 1) + ". İl Plaka Kodu", info[index]);
                result.Add((y + 1) + ". İl Milletvekili Kontenjanı", info[index + 1]);

                numberOfValidVotes = 0;

                for (int i = 0; i < numberOfParties; i++)
                {
                    numberOfValidVotes += info[index + 2];

                    result.Add((y + 1) + " İli " + (i + 1) + ". Parti Oy Sayısı", info[index + 2]);
                    index++;
                }

                result.Add((y + 1) + ". İl " + " Geçerli Oy Sayısı", numberOfValidVotes);
            }

            //foreach (var kvp in result)
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //}

            return result;
        }
        #endregion

        #region Total Number Of Deputies By Parties
        public static List<int> TotalNumberOfDeputiesByParties()
        {
            Dictionary<string, int> members = DeputiesByParties();
            List<int> result = new List<int>();

            for(int i = 0; i < NumberOfParties(); i++)
            {
                int total = 0;
                foreach(var member in members)
                {
                    if(member.Key.EndsWith((i + 1) + " Partisi Milletvekili Sayısı : "))
                    {
                        total += member.Value;
                    }
                }
                result.Add(total);
            }
            return result;
        }
        #endregion

        #region Number Of Deputies By Political Parties And Cities
        public static Dictionary<string, int> DeputiesByParties()
        {
            Dictionary<string, int> member = new Dictionary<string, int>();
            Dictionary<string, int> infos = GroupData();


            for (int y = 0; y < NumberOfCities(); y++)
            {
                List<int> numberOfVotes = new List<int>();

                for (int i = 0; i < NumberOfParties(); i++)
                {
                    if (infos.ContainsKey((y + 1) + " İli " + (i + 1) + ". Parti Oy Sayısı"))
                    {
                        numberOfVotes.Add(infos[(y + 1) + " İli " + (i + 1) + ". Parti Oy Sayısı"]);
                    }
                }

                int quato = infos[(y + 1) + ". İl Milletvekili Kontenjanı"];

                for (int i = 0; i < quato; i++)
                {
                    int max = numberOfVotes.Max();
                    int maxIndex = numberOfVotes.IndexOf(max);
                    if (member.ContainsKey((y + 1) + " İli " + (maxIndex + 1) + " Partisi Milletvekili Sayısı : "))
                    {
                        member[(y + 1) + " İli " + (maxIndex + 1) + " Partisi Milletvekili Sayısı : "]++;
                    }
                    else
                    {
                        member.Add((y + 1) + " İli " + (maxIndex + 1) + " Partisi Milletvekili Sayısı : ", 1);
                    }

                    numberOfVotes[maxIndex] /= 2;
                }

            }

            //foreach (var item in member)
            //{
            //    Console.WriteLine($"{item.Key}\t{item.Value}");
            //}
            return member;
        }
        #endregion

        #region Finding the Number of Cities Where the Party Was Not Elected
        public static List<int> NumOfCitiesWherePartyNotElected()
        {
            List<int> result = new List<int>();
            Dictionary<string, int> infos = MemberOfParliament();

            for(int i = 0; i < NumberOfParties(); i++)
            {
                int cities = 0;
      
                for (int j = 0; j < NumberOfCities(); j++)
                {
                    int count = 0;
                    foreach (var info in infos)
                    {
                        if(info.Key.StartsWith((j + 1) + " İli ") && info.Value == (i + 1))
                        {
                            count++;
                        }
                    }
               
                    if(count == 0)
                    {
                        cities++;
                    }
                }    
                result.Add(cities);
            }

            return result;
        }
        #endregion

        #region Election Of Members Of Parliament Based On The Number Of Votes 
        public static Dictionary<string, int> MemberOfParliament()
        {
            Dictionary<string, int> member = new Dictionary<string, int>();
            Dictionary<string, int> infos = GroupData();

            for (int y = 0; y < NumberOfCities(); y++)
            {
                List<int> numberOfVotes = new List<int>();

                for (int i = 0; i < NumberOfParties(); i++)
                {
                    if (infos.ContainsKey((y + 1) + " İli " + (i + 1) + ". Parti Oy Sayısı"))
                    {
                        numberOfVotes.Add(infos[(y + 1) + " İli " + (i + 1) + ". Parti Oy Sayısı"]);
                    }
                }

                int quato = infos[(y + 1) + ". İl Milletvekili Kontenjanı"];

                for (int i = 0; i < quato; i++)
                {
                    int max = numberOfVotes.Max();
                    int maxIndex = numberOfVotes.IndexOf(max);
                    member.Add((y + 1) + " İli " + (i + 1) + ". Milletvekili Partisi : ", maxIndex + 1);
                    numberOfVotes[maxIndex] /= 2;
                }
            }
            return member;
        }
        #endregion
    }
}
