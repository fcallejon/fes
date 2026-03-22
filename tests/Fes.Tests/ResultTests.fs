namespace Fes.Tests

open Fes
open Xunit

module ResultTests =

    [<Fact>]
    let ``Result.sequence returns Ok list when all results are Ok`` () =
        let results = [ Ok 1; Ok 2; Ok 3 ]
        let actual = Result.sequence results
        Assert.Equal(Ok [ 1; 2; 3 ], actual)

    [<Fact>]
    let ``Result.sequence returns first Error when any result is Error`` () =
        let results = [ Ok 1; Error "first error"; Ok 3; Error "second error" ]
        let actual = Result.sequence results
        Assert.Equal(Error "first error", actual)

    [<Fact>]
    let ``Result.sequence returns Ok empty list for empty input`` () =
        let results : Result<int, string> list = []
        let actual = Result.sequence results
        Assert.Equal(Ok [], actual)

    [<Fact>]
    let ``Result.sequence returns Error for single Error input`` () =
        let results = [ Error "only error" ]
        let actual = Result.sequence results
        Assert.Equal(Error "only error", actual)

    [<Fact>]
    let ``Result.sequence preserves order of Ok values`` () =
        let results = [ Ok "a"; Ok "b"; Ok "c" ]
        let actual = Result.sequence results
        Assert.Equal(Ok [ "a"; "b"; "c" ], actual)
