// For more information see https://aka.ms/fsharp-console-apps
type Chicken = { name: string; size: int }
let bird1 =  { name= "jjjj"; size= 5 }
let myTuple = "jjjj",5

let fst = fst myTuple
let scd = snd myTuple

let name, number = myTuple

let myStructTuple = struct ("jjjj",5)

let struct (l, f)  = myStructTuple



