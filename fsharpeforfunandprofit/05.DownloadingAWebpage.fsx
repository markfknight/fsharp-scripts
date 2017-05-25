// "open" brings a .NET namesapce into visibility
open System.Net
open System
open System.IO

// Fetch the contents of a web page
let fetchUrl callback url =
    let req = WebRequest.Create(Uri(url))
    use resp = req.GetResponse()
    use stream = resp.GetResponseStream()
    use reader = new IO.StreamReader(stream)
    callback reader url

let myCallback (reader: IO.StreamReader) url =
    let html = reader.ReadToEnd()
    let html1000 = html.Substring(0, 1000)
    printfn "Donwloaded %s. First 1000 is %s" url html1000
    html // return all the html

// test
let google = fetchUrl myCallback "http://google.com"

// build a function with the callback baked in
let fetchUrl2 = fetchUrl myCallback
// test