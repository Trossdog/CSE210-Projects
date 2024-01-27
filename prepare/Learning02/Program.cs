using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company = "Microsoft Corporation";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Intel Corporation";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2014;
        job2._endYear = 2019;

        Resume resume1 = new Resume();
        resume1._name = "Tyler";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayDetails();
        


    }
}