using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public static class PerformanceMeasuresController
    {
        public static void CalcEndingInventoryAverage(PerformanceMeasures performanceMeasures, List<SimulationCase> simulationTable)
        {
            Decimal endingInventoryAverage = 0;
            for(int i = 0; i < simulationTable.Count; i++)
            {
                endingInventoryAverage += simulationTable[i].EndingInventory;
            }
            endingInventoryAverage /= simulationTable.Count;
            performanceMeasures.EndingInventoryAverage = endingInventoryAverage;
        }

        public static void CalcShortageQuantityAverage(PerformanceMeasures performanceMeasures, List<SimulationCase> simulationTable)
        {
            Decimal shortageQuantityAverage = 0;
            for(int i = 0; i < simulationTable.Count; i++)
            {
                shortageQuantityAverage += simulationTable[i].ShortageQuantity;
            }
            shortageQuantityAverage /= simulationTable.Count;
            performanceMeasures.ShortageQuantityAverage = shortageQuantityAverage;
        }
    }
}
