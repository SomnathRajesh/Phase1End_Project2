using Project_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome User");
        int option;
        do
        {
            Console.WriteLine("Enter the number of the function you want to perform");
            Console.WriteLine("1. Store Data\n2. Retrieve Data\n3. Update Data");
            int n = int.Parse(Console.ReadLine());


            switch (n)
            {
                case 1:
                    StoreData storeData = new StoreData();
                    storeData.Save();
                    break;
                case 2:
                    RetrieveData retrieveData = new RetrieveData();
                    retrieveData.FetchData();
                    break;
                case 3:
                    UpdateData updateData = new UpdateData();
                    updateData.Update();
                    break;
                default:
                    Console.WriteLine("Invalid Entry!!");
                    break;

            }
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("1. Yes\n2. No");
            option = int.Parse(Console.ReadLine());
        } while (option == 1);
    }
}