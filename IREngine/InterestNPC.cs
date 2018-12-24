using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IREngine
{
    class InterestNPC : NPCs
    {
        public InterestNPC(string firstName, string lastName, Gender gender, Sex sex, int age, bool crushing, bool angry, bool sad, bool embarrased, int willingLevel, int trustLevel, int interestLevel) : 
            base(firstName, lastName, gender, sex, age)
        {
            this.crushing = crushing;
            this.angry = angry;
            this.sad = sad;
            this.embarrased = embarrased;
            this.willingLevel = willingLevel;
            this.trustLevel = trustLevel;
            this.interestLevel = interestLevel;

        }

        //Fields
        public bool crushing { get; set; }
        public bool angry { get; set; }
        public bool sad { get; set; }
        public bool embarrased { get; set; }
        protected int willingLevel;
        protected int trustLevel;
        protected int interestLevel;

        public bool increaseWillingLevel(int i)
        {
            if (this.willingLevel >= 100)
            {
                // willing level is at max (100)
                return false;
            }
            this.willingLevel += i;
            if (this.willingLevel > 100)
                this.willingLevel = 100;
            return true;
        }

        public bool decreaseWillingLevel(int i)
        {
            if (this.willingLevel <= 0)
            {
                // willing level is at min (0)
                return false;
            }
            this.willingLevel -= i;
            if (this.willingLevel < 0)
                this.willingLevel = 0;
            return true;
        }

        public bool increaseTrustLevel(int i)
        {
            if (this.trustLevel >= 100)
            {
                // trust level is at max (100)
                return false;
            }
            this.trustLevel += i;
            if (this.trustLevel > 100)
                this.trustLevel = 100;
            return true;
        }

        public bool decreaseTrustLevel(int i)
        {
            if (this.trustLevel <= 0)
            {
                // trust level is at min (0)
                return false;
            }
            this.trustLevel -= i;
            if (this.trustLevel < 0)
                this.trustLevel = 0;
            return true;
        }

        public bool increaseInterestLevel(int i)
        {
            if (this.interestLevel >= 100)
            {
                //interest level at max (100)
                return false;
            }
            this.interestLevel += i;
            if (this.interestLevel > 100)
                this.interestLevel = 100;
            return true;
        }

        public bool decreaseInterestLevel(int i)
        {
            if (this.interestLevel <= 0)
            {
                //interest level at min (0)
                return false;
            }
            this.interestLevel -= i;
            if (this.interestLevel < 0)
                this.interestLevel = 0;
            return true;
        }
    }
}
