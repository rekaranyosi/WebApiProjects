var viccek;

windows.onload(){
    Letöltés();
}

fetch('/jokes.json')
    .then(response => response.json())
    .then(data => letöltésBefejeződött(data)
    );

function Letöltés() {
    for (var i = 0; i < length; i++) {

    }
}
function letöltésBefejeződött(d) {
    console.log("Sikeres letöltés")
    console.log(d)
    viccek = d;
}