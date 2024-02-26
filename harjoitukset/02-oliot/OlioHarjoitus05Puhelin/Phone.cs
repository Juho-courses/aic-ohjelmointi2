class Phone
{
    public string Manufacturer { get; private set; }
    public bool CallOnGoing { get; private set; } = false;
    public string Number { get; private set; }

    public Phone(string manufacturer)
    {
        Manufacturer = manufacturer;
    }

    public Phone()
    {

    }

    public void Call(string _number)
    {
        if (CallOnGoing)
        {
            Console.WriteLine($"Call already ongoing with {Number}");
            return;
        }
        CallOnGoing = true;
        Number = _number;
        Console.WriteLine($"Calling number {Number}");
    }

    public void EndCall()
    {
        if (!CallOnGoing)
        {
            Console.WriteLine("No call to hang up.");
            return;
        }

        CallOnGoing = false;
        Number = "";
        Console.WriteLine("Hanging up.");
    }
}