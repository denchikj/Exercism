module AnnalynsInfiltration

let canFastAttack (knightIsAwake: bool): bool = 
    match knightIsAwake with
    | true -> false
    | false -> true

let canSpy (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    match knightIsAwake, archerIsAwake, prisonerIsAwake with
    | false, false, false -> false
    | _ -> true
    
let canSignalPrisoner (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    match archerIsAwake, prisonerIsAwake with
    | false, true -> true
    | _ -> false

let canFreePrisoner (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool): bool =
    match knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent with
    | _, false, _, true -> true
    | false, false, true, false -> true
    | _ -> false
