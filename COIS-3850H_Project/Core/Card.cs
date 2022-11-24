using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COIS_3850H_Project.Core
{
    public class Card
    {
        //declaration of private fields
        private string name;
        private string colour;
        private int limit;
        private int random69;
        private int[] creditCardNum;

        Random rnd = new Random();

        //No Argument Constructor
        public Card()
        {
            Name = "Default";
            Colour = "Default";
            Limit = 0;
            CardNum ccNumber = new CardNum(Random69);

            CreditCardNum = ccNumber.CCNUM;
        }

        //3 Argument Constructor
        public Card(string NAME, string COLOUR, int LIMIT)
        {
            Name = NAME;
            Colour = COLOUR;
            limit = LIMIT;
            CardNum ccNumber = new CardNum(Random69);

            CreditCardNum = ccNumber.CCNUM;
        }

        //Name Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Colour Property
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        //Limit Property
        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        //Random69 Property
        public int Random69
        {
            set { random69 = rnd.Next(6, 9); }
            get
            {
                random69 = rnd.Next(6, 9);
                return random69;
            }
        }

        public int[] CreditCardNum
        {
            set { creditCardNum = value; }
            get { return creditCardNum; }
        }
    }
}
