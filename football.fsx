#load "packages/FsLab/FsLab.fsx"
open FSharp.Data
open XPlot.GoogleCharts

type Football = JsonProvider<"https://raw.githubusercontent.com/opendatajson/football.json/master/2016-17/en.1.json">

let uk = Football.Load("https://raw.githubusercontent.com/opendatajson/football.json/master/2016-17/en.1.json")

let allMatches = uk.Rounds |> Seq.collect (fun i -> i.Matches)

let flip f x y = f y x

let orZero = (flip defaultArg) 0

let createDataPair (m : Football.Match) = orZero m.Score1, orZero m.Score2

let scorePairs =
    allMatches
    |> Seq.map createDataPair

scorePairs
|> Chart.Scatter