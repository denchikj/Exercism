module Gigasecond

open System

let add (beginData: DateTime) = beginData.AddSeconds(10.0 ** 9.0)