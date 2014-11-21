namespace FSharpSolver.Tests

open NUnit.Framework
open FsUnit

open FSharpSolver.Functions.ListSolutions

// Define your library scripting code here

module testmodule =

    [<TestFixture>]
    type ``Simple tests`` ()= 
            [<Test>] member test.
                ``test 1``()=
                    x |> should equal (1);
    
