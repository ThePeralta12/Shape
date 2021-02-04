using System;
using System.IO;
using System.Text;
using System.Collections;

namespace MyShape
{
    class Program
    {

        public class Circle
        {
            public int X { get; set; }  // circle centre x-coordinate
            public int Y { get; set; }  // circle centre y-coordinate
            public int R { get; set; }  // circle radius

            public Circle() { X = 100; Y = 100; R = 100; }
            public Circle(int x, int y, int r) { X = x; Y = y; R = r; }

            public override string ToString()
            {
                // convert the Object to a string
                string dispXYR = String.Format("Circle at ({0},{1}) R={2}.", X, Y, R);

                // convert the object to an SVG element descriptor string for circle
                // note this contains the SVG canvas wrapper also - not ideal really
                string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">" + Environment.NewLine;
                string svgClose = Environment.NewLine + @"</svg>";
                string dispSVG = String.Format(@"<circle cx=""{0}"" cy=""{1}"" r=""{2}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", X, Y, R);

                //return svgOpen + "".PadLeft(3, ' ') + dispSVG + svgClose;
                return dispSVG;
            }
        }
        public class Rectangle
        {
            public int X { get; set; }  //Position X-coordinate
            public int Y { get; set; }  //Position Y-Coordinate

            public int Height {get; set;} //Height

            public int Width {get; set;} //Width

            public Rectangle() { X = 100; Y = 100; Height = 100; Width = 100;}
            public Rectangle(int x, int y, int height, int width) { X = x; Y = y; Height = height; Width=width;}

            public override string ToString()
            {
                // convert the Object to a string


                // convert the object to an SVG element descriptor string for circle
                // note this contains the SVG canvas wrapper also - not ideal really
                string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">" + Environment.NewLine;
                string svgClose = Environment.NewLine + @"</svg>";
                string dispSVG = String.Format(@"<rect x=""{0}"" y=""{1}"" height=""{2}"" width=""{3}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", X, Y,Height, Width);

                //return svgOpen + "".PadLeft(3, ' ') + dispSVG + svgClose;
                return dispSVG;
            }
        }

         public class Ellipse 
        {
            public int X { get; set; }  //Position X-coordinate
            public int Y { get; set; }  //Position Y-Coordinate
            public int RX {get; set;} //RX
            public int RY {get; set;} //RY

            public Ellipse() { X = 100; Y = 100; RX = 100; RY = 100;}
            public Ellipse(int x, int y, int rx, int ry) { X = x; Y = y; RX = rx; RY=ry;}

            public override string ToString()
            {


                // convert the object to an SVG element descriptor string for circle
                // note this contains the SVG canvas wrapper also - not ideal really
                string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">" + Environment.NewLine;
                string svgClose = Environment.NewLine + @"</svg>";
                string dispSVG = String.Format(@"<ellip x=""{0}"" y=""{1}"" rx=""{2}"" ry=""{3}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", X, Y,RX, RY);

                //return svgOpen + "".PadLeft(3, ' ') + dispSVG + svgClose;
                return dispSVG;
            }
        }
        public class Line {
            public int X1 { get; set; } 
            public int Y1 { get; set; }  
            public int X2 { get; set; }  
            public int Y2 { get; set; }   
            public Line() { X1 = 100; Y1=100; X2 = 100;Y2=100; }
            public Line(int x1, int y1, int x2, int y2) { X1 = x1; Y1=y1; X2=x2; Y2=y2;}

            public override string ToString()
            {
                // convert the object to an SVG element descriptor string for circle
                // note this contains the SVG canvas wrapper also - not ideal really
                string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">" + Environment.NewLine;
                string svgClose = Environment.NewLine + @"</svg>";
                string dispSVG = String.Format(@"<line x1=""{0}"" y1=""{1}"" x2 = ""{2}"" y2=""{3}"" style = ""fill:none;stroke:black;stroke-width:3"" />", X1,Y1,X2,Y2);

                //return svgOpen +  "".PadLeft(3, ' ') + dispSVG + svgClose;
                return dispSVG;
            }
        }

        public class Polyline 
        {
            public String points { get; set; }  
            public Polyline() { points = "20,20 40,25 60,40 80,120 120,140 200,180"; }
            public Polyline(String p) { points = p;}

            public override string ToString()
            {


                // convert the object to an SVG element descriptor string for circle
                // note this contains the SVG canvas wrapper also - not ideal really
                string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">" + Environment.NewLine;
                string svgClose = Environment.NewLine + @"</svg>";
                string dispSVG = String.Format(@"<polyl points=""{0}"" style = ""fill:none;stroke:black;stroke-width:3"" />", points);

                //return svgOpen +  "".PadLeft(3, ' ') + dispSVG + svgClose;
                return dispSVG;
            }
        }

        public class Polygon 
        {
            public String points { get; set; }  
            public Polygon() { points = "200,10 250,190 160,210"; }
            public Polygon(String p) { points = p;}

            public override string ToString()
            {


                // convert the object to an SVG element descriptor string for circle
                // note this contains the SVG canvas wrapper also - not ideal really
                string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">" + Environment.NewLine;
                string svgClose = Environment.NewLine + @"</svg>";
                string dispSVG = String.Format(@"<polyg points=""{0}"" style = ""fill:none;stroke:black;stroke-width:3"" />", points);

                //return svgOpen +  "".PadLeft(3, ' ') + dispSVG + svgClose;
                return dispSVG;
            }
        }

        static void Main(string[] args)
        {

            ArrayList arr = new ArrayList();

          
            Console.WriteLine("\nNow playing with Circle Class");
            Circle c1 = new Circle();
            arr.Add(c1.ToString());
           String dispSVGcir = c1.ToString();

            Console.WriteLine("\nNow playing with Rectangle Class");
             Rectangle r1 = new Rectangle();
             arr.Add(r1.ToString());
            String dispSVGrec = r1.ToString();


             Console.WriteLine("\nNow playing with Ellipse Class");
             Ellipse e1 = new Ellipse();
             arr.Add(e1.ToString());
            String dispSVGellip = e1.ToString();

            Console.WriteLine("\nNow playing with Line Class");
             Line l1 = new Line();
             arr.Add(l1.ToString());
            String dispSVGline = l1.ToString();

             Console.WriteLine("\nNow playing with Polyline Class");
             Polyline pl1 = new Polyline();
             arr.Add(pl1.ToString());
             String dispSVGpolyl = pl1.ToString();

             Console.WriteLine("\nNow playing with Polygon Class");
             Polygon pg1 = new Polygon();
             arr.Add(pg1.ToString());
            String dispSVGployg= pg1.ToString();

            String path = @"./Shapes.svg";

         string[] toPrint = {dispSVGcir, dispSVGrec, dispSVGellip, dispSVGline,dispSVGpolyl, dispSVGployg};

            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(@"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">" + Environment.NewLine);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            using (StreamWriter sw = File.AppendText(path)){
                    for(int i = 0; i < toPrint.Length; i++){
                        sw.WriteLine(toPrint[i]);
                    }
            }

                        int caseSwitch = 1;

                         switch (caseSwitch)
                            {
                             case 1:
                                  Console.WriteLine("Case 1");
                                    break;
                                         case 2:
                                        Console.WriteLine("Case 2");
                                            break;
                                                default:
                                                 Console.WriteLine("Default case");
                                                    break;
      }
        



                
                String dispSVG = "";
                for(int i=0;i<arr.Count;i++){
                dispSVG = (String)arr[i];
                using (StreamWriter sw = File.AppendText(path)){
                    sw.WriteLine("".PadLeft(3, ' ') + dispSVG);
                }
                Console.WriteLine(dispSVG);
            }
               



            // Open the stream and read it back.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                    //Console.WriteLine("Hello World");
                }
            }

        }
    }

}