using System;
using System.Diagnostics;

namespace IREngine
{
    internal class WeightedEncounters
    {
        public int encounters { private set; get; }
        public int encountersWeight { private set; get; }

        public WeightedEncounters()
        {
            encounters = 0;
            encountersWeight = 0;
        }

        public WeightedEncounters(int encounters, int encountersWeight)
        {
            this.encounters = encounters;
            this.encountersWeight = encountersWeight;
        }

        public bool addEncounter()
        {
            try
            {
                encounters++;
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine( e.StackTrace);
                return false;
            }
        }

        public bool addEncounter(int weight)
        {
            if (weight < 0)
                return false;

            encountersWeight += weight;
            encounters++;
            return true;
        }
    }
}