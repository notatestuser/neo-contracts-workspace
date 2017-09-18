using System;
using System.Linq;
using System.Text;
using Neo.Cryptography;
using Neo.VM;
using Testbox.Utilities;
using Xunit;

namespace Testbox
{
    public class Test_HelloWorld
    {
	[Fact]
	public void HelloWorld()
	{
	    byte[] program = ExecutionHelper.Compile(nameof(HelloWorld));

	    using (ExecutionEngine ee = new ExecutionEngine(null, Crypto.Default, null, null))
	    {
		ee.LoadScript(program);
		ee.Execute();
	    }
	}
    }
}
