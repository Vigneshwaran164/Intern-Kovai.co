using System;

namespace encapsulation
{
    class Patient
    {
        private string patientName ; 
        private string[] prescription ;
        private string testResultForFever ;

        public string PatientName   
        {
            get { return patientName; }
            set { patientName = value; }

        }
        public string[] Prescription
        {
            get { return prescription; }
            set { prescription = value; }

        }
        public string TestResultForFever
        {
            get { return testResultForFever; }
            set { testResultForFever = value; }
        }
        public void DisplayPatientRecord()
        {
            Console.WriteLine($"The Patient name is {patientName}");
            Console.WriteLine($"The prescription for {patientName} is {string.Join(", ",prescription)}");
            Console.WriteLine($"And the Test Result is {testResultForFever}");
        }


    }

    class MedicalSystem

    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            patient.PatientName = "Vigneshwaran R";
            patient.Prescription = new string[] {"paracetomol","dolo"};
            patient.TestResultForFever = "positive" ;
            patient.DisplayPatientRecord(); 
        }

    }

}