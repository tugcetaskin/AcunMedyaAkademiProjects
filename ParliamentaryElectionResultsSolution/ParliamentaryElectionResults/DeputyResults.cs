using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParliamentaryElectionResults
{
    public class DeputyResults
    {
        #region First Outpu
        public static void OutputsOfTheFirstTable()
        {
            Dictionary<string, int> result = Process.GroupData();

            int cities = Process.NumberOfCities();
            int parties = Process.NumberOfParties();

            for (int i = 0; i < cities; i++)
            {
                double numberOfTotalVotes = Convert.ToDouble(Process.NumberOfValidVotesByCities()[i]);

                if (result.ContainsKey((i + 1) + ". İl Plaka Kodu"))
                {
                    int plateCod = result[(i + 1) + ". İl Plaka Kodu"];
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"\nİl Plaka Kodu          : {plateCod}");
                }

                if(result.ContainsKey((i + 1) + ". İl Milletvekili Kontenjanı"))
                {
                    int quota = result[(i + 1) + ". İl Milletvekili Kontenjanı"];
                    Console.WriteLine($"Milletvikili Kontenjanı: {quota}");
                }

                if(result.ContainsKey((i + 1) + ". İl " + " Geçerli Oy Sayısı"))
                {
                    int validVotes = result[(i + 1) + ". İl " + " Geçerli Oy Sayısı"];
                    Console.WriteLine($"Geçerli Oy Sayısı      : {validVotes}");
                }

                Console.WriteLine("\n\nPusula Sıra\tOy Say\t Oy Yüzde\tMv Say\n");

                for (int j = 0; j < parties; j++)
                {
                    Dictionary<string, int> memberOfParties = Process.DeputiesByParties();

                    if(result.ContainsKey((i + 1) + " İli " + (j + 1) + ". Parti Oy Sayısı"))
                    {
                        int ballotOrder = j + 1;
                        double numberOfVotes = Convert.ToDouble(result[(i + 1) + " İli " + (j + 1) + ". Parti Oy Sayısı"]);                      
                        string percentage = Percentage(numberOfVotes, numberOfTotalVotes);
                        int numberOfDeputies = 0;

                        if (memberOfParties.ContainsKey((i + 1) + " İli " + (j + 1) + " Partisi Milletvekili Sayısı : "))
                        {
                            numberOfDeputies = memberOfParties[(i + 1) + " İli " + (j + 1) + " Partisi Milletvekili Sayısı : "];
                        }

                        Console.WriteLine($"  {ballotOrder}\t\t {numberOfVotes}\t%{percentage}\t  {numberOfDeputies}");
                    }
                }     
            }

            
        }
        #endregion

        #region Second Output
        public static void OutputsOfTheSecondTable()
        {
            int validVotes = 0;
            List<int> validTotalVotes = Process.NumberOfValidVotesByCities();
            List<int> votesByParties = Process.NumberOfValidVotesByParties();
            List<int> numberOfDeputies = Process.TotalNumberOfDeputiesByParties();
            List<int> numCities = Process.NumOfCitiesWherePartyNotElected();

            foreach(int votes in validTotalVotes)
            {
                validVotes += votes;
            }

            Console.WriteLine("\n\n-----------------------------------------");
            Console.WriteLine("Türkiye Geneli\n" +
                "Milletvekili Kontenjanı : " + Process.NumberOfQuota() + "\n" +
                "Geçerli Oy Sayısı       : " + validVotes);
            Console.WriteLine("\nPusula Sıra\tOy Say\t Oy Yüzde    Mv Say\t Mv Yüzde\t  0 Mv İl Say\n");

            for(int i = 0; i < Process.NumberOfParties(); i++)
            {
                int numberOfVotes = votesByParties[i];
                string percentage = Percentage(numberOfVotes, validVotes);
                int deputiesNumber = numberOfDeputies[i];
                string depPercentage = Percentage(deputiesNumber, Process.NumberOfQuota());
                int cityNum = numCities[i];
                Console.WriteLine($"  {(i + 1)}\t\t {numberOfVotes}\t{percentage}   \t{deputiesNumber}\t%{depPercentage}\t\t{cityNum}");
            }
        }
        #endregion

        #region Percentage Calculation
        public static string Percentage(double num1, double num2)
        {
            double result = num1 * (100 / num2);
            string formattedResult = result.ToString("F2").PadLeft(8);
            return formattedResult;
        }
        #endregion
    }
}
