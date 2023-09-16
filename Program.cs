namespace T09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            String roomType = Console.ReadLine();
            String assessment = Console.ReadLine();
            double roomPrice = 0.0;
            switch (roomType)
            {
                case "room for one person":
                    roomPrice = (days - 1) * 118;
                    break;

                case "apartment":
                    roomPrice = (days - 1) * 155;
                    if (days < 10)
                    {
                        roomPrice *= 0.7;
                    }
                    else if (10 < days && days < 15)
                    {
                        roomPrice *= 0.65;
                    }
                    else if (days > 15)
                    {
                        roomPrice *= 0.5;
                    }
                    break;


                case "president apartment":
                    roomPrice = (days - 1) * 235;
                    if (days < 10)
                    {
                        roomPrice *= 0.9;
                    }
                    else if (10 < days && days < 15)
                    {
                        roomPrice *= 0.85;
                    }
                    else if (days > 15)
                    {
                        roomPrice *= 0.8;
                    }
                    break;

            } if (assessment == "positive")
                    {
                        roomPrice *= 1.25;
                    }
                    else
                        roomPrice *= 0.9;
            
            Console.WriteLine(roomPrice.ToString("F2"));
        }
    }
}