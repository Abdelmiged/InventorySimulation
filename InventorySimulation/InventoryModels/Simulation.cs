using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryModels;

namespace InventoryModels
{
    public class Simulation
    {
        SimulationSystem system;
        private Random rand = new Random();
        public Simulation(SimulationSystem system)
        {
            this.system = system;
        }

        public void BeginSimulation()
        {
            int cycleLength = system.ReviewPeriod;
            int cycleCounter = 1;
            bool firstTime = true;
            int[] orderValues = new int[2]{ system.StartOrderQuantity, system.StartLeadDays};

            for(int i = 0; i < system.NumberOfDays; i++)
            {
                SimulationCase simulationSystemRow = new SimulationCase();

                FillDay(i, simulationSystemRow);
                if(cycleLength <= 0)
                {
                    cycleLength = system.ReviewPeriod;
                    cycleCounter++;
                }

                FillCycle(cycleCounter, simulationSystemRow);
                FillDayWithinCycle(cycleLength, simulationSystemRow);

                cycleLength--;
                orderValues[1]--;

                if(orderValues[1] < 0)
                {
                    FillBeginningInventory(i - 1, orderValues[0], simulationSystemRow, system.SimulationTable, firstTime);
                    orderValues[0] = 0;
                }
                else
                    FillBeginningInventory(i - 1, 0, simulationSystemRow, system.SimulationTable, firstTime);

                FillRandomDemandDigit(simulationSystemRow);
                FillDemand(simulationSystemRow);
                FillEndingInventory(i - 1, simulationSystemRow, system.SimulationTable, firstTime);
                FillShortageQuantity(i - 1, simulationSystemRow, system.SimulationTable, firstTime);

                if (simulationSystemRow.DayWithinCycle == system.ReviewPeriod)
                    orderValues = FillOrderQuantity(simulationSystemRow);

                FillDaysUntilOrderArrives(i - 1, simulationSystemRow, system.SimulationTable, firstTime);

                firstTime = false;
                system.SimulationTable.Add(simulationSystemRow);
            }

            CalcPerformanceMeasures(system, system.SimulationTable);
        }

        private void FillDay(int value, SimulationCase simulationSystemRow)
        {
            simulationSystemRow.Day = value + 1;
        }

        private void FillCycle(int value, SimulationCase simulationSystemRow)
        {
            simulationSystemRow.Cycle = value;
        }

        private void FillDayWithinCycle(int value, SimulationCase simulationSystemRow)
        {
            simulationSystemRow.DayWithinCycle = ((system.ReviewPeriod - value) % system.ReviewPeriod) + 1;
        }

        private void FillBeginningInventory(int indx, int order, SimulationCase simulationSystemRow, List<SimulationCase> simulationSystemTable, bool firstTime = false)
        {
            if (firstTime)
                simulationSystemRow.BeginningInventory = system.StartInventoryQuantity;
            else
            {
                simulationSystemRow.BeginningInventory = simulationSystemTable[indx].EndingInventory + order;
            }
        }

        private void FillRandomDemandDigit(SimulationCase simulationSystemRow)
        {
            simulationSystemRow.RandomDemand = GenerateRandomNumber();
        }

        private void FillDemand(SimulationCase simulationSystemRow)
        {
            simulationSystemRow.Demand = GetRandomDigitValue(simulationSystemRow.RandomDemand, system.DemandDistribution);
        }

        private void FillEndingInventory(int indx, SimulationCase simulationSystemRow, List<SimulationCase> simulationSystemTable, bool firstTime)
        {
            if (firstTime)
                simulationSystemRow.EndingInventory = simulationSystemRow.BeginningInventory - simulationSystemRow.Demand;
            else
            {
                simulationSystemRow.EndingInventory = simulationSystemRow.BeginningInventory - (simulationSystemRow.Demand + simulationSystemTable[indx].ShortageQuantity);
            }

            if (simulationSystemRow.EndingInventory <= 0)
                simulationSystemRow.EndingInventory = 0;
        }

        private void FillShortageQuantity(int indx, SimulationCase simulationSystemRow, List<SimulationCase> simulationSystemTable, bool firstTime)
        {
            if(firstTime)
            {
                if (simulationSystemRow.BeginningInventory - simulationSystemRow.Demand < 0)
                    simulationSystemRow.ShortageQuantity = Math.Abs(simulationSystemRow.BeginningInventory - simulationSystemRow.Demand);
            }
            else
            {
                if (simulationSystemRow.BeginningInventory - (simulationSystemRow.Demand + simulationSystemTable[indx].ShortageQuantity) < 0)
                    simulationSystemRow.ShortageQuantity = Math.Abs(simulationSystemRow.BeginningInventory - (simulationSystemRow.Demand + simulationSystemTable[indx].ShortageQuantity));
            }
        }

        private int[] FillOrderQuantity(SimulationCase simulationSystemRow)
        {
            int[] orderValues = new int[2];
            simulationSystemRow.OrderQuantity = system.OrderUpTo - simulationSystemRow.EndingInventory + simulationSystemRow.ShortageQuantity;
            orderValues[0] = simulationSystemRow.OrderQuantity;
            FillRandomLeadTimeDigit(simulationSystemRow);
            orderValues[1] = FillLeadTime(simulationSystemRow);
            return orderValues;
        }

        private void FillRandomLeadTimeDigit(SimulationCase simulationSystemRow)
        {
            simulationSystemRow.RandomLeadDays = GenerateRandomNumber();
        }

        private int FillLeadTime(SimulationCase simulationSystemRow)
        {
            return simulationSystemRow.LeadDays = GetRandomDigitValue(simulationSystemRow.RandomLeadDays, system.LeadDaysDistribution);
        }

        private void FillDaysUntilOrderArrives(int indx, SimulationCase simulationSystemRow, List<SimulationCase> simulationSystemTable, bool firstTime)
        {
            if (firstTime)
                simulationSystemRow.DaysUntilOrderArrives = system.StartLeadDays - 1;
            else
            {
                if (simulationSystemRow.LeadDays != 0)
                    simulationSystemRow.DaysUntilOrderArrives = simulationSystemRow.LeadDays;
                else
                {
                    simulationSystemRow.DaysUntilOrderArrives = simulationSystemTable[indx].DaysUntilOrderArrives - 1;
                    if (simulationSystemRow.DaysUntilOrderArrives < 0)
                        simulationSystemRow.DaysUntilOrderArrives = 0;
                }
            }
        }

        private int GenerateRandomNumber(int minRange = 1, int maxRange = 101)
        {
            return rand.Next(minRange, maxRange);
        }

        private int GetRandomDigitValue(int randomDigit, List<Distribution> distributionTable)
        {
            for(int i = 0; i < distributionTable.Count; i++)
            {
                if (randomDigit >= distributionTable[i].MinRange && randomDigit <= distributionTable[i].MaxRange)
                    return distributionTable[i].Value;
            }
            return 0;
        }

        private void CalcPerformanceMeasures(SimulationSystem system, List<SimulationCase> simulationTable)
        {
            PerformanceMeasuresController.CalcEndingInventoryAverage(system.PerformanceMeasures, simulationTable);
            PerformanceMeasuresController.CalcShortageQuantityAverage(system.PerformanceMeasures, simulationTable);
        }
    }
}