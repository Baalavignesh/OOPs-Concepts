namespace OOPs_Concepts
{
    internal class CaloriesTracker
    {
        public CaloriesTracker()
        {
            Console.WriteLine("Parent Class");
        }
        static void Main(string[] args)
        {

            FoodDetails f1 = new FoodDetails();
            f1.AddFood("potato", 100);


            UserDetails u1 = new UserDetails();
            u1.CreateUser();

            u1.FoodConsumed();
            double final_result = u1.CalculateCalories();
            Console.WriteLine(final_result);

            if(final_result > 0)
            {
                Console.WriteLine($"Eat more food, {final_result} calories pending");
            }
            else
            {
                Console.WriteLine($"Eat less food, {final_result} calories exceeded");
            }


        }
    }
}