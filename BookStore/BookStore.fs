module BookStore

let price = 8.0m

let discount count =
    match count with
    | 2 -> 0.05m
    | 3 -> 0.10m
    | 4 -> 0.20m
    | 5 -> 0.25m
    | _ -> 0.00m

let discountPrice count price = price - (price * (discount count))
let regularPrice count = decimal (count) * price

let booksPrice count =
    regularPrice count |> discountPrice count

let groups books =
    books
    |> List.countBy id
    |> List.map (fun (_, count) -> count)
    |> List.sortByDescending id

let removeBooks books groups =
    let left =
        groups
        |> List.take books
        |> List.map (fun i -> i - 1)
        |> List.filter (fun i -> i > 0)

    let right = groups |> List.skip books
    left @ right

let total books =
    let rec loop total groups books =
        let books = groups |> List.length |> min books

        match books with
        | 0 -> total + (groups |> List.sum |> regularPrice)
        | _ ->
            let groups = removeBooks books groups
            let price = booksPrice books
            let total = total + price
            loop total groups books

    match books with
    | [] -> 0.0m
    | _ ->
        let groups = groups books
        let numOfGroups = groups |> List.length

        [ 1 .. numOfGroups ]
        |> List.map (loop 0.0m groups)
        |> List.min
