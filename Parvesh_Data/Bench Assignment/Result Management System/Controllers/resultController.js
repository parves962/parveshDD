const db = require('../Models/Result')
const router = require('express').Router();



const addResult = async (req, res) => {
    console.log(req.body.rollno);
    let rollno = req.body.rollno;

    let rt = await db.findOne({ where: { rollno: rollno }, raw: true });

    if (rt) {
        console.log("rt here")
        res.render('addResult', { messages: "Roll no already exists" })
    }
    else if (req.body.rollno < 1 || req.body.score < 1) {
        res.render('addResult', { messages: " Can't be Negative" })
    }
    else {
        let info = {
            rollno: req.body.rollno,
            name: req.body.name,
            dob: req.body.dob,
            score: req.body.score
        }
        console.log(info);
        const result = await db.create(info);
        res.redirect('/api/allResult');
    }
}

const allResult = async (req, res) => {
    let results = await db.findAll({ raw: true });
    let total = await db.count();
    res.render('result', { result: results, total: total });
}

const oneResult = async (req, res) => {

    let rollno = req.body.rollno;
    let dob = req.body.dob;
    console.log(rollno, dob)
    let results = await db.findOne({ where: { rollno: rollno, dob: dob }, raw: true });
    if (results) {
        res.render('stResult', { result: results });
    }
    else {
        res.render('student', { messages: "Data not found" })
    }
}

const editRecord = async (req, res) => {
    let id = req.params.id;
    let results = await db.findOne({ where: { id: id }, raw: true });
    res.render('update', { result: results });
}

const updateResult = async (req, res) => {

    let id = req.params.id

    if (req.body.score < 1) {
        res.render('update', { messages: "score cant be negative" })
    }

    else {
        console.log(req.body)
        const result = await db.update(req.body, { where: { id: id } });
        res.redirect('/api/allResult');
    }
}

const deleteResult = async (req, res) => {

    let id = req.params.id;

    await db.destroy({ where: { id: id } });
    res.redirect('/api/allresult');
}

module.exports = {
    addResult,
    allResult,
    oneResult,
    updateResult,
    deleteResult,
    editRecord
}