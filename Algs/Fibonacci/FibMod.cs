﻿using System;
using System.Collections.Generic;

namespace Algs.Fibonacci
{
    public class FibMod
    {
        public Int64 CalculateFibModuloM (Int64 n, Int64 m)
        {
            var binary = StringToArray(Convert.ToString(n, 2));
            var length = binary.Count;

            Int64 FibkMinusOne = 0;
            Int64 Fibk = 1;

            Int64 Fib2kMinusOne;
            Int64 Fib2k;
            Int64 Fib2kPlusOne;

            Int64 k = 1;

            for (int i = 1; i < length; i++)
            {
                Fib2kMinusOne = CalculateTwiceMinusOne(Fibk, FibkMinusOne, m);
                Fib2kPlusOne = CalculateTwicePlusOne(Fibk, FibkMinusOne, k, m);
                Fib2k = CalculateTwice(Fib2kPlusOne, Fib2kMinusOne, m);

                if (Convert.ToUInt16(binary[i]) == 0)
                {
                    k = 2 * k;
                    Fibk = Fib2k;
                    FibkMinusOne = Fib2kMinusOne;
                }

                else
                {
                    k = 2 * k + 1;
                    Fibk = Fib2kPlusOne;
                    FibkMinusOne = Fib2k;
                }
            }

            return Fibk % m;
        }

        public int CalculateSumFibkMod10 (int k)
        {
            int MaxIterations = (k + 1) % 60;

            int result = GetPisanoTenSumModTen(MaxIterations);

            return result;
        }

        public int CalculateSumFibmTonMod10 (int m, int n)
        {
            int FibM = GetFibkModTen(m);            
            int sum = FibM;

            if (n - m >= 60)
            {
                sum += GetPisanoTenSumModTen(59, (m + 1) % 60);
                sum += GetPisanoTenSumModTen((n + 1) % 60);
            }

            else
            {
                sum += GetPisanoTenSumModTen(n % 60, (m + 1) % 60);
            }

            return sum % 10;
        }

        #region Helpers

        private int GetPisanoTenSumModTen (int MaxIterations)
        {
            int[] Fibs = new int[MaxIterations];

            Fibs[0] = 0;
            Fibs[1] = 1;

            for (int i = 2; i < MaxIterations; i++)
            {
                Fibs[i] = (Fibs[i - 1] + Fibs[i - 2]) % 10;
            }

            int sum = 0;

            for (int i = 0; i < MaxIterations; i++)
            {
                sum += Fibs[i];
            }

            return sum % 10;
        }

        private int GetPisanoTenSumModTen (int MaxIterations, int start)
        {
            int[] Fibs = new int[MaxIterations + 1];

            Fibs[0] = 0;
            Fibs[1] = 1;

            for (int i = 2; i <= MaxIterations; i++)
            {
                Fibs[i] = (Fibs[i - 1] + Fibs[i - 2]) % 10;
            }

            int sum = 0;

            for (int i = start; i <= MaxIterations; i++)
            {
                sum += Fibs[i];
            }

            return sum % 10;
        }

        private int GetFibkModTen (int k)
        {
            int Iterations = k % 60;

            int[] Fibs = new int[Iterations + 1];

            Fibs[0] = 0;
            Fibs[1] = 1;

            int i;

            for (i = 2; i <= Iterations; i++)
            {
                Fibs[i] = Fibs[i - 1] + Fibs[i - 2];
            }

            return Fibs[i - 1] % 10;
        }

        private Int64 CalculateTwice (Int64 Fib2kPlusOne, Int64 Fib2kMinusOne, Int64 mod)
        {
            return Fib2kPlusOne < Fib2kMinusOne ? mod - Math.Abs(Fib2kPlusOne - Fib2kMinusOne) : Fib2kPlusOne - Fib2kMinusOne;
        }

        private Int64 CalculateTwiceMinusOne (Int64 Fibk, Int64 FibkMinusOne, Int64 mod)
        {
            var result = ((Fibk * Fibk) + (FibkMinusOne * FibkMinusOne)) % mod;

            return result;
        }

        private Int64 CalculateTwicePlusOne (Int64 Fibk, Int64 FibkMinusOne, Int64 k, Int64 mod)
        {
            Fibk = Fibk < FibkMinusOne ? Fibk + mod : Fibk;

            var result = Math.Abs(((4 * (Fibk * Fibk)) - (FibkMinusOne * FibkMinusOne) + (2 * (k % 2 == 0 ? 1 : -1)))) % mod;

            return result;
        }

        private List<int> StringToArray (string number)
        {
            var chars = number.ToCharArray();
            List<int> binary = new List<int>();
            var length = chars.Length;

            for (int i = 0; i < length; i++)
            {
                binary.Add(Int32.Parse(chars[i].ToString()));
            }

            return binary;
        }

        private int NumberOfDigits (Int64 number)
        {
            int count = 0;

            while (number / 10 != 0)
            {
                count++;
                number /= 10;
            }

            count++;

            return count;
        }
        #endregion
    }
}