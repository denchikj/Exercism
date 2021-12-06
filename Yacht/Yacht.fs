module Yacht

type Category =
    | Ones
    | Twos
    | Threes
    | Fours
    | Fives
    | Sixes
    | FullHouse
    | FourOfAKind
    | LittleStraight
    | BigStraight
    | Choice
    | Yacht

type Die =
    | One = 1
    | Two = 2
    | Three = 3
    | Four = 4
    | Five = 5
    | Six = 6

let compare =
    ([ Ones
       Twos
       Threes
       Fours
       Fives
       Sixes ],
     [ Die.One
       Die.Two
       Die.Three
       Die.Four
       Die.Five
       Die.Six ])
    ||> List.zip
    |> Map.ofList

let score category dice =
    if Map.containsKey category compare then
        let item = compare.[category]
        List.sumBy (fun die -> if die = item then int die else 0) dice
    else
        let values = List.map int dice |> List.sortDescending

        let counts =
            List.countBy id dice
            |> List.map snd
            |> List.sortDescending

        match category, counts with
        | Yacht, [ 5 ] -> 50
        | FullHouse, [ 3; 2 ]
        | Choice, _ -> List.sum values
        | FourOfAKind,
          (4
          | 5) :: _ -> values.Head * 4
        | LittleStraight, [ 1; 1; 1; 1; 1 ] when values.[0] = 5 -> 30
        | BigStraight, [ 1; 1; 1; 1; 1 ] when values.[4] = 2 -> 30
        | _ -> 0
