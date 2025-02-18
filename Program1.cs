﻿namespace DefaultNamespace;

using System;
using System.Collections.Generic;
// abstract JobRole class 
public abstract class JobRole{
    public string Name { get; set; }
    public string Skills { get; set; }
}
//  softwareEngineer class
public class SoftwareEngineer : JobRole{
    public SoftwareEngineer(){
        Name = "Software Engineer";
        Skills = "C#, .NET, SQL, Problem Solving";
    }
}

public class DataScientist : JobRole{
    public DataScientist(){
        Name = "Data Scientist";
        Skills = "Python, R, Machine Learning, Data Analysis";
    }
}
// generic class for Resume
public class Resume<T> where T : JobRole{
    public T JobRole { get; set; }
    public string CandidateName { get; set; }
    public string CandidateSkills { get; set; }
    public Resume(T jobRole, string candidateName, string candidateSkills){
        JobRole = jobRole;
        CandidateName = candidateName;
        CandidateSkills = candidateSkills;
    }
    public bool IsQualified(){
        return CandidateSkills.Contains(JobRole.Skills);
    }
}

// Screening pipeline
public class ScreeningPipeline{
    private List<JobRole> jobRoles = new List<JobRole>();
    public void AddJobRole(JobRole jobRole){
        jobRoles.Add(jobRole);
    }
    public void ProcessResumes<T>(List<Resume<T>> resumes) where T : JobRole{
        foreach (var resume in resumes){
            Console.WriteLine($"Processing resume for {resume.CandidateName} applying for {resume.JobRole.Name}");
            if (resume.IsQualified()){
                Console.WriteLine($"{resume.CandidateName} is qualified for the {resume.JobRole.Name} position.");
            }
            else{
                Console.WriteLine($"{resume.CandidateName} is not qualified for the {resume.JobRole.Name} position.");
            }
        }
    }
}
public class Program1{
    public static void Main(){
        var softwareEngineerRole = new SoftwareEngineer();
        var dataScientistRole = new DataScientist();
        var resumes = new List<Resume<JobRole>>{
            new Resume<JobRole>(softwareEngineerRole, "Mogambo", "C#, .NET, SQL"),
            new Resume<JobRole>(dataScientistRole, "James Bond", "Python, R, Machine Learning, Data Analysis")
        };
        var screeningPipeline = new ScreeningPipeline();
        screeningPipeline.AddJobRole(softwareEngineerRole);
        screeningPipeline.AddJobRole(dataScientistRole);
        screeningPipeline.ProcessResumes(resumes);
    }
}

