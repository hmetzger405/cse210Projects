class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Holden", "Metzger", 22, 165);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice =  new Police("Teaser, flash light", "Sally", "Jones", 34, 110);
        Console.WriteLine(myPolice.GetPoliceInformation());

        Doctor myDoctor = new Doctor("Stethoscope, needle", "Gregory", "House", 66, 180);
        Console.WriteLine(myDoctor.GetDoctorInformation());

        Surgeon mySurgeon = new Surgeon("Surgeon", "Hammer", "Tom", "Brady", 46, 230);
        Console.WriteLine(mySurgeon.GetSurgeonInformation());     
        mySurgeon.setAge(47);
        mySurgeon.setWeight(235);  
        Console.WriteLine(mySurgeon.GetSurgeonInformation());     
    }
 }