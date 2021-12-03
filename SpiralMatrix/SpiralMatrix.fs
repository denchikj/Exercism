module SpiralMatrix

let spiralMatrix size =
    let rec innerMatrix it sizes =
        let rotate = List.transpose >> List.map List.rev
        let x, z = sizes

        match x with
        | x when x = 0 && z = 0 -> []
        | _ ->
            [ it .. (it + x - 1) ]
            :: (innerMatrix (it + x) (z - 1, x) |> rotate)

    innerMatrix 1 (size, size)
