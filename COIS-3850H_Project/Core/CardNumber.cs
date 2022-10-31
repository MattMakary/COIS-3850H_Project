using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCardWPFPractice
{
    public class CardNumber
    {
        Random rnd = new Random();
        private int issNum = 7;
        private int random69;
        private int cardLength;
        private int accnum;

        //initialize array to be maximum needed size (16)
        //find end of array before adding check dig?


        //private int[] card = new int[16];
        private int[] card = new int[16];


        //Constructor for card int[]
        //predetermined values for issuer# and bank# in card[0-5]
        //6 - 9 random Account Number digits in card[6 - cardLength -1]
        //Check digit (of 9 for now) in card[cardlength-1] (last digit)
        public int[] Card
        {
            get
            {
                card[0] = issNum;
                card[1] = 5;
                card[2] = 5;
                card[3] = 5;
                card[4] = 5;
                card[5] = 5;

                for (int i = 6; i < CardLength - 2; i++)
                {
                    card[i] = AccNum;
                }

                //last digit = check digit(9)

                card[CardLength] = 9;
                return card;
            }
        }

        //Random number from 6 - 9 to determine number of random account number digits
        public int Random69
        {
            get
            {
                int random69 = rnd.Next(6, 9);
                return random69;
            }
        }

        //Card Length property
        //1 IssNum + 5 BankNum Digits + 1 Check Digit = 7 + random 6 - 9 accountNum digits
        public int CardLength
        {
            get { return Random69 + 7; }
        }

        //Constructor for random account number
        //generate and return random int from 0 - 10
        public int AccNum
        {
            get
            {
                int accnum = rnd.Next(10);
                return accnum;
            }
        }

    }
}
