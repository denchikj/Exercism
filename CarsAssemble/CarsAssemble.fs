module CarsAssemble

let successRate (speed: int): float =
    match speed with 
    | x when speed > 0 && speed < 5 -> 1.0
    | x when speed > 4 && speed < 9 -> 0.9
    | 9 -> 0.8
    | 10 -> 0.77
    | _ -> 0.0

let productionRatePerHour (speed: int): float =
    float (speed * 221) * successRate speed

let workingItemsPerMinute (speed: int): int =
    int (productionRatePerHour speed) / 60
