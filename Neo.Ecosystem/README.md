# Neo.Ecosystem

[NEO](https://neo.org/) is an open source public chain project that sallows for a smarter way for asset registration, issuance, and circulation.

The Neo.Ecosystem project combines the core NEO projects into one solution. It is meant to be the fastest and easiest way to get familiar with the code behind the foundation for NEO. Namely, you'll find the following projects added as submodules:

### Core NEO Libraries:

 * [neo-cli](https://github.com/vardthomas/neo-cli) - Command line implementation of a NEO client
 * [neo-gui](https://github.com/vardthomas/neo-gui) - WinForms GUI implementation of a NEO client
 * [neo-compiler](https://github.com/vardthomas/neo-compiler) - Contains projects to compile to NEO virtual machine language
 * [neo-vm](https://github.com/vardthomas/neo-vm) - NEO virtual machine
 * [neo](https://github.com/vardthomas/neo) - Core NEO library
 * [neo-devpack-dotnet](https://github.com/vardthomas/neo-devpack-dotnet) - Visual Studio project templates for creating smart contracts

### Unit Tests:

 * [Neo.VM.Tests](https://github.com/vardthomas/Neo.VM.Tests) - Unit tests for the NEO virtual machine
 * [Neo.Compiler.Tests](https://github.com/vardthomas/Neo.Compiler.Tests) - Unit tests for the NEO compiler


### Utility Libraries:

 * [leveldb](https://github.com/vardthomas/leveldb) - LevelDB database

 ### Getting Started

After checking out the source, run the following command to pull down all submodules:

```sh
$ git submodule update --init --recursive
```
NOTE: Since this solution compiles leveldb and copies the resulting dll to the output directories of neo-gui project, you cannot target "Any CPU". You'll need to target x64 or x86.
