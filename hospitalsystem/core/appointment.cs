

using System.Reflection.Metadata;

namespace hospitalsystem.core {
class Appointment
{
    public void schedule( string PatientName , string DoctorName )
    {
        Console.WriteLine("Appointment scheduled for Patient: {PatientName} with Doctor: {DoctorName} ");
    }
     public void schedule(string PatientName ,string DoctorName ,DateTime date,string mode="offline")
    {
        Console.WriteLine("Appointment scheduled for Patient: {P.NAME} with Doctor: {D.NAME} on {date} via {mode} ");

        
    }
}}