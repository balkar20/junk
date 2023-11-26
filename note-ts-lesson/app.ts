import http from 'http'

http.createServer(function (req, res) {
    res.setHeader('Content-Type', 'text/html; charset=utf-8');
    res.end("<p>hello world</p>");
})
.listen(3005, () => console.log("Server started"))
let message = "Message";
console.log(message);
