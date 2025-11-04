using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;



class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "GPU Architecture Engineer";
        job1._company = "Nvidia";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "McDonald's";
        job2._startYear = 2008;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "Holden Metzger";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


    }

}