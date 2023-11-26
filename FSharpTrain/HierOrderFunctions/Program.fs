// For more information see https://aka.ms/fsharp-console-apps

let myValidator (trueHandler: int -> unit) (a: int) : bool =
    if a > 0 then
        trueHandler a
        true
    else
        false
        
let trueHandler (x: int) =
    printfn $"Handling value: %d{x}"
    
let value = 5
myValidator trueHandler value


// composedFunction 
let addOne x = x + 1
let multiplyByTwo x = x * 2

let composedFunction = addOne >> multiplyByTwo

let result = composedFunction 3
printfn "Result: %d" result
 