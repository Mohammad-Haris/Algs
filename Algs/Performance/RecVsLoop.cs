namespace Algs.Performance
{
    internal class RecVsLoop
    {
        internal int Recursive (int value, int x)
        {
            if (value < 1)
            {
                return x;
            }

            value--;
            x++;

            return Recursive(value, x);
        }

        internal int Loop (int length)
        {
            int x = 0;

            for (int i = 0; i < length; i++)
            {
                x++;
            }

            return x;
        }
    }
}
