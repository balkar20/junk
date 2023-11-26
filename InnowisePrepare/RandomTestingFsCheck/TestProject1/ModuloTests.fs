module ModuloTests

open System
open FsCheck
open FsCheck.FSharp
open FsCheck.Xunit

let modulo (a: bigint) (n: bigint) = a%n 
    
[<Property>]
let ``Reversing a list twice should result in the original list`` (lst: list<int>) =
    let reversedTwice = lst |> List.rev |> List.rev
    reversedTwice = lst
    
    
