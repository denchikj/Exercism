module Triangle

let check a b c =
    a > 0.0
    && b > 0.0
    && c > 0.0
    && (a + b) > c
    && (b + c) > a
    && (c + a) > b

let equilateral triangle =
    match triangle with
    | [ a; b; c ] -> check a b c && a = b && b = c && c = a
    | _ -> false

let isosceles triangle =
    match triangle with
    | [ a; b; c ] -> check a b c && (a = b || b = c || c = a)
    | _ -> false

let scalene triangle =
    match triangle with
    | [ a; b; c ] -> check a b c && a <> b && b <> c && c <> a
    | _ -> false
