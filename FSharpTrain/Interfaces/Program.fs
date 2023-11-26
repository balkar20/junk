type IAnimal =
    abstract member Name : string
    abstract member Talk : string -> unit

type Chicken(name: string) =
    member this.Name = name
    member this.Talk words =
        printfn $"My name is: %s{name}"
        printfn $"Cluck: %s{words}"
    interface IAnimal with
        member c.Name = c.Name
        member c.Talk words = c.Talk words

let chicken = Chicken("Henrietta")
chicken.Talk("Hello, world!")