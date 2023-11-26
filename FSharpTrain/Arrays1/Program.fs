// For more information see https://aka.ms/fsharp-console-apps

let numbers = [| 1; 2; 3; 4; 5 |]

for i = 0 to Array.length numbers - 1 do
    printfn $"%d{numbers.[i]}"
    
let zeroCreateArr: int array = Array.zeroCreate 5
//Arrays is mutable
zeroCreateArr[0] <- 10


