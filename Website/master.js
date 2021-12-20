const ids = ["more1", "more2", "more3", "more4", "more5", "more6", "more7", "more8", "more9"];
var x = 0;
for (let i in ids) {
    document.getElementById(ids[i]).style = "display: none; visibility: visible;";
}
function more() {
    // when the user presses the "More" button on the homepage
    if (x > ids.length) {
        // too many "More" presses? give them something great
        window.location = "https://www.youtube.com/embed/dQw4w9WgXcQ";
    }
    document.getElementById(ids[x]).style = "display: block; visibilty: visible;";
    x++;
}
