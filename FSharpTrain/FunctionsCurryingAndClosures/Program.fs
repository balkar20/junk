// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let loggSomething (loggingParams: string) (myMessage: string) : unit =
  
  ()
  
let myLogger = loggSomething "Params here"

let mutable myChickenName = "Clycky"

let myClosure (n: int) =
  $"{myChickenName}  - {n}"
  

// myChickenName <- "Charley"

myClosure 10 
