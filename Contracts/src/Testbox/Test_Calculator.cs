using System;
using System.Linq;
using System.Text;
using Neo.Cryptography;
using Neo.VM;
using Testbox.Utilities;
using Xunit;

namespace Testbox
{
    public class Test_Calculator
    {
	[Fact]
	public void Calculator()
	{
	    byte[] program = ExecutionHelper.Compile(nameof(Calculator));

	    using (ScriptBuilder sb = new ScriptBuilder())
	    using (ExecutionEngine ee = new ExecutionEngine(null, Crypto.Default, null, null))
	    {
		ee.LoadScript(program);

		sb.EmitPush(5);
		sb.EmitPush(5);

		ee.LoadScript(sb.ToArray());
		ee.Execute();

		var result = ee.EvaluationStack.Peek().GetBigInteger(); // set the return value here
		Assert.Equal(result, 10);
	    }
	}
    }
}
