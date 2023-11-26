const http = require('http');

const server = http.createServer((req, res) => {
    console.log("req made");
    res.setHeader('Content-Type', 'application/json');
    res.write('localhost');
    res.end();
});

server.listen(3005, 'localhost', () => {
    console.log("req noq listen");
});