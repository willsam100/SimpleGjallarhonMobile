namespace Gjallarhorn.Core

open Xamarin.Forms
open Xamarin.Forms.Xaml
open System.Reflection

type MainPage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<MainPage>)
