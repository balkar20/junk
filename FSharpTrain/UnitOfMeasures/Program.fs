// For more information see https://aka.ms/fsharp-console-apps
[<Measure>] type meter
[<Measure>] type second
[<Measure>] type kilogram

let distance : float<meter> = 10.0<meter>
let time : float<second> = 5.0<second>
let weight : float<kilogram> = 2.5<kilogram>

let speed = distance / time
let acceleration = weight / (time * time)

printfn "Speed: %f m/s" speed
printfn "Acceleration: %f m/s^2" acceleration


module Domain =
    module Units =
        [<Measure>] type PackWeight
    module PackWeight =
        let create (x: float) =
            if x <= 0.0 then
                invalidArg (nameof x) "Invalid argument"
            x*1.0<Units.PackWeight>
         
                
            
open Domain        
let m1 =  PackWeight.create -10.0


[<Measure>] type Cow
[<Measure>] type Chicken

type Animal<[<Measure>] 'Measure> =
    { Size : float }

    static member (+) (a: Animal<'Measure>, b: Animal<'Measure>) : Animal<'Measure> =
        { Size = a.Size + b.Size }
    
    static member (*) (a: Animal<'LMeasure>, b: Animal<'RMeasure>) : Animal<'LMeasure * 'RMeasure> =
        { Size = a.Size * b.Size }
        
    static member (/) (a: Animal<'LMeasure>, b: Animal<'RMeasure>) : Animal<'LMeasure * 'RMeasure> =
        { Size = a.Size / b.Size }
        
 
 [<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]       
 module Animal =
     let create (x: float<'Measure>): Animal<'Measure> =
         {Size = float x}
 
 
let cl = Animal.create 1.0<Chicken>
let c2 = Animal.create 2.0<Chicken>
let c3 = cl + c2
let c4 = Animal.create 2.0<Cow>
let c5 = cl / c4

let c5Size = c5.Size

printfn $"The size is {c5Size}"

let ql = 1.0<Chicken>
let q2 = 2.1<Chicken>
let result = ql + q2 * 1.0<_>





    


