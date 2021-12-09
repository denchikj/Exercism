module Anagram

let findAnagrams (sources: string list) (target: string) =
    let sort (s: string) = s.ToLower() |> Seq.sort |> Seq.toArray

    sources
    |> List.filter (fun x -> x.ToLower() <> target.ToLower())
    |> List.filter (fun x -> sort x = sort target)
