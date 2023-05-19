﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        int[] populations = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int maxCustomers = 0;

        for (int i = K; i <= N; i++)
        {
            int totalCustomers = 0;

            for (int j = i - K; j <= i + K && j < N; j++)
            {
                totalCustomers += populations[j];
            }

            if (totalCustomers > maxCustomers)
            {
                maxCustomers = totalCustomers;
            }
        }

        Console.WriteLine(maxCustomers);
    }
}
