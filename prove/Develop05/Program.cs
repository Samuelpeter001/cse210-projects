class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();

        ListingActivity listingActivity = new ListingActivity();

        ReflectingActivity reflectingActivity = new ReflectingActivity();
    }
    Console.Write("Choose an option: ");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            breathingActivity.Run()
            break;
        case 2:
            listingActivity.Run();
            break;
        case 3:
            reflectingActivity.Run();
            break;
    }
}
