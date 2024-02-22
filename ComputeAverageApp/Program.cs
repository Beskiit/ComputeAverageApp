namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            int x = 0;
            double totalGrade = 0;
            Console.WriteLine("Enter 5 grades separated by new line: ");
            while(true)
            {
                int grade = Convert.ToInt32(Console.ReadLine());
                totalGrade += grade;
                x++;
                if(x == 5)
                {
                    break;
                }
            }

            double average = totalGrade / 5;
            Console.WriteLine("The average is " + average + " and round off to " + Math.Round(average));
        }
    }
}