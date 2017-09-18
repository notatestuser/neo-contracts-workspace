using System;
using Neo.SmartContract.Framework;

namespace Calculator
{
    public class Calculator : SmartContract
    {
	public static int Main(int a, int b)
	{
	    return a + b;
	}
    }
}
