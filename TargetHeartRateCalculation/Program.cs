using System;
class HeartRate
{
    private string? firstName;
    private string? lastName;
    private int yearBirth;
    private int currentYear;

    public HeartRate(string? firstName, string? lastName, int yearBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.yearBirth = yearBirth;
        this.currentYear = DateTime.Today.Year;
    }
    // end of HeartRate class constructor

    public string? FirstName 
    { 
        get { return firstName; } 
        set { firstName = value; } 
    }
    // end of FirstName property

    public string? LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    // end of LastName property

    public int YearBirth
    {
        get { return yearBirth; }
        set { yearBirth = value; }
    }
    // end of YearBirth property

    public int PersonAge
    {
        get { return Convert.ToInt32(currentYear - YearBirth); }
    }
    // end of PersonAge property

    public int MaxHeartRate
    {
        get { return 220 - PersonAge; }
    }
    // end of MaxHeartRate property

    public int MinTargetRate
    {
        get { return Convert.ToInt32(MaxHeartRate * 0.5); }
    }
    // end of MinTargetRate property

    public int MaxTargetRate
    {
        get { return Convert.ToInt32(MaxHeartRate * 0.85); }
    }
    // end of MaxTargetRate property

    static void Main(string[] args)
    {
        string? fName;
        string? lName;
        int yearOfBirth;

        Console.Write("Enter Your First Name: ");
        fName = Console.ReadLine();

        Console.Write("Enter Your Last Name: ");
        lName = Console.ReadLine();

        Console.Write("Enter Your Year of Birth: ");
        yearOfBirth = Convert.ToInt32(Console.ReadLine());

        HeartRate heartRate = new HeartRate(fName, lName, yearOfBirth);

        Console.WriteLine();

        Console.WriteLine("Name: " + heartRate.FirstName + " " + heartRate.LastName);
        Console.WriteLine("Current Age: " + heartRate.PersonAge);
        Console.WriteLine("Maximum Heart Rate: " + heartRate.MaxHeartRate);
        Console.WriteLine("Target Heart Rate Range: " + (heartRate.MaxHeartRate - heartRate.MinTargetRate));
    }
    // end of Main method
}
// end of HeartRate class