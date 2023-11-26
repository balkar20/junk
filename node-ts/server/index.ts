import http from 'http';


http.createServer(function (req, res) {
    res.end("Heelo word");
})
.listen(3005, () => console.log("Heelo"));
const addNumber = (a: number, b: number) => {
    return a + b;
}

// fs.writeFileSync("text.txt", "test");

let g = addNumber(1, 2);
console.log(g);

