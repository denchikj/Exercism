module LogLevels

let message (logLine: string): string = logLine.Split(":").[1].Trim()

let logLevel(logLine: string): string = 
    match logLine.Trim().Split(" ")[0] with
    | "[ERROR]:" -> "error"
    | "[INFO]:" -> "info"
    | _ -> "warning"

let reformat(logLine: string): string = sprintf "%s (%s)" (message logLine) (logLevel logLine) 