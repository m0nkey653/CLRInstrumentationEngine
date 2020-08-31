// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace SingleRetDefaultInstrumentationTest
{
    class Program
    {
        static int Main(string[] args)
        {
            int error = 0;

            TwoReturnsAndBranchTest();

            return error;
        }

        private static void TwoReturnsAndBranchTest()
        {
            int x = 0;
            if (x == 3)
            {
                System.Console.WriteLine(x.ToString());
                return;
            }

            System.Console.WriteLine(x.ToString());
            return;
        }
    }
}
