// Learn more about F# at http://fsharp.org

open System

let getRandom = System.Random().Next()%2 |> System.Convert.ToBoolean

let simulateRandomWalk (n: int) =
    //printfn "%i" n
    let r = getRandom
    
    r

[<EntryPoint>]
let main argv =
    //printfn "Hello World from F#!"
    //simulateRandomWalk 7
    

    
    
    0 // return an integer exit code
