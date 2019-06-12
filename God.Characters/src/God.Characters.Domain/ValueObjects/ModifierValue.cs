namespace God.Characters.Domain.ValueObjects
{
    public struct ModifierValue
    {
        public int Value { get; set; }
        public ModifierValue(int attribute)
        {
            Value = 0;
            int modifier = 10;
            do
            {
                if (modifier == attribute || (modifier + 1) == attribute)
                    return;
                if (modifier > attribute)
                {
                    Value--;
                    modifier -= 2;
                }
                else
                {
                    Value++;
                    modifier += 2;
                }
            }
            while (true);
        }
    }
}
