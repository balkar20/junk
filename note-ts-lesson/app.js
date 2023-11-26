"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const http_1 = __importDefault(require("http"));
http_1.default.createServer(function (req, res) {
    res.setHeader('Content-Type', 'text/html; charset=utf-8');
    res.end("<p>hello world</p>");
})
    .listen(3005, () => console.log("Server started"));
let message = "Message";
console.log(message);
