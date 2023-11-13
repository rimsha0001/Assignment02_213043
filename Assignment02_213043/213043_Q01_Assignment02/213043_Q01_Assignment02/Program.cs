using System;
using System.Xml.Linq;
//c)
namespace Qno1
{ 

    abstract class Telephone
    {
        protected string phonetype;
        public abstract void Ring();

    }
    class Digitalphone : Telephone
    {
       public Digitalphone() 
       {
            phonetype = "Digital";

       }

        public override void Ring()
        {
            // Implement how the DigitalPhone rings.
            Console.WriteLine($" Ringing the {phonetype} phone");
        }
    }
    class Talkingphone : Telephone 
    {
        public Talkingphone()
        {
            phonetype = "Talking";
        }

        public override void Ring()
        {
            // Implement how the DigitalPhone rings.
            Console.WriteLine($" Ringing the {phonetype} phone");
        }

    }
    class program 
    {
        static void Main (string[] args)
        {
            Digitalphone digitalphone = new Digitalphone();
            Talkingphone talkingphone = new Talkingphone();
            digitalphone.Ring();
            talkingphone.Ring();



        }
    }
}