#load "packages/FsLab/FsLab.fsx"
open FSharp.Data
open XPlot.GoogleCharts

type Football = JsonProvider<"example.json">

let uk = Football.Load("data.json")

let allMatches = uk.Rounds |> Seq.collect (fun i -> i.Matches)

let flip f x y = f y x

let orZero = (flip defaultArg) 0

let createDataPair (m : Football.Match) = orZero m.Score1, orZero m.Score2

let scorePairs =
    allMatches
    |> Seq.map createDataPair

scorePairs
|> Chart.Scatter