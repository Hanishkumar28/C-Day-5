using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class PhotoBook
    {
        protected int numPage;
        public int GetNumberPages(int _noofpages)
        {
            numPage = _noofpages;
            return numPage;
        }
        public PhotoBook()
        {
            numPage = 16;
        }
        public PhotoBook(int _numPage)
        {
            numPage = _numPage;
        }
        public int GetNumberofPages()
        {
            return numPage;
        }

    }
    class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            numPage = 64;
        }
    }
    class PhotoBookTest
    {
        static void Main()
        {
            PhotoBook photo1 = new PhotoBook();
            Console.WriteLine("Number of Pages in the Photobook1 : " + photo1.GetNumberofPages());
            PhotoBook photo2 = new PhotoBook(30);
            Console.WriteLine("Number of Pages in the Photobook2 : " + photo2.GetNumberofPages());
            BigPhotoBook bigphoto = new BigPhotoBook();
            Console.WriteLine("Number of Pages in the BigPhotobook : " +bigphoto.GetNumberofPages());
        }
    }
}
