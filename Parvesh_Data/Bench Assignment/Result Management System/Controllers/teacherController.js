const db = require('../Models/Result')
const router = require('express').Router();

let status = false;

const loginStatus = (req, res) => {
    return status;
}



const teacherLogin = async (req, res) => {

    if (req.body.name == 'Ashish Sharma' && req.body.password == '123') {
        status = true;
        let results = await db.findAll({ raw: true });

        let total = await db.count();

        res.render('result', { result: results, total: total });

    }
    else {
        res.render('teacher', { messages: "enter the correct details" })
    }
}

const logout = (req, res) => {
    status = false;
    res.redirect('/');
}

module.exports = {
    teacherLogin,
    loginStatus,
    logout
}