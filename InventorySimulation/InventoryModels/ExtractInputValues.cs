using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryModels;

namespace InventorySimulation
{
    static public class ExtractInputValues
    {
        static private int dataIndx = 6;
        static public void FillData(SimulationSystem system, string fileContent)
        {
            string[][] separatedFileContent = InputParser.ParseFileContent(fileContent);

            system.OrderUpTo = Convert.ToInt32(separatedFileContent[1][0]);
            system.ReviewPeriod = Convert.ToInt32(separatedFileContent[1][1]);
            system.StartInventoryQuantity = Convert.ToInt32(separatedFileContent[1][2]);
            system.StartLeadDays = Convert.ToInt32(separatedFileContent[1][3]);
            system.StartOrderQuantity = Convert.ToInt32(separatedFileContent[1][4]);
            system.NumberOfDays = Convert.ToInt32(separatedFileContent[1][5]);
            system.DemandDistribution = FillDistributionTable(separatedFileContent[1]);
            system.LeadDaysDistribution = FillDistributionTable(separatedFileContent[1]);
            dataIndx = 6;
        }

        static private List<Distribution> FillDistributionTable(string[] data)
        {
            Decimal cummulativeProbabilty = 0;

            List<Distribution> distributionTable = new List<Distribution>();
            while (cummulativeProbabilty != 1)
            {
                Distribution distributionRow = new Distribution();
                string[] probValues = InputParser.ParseProbValue(data[dataIndx]);

                if (Convert.ToDecimal(probValues[1]) == 0)
                {
                    dataIndx++;
                    continue;
                }

                int value = Convert.ToInt32(probValues[0]);
                Decimal probability = Convert.ToDecimal(probValues[1]);
                cummulativeProbabilty += probability;

                distributionRow.Value = value;
                distributionRow.Probability = probability;
                distributionRow.CummProbability = cummulativeProbabilty;

                distributionTable.Add(distributionRow);
                dataIndx++;
            }

            CalcRange(distributionTable);
            return distributionTable;
        }

        static private void CalcRange(List<Distribution> distributionTable, bool less=false)
        {
            distributionTable[0].MinRange = 1;
            distributionTable[0].MaxRange = Convert.ToInt32((distributionTable[0].CummProbability * 100));

            for (int i = 1; i < distributionTable.Count; i++)
            {
                distributionTable[i].MinRange = distributionTable[i - 1].MaxRange + 1;
                distributionTable[i].MaxRange = Convert.ToInt32((distributionTable[i].CummProbability * 100));
            }
        }
    }
}