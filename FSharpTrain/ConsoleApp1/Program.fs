
open MyNs
let myList = [1; 2; 3;]
let myList2 = [1; 2; 3;]

let firstElement = List.head myList
let lastElement = List.last myList
let secondElement = List.item 1 myList
let mySecList = 4 :: myList

for i in mySecList do
    printfn $"Module2 %A{i}"
    
// Module2 4
// Module2 1
// Module2 2
// Module2 3
    
    
// let numbers = {1..10}
//
// let Square  x = x*x
// let IsEven  x = x%x =0
//
// let multiply x y =
//     x * y
//     
// let double = multiply 2
// let double2 z = multiply 2 z
//
// let oki = double2 5
// let ten = double 5
//
// printfn $"Module2 %A{oki}"
// printfn $"Module2 %A{ten}"

// let o = Seq.filter IsEven numbers
// for squaredValue in o do
//     printfn $"Module2 %A{squaredValue}"
// let squareOfEvens = 
//     numbers
//     |> Seq.filter IsEven
//     |> Seq.map Square
// let squaredValues = Seq.map Square numbers
//
// for squaredValue in squaredValues do
//     printfn $"Module2 %A{squaredValue}"


    
     