module KindergartenGarden

type Plant =
    | Violets
    | Radishes
    | Clover
    | Grass

let students =
    [ "Alice"
      "Bob"
      "Charlie"
      "David"
      "Eve"
      "Fred"
      "Ginny"
      "Harriet"
      "Ileana"
      "Joseph"
      "Kincaid"
      "Larry" ]

let plants (diagram: string) student =
    let offset =
        (students |> Seq.findIndex (fun x -> x = student))
        * 2

    diagram.Split("\n")
    |> Seq.map (fun x -> x.Substring(offset, 2))
    |> Seq.reduce (fun a b -> a + b)
    |> Seq.map
        (fun x ->
            match x with
            | 'V' -> Plant.Violets
            | 'R' -> Plant.Radishes
            | 'C' -> Plant.Clover
            | 'G' -> Plant.Grass
            | _ -> failwith "invalid plant code")
    |> Seq.toList
