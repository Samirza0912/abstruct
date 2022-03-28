using System;


namespace abstruct
{
    class Program
    {
        /*Bir Figure abstrakt class-ı olur 
         * və onun Figure-dan miras alan zaman mütləq override edilməsi lazım olan bir CalcArea methodu olur.

Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

Program class-ında bir menu olacaq
1. Square
2. Rectangular
0. Quit

İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Select the number between 0-2: \n" +
                "1. Square \n" +
                "2. Rectangular \n" +
                "0. End program");

            int num = int.Parse(Console.ReadLine());
            int square;
            int width;
            int length;
            do
            {
                switch (num)
                {
                    case 1:
                        {
                            Console.Write("Please enter the side ");
                            square = int.Parse(Console.ReadLine());
                            Square squares = new Square();
                            squares.CalcArea(square,0);
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Please enter the width ");
                            width = int.Parse(Console.ReadLine());
                            Console.Write("Please enter the length ");
                            length = int.Parse(Console.ReadLine());

                            Rectangular rec = new Rectangular();
                            rec.CalcArea(width,length);
                        }
                        break;

                    case 0:
                        {

                        }
                        break;


                    default:
                        break;
                }
            } while (num < 0 || num > 2);
        }
    }




    
    

    abstract class Figure
    {
        public abstract void CalcArea(int num1, int num2);
    }
    class Square:Figure
    {
        private int _side;
        public int side {
            get
            {
                return _side;
            }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("side cannot be negative");
                    return;
                }
                value = _side;
            }
        }

        public override void CalcArea(int num1, int num2)
        {
            int sq = num1 * num1;
            Console.WriteLine(sq);
        }
    }
    class Rectangular:Figure
    {
        private int _width;
        private int _length;
        public int width
        {
            get { return _width; }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("width cannot be negative");
                    return;
                }
                value = _width;
            }
        }
        public int length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("length cannot be negative");
                    return;
                }
                value = _length;
            }
        }

        public override void CalcArea(int num1, int num2)
        {
            int rec = num1*num2;
            Console.WriteLine(rec);
        }
    }
}

