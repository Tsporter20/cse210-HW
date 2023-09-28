using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Gameplay Porgrammer";
        job1._company = "Bungie Inc.";
        job1._startdate = 2017;
        job1._enddate = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Game Director";
        job2._company = "Ubisoft";
        job2._startdate = 2021;
        job2._enddate = 2023;

        Resume myResume = new Resume();
        myResume._name = "Talmage Porter";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}