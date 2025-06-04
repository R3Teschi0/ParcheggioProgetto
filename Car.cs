public class Car : Vehicle
{

    public Car(string _modelName, DateTime _registrationDate) : base(_modelName, _registrationDate)
    {

    }

    public override void Sound()
    {
        Console.WriteLine("Vrooom!");
    }

    public override string Type
    {
        get { return "Car"; }
    }

    public override int GetDaysInParking()
    {
        int days = (DateTime.Today - EntryDate.Day).days;
        if (DateTime.Now.AddDays(-days) < EntryDate)
        {
            days--;
        }

        return days;
    }

    public override int GetVehicleAge()
    {
        int years = (DateTime.Now.Year - RegistrationDate.Year).years;
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
