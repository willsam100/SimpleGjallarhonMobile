namespace Gjallarhorn.Core

open Xamarin.Forms
open Xamarin.Forms.Xaml
open System.Reflection

type MainPage() =
    inherit ContentPage()

    do 
        let assembly = typeof<MainPage>.GetTypeInfo().Assembly;
        assembly.GetManifestResourceNames() |> Array.iter (fun res -> System.Diagnostics.Debug.WriteLine("found resource: " + res))

      

    let _ = base.LoadFromXaml(typeof<MainPage>)
