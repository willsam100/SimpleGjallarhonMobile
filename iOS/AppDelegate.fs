namespace Gjallarhorn101.iOS

open System
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS

[<Register ("AppDelegate")>] 
type AppDelegate () =
    inherit FormsApplicationDelegate ()

    override this.FinishedLaunching (app, options) =
        Forms.Init()
        base.LoadApplication(Gjallarhorn.Core.Program.App())
        base.FinishedLaunching(app, options)

module Main =
    [<EntryPointAttribute>]
    let main args =
        UIApplication.Main(args, null, "AppDelegate")
        0

