using System;
namespace hospitalsystem.core
{
class Doctor
{
    public static int totalDoctors;
    public readonly int LicenseNumber;
    public string Name { get; set; }
    static Doctor()
    {
        totalDoctors = 0;
    }
    public Doctor(string Name,int licenseNumber)
    {
        this.Name = Name;
        this.LicenseNumber = licenseNumber;
        totalDoctors++;
    }
    
}}