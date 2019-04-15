module ICPC
open System

let commaSprinkler input =
    failwith "Not implemented"

let rivers input =
    //failwith "Not implemented"
    let stringInputArray = input.ToString().Split(' ')
    let listString = stringInputArray|> Array.toList 
    match listString.Length < 2 with
    |true -> None
    |false -> Some 1


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
