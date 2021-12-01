module Isogram

open System

let isIsogram str =
    str
    |> Seq.filter Char.IsLetter
    |> Seq.countBy Char.ToLower
    |> Seq.forall (fun (l, x) -> x = 1)
