class Elevator
{

    public int FloorCount { get; private set; }
    public int CurrentFloor { get; private set; }
    public bool IsMoving { get; private set; }

    public Elevator(int _floorcount)
    {
        FloorCount = _floorcount;
        IsMoving = false;
        CurrentFloor = 1;
    }

    public void Start(int _target)
    {
        if (IsMoving)
        {
            Console.WriteLine("Already on the move");
            return;
        }

        if (_target == CurrentFloor)
        {
            Console.WriteLine("Already in the target floor.");
            return;
        }

        if (_target < 1 || _target > FloorCount)
        {
            Console.WriteLine("Invalid target floor.");
            return;
        }

        // mennään ylös
        else if (_target > CurrentFloor)
        {
            IsMoving = true;
            for (int i = CurrentFloor; i < _target; i++)
            {
                CurrentFloor++;
                PrintLocation();
            }
        }

        // mennään alas 
        if (_target < CurrentFloor)
        {
            IsMoving = true;
            for (int i = CurrentFloor; i > _target; i--)
            {
                CurrentFloor--;
                PrintLocation();
            }
        }
        Console.WriteLine($"Target floor ({_target}) reached!");
        IsMoving = false;
    }

    public void PrintLocation()
    {
        for (int i = 1; i < FloorCount + 1; i++)
        {
            if (i == CurrentFloor)
            {
                Console.Write("[");
            }

            Console.Write(i);

            if (i == CurrentFloor)
            {
                Console.Write("]");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}