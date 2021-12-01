module RobotSimulator

type Direction =
    | North
    | East
    | South
    | West

type Position = int * int

type Robot =
    { direction: Direction
      position: Position }

let create direction position =
    { direction = direction
      position = position }

let turnRight =
    function
    | North -> East
    | East -> South
    | South -> West
    | West -> North

let turnLeft =
    function
    | North -> West
    | East -> North
    | South -> East
    | West -> South

let (+) ((x1, y1): Position) ((x2, y2): Position) = (x1 + x2, y1 + y2)

let moveForward =
    function
    | North -> (0, 1)
    | South -> (0, -1)
    | East -> (1, 0)
    | West -> (-1, 0)

let moveOne instruction robot =
    match instruction with
    | 'R' ->
        { robot with
              direction = turnRight robot.direction }
    | 'L' ->
        { robot with
              direction = turnLeft robot.direction }
    | 'A' ->
        { robot with
              position = robot.position + (robot.direction |> moveForward) }
    | _ -> robot

let move instructions robot =
    Seq.fold (fun r c -> moveOne c r) robot instructions