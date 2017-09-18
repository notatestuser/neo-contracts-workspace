# Neo.Sandbox
A project to explore and learn more about the NEO code base.

This project allows you to easily create and execute smart contracts locally. The solution is set up to be checked out along with the [Neo.Ecosystem](https://github.com/vardthomas/Neo.Ecosystem) project. In order for all of the project references to be resolved correcty, your root folder should look like this:

* Neo.Ecosystem/
* Neo.Sandbox/

You should fork this project and use it as a playground to experiment with compiling and executing smart contracts. The solution is laid out as follows:

* 'neo' solution folder - contains neo core project references
* 'smart_contracts' - contains example smart contracts
* Testbox project - unit test project used to compile and run smart contracts

### Using the solution

To experiment with your own smart contracts, you should do the following:

1. Create a project for the smart contract in the 'src/' directory.
2. Add the new project as a build dependency to the 'Testbox' project.
3. Create a new unit test that compiles and runs the smart contract (see [Test_HelloWorld](https://github.com/vardthomas/Neo.Sandbox/blob/master/src/Testbox/Test_HelloWorld.cs)) for reference
4. Once you've implemented the smart contract code, debug the unit test to step through compilation and execution.
