namespace Algs.Performance
{
    internal class ProVsMem
    {        
        public void CPU ()
        {
            int x = 10000, y = 0;

            for (int itr = 0; itr < 10000000; itr++)
            {
                y += 10 + 10 + 10 + 10 + 10 + 10 + 10 + 10 + 10;

                x++;
            }

            y = y + x;
        }

        public void Memory ()
        {
            int x = 10000, y = 0;

            for (int i = 0; i < 10000000; i++)
            {
                y = x;

                x++;
            }

            y = y + x;
        }
    }
}
