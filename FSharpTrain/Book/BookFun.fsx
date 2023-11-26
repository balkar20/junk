let adderGenerator numberToAdd = (+) numberToAdd

// create an "adder" by partial application of add
// create wrappers for .NET string functions
let replace oldStr newStr (s:string) =
  s.Replace(oldValue=oldStr, newValue=newStr)

let startsWith (lookFor:string) (s:string) =
  s.StartsWith(lookFor)

let result =
  "hello"
  |> replace "h" "j"
  |> startsWith "j"
  
["the"; "quick"; "brown"; "fox"]
|> List.filter (startsWith "f")

let doSomething x y  =
  let intermediateFn z = x+y+z
  intermediateFn        // return intermediateFn

let doSomethingPartial = doSomething 1 2
doSomethingPartial 3     // only one parameter after function now
3 |> doSomethingPartial  // same as above - last parameter piped in
