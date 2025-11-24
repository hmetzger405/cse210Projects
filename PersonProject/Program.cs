using System.Security;

class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
        Console.WriteLine($" ${person.GetSalary()}");
    }
    public static void Main(string[] args)
    {
    //    Person myPerson = new Person("Holden", "Metzger", 22, 165);
    //    Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice =  new Police("Teaser, flash light", "Sally", "Jones", 34, 110);
        Console.WriteLine(myPolice.GetPoliceInformation());

        Doctor myDoctor = new Doctor("Stethoscope, needle", "Gregory", "House", 66, 180);
        Console.WriteLine(myDoctor.GetDoctorInformation());

        Surgeon mySurgeon = new Surgeon("Surgeon", "Hammer", "Tom", "Brady", 46, 230);
        Console.WriteLine(mySurgeon.GetSurgeonInformation());     
        mySurgeon.SetAge(47);
        mySurgeon.SetWeight(235);  
        Console.WriteLine(mySurgeon.GetSurgeonInformation());     

        Console.WriteLine("\n\n\n\n");

        List<Person> myPeople = new List<Person>();
        myPeople.Add(myDoctor);
    //    myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(mySurgeon);

        foreach(Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }
 }