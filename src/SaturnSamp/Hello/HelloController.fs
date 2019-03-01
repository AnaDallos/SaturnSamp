namespace Hello

open Saturn
open Giraffe.ResponseWriters
open Giraffe.Serialization

module Controller=
    
    let indexAction =
        htmlView(Views.index)
        
    type B = {text:string}
    
    let ApiAction=
        json { text= "Hello world" }

    let helloView = router{
        get "/" indexAction
        get "/api" ApiAction
    }
 
    let index2Action name =
        htmlView(Views.index2 name)

    let helloView2 = router{
        getf "/%s" index2Action 
    }

