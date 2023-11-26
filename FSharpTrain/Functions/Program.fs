// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"



[<RequireQualifiedAccess>]
type Animal =
    | Chicken of int
    | Cow of string

let myChic = "klklk"
 
let myAnimalFunction (a: Animal) =
    match a with
    | Animal.Chicken chicken -> printfn $"Chicken: {chicken}"
    | Animal.Cow cow -> printfn $"Cow: {cow}"


let myOtherAnimalFunction  =
    function
    | Animal.Chicken chicken -> printfn $"Chicken: {chicken}"
    | Animal.Cow cow -> printfn $"Cow: {cow}"
    
let mc =  Animal.Chicken 42
let mg =  42

myOtherAnimalFunction mc 
    

    
    