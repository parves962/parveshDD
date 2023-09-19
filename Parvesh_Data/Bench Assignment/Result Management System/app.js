const express = require('express');
const exphbs = require('express-handlebars');
const bodyParser = require('body-parser');
const mysql = require('mysql2');
const db = require('./db');
const {check, validationResult} = require('express-validator')

require('dotenv').config();

const app = express();
const port = process.env.PORT || 5000;

//parsing middleware
app.use(express.json());
app.use(bodyParser.urlencoded({extended : false}));

//static files
app.use(express.static('public'));

//template engine
app.engine('hbs',exphbs.engine( {extname : '.hbs'}));
app.set('view engine', 'hbs');

//Router
app.get('',(req,res) => {
    res.render('home');
});

//routers
const router = require('./routes/resultRouter.js')
app.use('/api',router)

app.listen(port,() => console.log(`listening on the port ${port}`));