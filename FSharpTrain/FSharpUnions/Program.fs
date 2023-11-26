// For more information see https://aka.ms/fsharp-console-apps
type Chicken = { name: string; size: int }
type Turkey = { name: string; size: int }
type Pork = { name: string; size: int }

type Bird =
    | Chicken of Chicken
    | Turkey of Turkey
    
let chicken1: Chicken = { name = "Chicken 1"; size = 10 }
let birdchicken1 = Bird.Chicken chicken1
let turkey1:Turkey = { name = "Turkey 1"; size = 20 }
let birdchicken2 = Bird.Turkey turkey1

let MyBirdFunction (bird: Bird) =
    match bird with
    | Chicken c  -> sprintf $"This is a chicken named {c.name}"
    | _ -> sprintf $"This is a chicken named"
    // | Turkey t -> sprintf $"This is a chicken named {t.name}"
MyBirdFunction birdchicken1