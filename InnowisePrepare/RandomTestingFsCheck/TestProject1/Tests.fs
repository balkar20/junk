module Tests

open System
open FsCheck
open FsCheck.FSharp
open FsCheck.Xunit

// [<Fact>]
// let ``My test`` () =
//     Assert.True(true)
    
[<Property>]
let ``Reversing a list twice should result in the original list`` (lst: list<int>) =
    let reversedTwice = lst |> List.rev |> List.rev
    reversedTwice = lst
    
// Property: Doubling a number twice is equivalent to multiplying it by 4
[<Property>]
let ``Doubling a number twice is equivalent to multiplying it by 4`` (x: int) =
    let doubledTwice = x |> (+) x |> (+) x |> (+) x
    let multipliedByFour = x * 4
    doubledTwice = multipliedByFour
    
// Property: The sum of two positive integers is always greater than either of the two integers
[<Property>]
let ``Sum of two positive integers is greater than either integer`` (x: int, y: int) =
    let sum = x + y
    sum > x && sum > y
    
    
