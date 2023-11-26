"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var http_1 = require("http");
http_1.default.createServer(function (req, res) {
    res.end("Heelo word");
})
    .listen(3005, function () { return console.log("Heelo"); });
var addNumber = function (a, b) {
    return a + b;
};
// fs.writeFileSync("text.txt", "test");
var g = addNumber(1, 2);
console.log(g);
