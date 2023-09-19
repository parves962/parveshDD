

function validateEmail(email) {
    let res = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    return res.test(email);
  }

function validateUrl(url)
{
    var res = url.match(/(http(s)?:\/\/.)?(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)/g);
    return (res !== null);
}

function addStudent()
{
    var name = document.getElementById("fname").value;
    var mail = document.getElementById("fmail").value;
    var website = document.getElementById("fwebsite").value;
    var link = document.getElementById("fimglink").value;
    if(name=="")
    {
        alert("Please enter a valid name");
        var uname = document.getElementById("fname");
        //uname.style.border = "solid 3px red";
    }
    else if (validateEmail(mail) == false)
    {
        alert("You have entered an invalid email address!")
    }
       
    else if(validateUrl(website)==false)
    {
        alert("You have entered an invalid url!");
    }
    else if(validateUrl(link)==false)
    {
        alert("You have entered an invalid image link!");
    }
    else
    {
        if(document.getElementById('male').checked == true) 
        { 
            var gender = "male";
        } 
        else if(document.getElementById('female').checked == true)
        {
            var gender = "female";
        }
        else 
        {
            alert("Please enter the gender");
        }

        var result = "";
        var checkboxes = document.getElementsByName("skills");
        for (var i = 0; i < checkboxes.length; i++) 
        {
            if (checkboxes[i].checked) 
            {
                result += checkboxes[i].value 
                    + " " ;
            }
        }

        var skill = result;
        
       
        var tr = document.createElement('tr');

        var td1 = tr.appendChild(document.createElement('td'));
        var td2 = tr.appendChild(document.createElement('td'));

        td1.innerHTML = name;
        td1.innerHTML += "<br>";
        td1.innerHTML += gender;
        td1.innerHTML += "<br>";
        td1.innerHTML += mail;
        td1.innerHTML += "<br>";
        td1.innerHTML += website;
        td1.innerHTML += "<br>";
        td1.innerHTML += skill;

        td2.innerHTML = `<img src = ${link} width ='100%' height = '200%'>`;

        document.getElementById("mytable").appendChild(tr);
    }

}