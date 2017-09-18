using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Neo.Compiler.MSIL;
using Neo.VM;

namespace Testbox.Utilities
{
    public static class ExecutionHelper
    {
#if DEBUG
	private const string Directory = "Debug/netstandard1.6";
#else
	private const string Directory = "Release/netstandard1.6";
#endif

	private const string SmartContractDirectory = "../../../../";

	public static byte[] Compile(string projectName)
	{
	    return Converter.Convert(new FileStream(Path.Combine(SmartContractDirectory, projectName, $@"bin/{Directory}", $"{projectName}.dll"), FileMode.Open));
	}
    }
}
