// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open Suave // always open suave
open Suave.Web // for config
open System.Net
 
let serverConfig port = 
    let port = Sockets.Port.Parse <| port
    { defaultConfig with
       bindings = [ HttpBinding.mk HTTP IPAddress.Loopback port ]
    }

[<EntryPoint>]
let main argsv = 
    let port = argsv.[0]
    startWebServer (serverConfig port) (Successful.OK "Hello World from Suave redeployed!")
    0 // return an integer exit code
