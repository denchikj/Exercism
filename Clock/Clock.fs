module Clock

let create hours minutes =
    (hours * 60 + minutes + 24 * 60 * 100) % (24 * 60)

let add minutes clock = clock + minutes
let subtract minutes clock = create 0 (clock - minutes)

let display clock =
    sprintf "%02i:%02i" (clock / 60 % 24) (clock % 60)
