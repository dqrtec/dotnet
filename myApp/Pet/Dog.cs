using System;

namespace Pet{
    public class Dog: IPet {
        public string talkToHuman(){
            return new string("Au-Au");
        }
    }
}