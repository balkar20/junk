

//Accessing list elements:
let myList = [1; 2; 3;]
let myList2 = [1; 2; 3;]

let firstElement = List.head myList
let lastElement = List.last myList
let secondElement = List.item 1 myList
let mySecList = 4 :: myList

for i in mySecList do
    

let four  :: theRest = myList

let combined  = myList @ myList2

let colList  =  [for i in 1..3 do
                     for j in 1 ..3 do
                         i * j]

//loop recursive
let myPrinter (values: list<int>) =
    let rec loop (values: list<int>) =
        match values with
        | [] -> ()
        |l  -> ()
        | head :: tail ->
            printfn $"{head}"
            loop tail
    loop values
let loopValues = [1;2;3]
    
myPrinter loopValues
printfn "First element: %d" firstElement
printfn "Last element: %d" lastElement
printfn "Second element: %d" secondElement

//List manipulation:

let doubledList = List.map (fun x -> x * 2) myList
let filteredList = List.filter (fun x -> x % 2 = 0) myList
let sum = List.sum myList

printfn "Doubled list: %A" doubledList
printfn "Filtered list: %A" filteredList
printfn "Sum of list elements: %d" sum

