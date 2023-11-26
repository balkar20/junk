// For more information see https://aka.ms/fsharp-console-apps

let divide x y =
    if y = 0 then None
    else Some (x / y)

let result =
    Some 10
    |> Option.bind (fun x -> divide x 2)

match result with
| Some x -> printfn "Result: %d" x
| None -> printfn "Error: Division by zero"

let optionalValue = Some 5

let doubledValue =
    optionalValue
    |> Option.map (fun x -> x * 2)

match doubledValue with
| Some x -> printfn "Doubled value: %d" x
| None -> printfn "No value provided"

let valueOrDefault =
    optionalValue
    |> Option.defaultValue 10

printfn "Value or default: %d" valueOrDefault

optionalValue
|> Option.iter (fun x -> printfn "Value: %d" x)

let noneValue = None

noneValue
|> Option.iter (fun x -> printfn "This won't be executed")

