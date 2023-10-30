namespace TransportManagement
{
    // Базовый класс для транспорта
    abstract class Transport
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public bool IsRented { get; set; }

        public abstract void PrintInfo();
    }
}

   