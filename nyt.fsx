// NY PDF: http://www.nytimes.com/images/2017/02/19/nytfrontpage/scan.pdf
// National PDF: http://www.nytimes.com/images/2017/02/19/nytfrontpage/scannat.pdf
// International PDF: http://www.nytimes.com/images/2017/02/19/nytfrontpage/INYT_frontpage_global.20170125.pdf

// NY JPG: https://static01.nyt.com/images/2017/02/19/nytfrontpage/scan_paper.jpg
// National JPG: https://static01.nyt.com/images/2017/02/19/nytfrontpage/scannat_paper.jpg
// International JPG: https://static01.nyt.com/images/2017/02/19/nytfrontpage/INYT_frontpage_global.20170125.jpg 

type Edition =
    | NewYork
    | National
    | International

type Format =
    | PDF
    | JPG

let getFormatPath (date : System.DateTime) format =
    match format with
    | PDF -> sprintf "http://www.nytimes.com/images/%i/%02i/%02i/nytfrontpage/" date.Year date.Month date.Day
    | JPG -> sprintf "https://static01.nyt.com/images/%i/%02i/%02i/nytfrontpage/" date.Year date.Month date.Day

let getFileExtension format =
    match format with
    | PDF -> "pdf"
    | JPG -> "jpg"

let getFileRoot (date : System.DateTime) edition =
    match edition with
    | NewYork       -> "scan"
    | National      -> "scannat"
    | International -> sprintf "INYT_frontpage_global.%i%02i%02i" date.Year date.Month date.Day

let getFile date edition format =
    let path = getFormatPath date format
    let fileRoot = getFileRoot date edition
    let extension = getFileExtension format
    path + fileRoot + "." + extension

getFile System.DateTime.Now NewYork PDF

let getFileForToday =
    getFile System.DateTime.Now

let getToday =
    getFileForToday NewYork PDF

let openLink (url : string) =
    ignore (System.Diagnostics.Process.Start(url))

openLink getToday