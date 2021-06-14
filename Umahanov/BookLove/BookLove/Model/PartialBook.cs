using System;

namespace BookLove.Model
{
    public partial class Book
    {
        public string GetPicture
        {
            get
            {
                return Environment.CurrentDirectory + @"\" + pucture;
            }
            set
            {
                pucture = value;
            }
        }
    }
}
