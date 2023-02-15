using Challenge21;

Employee user1 = new Employee ("Kasia", "Nowak", 30);
Employee user2 = new Employee ("Basia", "Kowalska", 40);
Employee user3 = new Employee ("Asia","Joanna", 50);

user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(4);
user1.AddScore(2);
user1.AddScore(2);

user2.AddScore(5);
user2.AddScore(4);
user2.AddScore(5);
user2.AddScore(6);
user2.AddScore(7);

user3.AddScore(7);
user3.AddScore(2);
user3.AddScore(7);
user3.AddScore(8);
user3.AddScore(9);

List<Employee> employess = new List<Employee>()
{
    user1, user2, user3
};
var maxResult = -1;
Employee userWithMaxResult = null;


foreach (var employee in employess)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        userWithMaxResult= employee;
        
    }
}
Console.WriteLine("Pracownik z największą ilością punktów ---  " + userWithMaxResult.Result + "\n" + userWithMaxResult.Name +"   " + userWithMaxResult.Surname + " wiek " + userWithMaxResult.Age);





