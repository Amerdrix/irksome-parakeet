var path = require('path')

module.exports =
{
    entry: "./main.jsx",
        
    output: {
        filename: "[name].bundle.js"
    },
    resolve: {
        root: [path.resolve('.')],
        alias: {"component": "component.mock"}
    },
    module:{
    loaders: [
         { 
             test: /\.jsx?$/, exclude: /node_modules/, loader: "babel-loader"}
        ]
    }
}