namespace Builder.Components
{
     class Engine
     {
        public Engine(double power)
        {
            Power = power;
        }

        private double power;

        public double Power 
        {
            get => power; 
            set => power = value; 
        }
     }
}
