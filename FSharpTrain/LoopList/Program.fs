// For more information see https://aka.ms/fsharp-console-apps
//loop recursive


//head  represents the first element of the list, and  tail  represents the remaining elements. 
let myPrinter (values: list<int>) =
    let rec loop (values: list<int>) =
        match values with
        | [] -> ()
        | head :: tail ->
            printfn $"{head}"
            loop tail
    loop values
let loopValues = [1;2;3]
    
myPrinter loopValues