using System;

class PatientBill
{
    public string? Billid { get; set; }
    public string? Patientname { get; set; }
    public bool Hasinsured { get; set; }

    public decimal Concultationfee { get; set; }
    public decimal labcharges { get; set; }
    public decimal Medicinecharges { get; set; }

    public decimal GrossAmount { get; set; }
    public decimal discountamount { get; set; }
    public decimal Finalpayable { get; set; }
}

public class BillOperations
{
    static PatientBill? LastBIll;
    static bool HasLastBill = false;

    // CREATE BILL
    public static void CreateBill()
    {
        PatientBill bill = new PatientBill();

        Console.WriteLine("ENTER THE BILL ID:");
        bill.Billid = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(bill.Billid))
        {
            Console.WriteLine("INVALID BILL ID");
            return;
        }

        Console.WriteLine("ENTER THE PATIENT NAME:");
        bill.Patientname = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(bill.Patientname))
        {
            Console.WriteLine("INVALID PATIENT NAME");
            return;
        }

        Console.WriteLine("Is the patient insured? (Y/N):");
        string? insuranceInput = Console.ReadLine();

        if (insuranceInput == null)
        {
            Console.WriteLine("INVALID INSURANCE INPUT");
            return;
        }

        if (insuranceInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
            bill.Hasinsured = true;
        else if (insuranceInput.Equals("N", StringComparison.OrdinalIgnoreCase))
            bill.Hasinsured = false;
        else
        {
            Console.WriteLine("INVALID INSURANCE OPTION");
            return;
        }

        Console.WriteLine("ENTER THE CONSULTATION FEE:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal consultation) || consultation <= 0)
        {
            Console.WriteLine("INVALID CONSULTATION FEE");
            return;
        }
        bill.Concultationfee = consultation;

        Console.WriteLine("ENTER THE LAB CHARGES:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal lab) || lab < 0)
        {
            Console.WriteLine("INVALID LAB CHARGES");
            return;
        }
        bill.labcharges = lab;

        Console.WriteLine("ENTER THE MEDICINE CHARGES:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal medicine) || medicine < 0)
        {
            Console.WriteLine("INVALID MEDICINE CHARGES");
            return;
        }
        bill.Medicinecharges = medicine;

        // BILL CALCULATIONS
        bill.GrossAmount = bill.Concultationfee + bill.labcharges + bill.Medicinecharges;
        bill.discountamount = bill.Hasinsured ? bill.GrossAmount * 0.10m : 0;
        bill.Finalpayable = bill.GrossAmount - bill.discountamount;

        LastBIll = bill;
        HasLastBill = true;

        Console.WriteLine("BILL CREATED SUCCESSFULLY");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.discountamount:F2}");
        Console.WriteLine($"Final Payable: {bill.Finalpayable:F2}");
    }

    // VIEW LAST BILL
    public static void DisplayLastBill()
    {
        if (!HasLastBill || LastBIll == null)
        {
            Console.WriteLine("NO BILL AVAILABLE. PLEASE CREATE A NEW BILL.");
            return;
        }

        Console.WriteLine("----------- LAST BILL -----------");
        Console.WriteLine($"Bill Id: {LastBIll.Billid}");
        Console.WriteLine($"Patient Name: {LastBIll.Patientname}");
        Console.WriteLine($"Insured: {(LastBIll.Hasinsured ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {LastBIll.Concultationfee:F2}");
        Console.WriteLine($"Lab Charges: {LastBIll.labcharges:F2}");
        Console.WriteLine($"Medicine Charges: {LastBIll.Medicinecharges:F2}");
        Console.WriteLine($"Gross Amount: {LastBIll.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {LastBIll.discountamount:F2}");
        Console.WriteLine($"Final Payable: {LastBIll.Finalpayable:F2}");
        Console.WriteLine("--------------------------------");
    }

    // CLEAR BILL
    public static void Clear()
    {
        LastBIll = null;
        HasLastBill = false;
        Console.WriteLine("BILL CLEARED SUCCESSFULLY");
    }
}

