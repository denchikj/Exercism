module Meetup

open System

type Week =
    | First
    | Second
    | Third
    | Fourth
    | Last
    | Teenth

let meetup year month week dayOfWeek : DateTime =
    let firstDayNumber =
        match week with
        | First -> 1
        | Second -> 8
        | Third -> 15
        | Fourth -> 22
        | Teenth -> 13
        | Last -> DateTime.DaysInMonth(year, month) - 6

    let firstDay = DateTime(year, month, firstDayNumber)

    let n =
        (int (dayOfWeek - firstDay.DayOfWeek) + 7) % 7

    firstDay.AddDays(n)
