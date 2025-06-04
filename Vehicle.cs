public abstract class Vehicle
{
    public string ModelName { get; }
    public DateTime RegistrationDate { get; }
    public DateTime EntryDate { get; }

    public Vehicle(string _modelName, DateTime _registrationDate)
    {
        ModelName = _modelName;
        RegistrationDate = _registrationDate;
        EntryDate = DateTime.Now;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Rumore veicolo");
    }

    public abstract String Type{ get; }

    public abstract int GetVehicleAge();
    public abstract int GetDaysInParking();
}
