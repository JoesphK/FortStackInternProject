require('dotenv').config();

// require mongoose
const mongoose = require('mongoose');
// connect to database
const mongoUri = process.env.MONGO_URI || 'mongodb://localhost:27017/todo_app_db';

mongoose.connect(mongoUri, {
    useNewUrlParser: true,
    useUnifiedTopology: true
});
// acquire the connection (to check if it is successful)
const db = mongoose.connection;
// check for error
db.on('error', console.error.bind(console, 'connection error:'));
// once connection is open, log to console
db.once('open', function() {
    console.log('connected to database');
});