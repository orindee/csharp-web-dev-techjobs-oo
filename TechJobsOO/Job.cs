using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                return "OOPS! This job does not seem to exist.";
            }
            
            if (Name.Equals(""))
                {
                    Name = "Data not available";
                }
            if (EmployerName.Value.Equals("") || EmployerName.Value == null)
                {
                    EmployerName.Value = "Data not available";
                }
            if (EmployerLocation.Value.Equals("") || EmployerLocation.Value == null)
                {
                    EmployerLocation.Value = "Data not available";
                }
            if (JobCoreCompetency.Value.Equals("") || JobCoreCompetency.Value == null)
                {
                    JobCoreCompetency.Value = "Data not available";
                }
            if (JobType.Value.Equals("") || JobType.Value == null)
                {
                    JobType.Value = "Data not available";
                }
                
                string jobListing = $"ID:{Id} \n " +
                $"Name:{Name} \n " +
                $"Employer:{EmployerName} \n " +
                $"Location:{EmployerLocation} \n " +
                $"Position Type:{JobType} \n " +
                $"Core Competency:{JobCoreCompetency}";

                return jobListing;
            }
        }
    }
