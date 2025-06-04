using System.Diagnostics.Contracts;

public class Motorbike : Vehicle
{

    public Motorbike(string _modelName, DateTime _registrationDate) : base(_modelName, _registrationDate)
    {

    }

    public override void Sound()
    {
        Console.WriteLine("Brummmm!");
    }

    public override string Type
    {
        get { return "Motorbike"; }
    }

    public override int GetDaysInParking()
    {
        int days = (DateTime.Now.Day - EntryDate.Day).days;
        if (DateTime.Now.AddDays(-days) < EntryDate)
        {
            days--;
        }

        return days;
    }

    public override int GetVehicleAge()
    {
        int years = (DateTime.Today - RegistrationDate.Year).years;
        if (RegistrationDate.Date > DateTime.Today.AddYears(-years))
        {
            years--;
        }

        return years;
    }

   public override string ToString()
    {
        return  "- Model: " + ModelName + "\n" +
                "- Type: " + Type + "\n" +
                "- RegistrationDate: " + RegistrationDate + "\n" +
                "- EntryDate: " + EntryDate + "\n" +
                "- Age = " + GetVehicleAge() + "\n" +
                "- Time in Parking: " + GetDaysInParking() + " days";
    }
}