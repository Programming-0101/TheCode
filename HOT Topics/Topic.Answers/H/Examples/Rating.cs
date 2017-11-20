using System;
using System.Linq;

namespace Topic.H.Examples
{
    public class Rating
    {
        public int Value { get; set; }

        public Rating(int value)
        {
            Value = value;
        }


        public override string ToString()
        {
            string rating;
            switch (Value)
            {
                case 5:
                    rating = "very good";
                    break;
                case 4:
                    rating = "good";
                    break;
                case 3:
                    rating = "average";
                    break;
                case 2:
                    rating = "bad";
                    break;
                case 1:
                    rating = "very bad";
                    break;
                default:
                    rating = "Invalid Rating";
                    break;
            }
            return rating;
        }
    }
}
