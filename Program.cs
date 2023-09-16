namespace T08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exHour = int.Parse(Console.ReadLine());
            int exMins = int.Parse(Console.ReadLine());
            int arrHour = int.Parse(Console.ReadLine());
            int arrMins = int.Parse(Console.ReadLine());

            String status = "";

            int exTimeMins = exHour * 60 + exMins;
            int arrTimeMins = arrHour * 60 + arrMins;
            int difference = arrTimeMins - exTimeMins;


            if (-30 <= difference && difference <= 0)
            {
                status = "On time";
            }
            else if (difference > 0)
            {
                status = "Late";
            }
            else if (-30 > difference)
            {
                status = "Early";
            }

            Console.WriteLine(status);

            difference = Math.Abs(difference);
            int difhours;
            int difMinutes;
            difhours = difference / 60;
            difMinutes = difference % 60;

            switch (status)
            {
                case "Early":
                    if (difference >= 60)
                    {
                        Console.WriteLine($"{difhours}:{difMinutes} hours before the start");
                    }
                    else
                        Console.WriteLine($"{difMinutes} minutes before the start");
                    break;

                case "On time":
                    if (difference > 0)
                    {
                        Console.WriteLine($"{difMinutes} minutes before the start");
                    }                        
                    break;

                case "Late":
                    if (difference >= 60)
                    {
                        Console.WriteLine($"{difhours}:{difMinutes} hours after the start");
                    }
                    else
                        Console.WriteLine($"{difMinutes} minutes after the start");
                    break;

            }
        }
    }
}