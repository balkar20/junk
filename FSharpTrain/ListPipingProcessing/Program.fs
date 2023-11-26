// For more information see https://aka.ms/fsharp-console-apps
let loopValues = [1;2;3]

let events =
    loopValues
    |> List.filter(fun x -> x%2 = 0)