﻿// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open Suave

[<EntryPoint>]
let main [|port; staticFileLocation|] = 
    startWebServer defaultConfig (Successful.OK "Hello World!")
    0 // return an integer exit code
