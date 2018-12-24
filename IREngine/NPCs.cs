using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IREngine
{
    internal abstract class NPCs : GameCharacter
    {
        //Properties
        public int age { get; set; }
        protected WeightedEncounters goodEncountersWithProtagonist = new WeightedEncounters();
        protected WeightedEncounters badEncountersWithProtagonist = new WeightedEncounters();

        public NPCs(string firstName, string lastName, Gender gender, Sex sex, int age) : base (firstName,lastName, gender, sex)
        {

        }
    }
}
