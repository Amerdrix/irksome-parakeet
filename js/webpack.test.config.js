var config = require('./webpack.config')
config.resolve.alias["rest"] = ["rest.mock"];

module.exports = config;
