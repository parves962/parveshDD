const resultController = require('../Controllers/resultController.js');
const teacherController = require('../Controllers/teacherController.js');

const auth = (req,res,next)=>{
    if(!teacherController.loginStatus())
    {
        res.redirect('/api/teacher')
    }
    next()
}

const router = require('express').Router();

router.get('/teacher',function(req,res){
    
    res.render('teacher');
})

router.get('/student',function(req,res){
    res.render('student');
})

router.get('/addRecord',auth,function(req,res){
    res.render('addResult');
})

router.get('/logout',teacherController.logout);

router.get('/editRecord/:id',auth,resultController.editRecord);

router.post('/login',teacherController.teacherLogin);


router.post('/addResult',auth,resultController.addResult)

router.get('/allResult',auth,resultController.allResult)

router.post('/oneResult',resultController.oneResult)

router.post('/edit/:id',auth,resultController.updateResult)

router.get('/delete/:id',auth,resultController.deleteResult)


module.exports = router;