namespace Advanced_DSA.Problems.Bit_Manipulation;

public static class NPlus2
{
    private static readonly int N = 9;
    private static readonly int[] A = new int[] { 1, 2, 4, 5, 7, 8, 9, 10, 11 };

    public static int[] Missing2Numbers()
    {
        int XOR = 0;
        for(int i=0; i<A.Length; i++)
        {
            XOR = XOR ^ A[i];
        }

        for(int i=1; i<=N+2; i++)
        {
            XOR = XOR ^ i;
        }

        int pos = -1;
        for(int i=0; i<32; i++)
        {
            if((XOR & (1<<i)) > 0)
            {
                pos = i; break;
            }
        }

        int X = 0, Y = 0;
        for(int i=0; i<A.Length; i++)
        {
            if ((A[i] & (1 << pos)) > 0) X = X ^ A[i];
            else Y = Y ^ A[i];
        }

        for (int i = 1; i <=N+2; i++)
        {
            if ((i & (1 << pos)) > 0) X = X ^ i;
            else Y = Y ^ i;
        }

        return new int[2] { X, Y };
    }
}
