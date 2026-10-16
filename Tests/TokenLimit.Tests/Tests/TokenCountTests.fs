namespace TokenLimit.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open TokenLimit.Domain

[<TestClass>]
type TokenCountTests () =

    [<TestMethod>]
    member this.ValidTokenCreation () =
        match TokenCount.create 5u with 
        | Ok count -> Assert.AreEqual(5u, TokenCount.value count)
        | Error message -> Assert.Fail $"Expected Ok, got Error: {message}"

    [<TestMethod>]
    member this.InvalidTokenCreation () =
        match TokenCount.create 0u with
        | Error message -> Assert.IsNotEmpty message
        | Ok count -> Assert.Fail $"Expected Error, got Ok: {TokenCount.value count}"
