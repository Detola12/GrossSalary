class Program{
         
    // An array that stores the number of sales person in different salary range
    static int[] rangeOfSalary = new int[9]; // each index of the array represent a range 


    static void Main(){
        //Array of all gross sales made by each sales person
        int[] grossSales = new int[] {2400, 900, 7000, 3100, 2000, 10000, 9000, 6750, 800, 250, 580};        

        int count = 0; // To get the index to fix each range
        foreach(int sale in grossSales){
            double salary = (0.09 * sale) + 200;
            count = (int)(salary - 200)/100;
            CheckRange(count, salary);
        }

        PrintResult();
        
   }

    //A function to check if a salary is within a particular range
   static void CheckRange(int index, double salary){
            if(salary >= 200 && salary <= 299){
                rangeOfSalary[index]++;
            }
            else if(salary >= 300  && salary < 399){
                rangeOfSalary[index]++;
            }
            else if(salary >= 400  && salary < 499){
                rangeOfSalary[index]++;
            }
            else if(salary >= 500  && salary < 599){
                rangeOfSalary[index]++;
            }
            else if(salary >= 600  && salary < 699){
                rangeOfSalary[index]++;
            }
            else if(salary >= 700  && salary < 799){
                rangeOfSalary[index]++;
            }
            else if(salary >= 800  && salary < 899){
                rangeOfSalary[index]++;
            }
            else if(salary >= 900  && salary < 999){
                rangeOfSalary[index]++;
            }
            else if(salary >= 1000){
                rangeOfSalary[^1]++;
            }
            else{
                Console.WriteLine("Something Went Wrong");
            }
   }

    //A function to Print how many of the salespeople earned salaries in particular ranges
   static void PrintResult(){
        Console.WriteLine("Salary Range             Number of SalesPerson");
        int counter = 2;
        foreach(int items in rangeOfSalary){
            if(counter <= 9){
                Console.WriteLine($"${counter}00 - ${counter}99                       {items}");
            }
            else{
                Console.WriteLine($"$1000 and over                    {items}");
            }
            counter++;
        }
   }
}