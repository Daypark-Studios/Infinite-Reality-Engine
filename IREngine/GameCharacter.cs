using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IREngine
{
    internal abstract class GameCharacter
    {
        //Properties
        public string firstName { private set; get; }
        public string lastName { private set; get; }
        public Gender gender;
        public Sex sex;

        //Fields

        private LinkedList<GameCharacter> acquantances = new LinkedList<GameCharacter>();
        private LinkedList<GameCharacter> friends = new LinkedList<GameCharacter>();

        //Constructor

        public GameCharacter(string firstName, string lastName, Gender gender, Sex sex)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.sex = sex;
        }


    }
}
