namespace ShapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double AreaSquare;
            double AreaRectangle;
            double AreaTriangle;
            double AreaDiamond;
            double AreaTrapezoid;
            double AreaCircle;
            String answer;
            double a;
            double w;
            double h;
            double b;
            double D;
            double d;
            double r;
            Boolean Continue;
            String AnswerContinue;

            do
            {
                //Init
                AreaSquare = 0;
                AreaRectangle = 0;
                AreaTriangle = 0;
                AreaDiamond = 0;
                AreaTrapezoid = 0;
                AreaCircle = 0;
                answer = "";
                a = 0;
                w = 0;
                h = 0;
                b = 0;
                D = 0;
                d = 0;
                r = 0;
                Continue = true;
                AnswerContinue = "";

                //Program
                Console.WriteLine("--------------------");
                Console.WriteLine("Area of Plane Shapes");
                Console.WriteLine("--------------------");
                Console.WriteLine();

                Console.WriteLine("What shape would you like to find the area of?");
                Console.WriteLine("S - Square\n" +
                                  "R - Rectangle\n" +
                                  "T - Triangle\n" +
                                  "D - Diamond\n" +
                                  "TR - Trapezoid\n" +
                                  "C - Circle");
                Console.Write("Please enter an opcion: ");
                answer = Console.ReadLine();
                answer = answer.ToUpper(); //make all letters capital
                Console.WriteLine();

                switch (answer)
                {
                    case "S":
                        Console.WriteLine("You have choicen a Square");
                        Console.Write("Enter length of side, a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        AreaSquare = CalculateShapeArea.Square(a);
                        Console.WriteLine("Area of the Square is: " + AreaSquare);
                        break;

                    case "R":
                        Console.WriteLine("You have choicen a Rectangle");
                        Console.Write("Enter width, w = ");
                        w = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter height, h = ");
                        h = Convert.ToDouble(Console.ReadLine());
                        AreaRectangle = CalculateShapeArea.Rectangle(w, h);
                        Console.WriteLine("Area of the Rectangle is:" + AreaRectangle);
                        break;

                    case "T":
                        Console.WriteLine("You have choicen a Triangle");
                        Console.Write("Enter base, b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter heigth, h = ");
                        h = Convert.ToDouble(Console.ReadLine());
                        AreaTriangle = CalculateShapeArea.Triangle(b, h);
                        Console.WriteLine("Area of the Triangule is: " + AreaTriangle);
                        break;

                    case "D":
                        Console.WriteLine("You have choicen a Diamond");
                        Console.Write("Enter length of diagonal 1 = , D = ");
                        D = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter length of diagonal 2 = , d = ");
                        d = Convert.ToDouble(Console.ReadLine());
                        AreaDiamond = CalculateShapeArea.Diamond(D, d);
                        Console.WriteLine("Area of the Diamond is: " + AreaDiamond);
                        break;

                    case "TR":
                        Console.WriteLine("You have choicen a Trapezoid");
                        Console.Write("Enter width top = , a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter width bottom = , b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter height = , h = ");
                        h = Convert.ToDouble(Console.ReadLine());
                        AreaTrapezoid = CalculateShapeArea.Trapezoid(a, b, h);
                        Console.WriteLine("Area of the Trapezoid is: " + AreaTrapezoid);
                        break;

                    case "C":
                        Console.WriteLine("You have choicen a Circle");
                        Console.Write("Enter radius, r = ");
                        r = Convert.ToDouble(Console.ReadLine());
                        AreaCircle = CalculateShapeArea.Circle(r);
                        Console.WriteLine("Area of the Circule is: " + AreaCircle);
                        break;

                    default:
                        Console.WriteLine("You have entered a wrong option");
                        break;
                }

                Console.Write("\nDo you want to calculate another area? Y-Yes / N-No: ");
                AnswerContinue = Console.ReadLine();
                AnswerContinue = AnswerContinue.ToUpper();
                if (AnswerContinue == "Y")
                {
                    Continue = true;
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Continue = false;
                }
            } while (Continue);
            
            Console.WriteLine("\nThank for using this calculator");
            Console.ReadKey();
        }

        
    }
}
