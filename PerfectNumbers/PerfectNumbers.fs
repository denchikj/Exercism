module PerfectNumbers

type Classification =
    | Perfect
    | Abundant
    | Deficient

let classify n : Classification option =
    let sum =
        [ 1 .. n - 1 ]
        |> Seq.filter (fun x -> n % x = 0)
        |> Seq.sum

    match n with
    | x when x > 0 && sum = n -> Some Perfect
    | x when x > 0 && sum > n -> Some Abundant
    | x when x > 0 && sum < n -> Some Deficient
    | _ -> None
