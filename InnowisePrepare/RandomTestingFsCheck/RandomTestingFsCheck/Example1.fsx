open Xunit
open FsUnit.Xunit

[<Fact>]
let ``Modulo operation should return 0`` () =
    let result = 10 % 5
    result |> should equal 0