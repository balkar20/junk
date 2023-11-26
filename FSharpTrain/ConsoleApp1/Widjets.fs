// namespace Widgets
//
// module WidgetModule1 =
//    let widgetFunction x y =
//       printfn $"Module1 %A{x} %A{y}"
// module WidgetModule2 =
//    let widgetFunction x y =
//       printfn $"Module2 %A{x} %A{y}"
//
// module useWidgets =
//
//   do
//      WidgetModule1.widgetFunction 10 20
//      WidgetModule2.widgetFunction 5 6

namespace MyNs
type Person(name, age) = 
    member val Name = name
    member val Age = age with get, set
    member this.PrintPerson() = printfn $"Person name: {this.Name}  age: {this.Age}"
 
 
type Employee(name, age, company) = 
    inherit Person(name, age)
    member val Company = company with get, set
    member this.Work() = printfn $"{this.Name} works"
     
// module useNs = 

