module BinarySearch

let find input value =
    input |> Array.tryFindIndex (fun i -> i = value)
